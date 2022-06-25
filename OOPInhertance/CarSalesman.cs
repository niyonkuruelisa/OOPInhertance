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
            throw new NotImplementedException();
        }
    }
}
