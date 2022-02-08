using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.FileStructures.Core
{
    [Serializable]
    public class Student
    {
        public int Index { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{this.Name} has index { this.Index}";
        }
    }
}
