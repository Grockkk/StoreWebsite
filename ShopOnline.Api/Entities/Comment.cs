namespace ShopOnline.Api.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public int Value { get; set; }
    }
}