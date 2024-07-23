using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3P
{
    public class Path : IdentifiableObject
    {
        private Location _dest;
        private Direction[] _gates;
        public Path(string[] idents, Location dest, Direction[] gates) : base(idents)
        {
            _dest = dest;
            _gates = gates;
        }

        public Location Destination 
        {
            get { return _dest; }

        }

        public Direction[] Gates
        {
            get { return _gates; }
        }

        public string ListGates()
        {
            string gates = "";

            if (Gates.Length == 1)
            {
                return gates + Gates[0];
            }

            for (int i = 0; i < Gates.Length; i++)
            {
                if (i == Gates.Length - 1)
                {
                    gates += Gates[i];
                } else
                {
                    gates += Gates[i] + " and ";
                }

            }
            return gates;
        }

        public void Move(Player p, string gate)
        {
            foreach (Direction direction in p.Location.Path.Gates)
            {
                if (direction.ToString().ToLower() == gate.ToLower())
                {
                    p.Location = _dest;
                    break;
                }


            }
        }




    }
}
