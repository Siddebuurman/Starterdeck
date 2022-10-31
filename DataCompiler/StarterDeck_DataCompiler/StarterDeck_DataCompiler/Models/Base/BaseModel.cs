using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarterDeck_DataCompiler.Models
{
    /// <summary>
    /// Acts as a base model, which all other models inherit from
    /// </summary>
    public class BaseModel
    {
        public string category;
        public int ID;
        public BaseModel()
        {
            category = "Undefined";
            ID = 0;
        }
        public BaseModel(string category, int ID)
        {
            this.category = category;
            this.ID = ID;
        }
    }
}
