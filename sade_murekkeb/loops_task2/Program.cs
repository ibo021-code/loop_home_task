using System.ComponentModel.Design;
using System;
Console.WriteLine("Eded daxil edin:");
int num = Convert.ToInt32(Console.ReadLine());
if (num <= 1)
{
    Console.WriteLine("eded ne sadedir ne murekkkeb");
}
else
{
    bool sadeEdeddir = true;
    for (int i = 2; i < num; i++)
    {
        if (num % i == 0)
        {
            sadeEdeddir = false;
        }
    
        
    }
    if(sadeEdeddir)
    {
        Console.WriteLine("eded sade ededdir");
    }
    else
    {
        Console.WriteLine("eded murekkeb ededdir");
    }
}

    