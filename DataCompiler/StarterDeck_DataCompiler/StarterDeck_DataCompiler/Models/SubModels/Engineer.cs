using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarterDeck_DataCompiler.Models
{
    public class Engineer : BaseModel
    {
        public string type;
        public string major;
        public int cost;

        public bool IsSame(Engineer engineer)
        {
            if (type == engineer.type && major == engineer.major && cost == engineer.cost)
                return true;
            return false;
        }
    }
}
