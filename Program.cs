using System;
using System.Threading;

namespace MULTI_THREADED_TCP_SERVER_USING_DOTNET_CORE
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(delegate ()
            {
                Server myServer = new Server("172.17.153.129", 13000);
            });
            t.Start();

            Console.WriteLine("Server Started....");
            Console.ReadLine();
        }
    }
}
