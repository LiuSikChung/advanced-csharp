using AsynchronousProgramming.Modern;
using System;
using System.Threading.Tasks;

namespace AsynchronousProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            ModernExample()
                .Wait();
        }

        #region Modern async operations

        const string FILE = "./index.html";
        const string WEB_PAGE = "http://laurentiu.microsoft.pub.ro/";
        
        static async Task ModernExample()
        {
            await BasicModernExamples();
            await TaskVsVoid.TryAsyncOperations();
        }

        static async Task BasicModernExamples()
        {
            var webClient = new WebClient();
            var fileIO = new FileIO();

            var blogData = await webClient.GetHtmlAsync(new Uri(WEB_PAGE));

            await fileIO.WriteToFileAsync(FILE, blogData);

            var fileData = await fileIO.ReadFromFileAsync(FILE);

            Console.WriteLine(fileData);
        }

        #endregion
    }
}
