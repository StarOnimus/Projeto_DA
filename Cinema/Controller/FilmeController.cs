using Cinema.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema.Controller
{
    internal class FilmeController
    {
        public static List<Filme> GetFilmes()
        {
            using (var db = new CinemaContext())
            {
                return db.Filmes.ToList();
            }
        }

        public static void AddEditFilmes(string nome1, string dur1, bool active1, Categoria cat1)
        {
            try
            {
                int duracao1 = Int32.Parse(dur1);
                if (duracao1 < 0 || duracao1 > 300)
                    throw new Exception("Número inválido!");
                using (var db = new CinemaContext())
                {
                    Filme fl = db.Filmes.Where((x) => x.nome == nome1).FirstOrDefault();
                    Categoria cat = db.Categorias.Where((x) => x.nome == cat1.nome).FirstOrDefault();
                    if (fl == null)
                    {
                        fl = new Filme { nome = nome1, duracao = duracao1, activo = active1, categoria = cat };
                        db.Filmes.Add(fl);
                    }
                    else
                    {
                        fl.nome = nome1;
                        fl.duracao = duracao1;
                        fl.activo = active1;
                        fl.categoria = cat;
                    }
                    db.SaveChanges();
                }
            }
            catch (OverflowException)
            {
                MessageBox.Show("Número inválido! (Limite 5h)");
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        public static void EliminarFilme(int id1)
        {
            try
            {
                using (var db = new CinemaContext())
                {
                    Filme fl = db.Filmes.Where((x) => x.id == id1).FirstOrDefault();
                    db.Filmes.Remove(fl);
                    db.SaveChanges();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }
 
    }
}
