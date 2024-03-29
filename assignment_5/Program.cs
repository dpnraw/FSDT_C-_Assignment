namespace assignment_5
{

    internal class Program
    {
        private static void Main(string[] args)
        {

            
            // Create a mailbox
            Mailbox mailbox = new Mailbox();

            // Add mail items to the mailbox
            mailbox.AddMail(new Letter(200.0, true, "Chemin des Acacias 28, 1009 Pully", "A3"));
            mailbox.AddMail(new Letter(800.0, false, "A4"));
            mailbox.AddMail(new Advertisement(1500.0, true, "Les Moilles 13A, 1913 Saillon"));
            mailbox.AddMail(new Advertisement(3000.0, false));
            mailbox.AddMail(new Parcel(5000.0, true, "Grand rue 18, 1950 Sion", 30.0));
            mailbox.AddMail(new Parcel(3000.0, true, "Chemin des fleurs 48, 2800 Delemont", 70.0));

            // Display the contents of the mailbox
            mailbox.Display();

            // Stamp the mails and display total postage amount
            double totalPostage = mailbox.Stamp();
            Console.WriteLine($"The total amount of postage is {totalPostage}");

            // Display the number of invalid mails
            int invalidCount = mailbox.InvalidMails();
            Console.WriteLine($"The box contains {invalidCount} invalid mails");

            Console.ReadKey();
        }

        
       
    }

}

