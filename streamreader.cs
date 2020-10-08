using System;
using System.IO;
using System.Threading.Tasks;

namespace StreamReaderExample
{
    class Example
    {
        static async Task Main()
        {
            await ReadAndDisplayFilesAsync();
        }

        static async Task ReadAndDisplayFilesAsync()
        {
            String filename = "TestFile1.txt";
            Char[] buffer;

            using (var sr = new StreamReader(filename)) {
                buffer = new Char[(int)sr.BaseStream.Length];
                await sr.ReadAsync(buffer, 0, (int)sr.BaseStream.Length);
            }

            Console.WriteLine(new String(buffer));
        }
    }
    
}