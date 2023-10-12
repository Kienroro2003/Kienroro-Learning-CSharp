// See https://aka.ms/new-console-template for more information

using JewelThief;

SafeOwner owner = new SafeOwner();
Safe safe = new Safe();
JewelThiefClass jewelThief = new JewelThiefClass();
jewelThief.OpenSafe(safe, owner);
Console.WriteLine("-------------");
Locksmith locksmith = jewelThief;
locksmith.ReturnContents("1234", owner);