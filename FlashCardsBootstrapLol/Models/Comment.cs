using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FlashCardsBootstrapLol.Models
{
    public class Comment
    {
        [Display(Name = "Author")]
        public Accaunt Author;

        [Display(Name = "Text")]
        public string Text;

        [Display(Name = "Time")]
        public string Time;

    }
}