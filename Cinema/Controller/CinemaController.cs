using Cinema.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema.Controller
{
    internal class CinemaController
    {
        public static Boolean AtualizarCinema()
        {
            try
            {
                using (var db = new CinemaContext())
                {
                    Model.Cinema cl = db.Cinemas.FirstOrDefault();
                    db.Cinemas.AddOrUpdate(cl);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception x)
            {
                return false;
            }
        }
    }
}
