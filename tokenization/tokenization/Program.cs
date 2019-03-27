﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tokenization
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> DictOp = new Dictionary<string, string>();

            DictOp.Add("+", "Add");
            DictOp.Add("*", "Multiply");
            DictOp.Add("-", "Subtract");
            DictOp.Add("/", "Divide");
            DictOp.Add("!", "Not");
            DictOp.Add("$$", "And");
            DictOp.Add("||", "Or");
            DictOp.Add("==", "Equal");
            DictOp.Add("?", "Question Mark");
            DictOp.Add("(", "Open Round Bracket");
            DictOp.Add(")", "Close Round Bracket");
            DictOp.Add("{", "Open Curly Bracket");
            DictOp.Add("}", "Close Curly Bracket");
            DictOp.Add("@", "At The Rate");
            DictOp.Add("#", "Hash");
            DictOp.Add("%", "Remainder");
            DictOp.Add("^", "Exponent");
            DictOp.Add("=", "Assignment");
            DictOp.Add("&", "Address");
            DictOp.Add("$", "Dollar");
            DictOp.Add("_", "Under Score");
            DictOp.Add(";", "Semi Colon");
            DictOp.Add(",", "Comma");
            DictOp.Add(":", "Colon");
            DictOp.Add(">>", "Shift Right");
            DictOp.Add("<<", "Shift Left");
            DictOp.Add("++", "Increament");
            DictOp.Add("--", "Decreament");
            DictOp.Add("<=", "Less than equal to");
            DictOp.Add(">=", "Greater than equal to");


           


            Dictionary<string, string> DictKw = new Dictionary<string, string>();

            
            DictKw.Add("goto", "Goto");
            DictKw.Add("break", "Break");
            DictKw.Add("if", "If");
            DictKw.Add("continue", "Continue");
            DictKw.Add("switch", "Switch");
            DictKw.Add("default", "By Default");
            DictKw.Add("else if", "Else if");
            DictKw.Add("is", "Is");
            DictKw.Add("New", "New");
            DictKw.Add("try", "Try");
            DictKw.Add("catch", "Catch");
            DictKw.Add("foreach", "Foreach");
            DictKw.Add("for", "For");
            DictKw.Add("do", "Do");
            DictKw.Add("while", "While");

            Dictionary<string, string> DictDType = new Dictionary<string, string>();

            DictDType.Add("int", "Integer");
            DictDType.Add("float", "Float");
            DictDType.Add("char", "Character");
            DictDType.Add("string", "String");
            DictDType.Add("bool", "Boolean");


            string line = string.Empty;
            string str = string.Empty;

            line = " ";
            int i = 1;
            label:
            if (line != string.Empty)
            {
                line = Console.ReadLine();
                str += line;
                goto label;
                i = i + 1;
            }


            for (int j=1;j<=i;j++)
            {
                Console.WriteLine("Code :");
                string[] tokensList = str.Split((new Char[] { ' ', ',', '.', '-', '\n', '\t' }));


                Console.WriteLine("Tokenization :");
                foreach (string token in tokensList)
                {

                    foreach (KeyValuePair<string, string> a in DictOp)
                    {
                        if (a.Key == token)
                        {
                            Console.WriteLine("< " + token + " , " + DictOp[token] + " >");

                        }

                    }
                    foreach (KeyValuePair<string, string> a in DictKw)
                    {
                        if (a.Key == token)
                        {
                            Console.WriteLine("< " + token + " , " + DictKw[token] + " >");

                        }



                    }
                    foreach (KeyValuePair<string, string> a in DictDType)
                    {
                        if (a.Key == token)
                        {
                            Console.WriteLine("< " + token + " , " + DictDType[token] + " >");

                        }



                    }

                    byte[] converted = Encoding.ASCII.GetBytes(token);

                    foreach (byte element in token)
                    {
                        if (element >= 48 && element <= 57)
                        {
                            if (token.Contains("."))
                            {
                                if (token.Length <= 8)
                                {
                                    Console.WriteLine("< " + token + " , Float >");
                                    break;
                                }
                                else if (token.Length > 8 && token.Length <= 16)
                                {
                                    Console.WriteLine("< " + token + " , Double >");
                                    break;
                                }
                            }
                            else
                            {
                                if (token.Length <= 8)
                                {
                                    Console.WriteLine(" < " + token + ", Integer");
                                    break;
                                }
                                else if (token.Length > 8 && token.Length <= 16)
                                {
                                    Console.WriteLine("< " + token + " , Long");
                                    break;
                                }
                            }
                        }



                    }

                    
                }
            }

            





            Console.ReadKey();
        }
    }
}
