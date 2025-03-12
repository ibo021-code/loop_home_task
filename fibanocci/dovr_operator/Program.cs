
        Console.Write("daxil et ededi : ");
        int n = int.Parse(Console.ReadLine());

        int a = 0, b = 1, c = 1;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"{a} + {b} = {c}");
            a = b;
            b = c;
            c = a + b;
        }
    


