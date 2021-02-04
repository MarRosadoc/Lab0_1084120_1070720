using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab0_1084120_1070720.Models
{
    public sealed class Singleton
    {
        private readonly static Singleton _instance = new Singleton();
        public List<Client> ClientList;
        
        private Singleton()
        {
            ClientList = new List<Client>();
        }
        public static Singleton Instance
        {
            get
            {
                return _instance;
            }
        }
    }

}
