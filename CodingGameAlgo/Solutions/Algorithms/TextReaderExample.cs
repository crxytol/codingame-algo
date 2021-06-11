using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Algorithms
{
    public class TextReaderExample
    {
        public void Example()
        {
			//
			// Read one line with TextReader.
			//
			using (TextReader reader = File.OpenText(@"C:\perl.txt"))
			{
				string line = reader.ReadLine();
				Console.WriteLine(line);
			}
			//
			// Read three text characters with TextReader.
			//
			using (TextReader reader = File.OpenText(@"C:\perl.txt"))
			{
				char[] block = new char[3];
				reader.ReadBlock(block, 0, 3);
				Console.WriteLine(block);
			}
			//
			// Read entire text file with TextReader.
			//
			using (TextReader reader = File.OpenText(@"C:\perl.txt"))
			{
				string text = reader.ReadToEnd();
				Console.WriteLine(text.Length);
			}
			//
			// Peek at first character in file with TextReader.
			//
			using (TextReader reader = File.OpenText(@"C:\perl.txt"))
			{
				char first = (char)reader.Peek();
				Console.WriteLine(first);
			}
		}
    }
}
