using BookAppOne.App.Services;

BookServices bookServices = new BookServices();

Console.WriteLine("0.Close App");
Console.WriteLine("1.Show All Books");
Console.WriteLine("2.Create New Book");

string RequestNumber = Console.ReadLine();

while (RequestNumber != "0")
{
    switch (RequestNumber)
    {
        case "1":
            bookServices.ShowBooks();
            break;
        case "2":
            bookServices.CreateBook();
            break;
        default:
            Console.WriteLine("Please Enter Valid Value");
            break;
    }


Console.WriteLine("0.Close App");
Console.WriteLine("1.Show All Books");
Console.WriteLine("2.Create New Book");

RequestNumber = Console.ReadLine();
}
