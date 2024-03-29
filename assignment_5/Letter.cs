namespace assignment_5
{
    public class Letter : Mail // inherit properties from Mail abstract base class
    {

        // Extra proprty to specify the format
        public string Format { get; set; }

        // constuctor to initialize valid letter object
        public Letter(double weight, bool isExpress, string destinationAddress, string format):
            base(weight, isExpress, destinationAddress)
        {
            Format = format;
        }

        // constuctor to initialize invalid letter object or without destinationAddress
        public Letter(double weight, bool isExpress, string format) :
            base(weight, isExpress)
        {
            Format = format;
        }

        //override Mail class method
        public override bool IsValid()
        {
            // Check for valid destination address
            return !string.IsNullOrWhiteSpace(DestinationAddress);
        }


        // override Stamp method
        public override double Stamp()
        {
            if (!IsValid()) { 
                return 0.0 ;
            }

            double baseFare = Format == "A4" ? 2.50 : 3.50;
            double amount = baseFare + 1.0 * (Weight / 1000); // Weight converted to kilograms
            if (IsExpress)
            {
                amount *= 2; // Double the amount for express shipping
            }
            return amount;

        }

        
    }

}
