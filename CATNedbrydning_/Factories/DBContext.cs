using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CATNedbrydning_.Models;

namespace CATNedbrydning_.Factories
{
    public class DBContext
    {
        private AutoFactory<Contact> contactFactory;
        private AutoFactory<Home> homeFactory;

        public AutoFactory<Contact> ContactFactory
        {
            get
            {
                // Hvis denne factory IKKE eksisterer!
                if (contactFactory == null)
                {
                    contactFactory = new AutoFactory<Contact>();
                }
                return contactFactory;
            }
        }

        public AutoFactory<Home> HomeFactory
        {
            get
            {
                // Hvis denne factory IKKE eksisterer!
                if (homeFactory == null)
                {
                    homeFactory = new AutoFactory<Home>();
                }
                return homeFactory;
            }
        }
    }
}