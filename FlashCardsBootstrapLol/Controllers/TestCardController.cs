using FlashCardsBootstrapLol.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlashCardsBootstrapLol.Controllers
{
    public class TestCardController : Controller
    {
        public TestDataBase db = new TestDataBase();

        // GET: Card
        public ActionResult Index()
        {
            return View(db.Cards.ToList());
        }

        // GET: Card/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Card/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Card/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Card/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Card/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Card/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Card/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }

    public class TestDataBase : DbContext
    {
        public List<Card> Cards = new List<Card>();

        public TestDataBase()
        {
            TestData();
        }

        void TestData()
        {
            Cards.Add(new Card
            {
                Title = "Florence Nightingale",
                Content = "I attribute my success to this: I never gave or took any excuse"
            });
            Cards.Add(new Card
            {
                Title = "Napoleon Hill",
                Content = "Whatever the mind of man can conceive and believe, it can achieve."
            });
            Cards.Add(new Card
            {
                Title = "Albert Einstein",
                Content = "Strive not to be a success, but rather to be of value."
            });
            Cards.Add(new Card
            {
                Title = "Robert Frost",
                Content = "Two roads diverged in a wood, and I—I took the one less traveled by, And that has made all the difference."
            });
            Cards.Add(new Card
            {
                Title = "Wayne Gretzky",
                Content = "You miss 100% of the shots you don’t take."
            });
            Cards.Add(new Card
            {
                Title = "Michael Jordan",
                Content = "I've missed more than 9000 shots in my career. I've lost almost 300 games. 26 times I've been trusted to take the game winning shot and missed. I've failed over and over and over again in my life. And that is why I succeed."
            });
            Cards.Add(new Card
            {
                Title = "Amelia Earhart",
                Content = "The most difficult thing is the decision to act, the rest is merely tenacity."
            });
            Cards.Add(new Card
            {
                Title = "Dr. Seuss",
                Content = "Don't cry because it's over, smile because it happened."
            });
            Cards.Add(new Card
            {
                Title = "Marilyn Monroe",
                Content = "I'm selfish, impatient and a little insecure. I make mistakes, I am out of control and at times hard to handle. But if you can't handle me at my worst, then you sure as hell don't deserve me at my best."
            });
            Cards.Add(new Card
            {
                Title = "Oscar Wilde",
                Content = "Be yourself; everyone else is already taken."
            });
            Cards.Add(new Card
            {
                Title = "Albert Einstein",
                Content = "Two things are infinite: the universe and human stupidity; and I'm not sure about the universe."
            });
            Cards.Add(new Card
            {
                Title = "Frank Zappa",
                Content = "So many books, so little time."
            });
            Cards.Add(new Card
            {
                Title = "Bernard M. Baruch",
                Content = "Be who you are and say what you feel, because those who mind don't matter, and those who matter don't mind."
            });
            Cards.Add(new Card
            {
                Title = "William W. Purkey",
                Content = "You've gotta dance like there's nobody watching, Love like you'll never be hurt, Sing like there's nobody listening, And live like it's heaven on earth."
            });
        }
    }
}
