using System;


namespace OOPInhertance
{
    internal class RetailSalesman : Salesman
    {
        public RetailSalesman(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public override void Sell()
        {
            throw new NotImplementedException();
        }
    }
}
