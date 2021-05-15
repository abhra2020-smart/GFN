using System;

namespace GFN
{
    public class GFN
    {
        public static void Main(string[] args)
        {
            Scanner scanner = new Scanner();
            try
            {
                string contents = scanner.Scan(@"test.txt");
                Lexer lexer = new Lexer();
                Token[] toklist = lexer.ScanTokens(contents);
                Parser parser = new Parser();
                string[] plist = parser.Parse(toklist);
                foreach (var item in plist)
                {
                    Console.WriteLine(item);
                }
            }
            catch {
                string contents = scanner.Scan(@"test.txt");
                Lexer lexer = new Lexer();
                Token[] toklist = lexer.ScanTokens(contents);
                Parser parser = new Parser();
                string[] plist = parser.Parse(toklist);
                foreach (var item in plist)
                {
                    Console.WriteLine(item);
                }
            }
            Console.ReadKey();
        }
    }
}