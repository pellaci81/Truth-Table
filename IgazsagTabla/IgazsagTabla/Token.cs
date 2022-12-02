using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IgazsagTabla
    {
    class Token
    {
        public enum TokenCategory
        {
            Undefined,
            Bool,
            Op,
            LeftParen,
            RightParen
        };

        // a magasabb prioritást hajtják végre először
        public int Precedence { get; private set; }
        public TokenCategory Category { get; private set; }
        public char Symbol { get; private set; } // alapérték 0
        // ha nem bal, akkor jobb
        public bool IsLeftAssoc { get; private set; }
        public bool BoolVal { get; set; }
        public bool isVariable { get; private set; }
        public int ArgCount { get; private set; }

        public Token(char symbol, 
            TokenCategory cat = TokenCategory.Undefined, 
            int precedence = -1,
            int argCount = 0,
            bool isLeftAssoc = true)
        {
            if (cat == TokenCategory.Bool) isVariable = true;
            this.Category = cat;
            this.Symbol = symbol;
            this.Precedence = precedence;
            this.IsLeftAssoc = isLeftAssoc;
            this.ArgCount = argCount;
        }

        // értékek konstruktora
        public Token(char symbol, bool boolVal)
        {
            this.Category = TokenCategory.Bool;
            this.BoolVal = boolVal;
            this.Symbol = symbol;
        }

        public override string ToString()
        {
            return String.Format("Category: {0}\nValue: {1}\nPrecedence: {2}\nAssociativity: {3}\n",
                Category.ToString(),
                Symbol == 0 ? BoolVal.ToString() : Symbol.ToString(),
                Precedence,
                IsLeftAssoc ? "left" : "right");
        }

        public static List<Token> Tokenize(string input)
        {
            List<Token> result = new List<Token>();
            input = Regex.Replace(input, @"\s+", "");
            foreach (char c in input) {
                if (Char.IsLetter(c)) {
                    // betűk átalakítása nagy betűvé
                    result.Add(new Token(Char.ToUpper(c), TokenCategory.Bool));
                    continue;
                }
                switch (c) {
                    case '0':
                        result.Add(new Token(c, false));
                        break;
                    case '1':
                        result.Add(new Token(c, true));
                        break;
                    case '(':
                        result.Add(new Token(c, TokenCategory.LeftParen));
                        break;
                    case ')':
                        result.Add(new Token(c, TokenCategory.RightParen));
                        break;
                    case '+':
                        result.Add(new Token(c, TokenCategory.Op, 2, 2));
                        break;
                    case '^':
                        result.Add(new Token(c, TokenCategory.Op, 3, 2));
                        break;
                    case '*':
                        result.Add(new Token(c, TokenCategory.Op, 4, 2));
                        break;
                    case '\'':
                        result.Add(new Token(c, TokenCategory.Op, 5, 1, false));
                        break;
                    default:
                        throw new Exception("Ellenőrizze a karaktereket!");
                }
            }
            return result;
        }
    }
}
