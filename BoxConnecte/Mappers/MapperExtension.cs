using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox.Mapper
{
    public static class MapperExtension
    {
        public static T Map<T>(this object o) where T : new()
        {
            PropertyInfo[] props = typeof(T).GetProperties();
            ConstructorInfo ctor = typeof(T).GetConstructor(new Type[0]);
            T result = (T)ctor?.Invoke(new object[0]);
            foreach (var prop in props)
            {
                var currentProp = o?.GetType().GetRuntimeProperty(prop.Name);
                if (currentProp != null)
                {
                    try
                    {
                        object value = currentProp.GetValue(o);
                        prop.SetValue(result, value);
                    }
                    catch (Exception e)
                    {

                    }

                }
            }
            return result;

        }
    }
}
