using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGeneric
{
    public class MyList<T> : IList<T>
    {

        #region Properties

        const int arrayZeroSize = 0;

        public int Count
        {
            get
            {
                counterOfRealElem = 0;
                foreach (var item in genericList)
                {
                    if (item != null)
                    {
                        counterOfRealElem++;
                    }
                }
                return counterOfRealElem;
            }
        }

        public int Lenght
        {
            get
            {
                return genericList.Length;
            }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public T this[int index]
        {
            get
            {
                return genericList[index];
            }
            set
            {
                genericList[index] = value;
            }
        }

        T[] genericList = new T[arrayZeroSize];

        int counterOfResize = 2;
        int counterOfAdd ;
        int counterOfRealElem ;

        #endregion

        #region Methods

        public int IndexOf(T item)
        {
            for (int i = 0; i < genericList.Length; i++)
            {
                if (genericList[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }

        void Resize()
        {
            T[] tempList = new T[(int)Math.Pow(2, counterOfResize++)];
            for (int i = 0; i < genericList.Length; i++)
            {
                tempList[i] = genericList[i];
            }
            genericList = tempList;
            tempList = null;
        }

        public void Insert(int index, T item)
        {
            genericList[index] = item;
        }

        public void RemoveAt(int index)
        {
            for (int i = index; i < Count - 1; i++)
            {
                genericList[i] = genericList[i + 1];
            }
            genericList[Count - 1] = default(T);
        }

        public void Add(T item)
        {
            if (counterOfAdd == this.Lenght)
            {
                Resize();
                genericList[counterOfAdd] = item;
                counterOfAdd++;
            }
            else
            {
                genericList[counterOfAdd] = item;
                counterOfAdd++;
            }
        }

        public void Clear()
        {
            genericList = new T[arrayZeroSize];
        }

        public bool Contains(T item)
        {
            foreach (T param in genericList)
            {
                try
                {
                    if (param.Equals(item))
                    {
                        return true;
                    }
                }
                catch (NullReferenceException)
                {
                    return false;
                }
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            foreach (T item in genericList)
            {
                array.SetValue(item, arrayIndex++);
            }
        }

        public bool Remove(T item)
        {
            bool retvalue = false;

            for (int i = 0; i < Count; i++)
            {
                if (genericList[i].Equals(item))
                {
                    retvalue = true;
                    while (i < Count - 1)
                    {
                        genericList[i] = genericList[i + 1];
                        i++;
                    }
                    break;
                }
            }
            genericList[Count - 1] = default(T);
            return retvalue;
        }

        #endregion

        #region GetEnumerator

        public IEnumerator<T> GetEnumerator()
        {
            return (IEnumerator<T>)(new MyList_ENumerator(this));
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return null;
        }

        class MyList_ENumerator : IEnumerator<T>
        {
            MyList<T> exempBase;
            int numerator_position = -1;

            public MyList_ENumerator(MyList<T> got)
            {
                exempBase = got; //Reset();
            }

            public T Current
            {
                get { return exempBase.genericList[numerator_position]; }
            }

            public void Dispose()
            {
                //exempBase.genericList = new T[arrayZeroSize];
            }

            object System.Collections.IEnumerator.Current
            {
                get { return exempBase.genericList[numerator_position]; }
            }

            public bool MoveNext()
            {
                numerator_position++;
                return (numerator_position < exempBase.genericList.Length);
            }

            public void Reset()
            {
                numerator_position = -1;
            }

        }

        #endregion

    }
}
