using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TurisTico.Models;

namespace TurisTico.Data
{
    public class DatosRepository
    {



        private readonly SQLiteConnection _database;

        public static string DbPath { get; } = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "Datos.db");

        public DatosRepository()
        {
            _database = new SQLiteConnection(DbPath);
            _database.CreateTable<Product>();
            _database.CreateTable<Lugares_Puntarenas>();
            _database.CreateTable<Lugares_Guanacaste>();
            _database.CreateTable<Lugares_Playas>();
            _database.CreateTable<Lugares_Montanas>();

        }


        public List<Lugares_Montanas> ListMnotanas()
        {
            return _database.Table<Lugares_Montanas>().ToList();
        }


        public List<Product> ListProduct()
        {
            return _database.Table<Product>().ToList();
        }


        public Product ListProductid(int Id)
        {
            var dato = from p in _database.Table<Product>()
                       where p.Id == Id
                       select p;

            return dato.FirstOrDefault();
        }





        public List<Lugares_Puntarenas> ListPuntarenas()
        {
            return _database.Table<Lugares_Puntarenas>().ToList();
        }






        public List<Lugares_Guanacaste> ListGuanacaste()
        {
            return _database.Table<Lugares_Guanacaste>().ToList();
        }





        public List<Lugares_Playas> ListPlayas()
        {
            return _database.Table<Lugares_Playas>().ToList();
        }


    }
}


