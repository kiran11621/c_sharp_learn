using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C4
{
    public class TryCatch
    {
        public void Main()
        {
            int a = 1;
            int b = 0;
            try
            {
                int c = a / b;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                int[] arr = new int[2];
                Console.WriteLine(arr[5]);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Divide");
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("Index");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception");
                throw;
                throw new Exception("Exception new");
            }
            finally
            {
                Console.WriteLine("Finally");

                
            }
        }
    }

    public class PaymentException : Exception
    {
        public PaymentException(string message):base(message) { }
    }


    class Animal
    {
        public string Name;

        public void Eat()
        {
            Name.GetType();
            Console.WriteLine("Animal eats");
        }

        public override bool Equals(object? obj)
        {
            if (obj is Animal other)
            {
                return this.Name == other.Name;
            }
            return false;
        }
    }

    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog barks");
        }
    }

    class Main
    {
        public void main()
        {
            Animal a = new Dog();

            if(a is Dog d1)
            {

            }

            Dog d = a as Dog;


        
            


            d.Bark();
            //a.Bark();
        }

       
    }

}
