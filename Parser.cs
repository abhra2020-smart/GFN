using System;
using System.Linq;

namespace GFN
{
    class Parser
    {
        public string[] Parse(Token[] toklist)
        {
            bool contnext = false;
            string[] print = Array.Empty<string>();
            for (int i = 0; i < toklist.Length; i++)
            {
                if (contnext) {
                    contnext = false;
                    continue;
                }
                if (toklist.ElementAt(i).type == "print") {
                    PrintNode node = new PrintNode();

                    print.Append(node.Eval(toklist.ElementAt(i++)));
                    contnext = true;
                } else if (toklist.ElementAt(i).type == ";") {
                    break;
                }
            }
            return print;
        }
    }
}
