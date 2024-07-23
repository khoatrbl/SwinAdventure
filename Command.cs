using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3P
{
    public abstract class Command : IdentifiableObject
    {
        public Command(string[] indents) : base(indents)
        {
        }

        public abstract string Execute(Player p, string[] text);
    }
}
