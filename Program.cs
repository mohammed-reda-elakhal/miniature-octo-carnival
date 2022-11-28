
    internal static class Program
    {
        static void Main()
        {
            int[] arr1 = new int[10];
            int i, n, p = 0, position;
            Console.Write("-----------------------------------------\n");

            Console.Write("entrer le nombre d'element de table : ");
            n = Convert.ToInt32(Console.ReadLine());
            /* Stored values into the array*/
            Console.Write("entrer {0} elements avec une croissante order:\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("entrer la valeur que tu veux insérer : ");
            position = Convert.ToInt32(Console.ReadLine());
            Console.Write("votre liste est :\n ");
            for (i = 0; i < n; i++)
                Console.Write("{0} ", arr1[i]);
            /* Determine the position where the new value will be insert.*/
            for (i = 0; i < n; i++)
                if (position < arr1[i])
                {
                    p = i;
                    break;
                }
            /* move all data at right side of the array */
            for (i = n; i >= p; i--)
                arr1[i] = arr1[i - 1];
            /* insert value at the proper position */
            arr1[p] = position;

            Console.Write("\n\nAprés l'insertion la liste est :\n ");
            for (i = 0; i <= n; i++)
                Console.Write("{0} ", arr1[i]);
            Console.Write("\n");

        }
    }
