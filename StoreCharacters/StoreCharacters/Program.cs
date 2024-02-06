// See https://aka.ms/new-console-template for more information

using System.Text;
using System.Text.Json;

File.WriteAllText("eureka.txt", "שלום", Encoding.Unicode);
byte[] eurekaBytes = File.ReadAllBytes("eureka.txt");
foreach (byte b in eurekaBytes)
    Console.Write("{0} ", b);
Console.WriteLine(Encoding.UTF8.GetString(eurekaBytes));
foreach (byte b in eurekaBytes)
    Console.Write("{0:x2} ", b);
Console.WriteLine();
Console.WriteLine(Encoding.Unicode.GetString(eurekaBytes));
Console.WriteLine(JsonSerializer.Serialize("ש"));