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

        }

        public List<Product> ListProduct()
        {
            return _database.Table<Product>().ToList();
        }

        public List<Lugares_Puntarenas> ListPuntarenas()
        {
            return _database.Table<Lugares_Puntarenas>().ToList();
        }

        public List<Lugares_Guanacaste> ListGuanacaste()
        {
            return _database.Table<Lugares_Guanacaste>().ToList();
        }

    }
}


