namespace CarBook.Domain.Entities;
public sealed class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Blog> Blogs { get; set; }
}
