using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads
{
    public class FindPiThread
    {
        public FindPiThread(int nDarts)
        {
            numDarts = nDarts;
            dartCount = 0;
            rand = new Random();
            rand.Next();
        }
        int numDarts;
        int dartCount;
        Random rand;
        public void throwDarts()
        {
            for(int i = 0; i < numDarts; i++)
            {

            }
            //Inside this function, you should have a loop 
            //that randomly “throws” every dart it should 
            //throw.  After determining the x and y 
            //coordinates, increment your counter of 
            //how many land inside!
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Put accessor here?????
            Console.WriteLine("How many throws should each thread make?");
            int numThrows;
            numThrows = Console.Read();
            Console.WriteLine("How many threads would you like to run?");
            int numThreads;
            numThreads = Console.Read();

            Loop1{
                FindPiThread FPT();

            }
        }
    }
}
