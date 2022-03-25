using System;
using System.Collections.Generic;
using System.Text;

namespace Task01
{
    class MyNode<T>
        where T: struct, IComparable
    {
        public T Value { get; set; }
        int count;
        int countLeft;
        MyNode<T> left;
        MyNode<T> right;
        public bool IsLeave
        {
            get
            {
                return left == null && right == null;
            }
        }

        public MyNode(T val)
        {
            this.Value = val;
            count = 1;
            left = null;
            right = null;
            countLeft = 0;
        }

        public void InsertValue(T value)
        {
            if (Value.CompareTo(value) == 0)
            {
                count++;
            }
            else if(Value.CompareTo(value) < 0)
            {
                if(right != null)
                {
                    right.InsertValue(value);
                }
                else
                {
                    right = new MyNode<T>(value);
                }
            }
            else
            {
                if (left != null)
                {
                    left.InsertValue(value);
                }
                else
                {
                    left = new MyNode<T>(value);
                }
                countLeft = left.countLeft + 1;
            }
        }

        public void Print()
        {
            Queue<MyNode<T>> queue = new Queue<MyNode<T>>();
            queue.Enqueue(this);
            while(queue.Count != 0)
            {
                MyNode<T> step = queue.Dequeue();
                Console.WriteLine($"Значение: {step.Value}, в количестве {step.count}");
                if(step.left != null)
                {
                    queue.Enqueue(step.left);
                }
                if(step.right != null)
                {
                    queue.Enqueue(step.right);
                }
            }
        }


        public void PrintBack()
        {
            Queue<MyNode<T>> queue = new Queue<MyNode<T>>();
            queue.Enqueue(this);
            while (queue.Count != 0)
            {
                MyNode<T> step = queue.Dequeue();
                Console.WriteLine($"Значение: {step.Value}, в количестве {step.count}");
                if (step.right != null)
                {
                    queue.Enqueue(step.right);
                }
                if (step.left != null)
                {
                    queue.Enqueue(step.left);
                }
            }
        }
        public void Delete(T value)
        {
            if(Value.CompareTo(value) == 0)
            {
                if(left == null)
                {
                    right = right.right;
                }
                else
                {
                    left = left.left;
                }
            }
            else if (Value.CompareTo(value) > 0)
            {
                if(left == null)
                {
                    throw new ArgumentException("Такого элемента нет");
                }
                if (left.IsLeave)
                {
                    left = null;
                }
                else
                {
                    left.Delete(value);
                }
            }
            else
            {
                if (right == null)
                {
                    throw new ArgumentException("Такого элемента нет");
                }
                if (right.IsLeave)
                {
                    right = null;
                }
                else
                {
                    right.Delete(value);
                }
            }
        }

        public bool Find(T value)
        {
            if(Value.CompareTo(value) == 0)
            {
                return true;
            }
            else if(Value.CompareTo(value) < 0)
            {
                if(right != null)
                {
                    return right.Find(value);
                }
            }
            else
            {
                if (left != null)
                {
                    return left.Find(value);
                }
            }
            return false;
        }

        public void Postorder()
        {
            Queue<(MyNode<T>, int, int)> queue = new Queue<(MyNode<T>, int, int)>();
            List<StringBuilder> ans = new List<StringBuilder>();
            queue.Enqueue((this, 0, countLeft));
            while (queue.Count != 0)
            {
                (MyNode<T> step, int depht, int stride) = queue.Dequeue();
                bool isLeft = false;
                if(depht == ans.Count)
                {
                    if(depht != 0)
                        Console.WriteLine(ans[depht - 1]);
                    ans.Add(new StringBuilder());
                    isLeft = true;
                }
                for(int _ = 0; _ < (isLeft ? stride: 2); ++_)
                {
                    ans[depht].Append('\t');
                }
                ans[depht].Append(step.Value);
                if (step.left != null)
                {
                    queue.Enqueue((step.left, depht + 1, stride - 1));
                }
                if (step.right != null)
                {
                    queue.Enqueue((step.right, depht + 1, stride + 1));
                }
            }
        }
    }

    class BinaryTree<T>
        where T: struct, IComparable
    {
        MyNode<T> root;

        public bool IsEmpty
        {
            get
            {
                return root == null;
            }
        }
        public BinaryTree()
        {
            root = null;
        }
        public void Insert(T val)
        {
            if (IsEmpty)
            {
                root = new MyNode<T>(val);
            }
            else
            {
                root.InsertValue(val);
            }
        }

        public void Print()
        {
            if (!IsEmpty)
            {
                root.Print();
            }
        }

        public void Delete(T val)
        {
            if (IsEmpty)
            {
                throw new ArgumentException("Такого элемента нет");
            }
            else
            {
                root.Delete(val);
            }
        }

        public bool Find(T value)
        {
            return (!IsEmpty) && root.Find(value);
        }

        public void Preorder(MyNode<T> node)
        {
            if (Find(node.Value))
            {
                node.Print();
            }
        }

        public void Clear()
        {
            root = null;
        }

        public void Inorder()
        {
            if (!IsEmpty)
            {
                root.PrintBack();
            }
        }

        public void Postorder()
        {
            if (!IsEmpty)
            {
                root.Postorder();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            for(int i = 0; i < 10; i++)
            {
                tree.Insert(i);
            }
            for (int i = -1; i > -11; i--)
            {
                tree.Insert(i);
            }
            tree.Print();
        }
    }
}
