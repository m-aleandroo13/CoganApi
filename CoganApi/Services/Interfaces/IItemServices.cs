using CoganApi.Dtos;
using CoganApi.Models;

namespace CoganApi.Services.Interfaces
{
    public interface IItemServices
    {
        IEnumerable<Items> GetItems();
        Items GetItem(int id);
        Items InsertItem(ItemsDto items);
        Items UpdateItem(ItemsDto items);
        bool DeleteItem(int id);
    }
}
