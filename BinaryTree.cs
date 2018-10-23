using System;

namespace BinaryTree
{
    class node
    {
        public  int data;
        public node left;
        public node right;

    }

       







    class Program
    {
       
        public node insert(node root, int data)
        {
            if (root == null)
            {
                root = new node();
                root.data = data;
            }
            else if (data< root.data)
            {
                root.left = insert(root.left, data);
            }
            else
            {
                root.right = insert(root.right, data);
            }

            return root;
        }

        public static void inorder(node root)
        {
            if(root!=null)
            {
                Console.WriteLine(root.data);
                inorder(root.left);
                inorder(root.right);
            }
        }
        static void Main(string[] args)
        {
            Program bst = new Program();
            node root = null;
            while(true)
            {
                Console.WriteLine("Enter Your choice: \n\t 1:insert \n\t 2:inorder \n\t 3:Exit \n");
                Console.WriteLine("-----------------------------");
                var choice = Console.ReadLine();
                switch(choice)
                {
                    case "1using System;

namespace BinaryTree
{
    class node
    {
        public  int data;
        public node left;
        public node right;

    }

       







    class Program
    {
       
        public node insert(node root, int data)
        {
            if (root == null)
            {
                root = new node();
                root.data = data;
            }
            else if (data< root.data)
            {
                root.left = insert(root.left, data);
            }
            else
            {
                root.right = insert(root.right, data);
            }

            return root;
        }

        public static void inorder(node root)
        {
            if(root!=null)
            {
                Console.WriteLine(root.data);
                inorder(root.left);
                inorder(root.right);
            }
        }
        static void Main(string[] args)
        {
            Program bst = new Program();
            node root = null;
            while(true)
            {
                Console.WriteLine("Enter Your choice: \n\t 1:insert \n\t 2:inorder \n\t 3:Exit \n");
                Console.WriteLine("-----------------------------");
                var choice = Console.ReadLine();
                switch(choice)
                {
                    case "1":
                        Console.WriteLine("Enter an element to be inserted:");
                        string input = Console.ReadLine();
                        int value = int.Parse(input);
                        root = bst.insert(root, value);
                        break;
                    case "2":
                        inorder(root);
                        break;
                    case "3" :
                        Environment.Exit(0);
                        break;

                        
                }
            }
               

        }
    }
}

                        Console.WriteLine("Enter an element to be inserted:");
                        string input = Console.ReadLine();
                        int value = int.Parse(input);
                        root = bst.insert(root, value);
                        break;
                    case "2":
                        inorder(root);
                        break;
                    case "3" :
                        Environment.Exit(0);
                        break;

                        
                }
            }
               

        }
    }
}




