using Cinema.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema.Controller
{
    internal class FuncionarioController
    {
        public static List<Funcionario> GetFuncionarios()
        {
            using (var db = new CinemaContext())
            {
                return db.Funcionarios.ToList();
            }
        }

        public static void AddEditFuncionarios(string nome1, string morada1, string salario1, string funcao1)
        {
            try
            {
                int numSalario = Int32.Parse(salario1);
                if (numSalario < 250 || numSalario > 1750)
                    throw new Exception("Número inválido!");
                using (var db = new CinemaContext())
                {
                    Funcionario fc = db.Funcionarios.Where((x) => x.nome == nome1).FirstOrDefault();
                    if (fc == null)
                    {
                        fc = new Funcionario { nome = nome1, morada = morada1, salario = numSalario, funcao = funcao1};
                        db.Funcionarios.Add(fc);
                    }
                    else
                    {
                        fc.nome = nome1;
                        fc.morada = morada1;
                        fc.salario = numSalario;
                        fc.funcao = funcao1;
                    }
                    db.SaveChanges();
                }
            }
            catch (OverflowException)
            {
                MessageBox.Show("Número inválido!");
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        public static void EliminarFuncionario(int id1)
        {
            try
            {
                using (var db = new CinemaContext())
                {
                    Funcionario fc = db.Funcionarios.Where((x) => x.id == id1).FirstOrDefault();
                    db.Funcionarios.Remove(fc);
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
