using System.Collections.Generic;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DeckOfCards.Pages
{
    public class CardsModel : PageModel
    {
        public List<CardDeck> Cards { get; set; }
        protected readonly ICardDeckService _cardService;
        public CardsModel(ICardDeckService cardService)
        {
            _cardService = cardService;           
        }

        public void OnGet()
        {
            Cards = _cardService.GetCardDeck();
        }
    }
}