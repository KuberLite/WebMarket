using System.ComponentModel.DataAnnotations;

namespace WebMarket.Domain.Entities
{
    public class Comment
    {
        public string CommentId { get; set; }

        public string UserId { get; set; }

        public string ProductId { get; set; }

        public string CommentText { get; set; }

        public string PublicationDate { get; set; }
    }
}
