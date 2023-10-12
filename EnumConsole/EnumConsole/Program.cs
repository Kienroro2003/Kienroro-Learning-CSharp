// See https://aka.ms/new-console-template for more information

using EnumConsole;

void ItIsHeart(Suits suits)
{
    if (suits == Suits.Hearts)
    {
        Console.WriteLine("You pulled a heart!");
    }
    else
    {
        Console.WriteLine($"You didn't pull a heart: {suits}");
    }
}

int score = (int)TrickScore.Fetch * 3;
Console.WriteLine(score);