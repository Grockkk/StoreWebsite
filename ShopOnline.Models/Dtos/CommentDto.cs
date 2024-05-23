using System.ComponentModel.DataAnnotations;

namespace ShopOnline.Models.Dtos
{
    public class CommentDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ocena jest wymagana.")]
        public double Value { get; set; }

        [Required(ErrorMessage = "Opis jest wymagany.")]
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
    }
}