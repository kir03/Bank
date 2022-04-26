using System;

namespace Bank // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ATM kir = new ATM(2000);
            kir.inf();
        }
    }
}