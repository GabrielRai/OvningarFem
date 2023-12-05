using System.ComponentModel.DataAnnotations;

namespace DataAccess2.Entities2;

public class BlogEntity
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Title { get; set; } = string.Empty;

    [Required]
    public string Content { get; set; } = string.Empty;
}