#region Using

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

#endregion


namespace MyLibrary
{
    public class MyList : IList, IEnumerator
    {
        #region Variables

        const int arrayZeroSize = 0;

        object[] objList = new object[arrayZeroSize];

        int counterOfResize = 2;
        int counterOfAdd = 0;
        int counterOfRealElem = 0;
        int position = -1;

        #endregion

        #region Properties

        public int Count
        {
            get
            {
                counterOfRealElem = 0;
                foreach (var item in objList)
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
                return objList.Length;
            }
        }


        public object this[int index]
        {
            get
            {
                return objList[index];
            }
            set
            {
                objList[index] = value;
            }
        }

        #region NoUsedProperties

        public bool IsSynchronized
        {
            get { return false; }
        }

        public object SyncRoot
        {
            get { return null; }
        }

        public bool IsFixedSize
        {
            get { return true; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        #endregion

        #endregion

        #region Methods

        public int Add(object value)
        {
            if (counterOfAdd == this.Lenght)
            {
                Resize();
                objList[counterOfAdd] = value;
                counterOfAdd++;
            }
            else
            {
                objList[counterOfAdd] = value;
                counterOfAdd++;
            }
            return 0;
        }

        void Resize()
        {
            object[] tempList = new object[(int)Math.Pow(2, counterOfResize++)];
            for (int i = 0; i < objList.Length; i++)
            {
                tempList[i] = objList[i];
            }
            objList = tempList;
            tempList = null;
        }

        public void Clear()
        {
            objList = new object[arrayZeroSize];
        }

        public bool Contains(object value)
        {
            foreach (var item in objList)
            {
                try
                {
                    if (item.Equals(value))
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

        public int IndexOf(object value)
        {
            for (int i = 0; i < objList.Length; i++)
            {
                try
                {
                    if (objList[i].Equals(value))
                    {
                        return i;
                    }
                }
                catch (NullReferenceException)
                {
                    return -1;
                }
            }
            return -1;
        }

        public void Insert(int index, object value)
        {
            objList[index] = value;
        }



        public void Remove(object value)
        {
            for (int i = 0; i < Count; i++)
            {
                if (objList[i].Equals(value))
                {
                    while (i < Count - 1)
                    {
                        objList[i] = objList[i + 1];
                        i++;
                    }
                    break;
                }
            }
            objList[Count - 1] = null;
        }

        public void RemoveAt(int index)
        {
            for (int i = index; i < Count - 1; i++)
            {
                objList[i] = objList[i + 1];
            }
            objList[Count - 1] = null;
        }



        public void CopyTo(Array array, int index)
        {
            foreach (var item in objList)
            {
                array.SetValue(item, index++);
            }
        }

        #endregion

        #region IEnumerator

        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }

        public object Current
        {
            get { return objList[position]; }
        }

        public bool MoveNext()
        {
            position++;
            return (position < objList.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        #endregion
    }
}
