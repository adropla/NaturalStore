using System;
using System.Collections.Generic;
using System.Linq;
using NaturalStore.Domain.Entities;

namespace NaturalStore.Domain.Repositories.Abstract
{
    public interface IServiceItemsRepository
    {
        IQueryable<ServiceItem> GetServiceItems();
        IEnumerable<string> GetCategories();
        IQueryable<ServiceItem> GetSI(string currentCategory);
        IQueryable<ServiceItem> FilterSI(string currentCategory);
        ServiceItem GetServiceItemById(Guid id);
        void SaveServiceItem(ServiceItem entity);
        void DeleteServiceItem(Guid id);
    }
}
