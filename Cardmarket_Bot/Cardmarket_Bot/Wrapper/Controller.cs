using Newtonsoft.Json;
using Cardmarket_Bot.Account;
using Cardmarket_Bot.Message;
using Cardmarket_Bot.Game;
using Cardmarket_Bot.Expansion;
using Cardmarket_Bot.Single;
using Cardmarket_Bot.Product;
using Cardmarket_Bot.Article;

namespace Cardmarket_Bot.Wrapper
{
    public static class Controller
    {
        public static AccountRoot GetAccountInformation()
        {
            return JsonConvert.DeserializeObject<AccountRoot>(RequestHelper.MakeRequest(Settings.ACCOUNT_ENDPOINT));
        }

        public static MessageRoot GetMessages()
        {
            return JsonConvert.DeserializeObject<MessageRoot>(RequestHelper.MakeRequest(Settings.MESSAGE_ENDPOINT));
        }

        public static GameRoot GetGames()
        {
            return JsonConvert.DeserializeObject<GameRoot>(RequestHelper.MakeRequest(Settings.GAMES_ENDPOINT));
        }

        public static ExpansionRoot GetExpansions(int gameID)
        {
            return JsonConvert.DeserializeObject<ExpansionRoot>(RequestHelper.MakeRequest(Settings.EXPANSIONS_ENDPOINT, gameID));
        }

        public static SingleRoot GetSingles(int expansionID)
        {
            return JsonConvert.DeserializeObject<SingleRoot>(RequestHelper.MakeRequest(Settings.SINGLES_ENDPOINT, expansionID));
        }

        public static ProductRoot GetProducts(int singleID)
        {
            return JsonConvert.DeserializeObject<ProductRoot>(RequestHelper.MakeRequest(Settings.PRODUCTS_ENDPOINT, singleID));
        }

        public static ArticleRoot GetArticles(int productID)
        {
            return JsonConvert.DeserializeObject<ArticleRoot>(RequestHelper.MakeRequest(Settings.ARTICLES_ENDPOINT, productID));

        }
    }
}
