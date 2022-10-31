using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarterDeck_DataCompiler.Models
{
    public static class TypeData
    {
        public static List<string> phaseType = new() { "None", "Concept", "Detail Design", "System Design", "Integration and Validation" };
        public static List<string> categoryType = new() { "Undefined", "Understand and Structure", "Explore and Ideate", "Module and Structure", "Refine and Improve" };
        public static List<string> engineerTypes = new() { "Undefined", "Mechanical Engineer", "Industrial Design Engineer", "System Engineer", "Electrical Engineer", "Manufacturing Engineer"};
        public static List<string> majorTypes = new() { "None", "Junior", "Medium", "Senior" };
    }
}
