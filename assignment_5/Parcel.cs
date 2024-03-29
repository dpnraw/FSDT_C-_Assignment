using System;

namespace assignment_5 { 
    public class Parcel: Mail // inherit properties
    {
        // additional properties
        public double Volume
        {
            get; set;
        }

        // construtor for valid destination address
        public Parcel(double weight, bool isExpress, string destinationAddress, double volume) : base(weight, isExpress, destinationAddress)
        {
            Volume = volume;
        }
 
        public Parcel(double weight, bool isExpress, double volume) : base(weight, isExpress)
        {
            Volume = volume;
        }


        // override IsValid method of mail class
        public override bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(DestinationAddress) && Volume <= 50;
        }

        // override stamp method of mail class
        public override double Stamp()
        {
            if (!IsValid())
            {
                return 0.0;
            }

            double amount = 0.25 * Volume + Weight / 1000 * 1.0; // Volume converted to liters and weight to kilograms
            if (IsExpress)
            {
                amount *= 2; // Double the amount for express shipping
            }
            return amount;
        }

        
    }
}


