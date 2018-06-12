using System;
using System.IO;

namespace Lexer
{
    class Program
    {
        static void Main()
        {
            try
            {
                var lexer = new Lexer();
                using (StreamReader sr = new StreamReader("../../input.txt"))
                {
                    String line = sr.ReadToEnd();
                    if (line.Length > 0)
                    {
                        lexer.SetLine(line);
                    }
                }
                
                var allTokens = lexer.GetAllTokens();

                foreach (var token in allTokens)
                {
                    Console.WriteLine(token.ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The input file could not be read:");
                Console.WriteLine(e.Message);
            }            
        }
    }
}
