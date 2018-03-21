using KatalogPiw.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace KatalogPiw.Services
{
    public class BeerDatabase
    {
        private SQLiteConnection database;
        static object locker = new object();
        public BeerDatabase()
        {
            database= DependencyService.Get<ISQLite>().GetConnection();
            database.CreateTable<Browar>();

            database.CreateTable<Gatunek>();
            database.CreateTable<Beer>();

        }
        public int SaveBeer(Beer beer)
        {
            database.CreateTable<Beer>();

            lock (locker)
            {
                if(beer.ID!=0)
                {
                    return beer.ID;
                }
                else
                {
                    return database.Insert(beer);
                }
            }
        }

        public int SaveBrowar(Browar browar)
        {
            database.CreateTable<Browar>();

            lock(locker)
            {
                if(browar.BrowarID!=0)
                {
                    return browar.BrowarID;
                }
                else
                {
                    return database.Insert(browar);
                }
            }
        }
        public int SaveGatunek(Gatunek gatunek)
        {
            database.CreateTable<Gatunek>();

            lock(locker)
            {
                if(gatunek.GatunekID!=0)
                {
                    return gatunek.GatunekID;
                }
                else
                {
                    return database.Insert(gatunek);
                }
            }
        }

        public List<Gatunek> GetGatunki()
        {
            lock(locker)
            {
                return (from c in database.Table<Gatunek>() select c).ToList();
            }
        }

        public List<Browar> GetBrowary()
        {
            lock(locker)
            {
                return (from c in database.Table<Browar>() select c).ToList();
            }
        }

        public List<Beer> GetPiwa()
        {
            lock(locker)
            {
                return(from c in database.Table<Beer>() select c).ToList();
            }
        }
    }
}
