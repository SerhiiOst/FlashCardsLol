using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlashCardsBootstrapLol.Models
{
    public enum Accesability
    {
        User,
        Moderator,
        Administrator
    }

    public enum Gender
    {
        Male,
        Female,
        Other,
        NoAnswer
    }

    public class Accaunt
    {
        public Accesability Accesability;

        public string Login;
        public string Password;

        public string Nickname;
        public Gender Gender;
        public int Age;
        //
        public string Country;
        public string Header;
        public string Info;

        public string ProfileImgPath;

        public List<Card> PublicatedCards = new List<Card>();
        public List<Card> FavouriteCards = new List<Card>();

        public List<Accaunt> Followers;
        public List<Accaunt> Watches = new List<Accaunt>();

        public Accaunt(string login, string password, string nickname, Gender gender, int age)
        {
            Login = login;
            Password = password;
            Nickname = nickname;
            Gender = gender;
            Age = age;
        }
    }
}