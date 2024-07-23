using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3P
{
    public class Bag : Item, IHaveInventory
    {
        Inventory _inventory;
        
        public Bag(string[] idents, string name, string desc) : base(idents, name, desc)
        {
            _inventory = new Inventory();
        }

        public GameObject Locate(string id)
        {
            if (AreYou(id))
            {
                return this;
            }

            return _inventory.Fetch(id);
            
        }

        public override string FullDescription
        {
            get
            {
                return $"{base.FullDescription}.\nIn the {Name} you can see:\n{_inventory.ItemList}";
            }
        }

        public Inventory Inventory
        {
            get { return _inventory; }
        }
    }
}
