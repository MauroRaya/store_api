namespace store_api.Domain.Entities;

public class Order
{
    public Guid Id { get; private set; }
    public string CustomerName { get; private set; }
    public List<OrderItem> Items { get; private set; }
    
    public Order() {}

    public Order(string customerName)
    {
        Id = Guid.NewGuid();
        CustomerName = customerName;
        Items = new List<OrderItem>();
    }

    public void AddItem(string itemName, decimal itemPrice)
    {
        Items.Add(new OrderItem(itemName, itemPrice));
    }
}