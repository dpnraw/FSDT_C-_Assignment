using System;

namespace assignment_5
{
    // Subclass representing an advertisement
    public class Advertisement : Mail
    {
        // Constructor
        public Advertisement(double weight, bool isExpress, string destinationAddress)
            : base(weight, isExpress, destinationAddress)
        {
        }

        public Advertisement(double weight, bool isExpress)
            : base(weight, isExpress)
        {
        }

        // Method to check if the advertisement is valid
        public override bool IsValid()
        {
            // Check for valid destination address
            return !string.IsNullOrWhiteSpace(DestinationAddress);
        }

        // Method to calculate postage amount for an advertisement
        public override double Stamp()
        {
            if (!IsValid())
            {
                return 0.0;
            }


            double amount = 5.0 * Weight / 1000; // Weight converted to kilograms
            if (IsExpress)
            {
                amount *= 2; // Double the amount for express shipping
            }
            return amount;
        }

        
    }
}