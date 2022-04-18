namespace Phoenix.Data.Models
{
    public class Comments
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public string Name { get; set; }


        public int UsefulUrlId { get; set; }
        public UsefulUrl UsefulUrl { get; set; }
    }
}

