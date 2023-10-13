using System.Collections.ObjectModel;

namespace JimmyLinq;

public static class ComicAnalyzer
{
    private static PriceRange CalculatePriceRange(Comic comic)
    {
        if (Comic.Prices[comic.Issue] < 100) return PriceRange.Cheap;
        return PriceRange.Expensive;
    }

    public static IEnumerable<IGrouping<PriceRange, Comic>> GroupComicsByPrice(IEnumerable<Comic> comics,
        IReadOnlyDictionary<int, decimal> prices)
    {
        var grouped =
            from comic in comics
            group comic by CalculatePriceRange(comic)
            into priceGroup
            orderby priceGroup.Key ascending
            select priceGroup;
        return grouped;
    }

    public static IEnumerable<string> GetReviews(IEnumerable<Comic> comics, IEnumerable<Review> reviews)
    {
        var comicReview = from c in comics
            join r in reviews on c.Issue equals r.Issue
            select $"{r.Critic} rated #{c.Issue} \'{c.Name}\' {r.Score}";
        return comicReview;
    }
}