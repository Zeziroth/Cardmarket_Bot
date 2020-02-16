namespace Cardmarket_Bot
{
    public static class Settings
    {
        public static readonly string API_ENDPOINT = "https://api.cardmarket.com/ws/v2.0/output.json/";

        public static readonly string ACCOUNT_ENDPOINT = "account";
        public static readonly string MESSAGE_ENDPOINT = "account/messages";

        public static readonly string GAMES_ENDPOINT = "games";
        public static readonly string EXPANSIONS_ENDPOINT = "games/{0}/expansions";
        public static readonly string SINGLES_ENDPOINT = "expansions/{0}/singles";
        public static readonly string PRODUCTS_ENDPOINT = "products/{0}";
        public static readonly string ARTICLES_ENDPOINT = "articles/{0}";
    }
}
