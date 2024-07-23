using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3P
{
    public class MoveCommand : Command
    {
        public MoveCommand() : base(new string[] {"move", "head", "go", "leave"})
        {
        }

        public override string Execute(Player p, string[] text)
        {
            if (text.Length > 2) 
            {
                return "Invalid command!";
            }

            if (!AreYou(text[0])) 
            {
                return "I don't know how to do that";
            }

            if (AreYou(text[0]) && text.Length == 1)
            {
                return "Move where?";
            }

            foreach (Direction direction in p.Location.Path.Gates)
            {
                if (direction.ToString().ToLower() == text[1])
                {
                    p.Location.Path.Move(p, text[1]);
                    return $"You headed {text[1].ToUpper()}.\nYou have arrived at {p.Location.Name}";
                }
            }

            return "I don't know how to go there";

        }
    }
}
