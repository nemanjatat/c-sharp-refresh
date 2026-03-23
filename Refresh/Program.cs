using Refresh;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // List = data structure that represents a list of objects that can be accessed by index.
        //        Similar to array, but can dynamically increase/decrease in size
        //        using System.Collections.Generic;

        List<String> menu = new List<String>();

        menu.Add("govedja bistra supa");
        menu.Add("engleski dorucak");
        menu.Add("kroasan nutela");
        menu.Add("pohovani pileci stapici mala porcija");

        //menu.Remove("engleski dorucak");
        //menu.Insert(0, "biftek natur");
        //Console.WriteLine(menu.Count());
        //Console.WriteLine(menu.IndexOf("kroasan nutela"));
        //menu.Add("kroasan nutela"); Console.WriteLine(menu.LastIndexOf("kroasan nutela"));
        //Console.WriteLine(menu.Contains("engleski dorucak"));
        //menu.Sort();
        //menu.Reverse();
        /*  String[] menuArray = menu.ToArray();
            foreach (String menuItem in menuArray)
            {
                Console.WriteLine(menuItem);
            }
        */

        foreach (String item in menu)
        {
            Console.WriteLine(item);
        }

        Console.ReadLine();
    }
}