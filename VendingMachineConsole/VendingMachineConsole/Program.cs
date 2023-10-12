// See https://aka.ms/new-console-template for more information

using VendingMachineConsole;

VendingMachine vendingMachine = new AnimalFeedVendingMachine();
Console.WriteLine(vendingMachine.Dispense(2.00M) );