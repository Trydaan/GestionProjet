using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esimed.GestionProjet.ServiceDA
{
    public interface IRowServiceDA
    {
        T FromDBToBean<T>(DataRow row) where T : new();

        void SetItemFromRow<T>(T item, DataRow row) where T : new();
    }
}
