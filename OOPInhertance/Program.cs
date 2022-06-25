// See https://aka.ms/new-console-template for more information
using OOPInhertance;


App();

void App()
{
    //  Create an instance from a class
    CarSalesman carSalesman1 = new CarSalesman("Niyonkuru", "Elisa");
    Console.WriteLine(carSalesman1.FullName);
    carSalesman1.Sell();
}
