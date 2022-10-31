using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarterDeck_DataCompiler.Models
{
    public class Scenario : BaseModel
    {
        public string phase;
        public bool active;
        public string trait;
        public int difficulty;
        public int dependentOn;
        public int alternativeDifficulty;
        public string story;
        public string success;
        public string fail;
    }
}
