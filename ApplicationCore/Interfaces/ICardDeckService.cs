using System.Collections.Generic;

namespace ApplicationCore.Interfaces
{
    public interface ICardDeckService : IBaseService
    {
        List<Entities.CardDeck> GetCardDeck();
    }
}