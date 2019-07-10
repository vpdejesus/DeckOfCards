using System;
using ApplicationCore.Interfaces;

namespace Infrastructure.Services
{
    public class ShuffleService : IShuffleService
    {
        static Random _random = new Random();

        private static void ShuffleArray<T>(T[] array)
        {
            int n = array.Length;

            for (int i = 0; i < n; i++)
            {
                int r = i + _random.Next(n - i);
                T t = array[r];
                array[r] = array[i];
                array[i] = t;
            }
        }

        public string[] GetShuffledCards(bool isShuffle)
        {
            string[] cardNo = new string[52];

            for (int i = 0; i < cardNo.Length; i++)
            {
                var value = i + 1;
                cardNo[i] = value.ToString();
            }

            if (isShuffle)
            {
                ShuffleArray(cardNo);
            }

            return cardNo;
        }
    }
}