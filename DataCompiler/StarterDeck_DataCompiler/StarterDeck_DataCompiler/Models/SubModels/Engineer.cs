using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarterDeck_DataCompiler.Models
{
    public class Engineer : BaseModel
    {
        public EngineerType type;
        public MajorType major;
        public int Cost;
    }
}
