namespace Crawler
{
    using AngleSharp;
    using MvcTemplate.Data;

    public static class Program
    {
        public static void Main()
        {
            var db = new ApplicationDbContext();

            var configuration = Configuration.Default.WithDefaultLoader();
            var browsingContext = BrowsingContext.New(configuration);
        }
    }
}
