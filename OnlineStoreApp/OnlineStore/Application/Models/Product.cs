namespace OnlineStore.Application.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Barcode { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public bool IsActive { get; set; } = true;
    public int CategoryId { get; set; }
    public Category Category { get; set; }
}
