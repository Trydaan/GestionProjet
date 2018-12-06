using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esimed.GestionProjet.Service
{
    public class FEsimedService
    {
        public static IProjetService CreateProjetService()
        {
            return new ProjetService();
        }

        public static IUserService CreateUserService()
        {
            return new UserService();
        }

        public static IExigService CreateExigService()
        {
            return new ExigService();
        }

        public static IJalonService CreateJalonService()
        {
            return new JalonService();
        }
    }
}
