namespace Cut_Coffee_Paste.Models
{
    // Models/BlogPost.cs
    using System.ComponentModel.DataAnnotations;

    public class BlogPost
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; } // Will store HTML from rich text editor

        public string? AuthorId { get; set; } // Links to Identity User

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public int LikesCount { get; set; }

        // For Tags/Categories
        public string? Tags { get; set; }
    }
}
