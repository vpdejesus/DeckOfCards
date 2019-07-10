using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;

namespace DeckOfCards.Pages
{
    public class DecksModel : PageModel
    {
        public List<CardDeck> Cards { get; set; }
        protected readonly ICardDeckService _cardService;
        public DecksModel(ICardDeckService cardService)
        {
            _cardService = cardService;
        }

        public void OnGet()
        {
            Cards = _cardService.GetCardDeck();
        }
    }
}