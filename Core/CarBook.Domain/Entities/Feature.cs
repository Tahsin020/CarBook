namespace CarBook.Domain.Entities;
public sealed class Feature
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<CarFeature> CarFeatures { get; set; }
}
