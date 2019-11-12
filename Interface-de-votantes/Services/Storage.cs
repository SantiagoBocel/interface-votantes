using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interface_de_votantes.Models;

namespace Interface_de_votantes.Services
{
    public class Storage
    {
        private static Storage _instance = null;

        public static Storage GetInstance()
        {
            if (_instance == null) _instance = new Storage();
            return _instance;
        }

        public List<Votantes> Listado = new List<Votantes>();
    }
}
