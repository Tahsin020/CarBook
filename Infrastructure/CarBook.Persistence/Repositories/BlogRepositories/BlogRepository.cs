﻿using CarBook.Application.Interfaces;
using CarBook.Application.Interfaces.BlogInterfaces;
using CarBook.Domain.Entities;
using CarBook.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CarBook.Persistence.Repositories.BlogRepositories;
public sealed class BlogRepository : IBlogRepository
{
    private readonly CarBookContext _context;

    public BlogRepository(CarBookContext context)
    {
        _context = context;
    }

    public List<Blog> GetAllBlogsWithAuthors()
    {
        var values = _context.Blogs.Include(x => x.Author).Include(x => x.Category).ToList();
        return values;
    }

    public List<Blog> GetLast3BlogsWithAuthors()
    {
        var values = _context.Blogs.Include(x => x.Author).Include(x => x.Category).OrderByDescending(x => x.Id).Take(3).ToList();
        return values;
    }
}
