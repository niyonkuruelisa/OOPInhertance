using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInhertance
{
    internal class CarSalesman
    {
        private string _firstName;
        private string _lastName;

        public CarSalesman(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        public string FullName
        {
            get
            {
                return string.Format("{0} {1}",_firstName,_lastName);
            }
        }

        public void Sell()
        {
            Console.WriteLine(string.Format("Hello! My name is {0}, I want you to buy this car.",FullName));
        }
    }
}
