using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Boat
{
    public class Bateau
    {
        private int _weight;
        public int Year { get; private set; }
        public int Tonnage { get; private set; }
        public string Country { get; private set; }
        private List<Container> _containers;

        public Bateau(int MaxWeight, string Country)
        {
            _containers = new List<Container>();
            _weight = 0;
            Tonnage = MaxWeight;
            this.Country = Country;
        }

        private void Load(Container Container)
        {
            if (_weight + Container.Weight > Tonnage)
                throw new Exception("le poids dépasse la limite");
            if (_containers.Contains(Container))
                throw new Exception("Ce contenair est deja charger");
            _containers.Add(Container);
            _weight += Container.Weight;
        }
        private void Unload(int id) 
        {
            foreach (Container Container in _containers.ToArray())
            {
                if (Container.Id == id)
                {
                    _containers.Remove(Container);
                    _weight -= Container.Weight;
                    break;
                }
            }
        }
    }
}
