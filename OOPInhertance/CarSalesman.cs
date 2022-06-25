using System;


namespace OOPInhertance
{
    internal class CarSalesman : Salesman
    {
        public CarSalesman(string firstName, string lastName) : base(firstName, lastName)
        {

        }

        public override void Sell()
        {
            Console.WriteLine(string.Format("Hello! My name is {0}, I would recommend you to buy this car.", FullName));

        }
    }
}
