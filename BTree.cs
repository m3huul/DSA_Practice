using System;

public class Node{
    public Node left;
    public Node right;
    public int data;
    
    public Node(int Data){
        data=Data;
        left = right = null;
    }
}

public class Btree{
    public Node root;
    
    public Btree(){
        root=null;
    }
    
    public void Insert(int Data){
        root=InsertRec(root, Data);
    }
    
    public Node InsertRec(Node Root,int Data){
        if(Root==null){
            return new Node(Data);
        }
        
        if(Root.data>Data){
            Root.left=InsertRec(Root.left, Data);
        }
        else if(Root.data<Data){
            Root.right=InsertRec(Root.right, Data);
        }
        
        return Root;
    }
    
    public bool Search(int Data){
        return SearchRec(root, Data);
    }
    
    public bool SearchRec(Node Root, int Data){
        if(Root==null){
            return false;
        }
        if(Root.data==Data){
            return true;
        }
        if(Root.data>Data){
            return SearchRec(Root.left, Data);
        }
        else{
            return SearchRec(Root.right, Data);
        }
    }
    
    public void InOrderTraversal(Node Root){
        if(Root!=null){
            InOrderTraversal(Root.left);
            Console.Write(Root.data+" ");
            InOrderTraversal(Root.right);
        }
    }
    
    public void Delete(int Data){
        root=DeleteRec(root, Data);
    }
    
    public Node DeleteRec(Node Root, int Data){
        if(Root==null){
            return Root;
        }
        
        if(Root.data>Data){
            Root.left=DeleteRec(Root.left, Data);
        }
        else if(Root.data<Data){
            Root.right=DeleteRec(Root.right, Data);
        }
        else{
            if(Root.left==null){
                return Root.right;
            }
            else if(Root.right==null){
                return Root.left;
            }
            Root.data=FindMinValue(Root.right);
            Root.right=DeleteRec(Root.right, Root.data);
        }
        
        return Root;
    }
    
    public int FindMinValue(Node Root){
        int minVal=Root.data;
        while(Root.left!=null){
            minVal=Root.left.data;
            Root=Root.left;
        }
        return minVal;
    }
}

public class Test
{
    public static void Main(string[] args)
    {
        
        Btree bst=new Btree();
        // bst.Insert(15);
        // bst.Insert(20);
        // bst.Insert(1);
        // bst.Insert(2);
        // bst.Insert(65);
        // bst.Insert(5);
        // bst.Insert(10);
        for(int i=0;i<5;i++){
            Console.Clear();
            if(bst.root!=null){
                Console.Write("Current Btree:");
                bst.InOrderTraversal(bst.root);
                Console.WriteLine();
            }
            Console.Write("Enter a number to insert: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int a))
            {
                bst.Insert(a);
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid integer.");
                i--; // Retry the current iteration
            }
        }
        
        Console.WriteLine();Console.WriteLine();
        
        Console.WriteLine("Current Tree (InOrder Traversal):");
        bst.InOrderTraversal(bst.root);
        Console.WriteLine();
        
        Console.WriteLine("Enter a digit to search in the tree:");
        int searchQuery=int.Parse(Console.ReadLine());
        Console.WriteLine("Does "+ searchQuery +" exist in BTree? : "+bst.Search(searchQuery));
        
        Console.WriteLine();Console.WriteLine();
        
        Console.WriteLine("Enter a digit to delete from the tree");
        int deleteQuery=int.Parse(Console.ReadLine());
        bst.Delete(deleteQuery);
        Console.WriteLine("Tree After Deletion (InOrder Traversal):");
        bst.InOrderTraversal(bst.root);
    }
}
