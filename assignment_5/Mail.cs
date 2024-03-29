using System;

namespace assignment_5 {
    public abstract class Mail
    {
        // Properties that are used in Letter, parcel and advertisement
        public double Weight { get; set; }
        public bool IsExpress { get; }
        public string DestinationAddress { get; set; }

        // we are using abstract method because we are going to override according to need in other classes

        public abstract double Stamp();
        public abstract bool IsValid();


        // Constructor to initialize object with valid destination address
        public Mail(double weight, bool isExpress, string destinatonAddress)
        {
            Weight = weight;
            IsExpress = isExpress;
            DestinationAddress = destinatonAddress;
        }

        // constructor to initialize objects with invalid destination address or no address
        public Mail(double weight, bool isExpress)
        {
            Weight = weight;
            IsExpress = isExpress;
            DestinationAddress = null;
        }
    }

}
