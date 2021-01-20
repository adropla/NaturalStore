using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using NaturalStore.Domain.Entities;
using NaturalStore.Domain.Repositories.Abstract;

namespace NaturalStore.Domain.Repositories.EntityFramework
{
    public class EFServiceItemsRepository : IServiceItemsRepository
    {
        private readonly AppDbContext context;
        public EFServiceItemsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<ServiceItem> GetServiceItems()
        {
            return context.ServiceItems;
        }

        public IQueryable<ServiceItem> GetSI(string currentCategory)
        {
            int pageSize = 100;
            return FilterSI(currentCategory)
                .OrderBy(g => g.Id)
                .Take(pageSize);
        }

        public IQueryable<ServiceItem> FilterSI(string currentCategory)
        {
            IQueryable<ServiceItem> SI = GetServiceItems();
            return currentCategory == null ? SI : SI.Where(p => p.Category == currentCategory);
        }
        public IEnumerable<string> GetCategories()
        {
            return GetServiceItems()
                .Select(p => p.Category)
                .Distinct()
                .OrderBy(x => x);
        }
        public ServiceItem GetServiceItemById(Guid id)
        {
            return context.ServiceItems.FirstOrDefault(x => x.Id == id);
        }

        public void SaveServiceItem(ServiceItem entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteServiceItem(Guid id)
        {
            context.ServiceItems.Remove(new ServiceItem() { Id = id });
            context.SaveChanges();
        }
    }
}
