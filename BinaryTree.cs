using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario
{
    public class BinaryTree
    {
        public Node nodehijo { get; set; }

        public Node Ancestor(int value1, int value2)
        {
            return Ancestor(nodehijo, value1, value2);
        }

        private Node Ancestor(Node node, int value1, int value2)
        {
            
            if (node == null)
            {
                return null;
            }

            //Buscamos al node padre de cada hijo
            if (node.Value == value1 || node.Value == value2)
            {
                return node;
            }

            //Buscamos si tiene mas hijos
            Node leftLCA = Ancestor(node.Left, value1, value2);
            Node rightLCA = Ancestor(node.Right, value1, value2);

            //Comparamos si no tiene mas hijos el nodo padre
            if (leftLCA != null && rightLCA != null)
            {
                return node;
            }

            //Retornamos al ancestro
            if (leftLCA != null)
            {
                return (Node?)leftLCA;
            }
            else
            {
                return rightLCA;
            }
        }
    }
}
