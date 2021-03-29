using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NameSortWindows
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make a List for the names to occupy
            //String nameListPath;
            String name;
            List<string> nameList = new List<string>();

            try
            {
                //Commented Lines below allow for User Input
                //Console.WriteLine("Please input the path of the file: ");

                ////Read the path of the file
                //nameListPath = Console.ReadLine();

                //StreamReader readFile = new StreamReader(Console.OpenStandardInput());

                //Read each line of the file
                name = Console.ReadLine();

                //While the line is not null, add the name to the list and go to the next line
                string temp = "";
                while (name != null)
                {
                    //Check to make sure there are no spaces around the name
                    foreach (char letter in name)
                    {
                        if (letter != ' ')
                        {
                            temp += letter;
                        }
                    }

                    nameList.Add(temp);

                    name = Console.ReadLine();
                    temp = "";
                }

                if (args[0] == "-s") {
                    //Order the names list, first by length, then alphabetically, then store into new list
                    List<String> sortNameList = new List<string>();
                    sortNameList = nameList.OrderBy(sortName => sortName.Length).ThenBy(sortName => sortName).ToList();

                    //Print out each name in the list in their sorted order
                    foreach (string names in sortNameList)
                    {
                        Console.WriteLine(names);
                    }
                }

                if (args[0] == "-r")
                {
                    //Allow user to reverse the sort if they so choose by typing "Reverse"
                    //Console.WriteLine();
                    //Console.WriteLine("To reverse sort, input \"Reverse\": ");

                    //if (Console.ReadLine() == "Reverse")
                    //{
                    //Initialize new list for the reverse sort, then sort by length, then alphabetically, but descending
                    List<String> reverseNameList = new List<string>();
                    reverseNameList = nameList.OrderByDescending(sortName => sortName.Length).ThenByDescending(sortName => sortName).ToList();

                    //Print out names in their reverse sorted order
                    //Console.WriteLine();

                    foreach (string names in reverseNameList)
                    {
                        Console.WriteLine(names);
                    }
                }

                //Close the file reader
                //readFile.Close();
                //Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}
