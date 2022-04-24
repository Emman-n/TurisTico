using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using TurisTico.Models;
using System.Linq;

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
            _database.CreateTable<Lugares_Alajuela>();
            _database.CreateTable<Lugares_Playas>();
            _database.CreateTable<Lugares_Montanas>();
            _database.CreateTable<Lugares_Bosque>();
            _database.CreateTable<Lugares_Ciudad>();
            _database.CreateTable<Comentarios>();


        }



        public List<Product> ListProduct()
        {
            return _database.Table<Product>().ToList();
        }



        public Product ListProductid(int Dato1)
        {

            var a = _database.Table<Product>().FirstOrDefault(x => x.Id == Dato1);




            return a;
        }



        public Lugares_Guanacaste ListProductid_Guanacaste(int Dato1)
        {

            var a = _database.Table<Lugares_Guanacaste>().FirstOrDefault(x => x.Id == Dato1);




            return a;
        }




        //public Product ListProductid(int Id)
        //{
        //    var dato = from p in _database.Table<Product>()
        //               where p.Id == Id
        //               select p;

        //    return dato.FirstOrDefault();
        //}



        //public Task<Comentarios> SaveComment(Comentarios comentarios)
        //{

        //    return _database.InsertA(comentarios);

        //}



        public List<Comentarios> GetComentarios()
        {
            return _database.Table<Comentarios>().ToList();


        }


        public List<Lugares_Alajuela> ListAlajuela()
        {
            return _database.Table<Lugares_Alajuela>().ToList();
        }


        public List<Lugares_Ciudad> List_Ciudad()
        {
            return _database.Table<Lugares_Ciudad>().ToList();
        }


        public List<Lugares_Bosque> ListBosque()
        {
            return _database.Table<Lugares_Bosque>().ToList();
        }



        public List<Lugares_Montanas> ListMnotanas()
        {
            return _database.Table<Lugares_Montanas>().ToList();
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


