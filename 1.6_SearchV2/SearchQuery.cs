namespace _1._6_SearchV2
{
    internal class SearchQuery
    {
        public string Text;
        public Dates Dates;

        public SearchQuery(string text, Dates dates)
        {
            Text = text;
            Dates = dates;
        }

        public SearchQuery()
        {
            
        }
    }
}