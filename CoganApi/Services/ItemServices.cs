using CoganApi.Dtos;
using CoganApi.Models;
using CoganApi.Repositories.Interfaces;
using CoganApi.Services.Interfaces;
using UnitsNet;

namespace CoganApi.Services
{
    public class ItemServices : IItemServices
    {
        private readonly IItemRepository _itemsRepository;
        public ItemServices(IItemRepository itemsRepository) 
        {
            _itemsRepository = itemsRepository;
        }
        public bool DeleteItem(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Items> GetItems()
        {
            return _itemsRepository.GetItems();
        }

        public Items GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public Items InsertItem(ItemsDto items)
        {
            return _itemsRepository.InsertItem(items);
        }

        public Items UpdateItem(ItemsDto items)
        {
            throw new NotImplementedException();
        }
    }
}
