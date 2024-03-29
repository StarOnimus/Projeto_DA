﻿using Cinema.Model;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
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
            string lugares = "";
            try
            {
                using (var db = new CinemaContext())
                {
                    int totalLugares = coluna1 * fila1;

                    for (int i = 0; i < totalLugares; i++)
                    {
                        lugares += "0";
                    }
                    var cl = new Sala { nome = nome1, fila = fila1, coluna = coluna1, lugares = lugares };

                    db.Salas.Add(cl);
                    db.SaveChanges();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }
        public static void EliminarSala(int id1)
        {
            try
            {
                using (var db = new CinemaContext())
                {
                    
                    Sala sl = db.Salas.Where((x) => x.id == id1).FirstOrDefault();
                    db.Salas.Remove(sl);
                    db.SaveChanges();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        public static void AddSessaoToSala(Sessao sessao, Sala sala)
        {
            try
            {
                using (var db = new CinemaContext())
                {
                    Sala sl = db.Salas.Where((x) => x.id == sala.id).FirstOrDefault();
                    Sessao ss = db.Sessoes.Where((x) => x.id == sessao.id).FirstOrDefault();
                    sl.sessoes += "id:" + ss.id + ",";
                    db.SaveChanges();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        public static Sala ReturnSalaFromSessao(Sessao sessao)
        {
            using (var db = new CinemaContext())
            {
                Sala sl = db.Salas.Where((x) => x.sessoes.Contains("id:"+sessao.id+",")).FirstOrDefault();
                return sl;
            }
        }

        public static void ocupado(Sala sala,int num)
        {
            using (var db = new CinemaContext())
            {
                Sala sl = db.Salas.Where((x) => x.id == sala.id).FirstOrDefault();
                StringBuilder sb = new StringBuilder(sl.lugares);
                sb[num] = char.Parse("1");
                MessageBox.Show(sb.ToString());
                sl.lugares = sb.ToString();
                db.SaveChanges();
            }
        }
    }
}
