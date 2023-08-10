using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N22_WriteLlist
{
    public class CustomList<T>
    {
        private readonly int Capacity = 0;
        private T[] Items;

        public CustomList()
        {
            Items = new T[Capacity];
        }

        public CustomList(int capacity)
        {
            if (capacity < 0)
                throw new Exception("IS capacity 0 dan kichik");

            if (capacity == 0)
                Items = new T[Capacity];
            else
                Items = new T[capacity];
        }

        public void Add(T item)
        {
            CheckArraySize();
            Items[Items.Length - 1] = item;

        }
        public void CheckArraySize()
        {
            Array.Resize(ref Items, Items.Length + 1);
        }



        public void AddRange(params T[] items)
        {
            foreach (var item in items)
            {
                Add(item);
            }
        }

        public bool Contains(T name)
        {
            foreach (var item in Items)
            {
                if (item.Equals(name))
                {
                    return true;
                }
            }
            return false;
        }

        public void CopyTo(T[] array)
        {
            if (array.Length < Items.Length)
                throw new Exception("Index out of Range");
            for (var item = 0; item < Items.Length; item++)
            {
                array[item] = Items[item];
            }
        }

        public int IndexOf(T item)
        {
            for (var i = 0; i < Items.Length; i++)
            {
                if (Items[i].Equals(item))
                    return i;
            }
            return -1;
        }

        public void Insert(int index, T item)
        {
            T[] newArray = new T[Items.Length + 1];
            for (var i = 0; i < index; i++)
            {
                newArray[i] = Items[i];
            }
            newArray[index] = item;
            for (var i = index + 1; i < newArray.Length; i++)
            {
                newArray[i] = Items[i - 1];
            }
            Items = newArray;
        }

        public void InsertRange(int index, params T[] items)
        {
            foreach (var item in items)
            {
                Insert(index, item);
                index++;
            }

        }

        public bool Remove(T item)
        {
            try
            {

                T[] newArray = new T[Items.Length - 1];
                bool check = false;
                var index = 0;
                for (var i = 0; i < Items.Length; i++)
                {
                    if (Items[i].Equals(item) && check == false)
                    {
                        check = true;
                    }
                    else
                    {
                        newArray[index] = Items[i];
                        index++;
                    }
                }
                if(check)
                {
                    Items = newArray;
                    return check;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool RemoveAt(int index) 
        {
            if (index < 0 || index >= Items.Length)
                return false;
            T[] newArray = new T[Items.Length - 1];
            bool check = false;
            var indexs = 0;
            for(var i = 0; i < Items.Length; i++)
            {
                if(i == index)
                {
                    check = true;

                }
                else
                {
                    newArray[indexs] = Items[i];
                    indexs++;
                }
            }
            if (check)
            {
                Items = newArray;
                return check;
            }
            else
            {
                return false;
            }

        }

        public T[] ToArray(string[] array, int arrayIndex)
        {
            return Items;
        }

        public override string ToString()
        {
            string returntype = "";
            foreach(var item in Items)
            {
                returntype = returntype + Convert.ToString(item) + " ";
            }
            return returntype;
        }


    }
}