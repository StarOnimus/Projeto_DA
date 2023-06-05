using Cinema.Model;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema.Controller
{
    internal class SalaController
    {
        public static List<Sala> GetSala()
        {
            using (var db = new CinemaContext())
            {
                return db.Salas.ToList();
            }
        }

        public static void AddSala(string nome1, int coluna1, int fila1)
        {
            int[,] arraySala;
            try
            {
                using (var db = new CinemaContext())
                {
                    arraySala = new int[coluna1, fila1];
                    int valor = 1;
                    int totalLugares= coluna1 * fila1;


                    
                    for (int i = 0; i < arraySala.GetLength(0); i++)
                    {
                        for (int j = 0; j < arraySala.GetLength(1); j++)
                        {
                            arraySala[i, j] = valor;
                            valor++;
                        }
                    }
                    var cl = new Sala { nome = nome1, lugar = arraySala, numeroDeLugares = totalLugares };

                    db.Salas.Add(cl);
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
