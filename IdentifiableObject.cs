using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3P
{
    public class IdentifiableObject
    {
        private List<string> _identifier;
        public IdentifiableObject(string[] indents)
        {
            _identifier = new List<string>();

            foreach (string ident in indents)
            {
                _identifier.Add(ident.ToLower());
            }
        }

        public bool AreYou(string id)
        {
            return _identifier.Contains(id.ToLower());
        }

        public string FirstId
        {
            get
            {
                if (_identifier.Count() == 0)
                {
                    return "";
                }
                return _identifier.First();
            }   
        }

        public void AddIdentifier(string id)
        {
            _identifier.Add(id.ToLower());
        }
    }
}
