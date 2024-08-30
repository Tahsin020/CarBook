using CarBook.Application.Features.RepositoryPattern;
using CarBook.Domain.Entities;
using CarBook.Persistence.Context;

namespace CarBook.Persistence.Repositories.CommentRepositories;
public class CommentRepository<T> : IGenericRepository<Comment>
{
    private readonly CarBookContext _context;

    public CommentRepository(CarBookContext context)
    {
        _context = context;
    }

    public void Create(Comment entity)
    {
        _context.Comments.Add(entity);
        _context.SaveChanges();
    }

    public List<Comment> GetAll()
    {
        return _context.Comments.Select(x => new Comment
        {
            Id = x.Id,
            BlogId = x.BlogId,
            CreatedDate = x.CreatedDate,
            Description = x.Description,
            Name = x.Name
        }).ToList();
    }

    public Comment GetById(int id)
    {
        return _context.Comments.Find(id);
    }

    public List<Comment> GetCommentsByBlogId(int id)
    {
        var values = _context.Comments.Where(x => x.BlogId == id).ToList();
        return values;
    }

    public void Remove(Comment entity)
    {
        var value = _context.Comments.Find(entity.Id);
        _context.Comments.Remove(value);
        _context.SaveChanges();
    }

    public void Update(Comment entity)
    {
        _context.Comments.Update(entity);
        _context.SaveChanges();
    }
}
