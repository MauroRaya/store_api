namespace store_api.Application.DTOs;

public class OrderDto
{
    public Guid Id { get; set; }
    public string CustomerName { get; set; }

    public OrderDto(Guid id, string customerName)
    {
        Id = id;
        CustomerName = customerName;
    }
}