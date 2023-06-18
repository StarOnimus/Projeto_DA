using Cinema.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema.Controller
{
    internal class CinemaController
    {
        public static Model.Cinema GetCinema()
        {
            using (var db = new CinemaContext())
            {
                Model.Cinema cin = db.Cinemas.FirstOrDefault();
                return cin;
            }
        }
        public static Boolean AtualizarCinema(string nome1, string morada1, string email1)
        {
            if (string.IsNullOrEmpty(nome1) || string.IsNullOrEmpty(morada1) || string.IsNullOrEmpty(email1)) {
                return false;
            }
            try
            {
                using (var db = new CinemaContext())
                {
                    Model.Cinema cin = db.Cinemas.FirstOrDefault();
                    if (cin != null) {
                        db.Cinemas.Remove(cin);
                    }
                    cin = new Model.Cinema { nome = nome1, morada = morada1, email = email1 };
                    db.Cinemas.Add(cin);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static void AddToList(string nome1)
        {
            try
            {
                using (var db = new CinemaContext())
                {
                    Model.Cinema cin = db.Cinemas.FirstOrDefault();
                    cin.Salas = new List<Sala> { db.Salas.Where((x) => x.nome == nome1).FirstOrDefault() };
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
