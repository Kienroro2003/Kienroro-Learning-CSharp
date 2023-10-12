// See https://aka.ms/new-console-template for more information

namespace ComicConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IEnumerable<Comic> mostExpensive =
                from comic in Comic.Catalog
                where Comic.Prices[comic.Issue] > 500
                orderby Comic.Prices[comic.Issue] descending 
                select comic;
            foreach (Comic comic in mostExpensive)
            {
                Console.WriteLine($"{comic} is worth {Comic.Prices[comic.Issue]:c}");
            }

            var number = 1;
            var number2 = number;
        }
    }
}