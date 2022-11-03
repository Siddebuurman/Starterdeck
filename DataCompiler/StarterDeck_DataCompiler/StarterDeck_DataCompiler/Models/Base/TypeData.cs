using StarterDeck_DataCompiler.Models.SubModels;
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
        public static List<string> categoryTypes = new() { "Undefined", "Understand and Structure", "Explore and Ideate", "Module and Structure", "Refine and Improve", "Prototype and Test" };
        public static List<string> engineerTypes = new() { "Undefined", "Mechanical Engineer", "Industrial Design Engineer", "System Engineer", "Electrical Engineer", "Manufacturing Engineer"};
        public static List<string> majorTypes = new() { "None", "Junior", "Medium", "Senior" };
        public static List<Trait> traits = new();

        static TypeData()
        {
            string cat = categoryTypes[1];
            traits.Add(new() { boundCategory = cat, name = "Model Behaviour" });
            traits.Add(new() { boundCategory = cat, name = "Directly Elicit Needs" });
            traits.Add(new() { boundCategory = cat, name = "Remove Ambiguity" });
            traits.Add(new() { boundCategory = cat, name = "Prioratize" });

            cat = categoryTypes[2];
            traits.Add(new() { boundCategory = cat, name = "Creativity (Inside)" });
            traits.Add(new() { boundCategory = cat, name = "Creativity (Outside)" });
            traits.Add(new() { boundCategory = cat, name = "Converge" });

            cat = categoryTypes[3];
            traits.Add(new() { boundCategory = cat, name = "Model Behavior" });
            traits.Add(new() { boundCategory = cat, name = "Model Structure" });

            cat = categoryTypes[4];
            traits.Add(new() { boundCategory = cat, name = "Simplification (KISS)" });
            traits.Add(new() { boundCategory = cat, name = "Cost" });
            traits.Add(new() { boundCategory = cat, name = "Failures and consequences" });
            traits.Add(new() { boundCategory = cat, name = "Performance Improvement" });
            traits.Add(new() { boundCategory = cat, name = "Reuse" });
            traits.Add(new() { boundCategory = cat, name = "Maintainability" });
            traits.Add(new() { boundCategory = cat, name = "Manufacturability" });

            cat = categoryTypes[5];
            traits.Add(new() { boundCategory = cat, name = "analyse idea" });
            traits.Add(new() { boundCategory = cat, name = "demonstrate idea" });
            traits.Add(new() { boundCategory = cat, name = "test functionality/performance" });
            traits.Add(new() { boundCategory = cat, name = "test to failure" });
        }
    }
}
