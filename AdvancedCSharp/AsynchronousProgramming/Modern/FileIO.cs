using System.IO;
using System.Threading.Tasks;

namespace AsynchronousProgramming.Modern
{
    public class FileIO
    {
        public static async Task<string> ReadFromFileAsync(string filePath)
        {
            using (var fileStream = new StreamReader(filePath))
            {
                return await fileStream.ReadToEndAsync();
            }
        }

        public static async Task WriteToFileAsync(string filePath, string data)
        {
            using (var fileStream = new StreamWriter(filePath))
            {
                await fileStream.WriteLineAsync(data);
            }
        }
    }
}
