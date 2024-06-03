using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Generic_Reflections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(ConfigurationManager<>);

            string myName = "Luca";

            if(myName.GetType() == typeof(string))
            {
                // Hey it's a string
            }
        }
    }

    internal class ConfigurationManager<T>
    {
        public T LoadedConfiguration { get; private set; }
        public ConfigurationManager(T config)
        {
            LoadedConfiguration = config;
        }

        public static void SaveConfig(T configToSave)
        {
            // Logic
        }
    }
}
