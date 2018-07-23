using System.ComponentModel.DataAnnotations;

namespace WebMarket.Domain.Entities.Models
{
    public class Comments
    {
        [Key]
        public string CommentsId { get; set; }

        [Key]
        public string UserId { get; set; }

        [Key]
        public string ProductId { get; set; }

        public string CommentText { get; set; }

        public string PublicationDate { get; set; }
    }
}
