using NaturalStore.Domain.Repositories.Abstract;

namespace NaturalStore.Domain
{
    public class DataManager
    {
        public ITextFieldsRepository TextFields { get; set; }
        public IServiceItemsRepository ServiceItems { get; set; }

        public IOrders Orders { get; set; }

        public DataManager(ITextFieldsRepository textFieldsRepository, IServiceItemsRepository serviceItemsRepository, IOrders orders)
        {
            TextFields = textFieldsRepository;
            ServiceItems = serviceItemsRepository;
            Orders = orders;
        }
    }
}
