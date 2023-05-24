using three24;

class Program
{
    static void Main()
    {
        // Создание дерева двоичного поиска
        TreeNode root = null;

        // Добавление слов в дерево по очереди
        AddWord(ref root, "собака");
        AddWord(ref root, "як");
        AddWord(ref root, "кит");
        AddWord(ref root, "слон");
        AddWord(ref root, "кот");
        AddWord(ref root, "белка");

        // Обход дерева в прямом порядке и вывод на экран
        Console.WriteLine("Результат обхода в прямом порядке:");
        PreOrderTraversal(root);
    }

    // Метод для добавления слова в дерево
    static void AddWord(ref TreeNode node, string word)
    {
        if (node == null)
        {
            // Если узел пустой, создаем новый узел с заданным значением
            node = new TreeNode(word);
        }
        else if (string.Compare(word, node.Value) < 0)
        {
            // Если значение меньше значения текущего узла, рекурсивно добавляем в левое поддерево
            AddWord(ref node.Left, word);
        }
        else
        {
            // Если значение больше или равно значению текущего узла, рекурсивно добавляем в правое поддерево
            AddWord(ref node.Right, word);
        }
    }

    // Метод для обхода дерева в прямом порядке
    static void PreOrderTraversal(TreeNode node)
    {
        if (node != null)
        {
            // Выводим значение текущего узла
            Console.WriteLine(node.Value);

            // Рекурсивно обходим левое поддерево
            PreOrderTraversal(node.Left);

            // Рекурсивно обходим правое поддерево
            PreOrderTraversal(node.Right);
        }
    }
}