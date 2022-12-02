using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IgazsagTabla
{
    class BoolExpr
    {
        private List<Token> Expression;
        private const string mismatchParenErrorMsg =
            "Hiba! Nem illő zárójel a kifejezésben!";

        public BoolExpr(string input)
        {
            Expression = Token.Tokenize(input);
            InsertANDs();

            // Konvertálás
            Expression = ShuntingYard(Expression);
        }

        public bool Solve()
        {
            Stack<bool> stack = new Stack<bool>();

            foreach (Token t in Expression) {
                if (t.Category == Token.TokenCategory.Bool) {
                    stack.Push(t.BoolVal);
                } else if (t.Category == Token.TokenCategory.Op) {
                    if (t.ArgCount > stack.Count) {
                        throw new Exception("Nem adott meg elegendő értéket!");
                    }

                    // operátor kiértékelése:
                    switch (t.Symbol) {
                        case '+':
                            stack.Push(stack.Pop() | stack.Pop());
                            break;
                        case '^':
                            stack.Push(stack.Pop() ^ stack.Pop());
                            break;
                        case '*':
                            stack.Push(stack.Pop() & stack.Pop());
                            break;
                        case '\'':
                            stack.Push(!stack.Pop());
                            break;
                        default:
                            throw new Exception("Hiba: Érvénytelen művelet!");
                    }
                }
            }

            if (stack.Count > 1) throw new Exception("Hiba: A bevitel túl sok értéket tartalmaz.");

            return stack.Pop();
        }

        // Tokenek konvertálása
        // Shunting Yard algoritmus használata
        // https://en.wikipedia.org/wiki/Shunting_yard_algorithm
        private List<Token> ShuntingYard(List<Token> list)
        {
            List<Token> outputQueue = new List<Token>();
            Stack<Token> operatorStack = new Stack<Token>();

            foreach (Token t in list) {
                if (t.Category == Token.TokenCategory.Bool) {
                    outputQueue.Add(t);
                } else if (t.Category == Token.TokenCategory.Op) {
                    while ((operatorStack.Count > 0) &&
                        (operatorStack.Peek().Category == Token.TokenCategory.Op) &&
                        (
                        (t.IsLeftAssoc && t.Precedence <= operatorStack.Peek().Precedence) ||
                        (!t.IsLeftAssoc && t.Precedence < operatorStack.Peek().Precedence)
                        )) {
                        outputQueue.Add(operatorStack.Pop());
                    }
                    operatorStack.Push(t);
                } else if (t.Category == Token.TokenCategory.LeftParen) {
                    operatorStack.Push(t);
                } else if (t.Category == Token.TokenCategory.RightParen) {
                    try {
                        while (operatorStack.Peek().Category != Token.TokenCategory.LeftParen) {
                            outputQueue.Add(operatorStack.Pop());
                        }
                        // előugrik a bal oldali operátor a veremből
                        operatorStack.Pop();
                    } catch (InvalidOperationException) {
                        throw new Exception(mismatchParenErrorMsg);
                    }
                }
            }

            // a veremben lévő fennmaradó operátorokat helyezze a kimeneti sorba:
            while (operatorStack.Count > 0) {
                // Ha a verem tetején lévő operátor token egy operátor
                if (operatorStack.Peek().Category == Token.TokenCategory.LeftParen ||
                    operatorStack.Peek().Category == Token.TokenCategory.RightParen) {
                    throw new Exception(mismatchParenErrorMsg);
                }
                outputQueue.Add(operatorStack.Pop());
            }

            return outputQueue;
        }

        private void InsertANDs()
        {
            // 2 token összehasonlítása egy időben
            int a = 0; int b = 1;
            while (b < Expression.Count) {
                // iterál minden lehetséges helyen ahol a *-t kell beilleszteni
                if ((Expression[a].Category == Token.TokenCategory.Bool &&
                     Expression[b].Category == Token.TokenCategory.LeftParen)
                     ||
                    (Expression[a].Category == Token.TokenCategory.Bool &&
                     Expression[b].Category == Token.TokenCategory.Bool)
                     ||
                    (Expression[a].Category == Token.TokenCategory.RightParen &&
                     Expression[b].Category == Token.TokenCategory.LeftParen)
                     ||
                    (Expression[a].Category == Token.TokenCategory.RightParen &&
                     Expression[b].Category == Token.TokenCategory.Bool)
                     || // feltételekhez nem tartozik (')
                    (Expression[a].Symbol == '\'' &&
                     Expression[b].Category == Token.TokenCategory.Bool)
                     ||
                    (Expression[a].Symbol == '\'' &&
                     Expression[b].Category == Token.TokenCategory.LeftParen)
                    ) {
                    Expression.Insert(b, new Token('*', Token.TokenCategory.Op, 4));
                    a++; b++;
                }
                a++; b++;
            }
        }

        public List<char> GetBoolVars()
        {
            List<char> boolVars = new List<char>();
            foreach (var t in Expression) {
                if (t.Category == Token.TokenCategory.Bool && t.isVariable) {
                    boolVars.Add(t.Symbol);
                }
            }
            boolVars = boolVars.Distinct().ToList();
            boolVars.Sort();

            return boolVars;
        }

        // a változó értékének beállítása, ha sikeres igazat ad vissza
        public bool SetValue(char c, bool val)
        {
            bool success = false;
            char ch = Char.ToUpper(c);
            foreach (var t in Expression) {
                if (t.Symbol == ch) {
                    t.BoolVal = val;
                    success = true;
                }
            }

            return success;
        }


        }
}
