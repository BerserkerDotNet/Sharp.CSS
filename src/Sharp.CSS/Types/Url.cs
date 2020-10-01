namespace Sharp.CSS.Types
{
    public class Url
    {
        private readonly string _url;

        public Url(string url)
        {
            _url = url;
        }

        public override string ToString()
        {
            return $"url({_url})";
        }
    }
}
