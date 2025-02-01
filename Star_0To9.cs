namespace Star_0To9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;
            int n;
            Console.WriteLine("*#*#*#*#*# Star Printing from 0 To 9 Program #*#*#*#*#*");
            while(true)
            { 
            Console.WriteLine("Enter 0 To 9 Any Digit and Postive Number Size of Row To View It in your Screen(Enter Row Number above 1 only)");
            ch = Console.ReadLine()[0];
                if (!int.TryParse(Console.ReadLine(), out n) || n < 1)
                {
                    Console.WriteLine("You have Enter The Invalid Input");
                    Console.WriteLine("Enter the Valid Option");
                }
                else
                {
                    switch (ch)
                    {
                        case '0':
                            _0(n); break;
                        case '1':
                            _1(n); break;
                        case '2':
                            _2(n); break;
                        case '3':
                            _3(n); break;
                        case '4':
                            _4(n); break;
                        case '5':
                            _5(n); break;
                        case '6':
                            _6(n); break;
                        case '7':
                            _7(n); break;
                        case '8':
                            _8(n); break;
                        case '9':
                            _9(n); break;
                        default:
                            Console.WriteLine("You Did not enter the Correct Input");
                            break;
                    }
                    string v;
                    Console.WriteLine("Press A To Clear the Previous Output Or Press B To Exit from the Program Or Press any key to Continue");
                    v = Console.ReadLine();
                    v=v.ToUpper();
                    if (v == "A")
                    {
                        Console.Clear();
                    }
                    else if (v == "B")
                    {
                        return;
                    }
                }
            }
        }
        static void _0(int n)
        {
            int i, j1, j2, k, l, r = n / 2, a1 = n / 2 + n / r, a2 = 0, a3 = a1 - 2, a4 = 0;
            for (i = 0; i <= n; i++)
            {
                if (i == 0 || i == n)
                {
                    for (j1 = 0; j1 <= a1; j1++)
                        Console.Write("*");
                    Console.WriteLine();
                }
                else
                {
                    for (j2 = 0; j2 <= a2; j2++)
                        Console.Write("*");
                    for (k = 0; k <= a3; k++)
                        Console.Write(" ");
                    for (l = 0; l <= a4; l++)
                        Console.Write("*");
                    Console.WriteLine();
                }
            }
        }
        static void _1(int n)
        {
            int i, j1, k, l, m, j2, k2,r = n / 2, s = n / 3, a1 = r - 1, a2 = 0, a3 = -2, a4 = 0, a5 = r-1,a6=0;
            for (i = 0; i <= n; i++)
            {
                if (i >= 0 && i <= s)
                {
                    for (j1 = 0; j1 <= a1; j1++)
                        Console.Write(" ");
                    for (k = 0; k <= a2; k++)
                        Console.Write("*");
                    for (l = 0; l <= a3; l++)
                        Console.Write(" ");
                    if (!(i == 0))
                    {
                        for (m = 0; m <= a4; m++)
                            Console.Write("*");
                    }
                    a1--;
                    a3++;
                    Console.WriteLine();
                }
                else
                {
                    for (j2 = 0; j2 <= a5; j2++)
                        Console.Write(" ");
                    for (k2 = 0; k2 <= a6; k2++)
                        Console.Write("*");
                    Console.WriteLine();
                }
            }
        }
        static void _2(int n)
        {
            int i, j1, j2, k, j3, r = n / 2, a1 = n / 2 + n / r, a2 = a1 - 1, a3 = 0, a4 = 0;
            for (i = 0; i <= n; i++)
            {
                if (i == 0 || i == r || i == n)
                {
                    for (j1 = 0; j1 <= a1; j1++)
                        Console.Write("*");
                    Console.WriteLine();
                }
                else if (i > 0 && i < r)
                {
                    for (j2 = 0; j2 <= a2; j2++)
                        Console.Write(" ");
                    for (k = 0; k <= a3; k++)
                        Console.Write("*");
                    Console.WriteLine();
                }
                else
                {
                    for (j3 = 0; j3 <= a4; j3++)
                        Console.Write("*");
                    Console.WriteLine();
                }
            }
        }
        static void _3(int n)
        {
            int i, j1, j2, k, r = n / 2, a1 = n / 2 + n / r, a2 = a1 - 1, a3 = 0;
            for (i = 0; i <= n; i++)
            {
                if (i == 0 || i == r || i == n)
                {
                    for (j1 = 0; j1 <= a1; j1++)
                        Console.Write("*");
                    Console.WriteLine();

                }
                else
                {
                    for (j2 = 0; j2 <= a2; j2++)
                        Console.Write(" ");
                    for (k = 0; k <= a3; k++)
                        Console.Write("*");
                    Console.WriteLine();
                }
            }
        }

        static void _4(int n)
        {
            int i, j1, k1, l, m, j2, j3, k2, r = n / 2, a1 = r - 1, a2 = 0, a3 = -2, a4 = 0, a5 = r + 2, a6 = a1, a7 = 0;
            for (i = 0; i <= n; i++)
            {
                if (i >= 0 && i < r)
                {
                    for (j1 = 0; j1 <= a1; j1++)
                        Console.Write(" ");
                    for (k1 = 0; k1 <= a2; k1++)
                        Console.Write("*");
                    for (l = 0; l <= a3; l++)
                        Console.Write(" ");
                    if (!(i == 0))
                    {
                        for (m = 0; m <= a4; m++)
                            Console.Write("*");
                    }
                    a1--;
                    a3++;
                    Console.WriteLine();
                }
                else if (i == r)
                {
                    for (j2 = 0; j2 <= a5; j2++)
                        Console.Write("*");
                    Console.WriteLine();
                }
                else
                {
                    for (j3 = 0; j3 <= a6; j3++)
                        Console.Write(" ");
                    for (k2 = 0; k2 <= a7; k2++)
                        Console.Write("*");
                    Console.WriteLine();
                }
            }
        }
        static void _5(int n)
        {
            int i, j1, j2, j3, k,j4, r = n / 2, a1 = n / 2 + n / r, a2 = 0, a3 = a1 - 1, a4 = a3, a5 = 0;
            for (i = 0; i <= n; i++)
            {
                if (i == 0)
                {
                    for (j1 = 0; j1 <= a1; j1++)
                        Console.Write("*");
                    Console.WriteLine();
                }
                else if (i == r || i == n)
                {
                    for (j2 = 0; j2 <= a3; j2++)
                        Console.Write("*");
                    Console.WriteLine();
                }
                else if(i>0&&i<r)
                {
                    for (j3 = 0; j3 <= a2; j3++)
                        Console.Write("*");
                    Console.WriteLine();
                }
                else
                {
                    for (j4 = 0; j4 <= a4; j4++)
                        Console.Write(" ");
                    for (k = 0; k <= a5; k++)
                        Console.Write("*");
                    Console.WriteLine();
                }
            }
        }
        static void _6(int n)
        {
            int i, j1, j2, j3, k, l, r = n / 2, a1 = n / 2 + n / r, a2 = 0, a3 = 0, a4 = a1 - 2, a5 = 0;
            for (i = 0; i <= n; i++)
            {
                if (i == 0 || i == r || i == n)
                {
                    for (j1 = 0; j1 <= a1; j1++)
                        Console.Write("*");
                    Console.WriteLine();
                }
                else if (i > 0 && i < r)
                {
                    for (j2 = 0; j2 <= a2; j2++)
                        Console.Write("*");
                    Console.WriteLine();
                }
                else
                {
                    for (j3 = 0; j3 <= a3; j3++)
                        Console.Write("*");
                    for (k = 0; k <= a4; k++)
                        Console.Write(" ");
                    for (l = 0; l <= a5; l++)
                        Console.Write("*");
                    Console.WriteLine();
                }
            }
        }
        static void _7(int n)
        {
            int i, j1, j2, k, r = n / 2, a1 = n / 2 + n / r, a2 = a1 - 1, a3 = 0;
            for (i = 0; i <= n; i++)
            {
                if (i == 0)
                {
                    for (j1 = 0; j1 <= a1; j1++)
                        Console.Write("*");
                    Console.WriteLine();
                }
                else
                {
                    for (j2 = 0; j2 <= a2; j2++)
                        Console.Write(" ");
                    for (k = 0; k <= a3; k++)
                        Console.Write("*");
                    Console.WriteLine();
                }
            }
        }
        static void _8(int n)
        {
            int i, j1, j2, k, l, r = n / 2, a1 = n / 2 + n / r, a2 = 0, a3 = a1 - 2, a4 = 0;
            for (i = 0; i <= n; i++)
            {
                if (i == 0 || i == r || i == n)
                {
                    for (j1 = 0; j1 <= a1; j1++)
                        Console.Write("*");
                    Console.WriteLine();
                }
                else
                {
                    for (j2 = 0; j2 <= a2; j2++)
                        Console.Write("*");
                    for (k = 0; k <= a3; k++)
                        Console.Write(" ");
                    for (l = 0; l <= a4; l++)
                        Console.Write("*");
                    Console.WriteLine();
                }
            }
        }
        static void _9(int n)
        {
            int i, j1, j2, k1, l, j3, k2, r = n / 2, a1 = n / 2 + n / r, a2 = 0, a3 = a1 - 2, a4 = 0, a5 = a1 - 1, a6 = 0;
            for (i = 0; i <= n; i++)
            {
                if (i == 0 || i == r || i == n)
                {
                    for (j1 = 0; j1 <= a1; j1++)
                        Console.Write("*");
                    Console.WriteLine();
                }
                else if (i >= 0 && i < r)
                {
                    for (j2 = 0; j2 <= a2; j2++)
                        Console.Write("*");
                    for (k1 = 0; k1 <= a3; k1++)
                        Console.Write(" ");
                    for (l = 0; l <= a4; l++)
                        Console.Write("*");
                    Console.WriteLine();
                }
                else
                {
                    for (j3 = 0; j3 <= a5; j3++)
                        Console.Write(" ");
                    for (k2 = 0; k2 <= a6; k2++)
                        Console.Write("*");
                    Console.WriteLine();
                }
            }
        }



    }
}
