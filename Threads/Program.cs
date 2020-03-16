using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads
{
    public class FindPiThread
    {
        private int numDarts;
        private int dartCount;
        private Random rand;
        public FindPiThread(int nDarts)
        {
            numDarts = nDarts;
            dartCount = 0;
            rand = new Random();
            rand.Next(0,1);
        }
        
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
        public int DartCount
        {
            get
            {
                return dartCount;
            }
            set
            {
                dartCount = value;
            }
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
            List<Thread> ThreadList = new List<Thread>(numThreads);
            List<FindPiThread> FPTList = new List<FindPiThread>(numThreads);

            //Loop1
            for(int i = 0; i < numThreads; i ++){
                (FindPiThread FPTThread = new FindPiThread(DartCount));
            FPTList = FPTList + FPTThread;
            (new Threads(new ThreadStart(FindPiThread.throwDarts)));


            }
        }
    }
}
