using FlashCardsBootstrapLol.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace FlashCardsBootstrapLol.Models
{
    public enum CardType
    {
        Qoute,
        ImageTop,
        ImageMiddle,
        ImageBottom,
        NoImage,
        Recomendations,     //not creatable
    }

    public class Card : IEntity
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [Display(Name = "Title")]
        public string Title;

        [Display(Name = "Content")]
        public string Content;

        [Display(Name = "Author")]
        public string Author;

        public string ImageName = "";

        public List<string> Tags = new List<string>();

        public CardType Type = CardType.Qoute;      //!!!Test!!!

        [Display(Name = "Likes")]
        public int Likes = 0;

        public List<Comment> Comments = new List<Comment>();
    }
}