using CoganApi.DBSettings;
using CoganApi.Dtos;
using CoganApi.Models;
using CoganApi.Repositories.Interfaces;

namespace CoganApi.Repositories.Query
{
    public class ItemRepository : IItemRepository
    {
        private readonly MyDbContext _itemRepository;

        public ItemRepository(MyDbContext context)
        {
            _itemRepository = context;
        }
        public bool DeleteItem(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Items> GetItems()
        {
            return _itemRepository.Items.ToList();
        }

        public Items GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public Items InsertItem(ItemsDto items)
        {
            var item = new Items
            {
                Name = items.Name,
                Stock = items.Stock ?? 0, 
                Unit_Of_Measure = items.UnitOfMeasure,
                Shape = items.Shape,
                Width = items.Width,
                Width_Measure = items.WidthMeasure,
                Height = items.Height,
                Height_Measure = items.HeightMeasure,
                Length = items.Length,
                Length_Measure = items.LengthMeasure
            };
            _itemRepository.Items.Add(item);
            _itemRepository.SaveChanges();
            return item;
        }

        public Items UpdateItem(ItemsDto items)
        {
            throw new NotImplementedException();
        }
    }
}
