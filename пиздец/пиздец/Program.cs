using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пиздец
{
    public class Deck
    {
        protected List<string> deck = new List<string> { "2", "2", "2", "2", "3", "3", "3", "4", "4", "4", "4", "4", "5", "5", "5", "5", "6", "6", "6", "6", "7", "7", "7", "7", "8", "8", "8", "8", "9", "9", "9", "9", "j", "j", "j", "j", "q", "q", "q", "q", "k", "k", "k", "k", "a", "a", "a", "a" };
        protected string GiveCard()
        {
            Random rnd = new Random();
            int cardindex = rnd.Next(0, deck.Count);
            string card = deck[cardindex];
            deck.RemoveAt(cardindex);
            return card;

        }
    }
    public class Player : Deck
    {
        private List<string> playershand = new List<string>();
        private int playershandprice;
        private int balance = 1000;
        private int playersbet;
        public void Bet(int bet)
        {
            balance -= bet;
            playersbet = bet;
        }
        public int GetPlayersBet()
        {
            return playersbet;
        }
        public void GivePrize(int prize)
        {
            balance += prize;
        }
        public void Hand()
        {
            playershand.Add(GiveCard());
            playershand.Add(GiveCard());
            for (int i = 0; i < 2; i++)
            {
                int cardprice;
                if (int.TryParse(playershand[i], out cardprice))
                {
                    playershandprice += cardprice;
                }
                else
                {
                    if (playershand[i] != "a")
                    {
                        playershandprice += 10;
                    }
                    else
                    {
                        if (playershandprice == 11)
                        {
                            playershandprice = 2;
                        }
                        else
                        {
                            playershandprice += 11;
                        }
                    }
                }
            }
        }
        public void ShowPlaersHandPrice()
        {
            Console.WriteLine(playershandprice);
        }
        public void AddCard()
        {
            playershand.Add(GiveCard());
            int cardprice;
            if (int.TryParse(playershand[playershand.Count - 1], out cardprice))
            {
                playershandprice += cardprice;
            }
            else
            {
                if (playershand[playershand.Count - 1] != "a")
                {
                    playershandprice += 10;
                }
                else
                {
                    playershandprice += 11;
                }
            }
        }
        public int GetPlaersHandPrice()
        {
            return playershandprice;
        }
        public int GetPlayersBalance()
        {
            return balance;
        }

    }

    public class Dealer : Deck
    {
        private string[] dealershand = { "", "" };
        private int dealershandprice;
        private int dealersfirstcard;
        public void Hand()
        {
            dealershand[0] = GiveCard();
            dealershand[1] = GiveCard();

            for (int i = 0; i < 2; i++)
            {
                int cardprice;
                if (int.TryParse(dealershand[i], out cardprice))
                {
                    dealershandprice += cardprice;
                }
                else
                {
                    if (dealershand[i] != "a")
                    {
                        dealershandprice += 10;
                    }
                    else
                    {
                        if (dealershandprice == 11)
                        {
                            dealershandprice = 2;
                        }
                        else
                        {
                            dealershandprice += 11;
                        }
                    }
                }
                if (i == 0)
                {
                    dealersfirstcard = cardprice;
                }
            }
        }
        public void ShowDealersFirstCard()
        {
            Console.WriteLine(dealersfirstcard);
        }
        public void ShowDealersHandPrice()
        {
            Console.WriteLine(dealershandprice);
        }
        public int GetDealersHandPrice()
        {
            return dealershandprice;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string flag = "";
            while (flag != "end")
            {
                Console.WriteLine("Добро пожаловать в блек джек");
                Console.WriteLine("Введите start ,чтобы начать играть");
                flag = Console.ReadLine();
                if (flag == "start")
                {
                    Deck deck = new Deck();
                    Player player = new Player();
                    Dealer dealer = new Dealer();
                    Console.Write("Ваш баланс:");
                    Console.WriteLine(player.GetPlayersBalance());
                    Console.Write("введите вашу ставку:");
                    player.Bet(int.Parse(Console.ReadLine()));
                    player.Hand();
                    Console.Write("Ваши карты:");
                    player.ShowPlaersHandPrice();
                    dealer.Hand();
                    Console.Write("1 карта дилера:");
                    dealer.ShowDealersFirstCard();
                    string flag1 = "";
                    while (flag1 != "no")
                    {
                        Console.WriteLine("Введите yes , если xотите добрать карту, и no ,если не хотите");
                        flag1 = Console.ReadLine();
                        if (flag1 == "yes")
                        {
                            player.AddCard();
                            Console.Write("Ваша рука:");
                            player.ShowPlaersHandPrice();
                        }
                    }
                    if (player.GetPlaersHandPrice() > 21)
                    {
                        Console.WriteLine("Ваша рука:");
                        player.ShowPlaersHandPrice();
                        Console.Write("Рука дилера:");
                        dealer.ShowDealersHandPrice();
                        Console.WriteLine("Вы проиграли,ваша рука больше 21");

                    }
                    else if (player.GetPlaersHandPrice() < dealer.GetDealersHandPrice())
                    {
                        Console.WriteLine("Ваша рука:");
                        player.ShowPlaersHandPrice();
                        Console.Write("Рука дилера:");
                        dealer.ShowDealersHandPrice();
                        Console.WriteLine("Вы проиграли,рука дилера больше");
                    }
                    else if (player.GetPlaersHandPrice() > dealer.GetDealersHandPrice())
                    {
                        if (player.GetPlaersHandPrice() != 21)
                            player.GivePrize(player.GetPlayersBet() * 2);
                        else
                            player.GivePrize(player.GetPlayersBet() * 3);
                        Console.WriteLine("Ваша рука:");
                        player.ShowPlaersHandPrice();
                        Console.Write("Рука дилера:");
                        dealer.ShowDealersHandPrice();
                        Console.WriteLine("Вы Выиграли");
                        Console.Write("Ваш баланс:");
                        Console.WriteLine(player.GetPlayersBalance());

                    }
                    else
                    {
                        player.GivePrize(player.GetPlayersBet());
                        Console.WriteLine("Ваша рука:");
                        player.ShowPlaersHandPrice();
                        Console.Write("Рука дилера:");
                        dealer.ShowDealersHandPrice();
                        Console.WriteLine("Ничья");
                        Console.Write("Ваш баланс:");
                        Console.WriteLine(player.GetPlayersBalance());
                    }
                }
            }
        }
    }
}
