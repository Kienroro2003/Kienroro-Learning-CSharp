// See https://aka.ms/new-console-template for more information

using System.Text.Json;

Console.WriteLine(JsonSerializer.Serialize(3));
Console.WriteLine(JsonSerializer.Serialize((long)-3));
Console.WriteLine(JsonSerializer.Serialize((byte)0));
Console.WriteLine(JsonSerializer.Serialize(float.MaxValue));
Console.WriteLine(JsonSerializer.Serialize(float.MinValue));
Console.WriteLine(JsonSerializer.Serialize(true));
Console.WriteLine(JsonSerializer.Serialize("Elephant"));
Console.WriteLine(JsonSerializer.Serialize("Elephant".ToCharArray()));
Console.WriteLine(JsonSerializer.Serialize("🐘"));