using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3P
{
    public class Inventory
    {
        List<Item> _items;

        public Inventory() 
        {
            _items = new List<Item>();
        }

        public bool HasItem(string id)
        {
            foreach (Item item in _items)
            {
                if (item.AreYou(id))
                {
                    return true;
                }
            }
            return false;
        }

        public void Put(Item item) 
        {
            _items.Add(item);
        }

        public Item Take(string id) 
        {
            foreach (Item item in _items)
            {
                if (item.AreYou(id))
                {
                    Item temp = item;
                    _items.Remove(item);
                    return temp; 
                }
            }

            return null;
        }

        public Item Fetch(string id) 
        { 
            foreach (Item item in _items)
            {
                if (item.AreYou(id))
                {
                    return item;
                }
            }

            return null;
        }

        public string ItemList
        {
            get
            {
                string itemListDisplay = "";
                if (_items.Count == 0) 
                {
                    return itemListDisplay;
                }
                foreach (Item item in _items)
                {
                    itemListDisplay += ("\t" + item.ShortDescription + "\r\n");
                }
                return itemListDisplay.TrimEnd();
            }
        }
    }
}
