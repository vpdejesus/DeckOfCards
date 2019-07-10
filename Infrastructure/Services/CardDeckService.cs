using System.Collections.Generic;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;

namespace Infrastructure.Services
{
    public class CardDeckService : ICardDeckService
    {
        public CardDeckService()
        {
        }

        private List<CardDeck> _cards
        {
            get
            {
                var model = new List<CardDeck>();

                for (int i = 1; i <= 52; i++)
                {
                    model.Add(new CardDeck()
                    {
                        Id = i,
                        ImagePath = $"/images/cards/{i.ToString()}.png"
                    });
                }

                return model;
            }
        }

        public List<CardDeck> GetCardDeck()
        {
            return _cards;
        }

        public void Dispose()
        {
            Dispose(true);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
            }
        }
    }
}