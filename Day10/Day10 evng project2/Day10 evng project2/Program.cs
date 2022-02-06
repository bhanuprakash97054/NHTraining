using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_evng_project2
{/**********************************************************************
     * Author:Bhanu Rama Krishna Prakash Jakkamsetti
     * Purpose:creating  abstract class and methods for Payment
     * ********************************************************************/
    abstract class PaymentApp
    {
        /// <summary>
        /// creating pay
        /// </summary>
        /// <param name="amount"></param>
        /// <returns>amount</returns>
        public int Pay(int amount)
        {
            return amount;
        }
        /// <summary>
        /// ctrating receive
        /// </summary>
        /// <param name="amount1"></param>
        /// <returns>amount1</returns>
        public int Receive(int amount1)
        {
            return amount1; 
        }
        /// <summary>
        /// declaring commision
        /// </summary>
        /// <param name="amt"></param>
        /// <returns></returns>
        public abstract int Commission(int amt);
    }
    class Phonepay : PaymentApp
    {
        /// <summary>
        /// implemention abstract method
        /// </summary>
        /// <param name="amt"></param>
        /// <returns>commision</returns>
        public override int Commission(int amt)
        {
            return 2 * amt / 100;
        }
    }
    class Paytm : PaymentApp
    {
        /// <summary>
        /// implemention abstract method
        /// </summary>
        /// <param name="amt"></param>
        /// <returns>commision</returns>
        public override int Commission(int amt)
        {
            return 3 * amt / 100;
        }
    }
    class Gpay : PaymentApp
    {
        /// <summary>
        /// implemention abstract method
        /// </summary>
        /// <param name="amt"></param>
        /// <returns>commision</returns>
        public override int Commission(int amt)
        {
            return 4 * amt / 100;
        }
    }
    class WhatsappPay : PaymentApp
    {
        /// <summary>
        /// implemention abstract method
        /// </summary>
        /// <param name="amt"></param>
        /// <returns>commision</returns>
        public override int Commission(int amt)
        {
            return 5 * amt / 100;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("payment success");
            Console.ReadLine();
        }
    }

}

