namespace CarBook.Domain.Entities;
public sealed class Brand
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Car> Cars { get; set; }
}
