using System;

namespace Star_AToZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            char ch;
            Console.WriteLine("*#*#*#*#*# A To Z Star Printing Program #*#*#*#*#*");
            while (true)
            {
                Console.WriteLine("Enter Any Character from A to Z and Any Positive number of Rows Above One for Printing that Character on your Screen(Enter Odd number of rows for Symmetrical Views of W,X and Y)");
                ch = Console.ReadLine()[0];
                ch=char.ToLower(ch);
                if (!int.TryParse(Console.ReadLine(),out n)|| n < 1 || !(ch >= 'a' && ch <= 'z'))
                {
                    Console.WriteLine("You have Enter The Invalid Input");
                    Console.WriteLine("Enter the Valid Option");
                }
                else
                {
                    switch (ch)
                    {
                        case 'a':
                            A(n); break;
                        case 'b':
                            B(n); break;
                        case 'c':
                            C(n); break;
                        case 'd':
                            D(n); break;
                        case 'e':
                            E(n); break;
                        case 'f':
                            F(n); break;
                        case 'g':
                            G(n); break;
                        case 'h':
                            H(n); break;
                        case 'i':
                            I(n); break;
                        case 'j':
                            J(n); break;
                        case 'k':
                            K(n); break;
                        case 'l':
                            L(n); break;
                        case 'm':
                            M(n); break;
                        case 'n':
                            N(n); break;
                        case 'o':
                            O(n); break;
                        case 'p':
                            P(n); break;
                        case 'q':
                            Q(n); break;
                        case 'r':
                            R(n); break;
                        case 's':
                            S(n); break;
                        case 't':
                            T(n); break;
                        case 'u':
                            U(n); break;
                        case 'v':
                            V(n); break;
                        case 'w':
                            W(n); break;
                        case 'x':
                            X(n); break;
                        case 'y':
                            Y(n); break;
                        case 'z':
                            Z(n); break;
                    }
                    Console.WriteLine();
                    string no;
                    Console.WriteLine("Press 0 To Clear the Previous Output Or Press 1 To Exit From the Program Or Press Any other Key to Continue");
                    no = Console.ReadLine();
                    if(no == "0")
                    {
                        Console.Clear();
                    }
                    else if(no=="1")
                    {
                        return;
                    }
                }
            }
        }
        static void A(int n)
        {
            int i, j, k, l, m, s, r = n / 3, a1 = n - 1, a2 = 0, a3 = 0, a4 = 0, x = r * 2;
            for (i = 0; i <= n; i++)
            {
                for (j = 0; j <= a1; j++)
                    Console.Write(" ");
                if (i == r)
                {
                    for (s = 0; s <= x; s++)
                        Console.Write("*");
                    Console.WriteLine();
                    a3 += 2;
                    a1--;
                }
                else
                {
                    for (k = 0; k <= a2; k++)
                        Console.Write("*");
                    if (!(i == 0))
                    {
                        for (l = 0; l <= a3; l++)
                            Console.Write(" ");
                        for (m = 0; m <= a4; m++)
                            Console.Write("*");
                        a3 += 2;
                    }
                    Console.WriteLine();


                    a1--;
                }
            }
        }
        static void B(int n)
        {
            int i, j, k, l, s, r = n / 2, x = (n / 2 + n / r - 1), a1 = 0, a2 = (n / 2 + n / r - 2), a3 = 0;
            for (i = 0; i <= n; i++)
            {
                if (i == 0 || i == r || i == n)
                {
                    for (s = 0; s <= x; s++)
                        Console.Write("*");
                    Console.WriteLine();
                }
                else
                {
                    for (j = 0; j <= a1; j++)
                        Console.Write("*");
                    for (k = 0; k <= a2; k++)
                        Console.Write(" ");
                    for (l = 0; l <= a3; l++)
                        Console.Write("*");
                    Console.WriteLine();

                }
            }
        }
        static void C(int n)
        {
            int i, j, k, s, r = n / 2, x = n / 2 + n / r - 1, a1 = 0, a2 = 0;
            for (i = 0; i <= n; i++)
            {
                if (i == 0 || i == n)
                {
                    for (j = 0; j <= a1; j++)
                        Console.Write(" ");
                    for (s = 0; s <= x; s++)
                        Console.Write("*");
                    Console.WriteLine();
                }
                else
                {
                    for (k = 0; k <= a2; k++)
                        Console.Write("*");
                    Console.WriteLine();
                }
            }
        }
        static void D(int n)
        {
            int i, j, k, l, s, r = n / 2, x = n / 2 + n / r - 1, a1 = 0, a2 = n / 2 + n / r - 2, a3 = 0;
            for (i = 0; i <= n; i++)
            {
                if (i == 0 || i == n)
                {
                    for (s = 0; s <= x; s++)
                        Console.Write("*");
                    Console.WriteLine();
                }
                else
                {
                    for (j = 0; j <= a1; j++)
                        Console.Write("*");
                    for (k = 0; k <= a2; k++)
                        Console.Write(" ");
                    for (l = 0; l <= a3; l++)
                        Console.Write("*");
                    Console.WriteLine();
                }
            }
        }
        static void E(int n)
        {
            int i, j, s, r = n / 2, x = n / 2 + n / r, a1 = 0;
            for (i = 0; i <= n; i++)
            {
                if (i == 0 || i == r || i == n)
                {
                    for (s = 0; s <= x; s++)
                        Console.Write("*");
                    Console.WriteLine();
                }
                else
                {
                    for (j = 0; j <= a1; j++)
                        Console.Write("*");
                    Console.WriteLine();
                }
            }
        }
        static void F(int n)
        {
            int i, j, s, r = n / 2, x = n / 2 + n / r, a1 = 0;
            for (i = 0; i <= n; i++)
            {
                if (i == 0 || i == r)
                {
                    for (s = 0; s <= x; s++)
                        Console.Write("*");
                    Console.WriteLine();
                }
                else
                {
                    for (j = 0; j <= a1; j++)
                        Console.Write("*");
                    Console.WriteLine();
                }
            }
        }
        static void G(int n)
        {
            int i, s1, s2, s3, j, k, l, r = n / 2, x = n / 2 + n / r, a1 = 0, a2 = x - 2, a3 = 0;
            for (i = 0; i <= n; i++)
            {
                if (i == 0 || i == n)
                {
                    for (s1 = 0; s1 <= x; s1++)
                        Console.Write("*");
                    Console.WriteLine();
                }
                else
                {
                    for (j = 0; j <= a1; j++)
                        Console.Write("*");
                    if (i >= r)
                    {
                        if (i == r)
                        {
                            for (s2 = 0; s2 <= x - 3; s2++)
                                Console.Write(" ");
                            for (s3 = 0; s3 <= a3 + 1; s3++)
                                Console.Write("*");
                        }
                        else
                        {
                            for (k = 0; k <= a2; k++)
                                Console.Write(" ");
                            for (l = 0; l <= a3; l++)
                                Console.Write("*");
                        }
                    }
                    Console.WriteLine();
                }
            }
            
        }
        static void H(int n)
        {
            int i, j, k,l, s, r = n / 2, x = n / 2 + n / r, a1 = 0, a2 = x - 2, a3 = 0;
            for (i = 0; i <= n; i++)
            {
                if (i == r)
                {
                    for (s = 0; s <= x; s++)
                        Console.Write("*");
                    Console.WriteLine();
                }
                else
                {
                    for (j = 0; j <= a1; j++)
                        Console.Write("*");
                    for (k = 0; k <= a2; k++)
                        Console.Write(" ");
                    for(l = 0; l <= a3;l++)
                        Console.Write("*");
                    Console.WriteLine();
                }
            }


        }
        static void I(int n)
        {
            int i, j1, j2, k, r = n / 2, a1 = n / 2 + n / r, a2 = a1 / 2 - 1, a3 = 0;
            for (i = 0; i <= n; i++)
            {
                if (i == 0 | i == n)
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

        static void J(int n)
        {
            int i, j1, j2, j3, k1, k2, s, r = n / 2, x = n / 2 + r / 2, a1 = x - 1, a2 = 0, ax = 0;
            for (i = 0; i <= n; i++)
            {
                if (i == 0 || i == n)
                {
                    for (s = 0; s <= x; s++)
                        Console.Write("*");
                    Console.WriteLine();
                }
                else
                {
                    if (i == n - 1)
                    {
                        for (j1 = 0; j1 <= ax; j1++)
                            Console.Write("*");
                        for (j2 = 0; j2 <= a1 - 1; j2++)
                            Console.Write(" ");
                        for (k1 = 0; k1 <= a2; k1++)
                            Console.Write("*");
                        Console.WriteLine();
                    }
                    else
                    {
                        for (j3 = 0; j3 <= a1; j3++)
                            Console.Write(" ");
                        for (k2 = 0; k2 <= a2; k2++)
                            Console.Write("*");
                        Console.WriteLine();
                    }
                }
            }
        }
        static void K(int n)
        {
            int i,j1, j2, k1, k2, l1, l2, r = n / 2, a1 = 0, a2 = r, a3 = 0, a4 = 0;
            for (i = 0; i <= n; i++)
            {
                if (i <= r)
                {
                    for (j1 = 0; j1 <= a1; j1++)
                        Console.Write("*");
                    for (k1 = 0; k1 <= a2; k1++)
                        Console.Write(" ");
                    for (l1 = 0; l1 <= a3; l1++)
                        Console.Write("*");
                    Console.WriteLine();
                    a2--;
                }
                else
                {
                    for (j2 = 0; j2 <= a1; j2++)
                        Console.Write("*");
                    for (k2 = 0; k2 <= a4; k2++)
                        Console.Write(" ");
                    for (l2 = 0; l2 <= a3; l2++)
                        Console.Write("*");
                    Console.WriteLine();
                    a4++;
                }
            }
        }
        static void L(int n)
        {
            int i, j1, j2, r = n / 2, x = n / 2 + n / r, a1 = 0;
            for (i = 0; i <= n; i++)
            {
                if (i == n)
                {
                    for (j1 = 0; j1 <= x; j1++)
                        Console.Write("*");
                }
                else
                {
                    for (j2 = 0; j2 <= a1; j2++)
                        Console.Write("*");
                    Console.WriteLine();
                }
            }
        }
        static void M(int n)
        {
            int i, j, k, l, m, nn,o, p, q, s, r = n / 2, x = n - 1, a1 = 0, a2 = -1,a3 = 0,a4 = x - 2,a5 = 0, a6 = -1, a7 = 0;
            for (i = 0; i <= n; i++)
            {
                for (j = 0; j <= a1; j++)
                    Console.Write("*");
                if (i == 0)
                {
                    for (s = 0; s <= x; s++)
                        Console.Write(" ");
                }
                else if (i > 0 && i <= r)
                {
                    for (k = 0; k <= a2; k++)
                        Console.Write(" ");
                    for (l = 0; l <= a3; l++)
                        Console.Write("*");
                    for (m = 0; m <= a4; m++)
                        Console.Write(" ");
                    for (nn = 0; nn <= a5; nn++)
                        Console.Write("*");
                    for (o = 0; o <= a6; o++)
                        Console.Write(" ");
                    a2++;
                    a4 -= 2;
                    a6++;
                }
                else
                {
                    for (p = 0; p <= x; p++)
                        Console.Write(" ");
                }
                for (q = 0; q <= a7; q++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
        static void N(int n)
        {
            int i, j, k, l, m, nn, s, x = n - 2, a1 = 0, a2 = -1, a3 = 0, a4 = x - 1, a5 = 0;
            for (i = 0; i <= n; i++)
            {
                for (j = 0; j <= a1; j++)
                    Console.Write("*");
                if (i == 0 || i == n)
                {
                    for (s = 0; s <= x; s++)
                        Console.Write(" ");
                }
                else if (i > 0 && i < n)
                {
                    for (k = 0; k <= a2; k++)
                        Console.Write(" ");
                    for (l = 0; l <= a3; l++)
                        Console.Write("*");
                    for (m = 0; m <= a4; m++)
                        Console.Write(" ");
                    a2++;
                    a4--;
                }
                for (nn = 0; nn <= a5; nn++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
        static void O(int n)
        {
            int i, j1, j2, k1, k2, l1, l2, a1 = 0, a2 = n - 2, a3 = 0, a4 = 0, a5 = n - 2, a6 = 0;
            for (i = 0; i <= n; i++)
            {
                if (i == 0 || i == n)
                {
                    for (j1 = 0; j1 <= a1; j1++)
                        Console.Write(" ");
                    for (k1 = 0; k1 <= a2; k1++)
                        Console.Write("*");
                    for (l1 = 0; l1 <= a3; l1++)
                        Console.Write(" ");
                    Console.WriteLine();
                }
                else
                {
                    for (j2 = 0; j2 <= a4; j2++)
                        Console.Write("*");
                    for (k2 = 0; k2 <= a5; k2++)
                        Console.Write(" ");
                    for (l2 = 0; l2 <= a6; l2++)
                        Console.Write("*");
                    Console.WriteLine();
                }
            }
        }
        static void P(int n)
        {
            int i, j1, j2, j3, k, l, r = n / 2, a1 = n / 2 + n / r - 1, a2 = 0, a3 = a1 - 1, a4 = 0, a5 = 0;
            for (i = 0; i <= n; i++)
            {
                if (i == 0 || i == r)
                {
                    for (j1 = 0; j1 <= a1; j1++)
                        Console.Write("*");
                    Console.WriteLine();
                }
                else if (i > 0 && i < r)
                {
                    for (j2 = 0; j2 <= a2; j2++)
                        Console.Write("*");
                    for (k = 0; k <= a3; k++)
                        Console.Write(" ");
                    for (l = 0; l <= a4; l++)
                        Console.Write("*");
                    Console.WriteLine();
                }
                else
                {
                    for (j3 = 0; j3 <= a5; j3++)
                        Console.Write("*");
                    Console.WriteLine();
                }
            }
        }
        static void Q(int n)
        {
            int i, j1, k1, l1, j2, k2, l2, j3, k3, k4, k5, l3, r = n / 2, s = n / 2 + 2 * n / r, a1 = 0, a2 = n - 2, a3 = 0,a4 = 0, a5 = n - 2, a6 = 0, a7 = 0, a8 = s - 2,a9 = 0, a10 = n - s-2, a11 = 0;
            for (i = 0; i <= n; i++)
            {
                if (i == 0 || i == n)
                {
                    for (j1 = 0; j1 <= a1; j1++)
                        Console.Write(" ");
                    for (k1 = 0; k1 <= a2; k1++)
                        Console.Write("*");
                    if (i == n)
                    {
                        for (l3 = 0; l3 <= a3; l3++)
                            Console.Write("*");
                        Console.WriteLine();
                    }
                    else
                    {
                        for (l1 = 0; l1 <= a3; l1++)
                            Console.Write(" ");
                        Console.WriteLine();
                    }
                }
                else if (i > 0 && i < s)
                {
                    for (j2 = 0; j2 <= a4; j2++)
                        Console.Write("*");
                    for (k2 = 0; k2 <= a5; k2++)
                        Console.Write(" ");
                    for (l2 = 0; l2 <= a6; l2++)
                        Console.Write("*");
                    Console.WriteLine();
                }
                else 
                {
                    for (j3 = 0; j3 <= a7; j3++)
                        Console.Write("*");
                    for (k3 = 0; k3 <= a8; k3++)
                        Console.Write(" ");
                    for (k4 = 0; k4 <= a9; k4++)
                        Console.Write("*");
                    for (k5 = 0; k5 <= a10; k5++)
                        Console.Write(" ");
                    for (l3 = 0; l3 <= a11; l3++)
                        Console.Write("*");
                    a8++;
                    a10--;
                    Console.WriteLine();
                }
            }
        }
        static void R(int n)
        {
            int i, j1, j2, j3, k1, k2, l1, l2, r = n / 2, x = n / 2 + r / 2 - 1, a1 = 0, a2 = x - 1, a3 = 0, a4 = 0, a5 = -1, a6 = 0;
            for (i = 0; i <= n; i++)
            {
                if (i == 0 || i == r)
                {
                    for (j1 = 0; j1 <= x; j1++)
                        Console.Write("*");
                    Console.WriteLine();
                }
                else if (i > 0 && i < r)
                {
                    for (j2 = 0; j2 <= a1; j2++)
                        Console.Write("*");
                    for (k1 = 0; k1 <= a2; k1++)
                        Console.Write(" ");
                    for (l1 = 0; l1 <= a3; l1++)
                        Console.Write("*");
                    Console.WriteLine();
                }
                else
                {
                    for (j3 = 0; j3 <= a4; j3++)
                        Console.Write("*");
                    for (k2 = 0; k2 <= a5; k2++)
                        Console.Write(" ");
                    for (l2 = 0; l2 <= a6; l2++)
                        Console.Write("*");
                    a5++;
                    Console.WriteLine();
                }
            }
        }
        static void S(int n)
        {
            int i, j1, j2, j3, k, r = n / 2, a1 = n, a2 = 0, a3 = n - 1, a4 = 0;
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
                        Console.Write(" ");
                    for (k = 0; k <= a4; k++)
                        Console.Write("*");
                    Console.WriteLine();
                }
            }
        }

        static void T(int n)
        {
            int i, j1, j2, k, r = n / 2, a1 = n, a2 = r - 1, a3 = 0;
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
        static void U(int n)
        {
            int i, j1, k1, l1, j2, k2, l2, r = n / 2, a1 = 0, a2 = n / 2 + n / r - 2, a3 = 0, a4 = 0, a5 = a2, a6 = 0;
            for (i = 0; i <= n; i++)
            {
                if (i == n)
                {
                    for (j1 = 0; j1 <= a1; j1++)
                        Console.Write(" ");
                    for (k1 = 0; k1 <= a2; k1++)
                        Console.Write("*");
                    for (l1 = 0; l1 <= a3; l1++)
                        Console.Write(" ");
                    Console.WriteLine();
                }
                else
                {
                    for (j2 = 0; j2 <= a4; j2++)
                        Console.Write("*");
                    for (k2 = 0; k2 <= a5; k2++)
                        Console.Write(" ");
                    for (l2 = 0; l2 <= a6; l2++)
                        Console.Write("*");
                    Console.WriteLine();
                }
            }
        }
        static void V(int n)
        {
            int i, j, k, l, m, a1 = -1, a2 = 0, a3 = 2 * n - 2, a4 = 0;
            for (i = 0; i <= n; i++)
            {
                for (j = 0; j <= a1; j++)
                    Console.Write(" ");
                for (k = 0; k <= a2; k++)
                    Console.Write("*");
                for (l = 0; l <= a3; l++)
                    Console.Write(" ");
                if (!(i == n))
                {
                    for (m = 0; m <= a4; m++)
                        Console.Write("*");
                }
                a1++;
                a3 -= 2;
                Console.WriteLine();
            }
        }
        static void W(int n)
        {
            int i, j1, k1, l1, m1, j2, k2, l2, l3, l4, l5, l6, m2, r = n / 2, c = 3 * n, a1 = -1, a2 = 0, a3 = c - 2, a4 = 0, a5 = r-1, a6 = 0, a7 = 3 * n / 2 - r - 2, a8 = 0, a9 = -2, a10 = 0, a11 = 3 * n / 2 - r - 2, a12 = 0;
            if (n % 2 == 1) { a7 = a7 + 1; a11 = a11 + 1; }
            for (i = 0; i <= n; i++)
            {
                if (i >= 0 && i < r)
                {
                    for (j1 = 0; j1 <= a1; j1++)
                        Console.Write(" ");
                    for (k1 = 0; k1 <= a2; k1++)
                        Console.Write("*");
                    for (l1 = 0; l1 <= a3; l1++)
                        Console.Write(" ");
                    for (m1 = 0; m1 <= a4; m1++)
                        Console.Write("*");
                    a1++;
                    a3 -= 2;
                    Console.WriteLine();
                }
                else
                {
                    for (j2 = 0; j2 <= a5; j2++)
                        Console.Write(" ");
                    for (k2 = 0; k2 <= a6; k2++)
                        Console.Write("*");
                    for (l2 = 0; l2 <= a7; l2++)
                        Console.Write(" ");
                    if (!(i == n))
                    {
                        for (l3 = 0; l3 <= a8; l3++)
                            Console.Write("*");
                    }
                    for (l4 = 0; l4 <= a9; l4++)
                        Console.Write(" ");
                    if (!(i == r))
                    {
                        for (l5 = 0; l5 <= a10; l5++)
                            Console.Write("*");
                    }
                    for (l6 = 0; l6 <= a11; l6++)
                        Console.Write(" ");
                    if (!(i == n))
                    {
                        for (m2 = 0; m2 <= a12; m2++)
                            Console.Write("*");
                    }
                    a5++;
                    a7 -= 2;
                    a9 += 2;
                    a11 -= 2;
                    Console.WriteLine();
                }

            }
        }
        static void X(int n)
        {
            int i, j1, k1, l1,l2,k2 ,m1, j2, r = n / 2, a1 = -1, a2 = 0, a3 = n - 2, a4 = 0, a5 = r - 2, a6 = 0,a7=0;
            for (i = 0; i <= n; i++)
            {
                if (i >= 0 && i <= r)
                {
                    for (j1 = 0; j1 <= a1; j1++)
                        Console.Write(" ");
                    for (k1 = 0; k1 <= a2; k1++)
                        Console.Write("*");
                    for (l1 = 0; l1 <= a3; l1++)
                        Console.Write(" ");
                    if (!(i == r))
                    {
                        for (m1 = 0; m1 <= a4; m1++)
                            Console.Write("*");
                    }
                    a1++;
                    a3 -= 2;
                    Console.WriteLine();
                }
                else
                {
                    for (j2 = 0; j2 <= a5; j2++)
                        Console.Write(" ");
                    for (k2 = 0; k2 <= a6; k2++)
                        Console.Write("*");
                    for (l2 = 0; l2 <= a7; l2++)
                        Console.Write(" ");
                    for (m1 = 0; m1 <= a4; m1++)
                        Console.Write("*");
                    a5--;
                    a7 += 2;
                    Console.WriteLine();
                }
            }
        }
        static void Y(int n)
        {
            int i, j1, k1,k2,j2 ,l, m, r = n / 2, a1 = -1, a2 = 0, a3 = n - 2, a4 = 0, a5 = r - 1, a6 = 0;
            for (i = 0; i <= n; i++)
            {
                if (i >= 0 && i <= r)
                {
                    for (j1 = 0; j1 <= a1; j1++)
                        Console.Write(" ");
                    for (k1 = 0; k1 <= a2; k1++)
                        Console.Write("*");
                    for (l = 0; l <= a3; l++)
                        Console.Write(" ");
                    if (!(i == r))
                    {
                        for (m = 0; m <= a4; m++)
                            Console.Write("*");
                    }
                    a1++;
                    a3 -= 2;
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
        static void Z(int n)
        {
            int x = n - 2, y = 0, i;
            for (i = 0; i <= n; i++)
            {
                if (i == 0 || i == n)
                {
                    for (int k = 0; k <= n; k++)
                        Console.Write("*");
                    Console.WriteLine();
                }
                else
                {
                    for (int j = 0; j <= x; j++)
                        Console.Write(" ");
                    for (int k = 0; k <= y; k++)
                        Console.Write("*");
                    x--;
                    Console.WriteLine();
                }
            }
        }






    }
}
