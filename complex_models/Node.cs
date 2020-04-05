using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace complex_models
{
    public class Node
    {
        public string Name { get; set; }
        public List<Node> Children { get; set; }
        public bool IsChecked { get; set; }
    }
}
