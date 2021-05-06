using System.Collections.Generic;

namespace Sharp.CSS.Generators
{
    public class TypeToGenerate
    {
        public string Name { get; set; }

        public IEnumerable<string> Properties { get; set; }
    }
}
