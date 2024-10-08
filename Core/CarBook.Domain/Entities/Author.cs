﻿namespace CarBook.Domain.Entities;
public sealed class Author
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string ImageUrl { get; set; }
    public string Description { get; set; }
    public List<Blog> Blogs { get; set; }
}
