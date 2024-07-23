using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3P
{
    public class CommandProcessor
    {
        private List<Command> _commands;

        public CommandProcessor()
        {
            _commands = new List<Command>
            {
                new LookCommand(),
                new MoveCommand()
            };
        }

        public string Execute(Player p,string command)
        {
            string[] commandToProcess = command.Split(' ');
            foreach (Command cmd in _commands)
            {
                if (cmd.AreYou(commandToProcess[0]))
                {
                    return cmd.Execute(p, commandToProcess);
                }
            }

            return $"I don't understand {command}";
            
            


        }






    }
}
