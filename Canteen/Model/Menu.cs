namespace Canteen.Model
{
    public class Menu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string ImageLocation { get; set; }
    }

    public class Foods : Menu { }
    public class Drinks : Menu { }
}
