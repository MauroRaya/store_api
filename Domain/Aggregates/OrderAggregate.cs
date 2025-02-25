using store_api.Domain.Entities;

namespace store_api.Domain.Aggregates;

public class OrderAggregate
{
    public Order Order { get; private set; }

    public OrderAggregate(string customerName)
    {
        Order = new Order(customerName);
    }

    public void AddItemToOrder(string itemName, decimal itemPrice)
    {
        Order.AddItem(itemName, itemPrice);
    }
}