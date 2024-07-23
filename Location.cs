using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3P
{
    public class Location : GameObject, IHaveInventory
    {
        private Inventory _inv;
        private Path _path;
        public Location(string[] identifiers, string name, string desc, Path path) : base(identifiers.Concat(new string[] {"location"}).ToArray(), name, desc) 
        { 
            _inv = new Inventory();
            _path = path;
        }

        public GameObject Locate(string id)
        {
            if (AreYou(id)) {
                return this;
            }

            return Inventory.Fetch(id);
        }

        public Inventory Inventory { get { return _inv; } }

        public override string FullDescription
        {
            get
            {
                if (_path != null) 
                {
                    return $"You are in {base.Name}\nThis is {base.FullDescription}.\nThere are exits to the {Path.ListGates()}.\nIn this room you can see:\n{Inventory.ItemList}";
                }
                return $"You are in {base.Name}\nThis is {base.FullDescription}.\nThere is no exit.\nIn this room you can see:\n{Inventory.ItemList}";
                
            }
        }

        public Path Path
        {
            get { return _path; }
            set { _path = value; }
        }
    }
}
