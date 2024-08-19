namespace CarBook.Dto.AuthorDtos;
public sealed class ResultAuthorByBlogIdDto
{
    public int Id { get; set; }
    public int AuthorId { get; set; }
    public string AuthorName { get; set; }
    public string AuthorDescription { get; set; }
    public string AuthorImage { get; set; }
}
