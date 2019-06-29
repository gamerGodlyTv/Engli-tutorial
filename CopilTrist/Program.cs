using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace CopilTrist
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello,welcome to you new English course");
            Console.WriteLine(" Please choose your language: ");
            Console.WriteLine(" English \n Romana ");
            string limba = Console.ReadLine();
            if (limba.Contains("English"))
            {


                Console.WriteLine("Enter your name: ");
                string nume = Console.ReadLine();
                if (nume.Contains("Creatorul"))
                {
                    Console.WriteLine("NO.");
                    Thread.Sleep(500);
                    Environment.Exit(-1);
                }
                else
                {
                    Console.WriteLine("Hello " + nume);
                }
                Thread.Sleep(1500);
                Console.WriteLine("This app will help you learn English.You'll have 4 lessons at the end of which you'll be tested");
                Thread.Sleep(1500);
                Console.WriteLine("Now,please choose (then write) your English level. ");
                
                Console.WriteLine(" Beginner \n Intermediate \n Advanced ");
                
                string nivel = Console.ReadLine();
                if (nivel.Contains("Beginner"))
                {
                    Console.WriteLine("Welcome in the beginner stage");
                    Thread.Sleep(1500);
                    Console.WriteLine("Here you'll be learning the basics of English");
                    Thread.Sleep(1500);
                    nivelIncepator:
                    Console.WriteLine("Please select one of the 4 lessons:\n Lesson 1 \n Lesson 2 \n Lesson 3 \n Lesson 4");

                    String lectie = Console.ReadLine();
                    if (lectie.Contains("Lesson 1"))
                    {
                        Console.WriteLine("In this lesson you'll be learning the alphabet");
                        Console.WriteLine("A " + "[ei] " + " (a-n-d, a-f-t-e-r, a-p-p-l-e)");
                        Console.WriteLine("B " + "[bi:] " + " (b-a-n-a-n-a, b-a-t-h-r-o-o-m, b-o-y)");
                        Console.WriteLine("C " + "[si:] " + " (c-a-r, c-o-a-t, c-o-l-o-u-r)");
                        Console.WriteLine("D " + "[di:] " + " (d-o-g, d-r-e-a-m, d-o-l-l-a-r)");
                        Console.WriteLine("E " + "[i:] " + " (e-l-e-p-h-a-n-t, e-y-e, e-x-t-r-e-m-e)");
                        Console.WriteLine("F " + "[ɛf] " + " (f-i-n-g-e-r, f-o-u-r, f-i-r-e)");
                        Console.WriteLine("G " + "[dʒiː] " + " (g-i-r-a-f-f-e, g-i-r-l, g-r-e-e-n)");
                        Console.WriteLine("H " + "[eitʃ] " + " (h-o-t-e-l, h-a-p-p-y, h-o-l-i-d-a-y)");
                        Console.WriteLine("I " + "[ai] " + " (i-m-a-g-e, i-s-l-a-n-d, I-n-d-i-a-n-a)");
                        Console.WriteLine("J " + "[dʒei] " + " (j-u-n-g-l-e, j-o-l-l-y, J-o-s-e-p-h-i-n-e)");
                        Console.WriteLine("K " + "[kei] " + " (k-a-n-g-a-r-o-o, k-o-a-l-a, k-a-r-a-t-e)");
                        Console.WriteLine("L " + "[ɛl] " + " (l-o-w, l-e-v-e-l, l-i-o-n)");
                        Console.WriteLine("M " + "[ɛm] " + " (m-o-t-h-e-r, m-o-m-e-n-t, m-e-s-s)");
                        Console.WriteLine("N " + "[ɛn] " + " (n-o, n-i-g-h-t, n-o-o-n)");
                        Console.WriteLine("O " + "[oʊ] " + " (o-l-d, o-b-j-e-c-t, o-a-t)");
                        Console.WriteLine("P " + "[piː] " + " (p-e-n-g-u-i-n-e, p-i-a-n-o, p-a-c-k-e-t)");
                        Console.WriteLine("Q " + "[kjuː] " + " (q-u-i-e-t, Q-u-e-e-n, q-u-o-t-e)");
                        Console.WriteLine("R " + "[ɑr] " + " (r-e-d, r-i-g-h-t, r-a-b-b-i-t)");
                        Console.WriteLine("S " + "[ɛs] " + " (s-t-r-o-n-g, s-e-v-e-n, s-i-l-v-e-r)");
                        Console.WriteLine("T " + "[tiː] " + " (t-e-a, t-h-o-u-s-a-n-d, t-w-o)");
                        Console.WriteLine("U " + "[juː] " + " (u-s-e, u-n-f-a-i-r, u-n-d-e-r)");
                        Console.WriteLine("V " + "[viː] " + " (v-a-c-a-t-i-o-n, v-e-r-y, v-a-m-p-i-r-e)");
                        Console.WriteLine("W " + "[ˈdʌbəl ju] " + " (w-e-s-t, w-o-r-m, w-h-i-t-e)");
                        Console.WriteLine("X " + "[ɛks] " + " (X-r-a-y, x-y-l-o-p-h-o-n-e, X-m-a-s)");
                        Console.WriteLine("Y " + "[wai] " + " (y-a-r-d, y-e-l-l-o-w, y-e-a-h)");
                        Console.WriteLine("Z " + "[zɛd] " + " (z-e-r-o, z-e-b-r-a, z-i-l-l-i-o-n)");
                        Thread.Sleep(10000);
                        Console.WriteLine("If you want to go back type \"Back\"");
                        string inapoi = Console.ReadLine();
                        if (inapoi.Contains("Back"))
                        {
                            goto nivelIncepator;
                        }

                    }
                    if (lectie.Contains("Lesson 2"))
                    {
                        Console.WriteLine("In this lesson you'll learn the colors");
                        Console.WriteLine("This are 7 basic colors in English");
                        Console.WriteLine("Red");
                        Console.WriteLine("Orange");
                        Console.WriteLine("Yellow");
                        Console.WriteLine("Green");
                        Console.WriteLine("Blue");
                        Console.WriteLine("Indigo");
                        Console.WriteLine("Violet");
                        Console.WriteLine("If you want to go back type \"Back\"");
                        string inapoi = Console.ReadLine();
                        Thread.Sleep(10000);
                        if (inapoi.Contains("Back"))
                        {
                            goto nivelIncepator;
                        }

                    }
                    if (lectie.Contains("Lesson 3"))
                    {
                        Console.WriteLine("In this lesson you will learn about personal pronouns");
                        Thread.Sleep(1500);
                        Console.WriteLine("I" + " me" + " singular" + " first");
                        Console.WriteLine("You" + " you" + " singular or plural" + " second");
                        Console.WriteLine("He" + " him" + " singular" + " masculin" + " third");
                        Console.WriteLine("She" + " her" + " singular" + " femenine" + " third");
                        Console.WriteLine("It" + " it" + " singular" + " third");
                        Console.WriteLine("We" + " us" + " plural" + " first");
                        Console.WriteLine("They" + " them" + " plural" + " third");
                        Console.WriteLine("One" + " one" + " generic" + " third");
                        Thread.Sleep(10000);
                        Console.WriteLine("If you want to go back type \"Back\"");
                        string inapoi = Console.ReadLine();
                        if (inapoi.Contains("Back"))
                        {
                            goto nivelIncepator;
                        }

                    }
                    if (lectie.Contains("Lesson 4"))
                    {
                        Console.WriteLine("In this lesson you will learn 25 of the most important verbs in English");
                        Thread.Sleep(1500);
                        Console.WriteLine("to be");
                        
                        Console.WriteLine("to have");
                        
                        Console.WriteLine("to do");
                        
                        Console.WriteLine("to say");
                        
                        Console.WriteLine("to go");
                        Thread.Sleep(2500);
                        Console.WriteLine("to get");
                        Console.WriteLine("to make");
                        Console.WriteLine("to know");
                        Console.WriteLine("to think");
                        Console.WriteLine("to take");
                        Thread.Sleep(2500);
                        Console.WriteLine("to see");
                        Console.WriteLine("to come");
                        Console.WriteLine("to want");
                        Console.WriteLine("to look");
                        Console.WriteLine("to use");
                        Thread.Sleep(2500);
                        Console.WriteLine("to find");
                        Console.WriteLine("to give");
                        Console.WriteLine("to tell");
                        Console.WriteLine("to call");
                        Console.WriteLine("to work");
                        Thread.Sleep(2500);
                        Console.WriteLine("to try");
                        Console.WriteLine("to ask");
                        Console.WriteLine("to need");
                        Console.WriteLine("to feel");
                        Console.WriteLine("to become");
                        Thread.Sleep(10000);
                        Console.WriteLine("If you want to go back type \"Back\"");
                        Console.WriteLine("If you want to write the test type \"Test\"");
                        string viata = Console.ReadLine();
                        if (viata.Contains("Back"))
                        {
                            goto nivelIncepator;
                        }
                        else if (viata.Contains("Test"))
                        {
                            goto Evaluare;
                        }

                        Evaluare:;
                        Console.WriteLine("Salut");
                        

                    }
                    
                }
            }
            else if (limba.Contains("Romana"))
                    {
                Console.WriteLine("Limba Romana inca nu este disponibila");
                Thread.Sleep(2000);
                Environment.Exit(-1);
                
            }
                
                Console.ReadLine();
        }
    }
}
