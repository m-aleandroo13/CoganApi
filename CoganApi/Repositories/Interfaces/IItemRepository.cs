using CoganApi.Dtos;
using CoganApi.Models;

namespace CoganApi.Repositories.Interfaces
{
    public interface IItemRepository
    {
        IEnumerable<Items> GetItems();
        Items GetItem(int id);
        Items InsertItem(ItemsDto items);
        Items UpdateItem(ItemsDto items);
        bool DeleteItem(int id);
    }
}
