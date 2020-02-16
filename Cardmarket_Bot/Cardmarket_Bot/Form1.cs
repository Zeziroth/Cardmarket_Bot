using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cardmarket_Bot.Wrapper;
using Cardmarket_Bot.Account;
using Cardmarket_Bot.Message;
using Cardmarket_Bot.Game;
using Cardmarket_Bot.Expansion;
using Cardmarket_Bot.Single;
using Cardmarket_Bot.Product;
using Cardmarket_Bot.Article;
using Cardmarket_Bot.General;

namespace Cardmarket_Bot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_Foil.SelectedIndex = 0;
            comboBox_FirstEdition.SelectedIndex = 0;
            comboBox_Condition.SelectedIndex = 0;
            comboBox_Bulk.SelectedIndex = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadGames();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            LoadExpansions();
        }

        private void listView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            LoadSingles();
        }
        private void listView3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            LoadArticles();
        }
        private void bulkBuyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadBulk();
        }
        public void LoadGames()
        {
            GameRoot games = Controller.GetGames();
            listView_Game.Items.Clear();
            foreach (Game.Game game in games.game)
            {
                ListViewItem itm = new ListViewItem(game.name);
                itm.Tag = game.idGame;
                ListViewAddItem(listView_Game, itm, label_Game);
            }
        }
        public void LoadExpansions()
        {
            if (listView_Game.SelectedItems.Count == 1)
            {
                ListViewItem itm = listView_Game.SelectedItems[0];
                ExpansionRoot expansions = Controller.GetExpansions((int)itm.Tag);
                listView_Expansion.Items.Clear();
                foreach (Expansion.Expansion expansion in expansions.expansion)
                {
                    ListViewItem itmNew = new ListViewItem(expansion.GetLocalByName("German").name);
                    itmNew.Tag = expansion.idExpansion;
                    ListViewAddItem(listView_Expansion, itmNew, label_Expansion);
                }
            }
        }
        public void LoadSingles()
        {
            if (listView_Expansion.SelectedItems.Count == 1)
            {
                ListViewItem itm = listView_Expansion.SelectedItems[0];
                SingleRoot singles = Controller.GetSingles((int)itm.Tag);
                listView_Single.Items.Clear();
                foreach (Single.Single single in singles.single)
                {
                    ListViewItem itmNew = new ListViewItem(single.GetLocalByName("German").name);
                    itmNew.Tag = single.idProduct;
                    ListViewAddItem(listView_Single, itmNew, label_Single);
                }
            }
        }
        public void LoadArticles()
        {
            if (listView_Single.SelectedItems.Count == 1)
            {
                ListViewItem itm = listView_Single.SelectedItems[0];
                ArticleRoot articles = Controller.GetArticles((int)itm.Tag);

                int isFoil = -1;
                switch (comboBox_Foil.Text)
                {
                    case "Yes":
                        isFoil = 1;
                        break;

                    case "No":
                        isFoil = 0;
                        break;
                }

                int isFirstEdition = -1;
                switch (comboBox_FirstEdition.Text)
                {
                    case "Yes":
                        isFirstEdition = 1;
                        break;

                    case "No":
                        isFirstEdition = 0;
                        break;
                }

                string condition = comboBox_Condition.Text;

                if (condition == "-")
                {
                    condition = "";
                }

                listView_Article.Items.Clear();
                listView_Article.BringToFront();
                foreach (Article.Article article in articles.GetArticleByFilter("German", condition, isFoil, isFirstEdition))
                {
                    ListViewItem itmNew = new ListViewItem(article.seller.username + " // " + article.price);
                    itmNew.Tag = article.idArticle;
                    ListViewAddItem(listView_Article, itmNew, label_Article);
                }
            }
        }

        public void LoadBulk()
        {
            LoadSingles();

            if (listView_Single.Items.Count > 0)
            {
                listView_Bulk.Items.Clear();
                listView_Bulk.BringToFront();
                Dictionary<string, List<double>> offers = new Dictionary<string, List<double>>();

                foreach (ListViewItem singleItem in listView_Single.Items)
                {
                    ArticleRoot articles = Controller.GetArticles((int)singleItem.Tag);

                    int isFoil = -1;
                    switch (comboBox_Foil.Text)
                    {
                        case "Yes":
                            isFoil = 1;
                            break;

                        case "No":
                            isFoil = 0;
                            break;
                    }

                    int isFirstEdition = -1;
                    switch (comboBox_FirstEdition.Text)
                    {
                        case "Yes":
                            isFirstEdition = 1;
                            break;

                        case "No":
                            isFirstEdition = 0;
                            break;
                    }

                    string condition = comboBox_Condition.Text;

                    if (condition == "-")
                    {
                        condition = "";
                    }


                    Article.Article article = articles.GetArticleByFilter("German", condition, isFoil, isFirstEdition).OrderBy(a => a.price).First();

                    ListViewItem itmNew = new ListViewItem("(" + singleItem.Text + ") " + article.seller.username + " // " + article.price);
                    itmNew.Tag = article.price;
                    ListViewAddItem(listView_Bulk, itmNew, label_Bulk);
                    if (!offers.ContainsKey(article.seller.username))
                    {
                        offers.Add(article.seller.username, new List<double>());
                    }
                    offers[article.seller.username].Add(article.price);
                    Application.DoEvents();
                }

                double price = 0.0;

                foreach (string sellers in offers.Keys)
                {
                    double currentPrice = offers[sellers].Sum();
                    int currentCount = offers[sellers].Count();

                    price += currentPrice;
                    price += Shipping.GetShippingPrice(currentCount, currentPrice, (comboBox_Bulk.Text == "YES"));
                }

                label_Bulk_Price.Text = "Price: " + Math.Round(price, 2);
            }
            else
            {
                MessageBox.Show("No singles for Bulk-Function");
            }
        }

        public void ListViewAddItem(ListView list, ListViewItem item, Label lbl = null)
        {
            list.Items.Add(item);
            lbl.Text = "Count: " + list.Items.Count;
        }
    }
}
