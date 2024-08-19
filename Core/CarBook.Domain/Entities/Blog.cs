﻿namespace CarBook.Domain.Entities;
public sealed class Blog
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int AuthorId { get; set; }
    public Author Author { get; set; }
    public string CoverImageUrl { get; set; }
    public DateTime CreatedDate { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public string Description { get; set; }
    public List<TagCloud> TagClouds { get; set; }
    public List<Comment> Comments { get; set; }
}
