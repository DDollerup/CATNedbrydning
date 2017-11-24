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
        private AutoFactory<Deconstruction> deconstructionFactory;
        private AutoFactory<Crushing> crushingFactory;
        private AutoFactory<Models.Environment> environmentFactory;
        private AutoFactory<Subpage> subpageFactory;

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
        public AutoFactory<Deconstruction> DeconstructionFactory
        {
            get
            {
                // Hvis denne factory IKKE eksisterer!
                if (deconstructionFactory == null)
                {
                    deconstructionFactory = new AutoFactory<Deconstruction>();
                }
                return deconstructionFactory;
            }
        }
        public AutoFactory<Crushing> CrushingFactory
        {
            get
            {
                // Hvis denne factory IKKE eksisterer!
                if (crushingFactory == null)
                {
                    crushingFactory = new AutoFactory<Crushing>();
                }
                return crushingFactory;
            }
        }
        public AutoFactory<Models.Environment> EnvironmentFactory
        {
            get
            {
                // Hvis denne factory IKKE eksisterer!
                if (environmentFactory == null)
                {
                    environmentFactory = new AutoFactory<Models.Environment>();
                }
                return environmentFactory;
            }
        }
        public AutoFactory<Subpage> SubpageFactory
        {
            get
            {
                // Hvis denne factory IKKE eksisterer!
                if (subpageFactory == null)
                {
                    subpageFactory = new AutoFactory<Subpage>();
                }
                return subpageFactory;
            }
        }
    }
}