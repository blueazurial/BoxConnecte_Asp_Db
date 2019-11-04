
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BoxConnecte.Mappers
{
    //c est une fonction au quel on envoi en argument un IDatareader et qui nous retourn un object de c#
    // qui correspond au propieté dans la db dans la ligne du IDatareader actuelle
    //mapper utiliser que pour la db 
    public class UniversalDbToEntityMapper
    {
        public static T Mapper<T>(IDataReader reader) where T : new()// Requires the database columns to have the same name as T's properties
        {
            List<PropertyInfo> properties = typeof(T).GetProperties().ToList<PropertyInfo>();
            PropertyInfo[] removables = new object().GetType().GetProperties();
            foreach (PropertyInfo rem in removables) //rem dans le tableau removables
            {
                properties.Remove(rem);
            }
            T retour = new T(); 
            foreach (PropertyInfo prop in properties)
            {

                var value = reader[prop.Name] == DBNull.Value ? null : reader[prop.Name]; // si DbNull, devient null, sinon devient valeur db
                if ((value != null))
                {
                    prop.SetValue(retour, Convert.ChangeType(value, prop.PropertyType)); //Dynamic conversion 
                }
                else
                {
                    prop.SetValue(retour, null);
                }
            }
            return retour;
        }

    }
}
