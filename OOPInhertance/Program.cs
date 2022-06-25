// See https://aka.ms/new-console-template for more information
using OOPInhertance;

App();

void App()
{
    //  Create an instance from a class
    CarSalesman ElisaTheSalesman = new CarSalesman("Niyonkuru", "Elisa");
    Console.WriteLine(ElisaTheSalesman.FullName);
    ElisaTheSalesman.Sell();

    RetailSalesman ChrisTheSalesman = new RetailSalesman("Iradukunda", "Chris");
    Console.WriteLine(ChrisTheSalesman.FullName);
    ChrisTheSalesman.Sell();
}
