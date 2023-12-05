using System.ComponentModel.DataAnnotations;

namespace DataAccess2.Entities2;

public class Comment
{
    [Key]
    public int Id { get; set; }

    public string CommentContent { get; set; } = string.Empty;

}