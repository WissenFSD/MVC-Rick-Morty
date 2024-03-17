namespace MVC_ApiCall.Models
{

    public class CharacterResults
    {
        public List<Character> results { get; set; }
        public Page info { get; set; }
    }


    public class Page
    {


        public int Count { get; set; }
        public int Pages { get; set; }


    }
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string Species { get; set; }
        public string Gender { get; set; }
        public string Image { get; set; }
    }
}
