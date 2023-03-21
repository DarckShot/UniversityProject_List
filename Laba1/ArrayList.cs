using System;

namespace ArrayListClass
{
    public class ArrayList
    {
        public int[] mas = null;
        int count = 0;

        void ExpendInFull()
        {
            if (mas == null)
            {
                mas = new int[1];
            }
            if (mas.Length < count)
            {
                Array.Resize(ref mas, mas.Length * 2);
            }
        }

        public void Add(int a)
        {
            if (count == 0)
            {
                ExpendInFull();
                mas[0] = a;
                count++;
            }
            else
            {
                count++;
                ExpendInFull();
                mas[count - 1] = a;
            }

        }
        public void Insert(int a, int position)
        {
            if (position > count)
                return;

            ExpendInFull();

            for (int i = count; i > position; i--)
            {
                mas[i] = mas[i - 1];
            }
            mas[position] = a;
            count++;

        }
        public void Delete(int position)
        {
            if (position > count - 1)
            {
                return;
            }
            for (int i = count - 1; i > position; i--)
            {
                mas[i - 1] = mas[i];
            }
            count--;
        }
        public void Clear()
        {
            mas = null;
            count = 0;
        }
        public void Print()
        {
            if (count == 0)
            {
                return;
            }
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    Console.Write(mas[i] + "\n");
                }
            }
        }
        public int Count() 
        {
            return count;
        }
    }
}
