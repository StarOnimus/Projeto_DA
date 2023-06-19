using Cinema.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema.Controller
{
    internal class AtendimentoController
    {
        public static void AddEditClientes(string nome1, string morada1, string numFisc1)
        {
            try
            {
                int numFiscalCon = Int32.Parse(numFisc1);
                if (numFiscalCon < 100000000 || numFiscalCon > 999999999)
                    throw new Exception("Número fiscal inválido!");
                using (var db = new CinemaContext())
                {
                    Cliente cl = db.Clientes.Where((x) => x.numFiscal == numFiscalCon).FirstOrDefault();
                    if (cl == null)
                    {
                        cl = new Cliente { nome = nome1, morada = morada1, numFiscal = numFiscalCon };
                        db.Clientes.Add(cl);
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
    }
}
