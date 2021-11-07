
using System;
using System.IO;

namespace CCDE_Ue4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(generateAddUser("C://tmp//4a.txt"));
            Console.WriteLine(generateAddUser("C://tmp//4b.txt"));
            Console.WriteLine(addGroup("C://tmp//4a.txt"));
            Console.WriteLine(addGroup("C://tmp//4b.txt"));
            Console.WriteLine(delUser("C://tmp//4a.txt"));
            Console.WriteLine(delUser("C://tmp//4b.txt"));

    //


            
        }

        public static string generateAddUser(String path)
        {
            
            string command = ""; 
            string f = File.ReadAllText(path);
            f = f.Replace(" ","_");
            f = f.Replace("\t", "_");

            string[] names = f.Split("\n", StringSplitOptions.None);
            
           // Console.WriteLine(names[1]);
            foreach (string name in names)
            {
                //sudo useradd 
                
                string add = "sudo useradd "; 
                
                command += add + name + "\n";
                
            }
            return command;
        }

        public static string delUser(String path)
        {

            string command = "";
            string f = File.ReadAllText(path);
            f = f.Replace(" ", "_");
            f = f.Replace("\t", "_");

            string[] names = f.Split("\n", StringSplitOptions.None);

            // Console.WriteLine(names[1]);
            foreach (string name in names)
            {
                //sudo useradd 

                string add = "sudo userdel ";

                command += add + name + "\n";

            }
            return command;
        }

        public static string addGroup(String path)
        {
            if (path.Equals("C://tmp//4b.txt"))
            {
                string command = "";
                string f = File.ReadAllText(path);
                f = f.Replace(" ", "_");
                f = f.Replace("\t", "_");

                string[] names = f.Split("\n", StringSplitOptions.None);

                // Console.WriteLine(names[1]);
                foreach (string name in names)
                {
                    //sudo useradd 

                    string add = "sudo usermod -G htlinn_4b ";

                    command += add + name + "\n";

                }
                return command;
            } else
            {
                string command = "";
                string f = File.ReadAllText(path);
                f = f.Replace(" ", "_");
                f = f.Replace("\t", "_");

                string[] names = f.Split("\n", StringSplitOptions.None);

                // Console.WriteLine(names[1]);
                foreach (string name in names)
                {
                    //sudo useradd 

                    string add = "sudo usermod -G htlinn_4a ";

                    command += add + name + "\n";

                }
                return command;
            }
            
        }
    }
}
