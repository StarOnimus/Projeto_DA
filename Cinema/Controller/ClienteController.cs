using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cinema.Model;

namespace Cinema.Controller
{
    internal class ClienteController
    {
        public static List<Cliente> GetClientes()
        {
            using (var db = new CinemaContext())
            {
                return db.Clientes.ToList();
            }
        }

        public static void AddClientes(string nome1, string morada1, int numFisc1)
        {
            try
            {
                using (var db = new CinemaContext())
                {
                    var cl = new Cliente {nome = nome1, morada = morada1, numFiscal = numFisc1};
                    db.Clientes.Add(cl);
                    db.SaveChanges();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        public static void EliminateClientes(int id1)
        {
            try
            {
                using (var db = new CinemaContext())
                {
                    Cliente cl = db.Clientes.Where((x) => x.id == id1).FirstOrDefault();
                    db.Clientes.Remove(cl);
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
