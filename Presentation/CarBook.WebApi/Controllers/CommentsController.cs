using CarBook.Application.Features.RepositoryPattern;
using CarBook.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CommentsController : ControllerBase
{
    private readonly IGenericRepository<Comment> _repository;

    [HttpGet]
    public IActionResult CommentList()
    {
        var values = _repository.GetAll();
        return Ok(values);
    }

    [HttpGet("{id}")]
    public IActionResult GetComment(int id)
    {
        var values = _repository.GetById(id);
        return Ok(values);
    }


    [HttpPost]
    public IActionResult CreateComment(Comment comment)
    {
        _repository.Create(comment);
        return Ok("Yorum Başarıyla eklendi");
    }

    [HttpDelete]
    public IActionResult RemoveComment(int id)
    {
        var value = _repository.GetById(id);
        _repository.Remove(value);
        return Ok("Yorum Başarıyla silindi");
    }

    [HttpPut]
    public IActionResult UpdateComment(Comment comment)
    {
        _repository.Create(comment);
        return Ok("Yorum Başarıyla güncellendi");
    }
}
