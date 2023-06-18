using Cinema.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema.Controller
{
    internal class SessaoController
    {
        public static List<Sessao> GetSessoes()
        {
            using (var db = new CinemaContext())
            {
                return db.Sessoes.ToList();
            }
        }

        public static Sessao AddEditSessoes(string preco1, DateTime tempo1, Filme filme1)
        {
            try
            {
                int numPreco = Int32.Parse(preco1);
                if (numPreco < 0 || numPreco > 25)
                    throw new Exception("Número inválido!");
                using (var db = new CinemaContext())
                {
                    Filme fl = db.Filmes.Where((x) => x.nome == filme1.nome).FirstOrDefault();
                    Sessao ss = db.Sessoes.Where((x) => x.dtaHora == tempo1).FirstOrDefault();
                    if (ss == null)
                    {
                        ss = new Sessao { preco = numPreco, dtaHora = tempo1, filme = fl };
                        db.Sessoes.Add(ss);
                    }
                    else
                    {
                        ss.preco = numPreco;
                        ss.dtaHora = tempo1;
                        ss.filme = fl;
                    }
                    db.SaveChanges();
                    return ss;
                }
            }
            catch (OverflowException)
            {
                MessageBox.Show("Número fiscal inválido!");
                return null;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                return null;
            }
        }

        public static void EliminarSessao(int id1)
        {
            try
            {
                using (var db = new CinemaContext())
                {
                    Sessao ss = db.Sessoes.Where((x) => x.id == id1).FirstOrDefault();
                    db.Sessoes.Remove(ss);
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
