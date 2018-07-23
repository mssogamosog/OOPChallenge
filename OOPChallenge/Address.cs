using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPChallenge
{
    public class Address
    {
        private int id;
        private string lineOne;
        private string lineTwo;
        private string city;
        private string country;
        private bool billingAddress;

        public Address(int id, string lineOne, string lineTwo, string city, string country, bool billingAddress)
        {
            this.id = id;
            this.lineOne = lineOne;
            this.lineTwo = lineTwo;
            this.city = city;
            this.country = country;
            this.billingAddress = billingAddress;
        }

        public string getAddress()
        {
            StringBuilder str = new StringBuilder();
            str.Append(this.lineOne).Append(" ").Append(this.lineTwo).Append(", ").Append(this.city).Append(" (").Append(this.country).Append(")");
            return str.ToString();
        }
    }
}
