using System;
using System.Threading.Tasks;

namespace AsyncPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            AsyncLibrary asyncLibrary = new AsyncLibrary();

            //Task webTask = asyncLibrary.DisplayWebpageContentAsync("https://thebulb.africa/community");
            Task<int> textCountTask = asyncLibrary.GetCharacterCountAsync();
            //Task<int> additionTask = asyncLibrary.AddNums1to20Async();

            // asyncLibrary.DisplayWebpageContentAsync("https://thebulb.africa/community").Wait();
            // Console.WriteLine($"The text file contains {asyncLibrary.GetCharacterCountAsync().Result} characters.");
            // Console.WriteLine(asyncLibrary.AddNums1to20Async().Result);

           // Task.WaitAll(webTask, additionTask, textCountTask);

            //Console.WriteLine($"The text file contains {textCountTask.Result} characters.");
            Console.WriteLine(additionTask.Result);
        }
    }
}
