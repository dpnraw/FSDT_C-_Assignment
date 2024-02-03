internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("How much did you receive money ($)?");
        double amount;
        bool success = double.TryParse(Console.ReadLine(), out amount);

        if (success)
        {
            //set 75% of amount to book and 25% to other
            int forBooks = (int)((int)amount * 0.75);
            Console.WriteLine($"Books and Supplies : {forBooks}");

            // get remaining amount for other items
            double remainingBalance = amount - forBooks;
            //divide remainingBalance into three parts for each other items and no of items 
            //int partBalance = (int)remainingBalance / 3;

            // get each no that can be purchased in addtion
            int coffee = (int)((int)remainingBalance / 3) / 2;
            int flashComputer = (int)((int)remainingBalance / 3) / 4;
            int subway = (int)((int)remainingBalance / 3) / 3; ;

            Console.WriteLine("You can buy then:");
            Console.WriteLine($"{coffee} Coffees");
            Console.WriteLine($"{flashComputer} Flash Computer Numbers");
            Console.WriteLine($"{subway} Subway Tickets");

            double finalSaving = remainingBalance - ((coffee *2) + (flashComputer *4) + (subway * 3));

            Console.WriteLine($"And you will have {finalSaving} for the white roses.");




        } else { Console.WriteLine("Wrong Input!!!"); }

        Console.ReadKey();

    }
}