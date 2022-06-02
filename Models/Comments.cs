namespace ThanksCardAPI.Models
{
    public class Comments
    {
        public long Id { get; set; }

        public string? Text { get; set; }

        public virtual User? User { get; set; }

        public long? UserId { get; set; }
    }
}
