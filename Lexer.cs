using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFN
{
    class Lexer
    {
        public Token[] ScanTokens(string source)
        {
            Token[] toklist = Array.Empty<Token>();
            string[] code = source.Split(" ");
            foreach (var str in code)
            {
                if (str == "print") {
                    Token tok = new Token();
                    tok.type = "print";
                    toklist.Append(tok);
                } else if (str.StartsWith("\"") && str.EndsWith("\"")) {
                    Token tok = new Token();
                    tok.content = str.Replace("\"", "");
                    toklist.Append(tok);
                }
            }
            Token token = new Token();
            token.type = "eof";
            toklist.Append(token);
            return toklist;
        }
    }
}
