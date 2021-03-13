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
            String nameListPath;
            String name;
            List<string> nameList = new List<string>();

            try
            {
                Console.WriteLine("Please input the path of the file: ");

                //Read the path of the file
                nameListPath = Console.ReadLine();

                StreamReader readFile = new StreamReader(nameListPath);

                //Read each line of the file
                name = readFile.ReadLine();

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

                    name = readFile.ReadLine();
                    temp = "";
                }

                //Order the names list, first by length, then alphabetically
                nameList = nameList.OrderBy(sortName => sortName.Length).ThenBy(sortName => sortName).ToList();

                //Print out each name in the list in their sorted order
                foreach (string names in nameList)
                {
                    Console.WriteLine(names);
                }

                //Close the file reader
                readFile.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}
