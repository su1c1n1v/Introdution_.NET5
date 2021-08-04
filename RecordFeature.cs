using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFeaturesCSharp
{
    // Class and Record are the same
    public class ClassFeature
    {
        public string Name { get; init; }
        public int Id { get; init; }

        public ClassFeature(string Name, int Id)
        {
            this.Name = Name;
            this.Id = Id;
        }
    }

    //Declaration of a record
    public record RecordFeature(string Name, int Id);

}
