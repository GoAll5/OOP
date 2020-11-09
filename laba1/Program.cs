using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace laba1
{
    class Program
    {

        static void Main()
        {

            try
            {


                // "C:\\Users\\1\\Desktop\\Work\\oop\\Pars\\laba1\\"
                Test.Pars();
                Console.Write("Input name file: ");
                string fileName = Console.ReadLine();
                Parser parsini = new Parser(fileName);


                Console.Write("Input section: ");
                string section;
                section = Console.ReadLine();
                string name;
                Console.Write("Input name: ");
                name = Console.ReadLine();
                string type;
                Console.Write("Input type {string/double/int}: ");
                type = Console.ReadLine();


                switch (type)
                {
                    case "string":
                        Console.WriteLine(parsini.GetInfo<string>(section, name));
                        break;
                    case "double":
                        Console.WriteLine(parsini.GetInfo<double>(section, name));
                        break;
                    case "int":
                        Console.WriteLine(parsini.GetInfo<int>(section, name));
                        break;
                    default:
                        throw new Exception(type + ": не является одним из типов(string/int/double)");

                }
            }
            //!
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e);
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("\tОшибка найдена!");
                Console.WriteLine("------------------------------------------------------");
            }
            catch (TypeLoadException e)
            {
                Console.WriteLine(e);
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("\tОшибка найдена!");
                Console.WriteLine("------------------------------------------------------");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("\tОшибка найдена!");
                Console.WriteLine("-------------------------------------------------------");
            }
            //!

        }
    }
}
