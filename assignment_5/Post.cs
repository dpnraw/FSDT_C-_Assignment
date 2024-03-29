using System;

namespace assignment_5
{
    public class Mailbox
    {
        // class members

        // array to hold the mails
        // declaring list
        private List<Mail> mails;

        // Constructor to initilize List of Mail objects 
        public Mailbox()
        {
            mails = new List<Mail>();
        }

        // Method to add a mail to the mailbox
        public void AddMail(Mail mail)
        {
            mails.Add(mail);
        }

        // Method to stamp mails and return total price
        public double Stamp()
        {
            double amount = 0.0;
            foreach (var mail in mails)
            {
                amount += mail.Stamp();
            }
            return amount;
        }

        // Method to calculate and return the number of invalid mails
        public int InvalidMails()
        {
            int count = 0;
            foreach (var mail in mails)
            {
                if (!mail.IsValid())
                {
                    count++;
                }
            }
            return count;
        }

        // Method to display the contents of the mailbox
        public void Display()
        {
            foreach (var mail in mails)
            {
                Console.WriteLine(mail.GetType().Name);
                // Display mail details and indicate if invalid
                Console.WriteLine($"Weight: {mail.Weight} grams");
                Console.WriteLine($"Express: {(mail.IsExpress ? "yes" : "no")}");
                Console.WriteLine($"Destination: {mail.DestinationAddress}");
                double postage = mail.Stamp();
                Console.WriteLine($"Price: ${postage}");
                if (!mail.IsValid())
                {
                    Console.WriteLine("(Invalid courier)");
                }
                if (mail is Letter letter)
                {
                    Console.WriteLine($"Format: {letter.Format}");
                }
                else if (mail is Parcel parcel)
                {
                    Console.WriteLine($"Volume: {parcel.Volume} liters");
                }
                Console.WriteLine();
            }
        }
    }
}
