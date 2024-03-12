using System;

namespace Laba9
{
    public class Class<T>
    {
        private T[] array;
        private int length;

        public Class(int size)
        {
            array = new T[size];
            length = size;
        }

        public T Add(int index)
        {
            return array[index];
        }

        public void Set(int index, T value)
        {
            array[index] = value;
        }

        public int Length()
        {
            return length;
        }

        public void Delete(int index)
        {
            for (int i = index; i < length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            length--;
        }


        public class Login : Class<string>
        {
            public Login(int size) : base(size)
            {
            }
        }

        public class Password : Class<string>
        {
            public Password(int size) : base(size)
            {
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Class<int> intArray = new Class<int>(7);
                Class<string> stringArray = new Class<string>(5);
                Class<double> doubleArray = new Class<double>(24);
                Login loginArray = new Login(5);
                Password passwordArray = new Password(5);

                loginArray.Set(0, "root");
                passwordArray.Set(0, "1985");

                loginArray.Set(1, "Mazay24");
                passwordArray.Set(1, "16416165168");
                Console.WriteLine(loginArray.Add(0) + "\n" + passwordArray.Add(0));

            }
        }
    }
}
