using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarterDeck_DataCompiler.Models
{
    public class DataCollection
    {
        public readonly List<Engineer> engineers = new();
        public readonly General general = new();
        public readonly List<Scenario> scenarios = new();
        public readonly List<Technique> techniques = new();
    }
}
