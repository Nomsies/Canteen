namespace Canteen.Model
{
    public class Transaction
    {
        public int Id {  get; set; }
        public DateTime dateTime { get; set; }
        public int MenuId { get; set; }
        public int TakeAway { get; set; }
        public int PaymentId { get; set; }
    }
}