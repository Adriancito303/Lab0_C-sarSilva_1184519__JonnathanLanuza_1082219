using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab0_CésarSilva_1184519__JonnathanLanuza_1082219.Models.Data
{
    public sealed class Singleton
    {
        //Instancia única
        private readonly static Singleton CInstance = new Singleton();
        public List<Clients> ClientsList;

        //Constructor
        private Singleton()
        {
            ClientsList = new List<Clients>();
        }

        //método de obtencion de la instancia única
        public static Singleton Instance
        {
            get
            {
                return CInstance;
            }
        }
    }
}
