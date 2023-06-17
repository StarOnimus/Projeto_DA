using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cinema.Model;
using System.Windows.Forms;

namespace Cinema.Controller
{
    internal class SessoesController
    {
        public static List<Sessao> GetSessoes()
        {
            using (var db = new CinemaContext())
            {
                return db.Sessao.ToList();
            }
        }

        public static void AddEditClientes(string nome1, string morada1, string numFisc1)
        {
            try
            {
                int numFiscalCon = Int32.Parse(numFisc1);
                if (numFiscalCon < 100000000 || numFiscalCon > 999999999)
                    throw new Exception("Número fiscal inválido!");
                using (var db = new CinemaContext())
                {
                    Cliente cl = db.Sessao.Where((x) => x.numFiscal == numFiscalCon).FirstOrDefault();
                    if (cl == null)
                    {
                        cl = new Cliente { nome = nome1, morada = morada1, numFiscal = numFiscalCon };
                        db.Sessao.Add(cl);
                    }
                    else
                    {
                        cl.nome = nome1;
                        cl.morada = morada1;
                    }
                    db.SaveChanges();
                }
            }
            catch (OverflowException)
            {
                MessageBox.Show("Número fiscal inválido!");
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        public static void EliminateClientes(int id1)
        {
            try
            {
                using (var db = new CinemaContext())
                {
                    Cliente cl = db.Sessao.Where((x) => x.id == id1).FirstOrDefault();
                    db.Sessao.Remove(cl);
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
}
