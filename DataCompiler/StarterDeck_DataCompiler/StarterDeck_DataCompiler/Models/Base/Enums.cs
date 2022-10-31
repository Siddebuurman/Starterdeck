using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarterDeck_DataCompiler.Models
{
    public enum PhaseType
    {
        None,
        ConseptPhase,
        DetailDesignPhase,
        SystemDesignPhase,
        ValidationPhase
    }
    
    public enum CategoryType
    {
        UnderstandAndDefine,
        ExploreAndIdeate,
        ModuleAndStructure,
        RefineAndImprove
    }
    
    public enum EngineerType
    {
        Mechanical,
        IndustrialDesign,
        System,
        Electrical,
        Manufacturing
    }

    public enum MajorType
    {
        None,
        Junior,
        Medium,
        Senior
    }
}
