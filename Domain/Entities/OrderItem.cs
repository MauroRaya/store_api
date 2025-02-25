namespace store_api.Domain.Entities;

public class OrderItem
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

    public OrderItem(string itemName, decimal itemPrice)
    {
        Id = Guid.NewGuid();
        Name = itemName;
        Price = itemPrice;
    }
}