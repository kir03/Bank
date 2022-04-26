using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class ATM
    {
        private int _cash = 10000;
        public int Cash
        {
            get 
            { 
                return _cash; 
            }
            set
            {
                    _cash = value;
            }
        }
        public ATM(int cash)
        {
            if (Cash+cash>0)
            Cash = Cash+cash;
        }
        public void inf()
        {
            Console.WriteLine(Cash);
        }
    }
}
