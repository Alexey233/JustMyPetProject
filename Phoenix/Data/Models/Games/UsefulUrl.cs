namespace Phoenix.Data.Models
{
    public class UsefulUrl
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }


        public int CommentsId { get; set; }
        public List<Comments> Comments { get; set; }
    }
}
