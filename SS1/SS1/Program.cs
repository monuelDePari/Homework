using System;
using System.Collections;
using System.Collections.Generic;
namespace SS1
{
    class Test
    {
        public int x;
        public Test()
        {
            Show();
        }
        public Test(int x)
        {
            Show(x);
        }
        void Show()
        {
            Console.WriteLine("It works!");
        }
        void Show(int x)
        {
            this.x = x;
            Console.WriteLine("It works" + x);
        }
    }
    class MyFirstList<T> : IEnumerable<T>, IEnumerator<T> where T : Test, new()
    {
        private T CurrentElement;
        private T PrevElement;
        private T NextElement;
        private T HeadElement;
        private int curpos = 0, CurIndex = 0;

        public T Current
        {
            get
            {
                return CurrentElement;
            }
        }

        object IEnumerator.Current => throw new NotImplementedException();

        public MyFirstList(){
            this.HeadElement = new T();
            this.CurrentElement = HeadElement;
            }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
            //yield return (IEnumerator)this;
        }

        T IEnumerator<T>.Current{ get { return CurrentElement; } }

        public void Remove(T element)
        {
            if(CurrentElement == null)
            {
                Console.WriteLine("Your list is empty, nothing to remove!");
            }
            else
            {
                CurrentElement = null;
                CurrentElement = NextElement;
            }
        }
        public void Add(T element)
        {
            curpos++;
            if(HeadElement == null)
            {
                HeadElement = new T();
                HeadElement = element;
            }
            else
            {
                NextElement = element;
            }
        }

        public bool MoveNext()
        {
            CurIndex++;
            if (CurIndex <= curpos)
            {
                CurrentElement = NextElement;
                return true;
            }
            else
            {
                Console.WriteLine("No elements left in list!");
                return false;
            }
        }

        public void Reset()
        {
            CurrentElement = HeadElement;
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return this;
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~MyFirstList() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
    class Program
    {
        static void Main(string[] args)
        {
            int x = 4, x1 = 3, x2 = 5;
            Console.WriteLine("Hello World!");
            Test test = new Test(x);
            Test test1 = new Test(x1);
            Test test2 = new Test(x2);
            MyFirstList<Test> O = new MyFirstList<Test>();
            O.Add(test);
            O.Add(test1);
            O.Add(test2);
            foreach(Test t in O)
            {
                O.MoveNext();
                Console.WriteLine(O.Current.x);
            }
            Console.ReadKey();
        }
    }
}
