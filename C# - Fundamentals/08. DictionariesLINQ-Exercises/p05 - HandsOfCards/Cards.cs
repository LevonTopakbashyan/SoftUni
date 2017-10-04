namespace p05___HandsOfCards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Cards
    {
        public static void Main()
        {
            var cardPowers = GetCardPower();
            var cardTypes = GetCardType();

            var cards = new Dictionary<string, HashSet<int>>();

            var line = Console.ReadLine();

            while (line != "JOKER")
            {
                var tokens = line.Split(':');

                var name = tokens[0];
                var playerCards = tokens[1].Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                foreach (var card in playerCards)
                {
                    var cardPower = card.Substring(0,card.Length-1);
                    var cardType = card.Substring(card.Length-1);

                    var sum = cardPowers[cardPower] * cardTypes[cardType];

                    if (!cards.ContainsKey(name))
                    {
                        cards[name] = new HashSet<int>();
                    }
                    cards[name].Add(sum);
                }

                line = Console.ReadLine();
            }
            foreach (var pair in cards)
            {
                var name = pair.Key;
                var cardsSum = pair.Value.Sum();

                Console.WriteLine($"{name} -> {cardsSum}");
            }
        }

        private static Dictionary<string, int> GetCardType()
        {
            var type = new Dictionary<string, int>();

            type["S"] = 4;
            type["H"] = 3;
            type["D"] = 2;
            type["C"] = 1;

            return type;
        }

        private static Dictionary<string, int> GetCardPower()
        {
            var power = new Dictionary<string, int>();

            for (int i = 2; i <= 10; i++)
            {
                power[i.ToString()] = i;
            }

            power["J"] = 11;
            power["Q"] = 12;
            power["K"] = 13;
            power["A"] = 14;

            return power;
        }
    }
}
