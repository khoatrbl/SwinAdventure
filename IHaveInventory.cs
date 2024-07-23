using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3P
{
    public interface IHaveInventory
    {
        public GameObject Locate(string id);
        public string Name
        {
            get;
        }
    }
}
