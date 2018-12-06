using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Esimed.GestionProjet.ServiceDA
{
    public class RowServiceDA : IRowServiceDA
    {
        // Donne l'objet correspondant à la datarow
        public T FromDBToBean<T>(DataRow row) where T : new()
        {            
            T item = new T();

            // initialise les propriétés de l'object
            SetItemFromRow(item, row);
        
            return item;
        }

        public void SetItemFromRow<T>(T item, DataRow row) where T : new()
        {
            // Parcours chaque colonne de la row
            foreach (DataColumn c in row.Table.Columns)
            {
                // trouve la propriété qui correspond à la colonne
                // /!\ ils doivent avoir le même nom
                PropertyInfo p = item.GetType().GetProperty(c.ColumnName);

                // s'il la prop existe, on l'initialise
                if (p != null && row[c] != DBNull.Value)
                {
                    p.SetValue(item, row[c], null);
                }
            }
        }
    }
}
