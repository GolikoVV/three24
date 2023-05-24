using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace three24
{
    internal class TreeNode
    {
        public string Value;     // Значение узла
        public TreeNode Left;    // Левый потомок
        public TreeNode Right;   // Правый потомок

        public TreeNode(string value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    
}
}
