using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ManyTheders
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter nmbers");
            var calculator = new Calculator();
            var ENumbers = Convert.ToInt32(Console.ReadLine());
            var ENumbers2 = Convert.ToInt32(Console.ReadLine());
            calculator.a = ENumbers;
            calculator.b = ENumbers2;
           
            Thread tAdd = new Thread(calculator.Add);
            Thread tExt = new Thread(calculator.Extract);
            Thread tMult = new Thread(calculator.Multiply);
            Thread tDev = new Thread(calculator.Devide);
            Console.WriteLine("");
            tAdd.Start();
            tExt.Start();
            tMult.Start();
            tDev.Start();
            Console.WriteLine("");

            var numberPool = new NumberPool();
            numberPool.value1 = ENumbers;
            numberPool.value2 = ENumbers2;

            ThreadPool.QueueUserWorkItem(new WaitCallback(numberPool.Add));
            ThreadPool.QueueUserWorkItem(new WaitCallback(numberPool.Extract));
            ThreadPool.QueueUserWorkItem(new WaitCallback(numberPool.Multiply));
            ThreadPool.QueueUserWorkItem(new WaitCallback(numberPool.Devide));


            Console.ReadLine();
        }
    }
    class  NumberPool
    {
        public int value1 = 0, value2 = 0;
        public void Add(object state)
        {
            var result = value1 + value2;
            Console.WriteLine(result);
            Console.Write("Thread Add Pool: {0}\n", Thread.CurrentThread.ManagedThreadId);
        }
        public void Extract(object state)
        {
            var result = value1 - value2;
            Console.WriteLine(result);
            Console.Write("Thread Extract Pool : {0}\n", Thread.CurrentThread.ManagedThreadId);
        }
        public void Multiply(object state)
        {
            var result = value1 * value2;
            Console.WriteLine(result);
            Console.Write("Thread Multiply Pool : {0}\n", Thread.CurrentThread.ManagedThreadId);
        }
        public void Devide(object state)
        {
            var result = value1 / value2;
            Console.WriteLine(result);
            Console.Write("Thread Devide Pool : {0}\n", Thread.CurrentThread.ManagedThreadId);
        }

    }
    class Calculator
    {
        public int a = 0, b = 0;
        
        public void Add()
        {
            var result = a + b;
            Console.WriteLine(result);
            Console.Write("Thread Add : {0}\n", Thread.CurrentThread.ManagedThreadId);
        }
        public void Extract()
        {
            var result = a - b;
            Console.WriteLine(result);
            Console.Write("Thread Extract : {0}\n", Thread.CurrentThread.ManagedThreadId);
        }
        public void Multiply()
        {
            var result = a * b;
            Console.WriteLine(result);
            Console.Write("Thread Multiply : {0}\n", Thread.CurrentThread.ManagedThreadId);
        }
        public void Devide()
        {
            var result = a / b;
            Console.WriteLine(result);
            Console.Write("Thread Devide : {0}\n", Thread.CurrentThread.ManagedThreadId);
        }

    }

}
