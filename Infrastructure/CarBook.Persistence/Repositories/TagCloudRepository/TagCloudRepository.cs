﻿using CarBook.Application.Interfaces.TagCloudInterfaces;
using CarBook.Domain.Entities;
using CarBook.Persistence.Context;

namespace CarBook.Persistence.Repositories.TagCloudRepository;
public sealed class TagCloudRepository : ITagCloudRepository
{
    private readonly CarBookContext _context;

    public TagCloudRepository(CarBookContext context)
    {
        _context = context;
    }

    public List<TagCloud> GetTagCloudsByBlogId(int id)
    {
        var values = _context.TagClouds.Where(x => x.BlogId == id).ToList();
        return values;
    }
}
