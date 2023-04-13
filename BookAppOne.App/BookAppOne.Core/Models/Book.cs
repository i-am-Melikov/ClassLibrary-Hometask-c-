namespace BookAppOne.Core.Models
{
    public class Book
    {
        public string Name { get; set; }
        public double Price { get; set; }


        public void GetFullInfo()
        {
            Console.WriteLine("Book`s name: "+Name + " "+"Book`s price:  " + Price);
        }
    }
}
