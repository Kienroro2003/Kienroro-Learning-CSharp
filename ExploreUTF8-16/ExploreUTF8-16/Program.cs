// See https://aka.ms/new-console-template for more information

using System.Text;

File.WriteAllText("eureka.txt", "W", Encoding.Unicode);
byte[] eurekaBytes = File.ReadAllBytes("eureka.txt");
foreach (byte b in eurekaBytes)
    Console.Write("{0:x2} ", b);
Console.WriteLine(Encoding.UTF8.GetString(eurekaBytes));

File.WriteAllText("elephant1.txt", "\uD83D\uDC18");
File.WriteAllText("elephant2.txt", "\U0001F418");