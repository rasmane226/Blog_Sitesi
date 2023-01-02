namespace Blog_Sitesi.Models
{
    public class Communication
    {
        [key]
        public int id { get; set; }
        public string ad { get; set; }
        public string email { get; set; }
        public string konu { get; set; }
        public string mesaj { get; set; }
    }
}
