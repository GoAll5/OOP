using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Globalization;
using System.ComponentModel;

namespace laba1
{
    internal class Parser
    {
        private Dictionary<SectionName, string> dictSectionValue;

        //!
        private void checkfile(string fileNames)
        {
            if (fileNames.Substring(fileNames.Length - 4, 4) != ".ini")
                throw new TypeLoadException("Файл \"" + fileNames + "\" не является .ini файлом");
        }
        //!
        public Parser(string fileNames)
        {
            checkfile(fileNames);
            var text = new StreamReader(fileNames);

            string readline;
            string section = "";
            string name;
            string value;
            dictSectionValue = new Dictionary<SectionName, string>();

            while (text.Peek() != -1)
            {
                readline = text.ReadLine();
                readline = readline.Replace(" ", "");
                readline = readline.Replace("\t", "");
                if (readline == null || readline.Length == 0 || readline[0] == ';')
                    continue;
                if (readline[0] == '[' && readline[readline.Length - 1] == ']')
                {

                    section = readline.Substring(1, readline.Length - 2);
                    continue;
                }
                else
                {

                    var position = readline.IndexOf("=");
                    name = readline.Substring(0, position);
                    //!
                    value = readline.Substring(position + 1, readline.Length - position - 1);
                    value = value.Replace(".", ",");
                    //!
                    if (value.IndexOf(";") != -1)
                        value = value.Substring(0, value.IndexOf(";"));

                    dictSectionValue.Add(new SectionName(section, name), value);
                }

            }

        }


        //!
        public T GetInfo<T>(string section, string name)
        {
            string value = "";
            SectionName nn = new SectionName(section, name);
            if (dictSectionValue.TryGetValue(nn, out value))
            {
                if (MyTryParse<T>(value))
                    return (T)TypeDescriptor.GetConverter(typeof(T)).ConvertFromString(value); // Convert string -> T
                throw new Exception("Не удалось преобразовать в: " + nameof(T));
            }
            else
                throw new Exception("В секции\"" + section + "\" не удалось найти поле:" + name);
        }
        //!
        private static bool MyTryParse<T>(string input)
        {
            try
            {
                TypeDescriptor.GetConverter(typeof(T)).ConvertFromString(input);
                return true;
            }
            catch
            {
                return false;
            }
        }


    }
}

