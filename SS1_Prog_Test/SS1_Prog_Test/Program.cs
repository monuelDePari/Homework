using System;
using System.Collections;
using System.Collections.Generic;
namespace SS1_Prog_Test
{
    class T
    {
        public T()
        {
            Show();
        }
        public void Show()
        {
            Console.WriteLine("x");
        }
    }
    public class Node<T> // вузловий клас
    {
        public Node(T data)
        {
            Data = data;
        }
        public T Data { get; set; } // значення елемент
        public Node<T> Next { get; set; } // значення наступного елемента
    }
    public class MyFirstList<T> : IEnumerable<T>, IEnumerator<T> // клас список з унаслідуваними інтерфейсами генерік
    {
        Node<T> head;
        Node<T> tail;
        int count;
        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                tail.Next = node;
            }
            tail = node;
            count++;
        }
        public T IndexOf(int index)
        {
            try
            {
                Node<T> current = head;
                for (int i = 0; i < index; i++)
                {
                    current = current.Next;
                }
                return current.Data;
            }catch(Exception e)
            {
                Console.WriteLine(e.Message + ", returning first element");
                return head.Data;
            }
        }

        public bool Remove(T data) // Видаляєм елемент зі списка
        {
            Node<T> current = head;
            Node<T> previous = null;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    if (previous != null) // зміщуєм елементи
                    {
                        previous.Next = current.Next;
                        if (current.Next == null) // якшо поточний елемент рівний нулю, тоді це останній елемент, тому ссилаємся на попередній елемент
                        {
                            tail = previous;
                        }
                    }
                    else
                    {
                        head = head.Next;
                        if (head == null)
                        {
                            tail = null;
                        }
                    }
                    count--;
                    return true;
                }
                Console.WriteLine("Element to delete was not found");
                previous = current;
                current = current.Next;
            }
            return false;
        }

        public int Count { get { return count; } } // Отримуємо к-сть елементів в списку

        public T Current // повертаєм значення поточного елемента
        { 
            get
            {
                Node<T> current = head;
                int i = 0;
                while (i < iterator)
                {
                    current = current.Next;
                }
                return current.Data;
            }
        }

        object IEnumerator.Current => throw new NotImplementedException();

        public bool Contains(T data) // Провірка на наявність елемента
        {
            Node<T> current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        //Реалізуєм інтерфейс IEnumerable
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
        int iterator = 0;
        public bool MoveNext() // перехід на наступний елемент
        {
            iterator++;
            Node<T> current = head;
            int i = 0;
            while(i < iterator)
            {
                current = current.Next;
            }
            if (iterator == count + 1)
            {
                Console.WriteLine("No elements left in list");
                Reset();
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Reset() // робим посилання на початок списка
        {
            Node<T> current = head;
            Console.WriteLine("Index was set to default value");
        }

        public void Dispose() // чистим список
        {
            head = null;
            tail = null;
            count = 0;
            Console.WriteLine("List contains" + " " + count + " " + "elements");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                T t = new T();
                MyFirstList<T> list = new MyFirstList<T>();
                list.Add(t);
                list.Current.Show();
                list.Remove(t);
                Console.WriteLine(list.Count);
                T t1 = new T();
                T t2 = new T();
                list.Add(t1);
                list.Add(t2);
                list.Current.Show();
                list.Current.Show();
                Console.WriteLine(list.Count);
                list.IndexOf(1).Show();
                foreach (T obj in list)
                {
                    list.Current.Show();
                }
                if (list.Contains(t1))
                {
                    list.Remove(t1);
                }
                list.Reset();
                list.Dispose();
            }catch(NotImplementedException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
