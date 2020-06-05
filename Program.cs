using System;

namespace Greading_system
{

    enum title
    {
        Mr,
        Dr,
        Mrs,
        Ms
    }
    class Students
    {
        public int Id;
        public string Name;
        public string Contact;
    }
    class Program
    
    {
        static void Main(string[] args)
        {
            int mark = 100;
            if (mark > 100)
            {
                Console.WriteLine("Please input the valid mark");
            }
            else
            {
                if(mark >= 0)
                {
                    Console.WriteLine("Please input the valid mark");
                }
                else
                {
                    if (mark >= 80)
                    {
                        Console.WriteLine("A+");
                    }
                    else
                    {
                        if (mark >= 70)
                        {
                            Console.WriteLine("A");
                        }
                        else
                        {
                            if (mark >= 60)
                            {
                                Console.WriteLine("B+");
                            }
                            else
                            {
                                if (mark >= 50)
                                {
                                    Console.WriteLine("B");
                                }
                                else
                                {
                                    Console.WriteLine("F");
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
