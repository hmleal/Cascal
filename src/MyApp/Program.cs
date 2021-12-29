using System;
using System.IO;
// using System.Collections;
using System.Collections.Generic;

namespace MyApp
{
    public class Token
    {
        string Type;
        string Value;
    
        public Token(string type, string value)
        {
            this.Type = type;
            this.Value = value;
        }
    }

    class Lexer
    {
        string Text;
        int Position;
        char CurrentChar;

        public Lexer(string text)
        {
            this.Text = text;
            this.Position = 0;
            this.CurrentChar = text[0];
        }

        public Token GetNextToken() {
            throw new NotImplementedException();
        }

        private void advance()
        {
            throw new NotImplementedException();
        }

        private void peek()
        {
            throw new NotImplementedException();
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var tokens = new List<Token>(); 
            foreach(char c in args[0])
            {
                var token = new Token("INTEGER", c.ToString());
                if(Char.IsDigit(c))
                {
                    token = new Token("INTEGER", c.ToString());

                    Console.WriteLine($"{c} is an integer");
                }

                if(Char.IsSymbol(c))
                {
                    token = new Token("SYMBOL", c.ToString());
                    Console.WriteLine($"{c} is an symbol");
                }

                tokens.Add(token);
            }

            Console.WriteLine(tokens);
        }
    }
}