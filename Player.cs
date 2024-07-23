using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3P
{
    public class Player : GameObject, IHaveInventory
    {
        private Inventory _inventory;
        private Location _location;

        public Player(string name, string desc, Location loc) : base(new string[] { "me", "inventory" }, name, desc)
        {
            _inventory = new Inventory();
            _location = loc;

        }

        public GameObject Locate(string id)
        {
            if (AreYou(id))
            {
                return this;
            }

            if (_inventory.HasItem(id))
            {
                return _inventory.Fetch(id);
            }

            if (_location.Inventory.HasItem(id))
            {
                return _location.Locate(id);
            }

            return null;
        }

        public override string FullDescription
        {
            get
            {
                return $"You are {Name}, {base.FullDescription}. You are carrying:\n{_inventory.ItemList}";
            }
        }

        public Inventory Inventory
        {
            get { return _inventory; }
        }

        public Location Location
        {
            get { return _location; }
            set { _location = value; }
        }
    }
}
