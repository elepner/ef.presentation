public class Author
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public List<Post> Posts { get; set; }
}
public class Post
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    
    public int AuthorId { get; set; }
    public Author Author { get; set; }

    public int? Rating { get; set; }
}
