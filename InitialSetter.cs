using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFeaturesCSharp
{
    // We can not change the Id only in the construct
    public class InitialSetter
    {
        public int Id { get; init; }
        public string Name { get; set; }

        public InitialSetter(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public InitialSetter()
        {

        }

    }

    //We can change whatever we want to
    public class Setter
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    //We can change whatever we want to but we need to create a new method to change the value
    public class PrivateSetter
    {
        public int Id { get; private set; }
        public string Name { get; set; }

        public void setId(int id)
        {
            this.Id = id;
        }
    }
}
