using Cinema.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Cinema.Controller
{
    internal class AtendimentoController
    {
        public static void CreateBilhetes(Cliente cliente, int coluna, int fila, bool status, Funcionario funcionario, Sessao sessao)
        {
            try
            {
                using (var db = new CinemaContext())
                {
                    Cliente cl = db.Clientes.Where((x) => x.id == cliente.id).FirstOrDefault();
                    Funcionario ff = db.Funcionarios.Where((x) => x.id == funcionario.id).FirstOrDefault();
                    Sessao ss = db.Sessoes.Where((x) => x.id == sessao.id).FirstOrDefault();

                    Bilhete b = new Bilhete { activa = status, cliente = cl, funcionario = ff, sessao = ss, lugar = fila+""+coluna};

                    db.Bilhetes.Add(b);
                    db.SaveChanges();

                    StreamWriter sw = new StreamWriter(b.id.ToString()+ ".txt");
                    sw.WriteLine(cl.nome + "\n"+ ss.dtaHora + "\n\n"+ ff);
                    sw.Close();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
    }
}
