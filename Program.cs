using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Exercise13
{
    static int position = 0;
    public static void Main()
    {
        int[] tab = new int[10];
        int i, n,en;
        Console.Write("\n\nInsert New value in the sorted array :\n");
        Console.Write("-----------------------------------------\n");

        Console.Write("enter la longueur de tableau : ");
        n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input {0} elements in the array in ascending order:\n", n);
        for (i = 0; i < n; i++)
        {
            Console.Write("element - {0} : ", i);
            tab[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.Write("Input the value to be inserted : ");
        en = Convert.ToInt32(Console.ReadLine());
        Console.Write("The exist array list is :\n ");
        for (i = 0; i < n; i++)
            Console.Write("{0} ", tab[i]);
        for (i = 0; i < n; i++)
            if (en < tab[i])
            {
                position = i;
                break;
            }
        for (i = n; i >= position; i--)
            tab[i] = tab[i - 1];
        tab[position] = en;

        Console.Write("\nAfter Insert the list is :\n ");
        for (i = 0; i <= n; i++)
            Console.Write("{0} ", tab[i]);
        Console.Write("\n");
    }
}