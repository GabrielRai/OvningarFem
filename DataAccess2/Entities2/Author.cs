using System.ComponentModel.DataAnnotations;

namespace DataAccess2.Entities2;

public class Author
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    public List<BlogEntity> BlogPosts { get; set; } = new();
}