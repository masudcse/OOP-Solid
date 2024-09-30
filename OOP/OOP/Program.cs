using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            int discount = Convert.ToInt32(Console.ReadLine());

            Dictionary<string, int> coffee = new Dictionary<string, int>();
            coffee.Add("Americano", 50);
            coffee.Add("Latte", 70);
            coffee.Add("Flat White", 60);
            coffee.Add("Espresso", 60);
            coffee.Add("Cappuccino", 80);
            coffee.Add("Mocha", 90);

            string[]stringArray2d = new string[coffee.Count];
            int i = 0;

            foreach (KeyValuePair<string, int> item in coffee)
            {
                stringArray2d[i] = item.Key+':'+' '+(item.Value-((item.Value*discount)/100)).ToString();
                i++;
                
            }

            //for (int item = 0; i < stringArray2d.GetLength(0); item++)
            //{
            //    for (int k = 0; k < stringArray2d.GetLength(1); k++)
            //    {
            //        //put a single value
            //        Console.Write(stringArray2d[item, k]);
            //    }
            //    //next row
            //    Console.WriteLine();
        //}
            foreach (string item in stringArray2d)
            {
                Console.Write("{0} ", item);
                Console.WriteLine();
            }
    //foreach (KeyValuePair<string, int> pair in coffee)
    //{
    //    coffeeDiscount.Add(pair.Key, pair.Value - discount);
    // //   Label1.Text += "Key= " + pair.Key + " | Value= " + pair.Value + "<br />";
    //}

    //Dictionary<string, string> d = new Dictionary<string, string>();
    //d.Add("a", "b");
    //string[] arr;
    //arr = d.Keys.ToArray();

    //Console.WriteLine(arr[,]);
}
    }

  



}
