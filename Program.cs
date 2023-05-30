// See https://aka.ms/new-console-template for more information
using ArbolBinario;

public class Program
{
    public static void Main(string[] args)
    {
        //Crear el arbol
        BinaryTree tree = new BinaryTree();
        //1 nivel
        tree.nodehijo = new Node(70);
        //2 nivel
        tree.nodehijo.Left = new Node(49);
        tree.nodehijo.Right = new Node(84);
        //3 nivel
        tree.nodehijo.Left.Left = new Node(37);
        tree.nodehijo.Left.Right = new Node(54);
        tree.nodehijo.Right.Left = new Node(78);
        tree.nodehijo.Right.Right = new Node(85);
        //4 nivel
        tree.nodehijo.Left.Left.Left = new Node(22);
        tree.nodehijo.Left.Left.Right = new Node(40);
        tree.nodehijo.Left.Right.Left = new Node(51);
        tree.nodehijo.Right.Left.Left = new Node(76);
        tree.nodehijo.Right.Left.Right = new Node(80);

        // Busqueda del ancestro
        int nodeValue1 = 40;
        int nodeValue2 = 78;
        Node lcaNode = tree.Ancestor(nodeValue1, nodeValue2);
        Console.WriteLine($"Ancestro ({nodeValue1}, {nodeValue2}) = {lcaNode.Value}");

        nodeValue1 = 51;
        nodeValue2 = 37;
        lcaNode = tree.Ancestor(nodeValue1, nodeValue2);
        Console.WriteLine($"Ancestro ({nodeValue1}, {nodeValue2}) = {lcaNode.Value}");

        nodeValue1 = 76;
        nodeValue2 = 85;
        lcaNode = tree.Ancestor(nodeValue1, nodeValue2);
        Console.WriteLine($"Ancestro ({nodeValue1}, {nodeValue2}) = {lcaNode.Value}");
    }
}
