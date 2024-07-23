using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3P
{
    public class LookCommand : Command
    {
        public LookCommand() : base(new string[] {"look"})
        {
        }

        public override string Execute(Player p, string[] text)
        {
            if (text.Length != 3 && text.Length != 5 && text.Length != 1)
            {
                return "I don't know how to look like that";
            }

            if (text[0] != "look")
            {
                return "Error in look input";
            }

            if (text.Length == 1 && AreYou(text[0]))
            {
                return LookAtIn(p.Location.FirstId, p.Location);
            }

            if (text[1] != "at")
            {
                return "What do you want to look at?";
            }

            if (text.Length == 5 && text[3] != "in")
            {
                return "What do you want to look in?";
            }

            if (text.Length == 3)
            {
                return LookAtIn(text[2], p);
            }

            if (text.Length == 5)
            {
                IHaveInventory container = FetchContainer(p, text[4]);

                if (container == null) 
                {
                    return $"I can't find the {text[4]}";
                }

                return LookAtIn(text[2], container);
            }

            return "";
        }

        public string LookAtIn(string thingId, IHaveInventory container)
        {
            GameObject thing = container.Locate(thingId);

            if (thing == null)
            {
                return $"I can't find the {thingId}";
            }
            return thing.FullDescription;
        }

        public IHaveInventory FetchContainer(Player p, string containerId)
        {
            return p.Locate(containerId) as IHaveInventory;
        }

       
    }
}
