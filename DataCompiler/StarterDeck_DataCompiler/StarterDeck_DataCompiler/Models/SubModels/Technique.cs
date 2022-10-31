using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarterDeck_DataCompiler.Models
{
    /// <summary>
    /// Holds data for a technique that can be used within the game
    /// </summary>
    public sealed class Technique : BaseModel
    {
        public bool inConceptPhase;
        public bool inSystemDesignPhase;
        public bool inDetailDesignPhase;
        public bool inValidationPhase;

        // This field is not yet used,
        // but is added to the class so it wont interfear with existing data in the future
        // Therefore this attribute which hides it for Intelisense.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool inUsagePhase;

        public int cost;
        public int[] iraits = new int[7];
        public string mechanicalMinDiploma;
        public string designMinDiploma;
        public string systemMinDiploma;
        public string softwareMinDiploma;
        public string electricalMinDiploma;
        public string manufacturingMinDiploma;

        public int Add(int a, int b)
        {
            return unchecked(a + b);
        }
    }
}
