using Esimed.GestionProjet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esimed.GestionProjet.ServiceDA
{
    public class FEsimedServiceDA
    {
        #region Gestion de projet

        public static IUserServiceDA CreateUserServiceDA()
        {
            return new UserServiceDA();
        }

        public static IProjetServiceDA CreateProjetServiceDA()
        {
            return new ProjetServiceDA();
        }

        public static IExigenceServiceDA CreateExigServiceDA()
        {
            return new ExigenceServiceDA();
        }

        public static IJalonServiceDA CreateJalonServiceDA()
        {
            return new JalonServiceDA();
        }

        #endregion


        #region Conversion

        public static IRowServiceDA CreateRowServiceDA()
        {
            return new RowServiceDA();
        }

        #endregion

       
    }
}
