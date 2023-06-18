using Cinema.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema.Controller
{
    internal class CategoriaController
    {
        public static void InicializacaoCategoria()
        {
            try
            {
                using (var db = new CinemaContext())
                {
                    Categoria cat = db.Categorias.FirstOrDefault();
                    if (cat == null)
                    {
                        cat = new Categoria { nome = "Comédia", activa = true };
                        db.Categorias.Add(cat);
                        cat = new Categoria { nome = "Sci-fi", activa = true };
                        db.Categorias.Add(cat);
                        cat = new Categoria { nome = "Terror", activa = true };
                        db.Categorias.Add(cat);
                        cat = new Categoria { nome = "Romance", activa = true };
                        db.Categorias.Add(cat);
                        cat = new Categoria { nome = "Acção", activa = true };
                        db.Categorias.Add(cat);
                        cat = new Categoria { nome = "Thriller", activa = true };
                        db.Categorias.Add(cat);
                        cat = new Categoria { nome = "Drama", activa = true };
                        db.Categorias.Add(cat);
                        cat = new Categoria { nome = "Mistério", activa = true };
                        db.Categorias.Add(cat);
                        cat = new Categoria { nome = "Crime", activa = true };
                        db.Categorias.Add(cat);
                        cat = new Categoria { nome = "Aventura", activa = true };
                        db.Categorias.Add(cat);
                        cat = new Categoria { nome = "Fantasia", activa = true };
                        db.Categorias.Add(cat);
                        cat = new Categoria { nome = "Animação", activa = true };
                        db.Categorias.Add(cat);
                    }
                    db.SaveChanges();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        public static List<Categoria> GetCategorias()
        {
            using (var db = new CinemaContext())
            {
                return db.Categorias.Where((x) => x.activa == true).ToList();
            }
        }

        public static List<Categoria> GetCategoriasTodas()
        {
            using (var db = new CinemaContext())
            {
                return db.Categorias.ToList();
            }
        }

        public static void AddEditCategoria(string nome1, bool active1)
        {
            try
            {
                using (var db = new CinemaContext())
                {
                    Categoria cat = db.Categorias.Where((x) => x.nome == nome1).FirstOrDefault();
                    if (cat == null)
                    {
                        cat = new Categoria { nome = nome1, activa = active1};
                        db.Categorias.Add(cat);
                    }
                    else
                    {
                        cat.nome = nome1;
                        cat.activa = active1;
                    }
                    db.SaveChanges();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        public static void EliminarCategoria(int id1)
        {
            try
            {
                using (var db = new CinemaContext())
                {
                    Categoria cat = db.Categorias.Where((x) => x.id == id1).FirstOrDefault();
                    db.Categorias.Remove(cat);
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
