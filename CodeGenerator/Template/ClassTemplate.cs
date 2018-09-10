using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CodeGenerator.Template
{
    class ClassTemplate
    {
        private string basePath;
        private string content;
        private string path;
        private string outputPath;

        public ClassTemplate(string aPath, string aOutputPath)
        {
            path = aPath;
            basePath = AppDomain.CurrentDomain.BaseDirectory;
            outputPath = aOutputPath;
        }

        public void replace(string old, string newstr)
        {
            content = content.Replace(old, newstr);
        }

        public void read()
        {
            string filename = basePath + @"\Template\" + path;
            Console.WriteLine("Read class template from " + filename);
            StreamReader sr = new StreamReader(filename);
            content = sr.ReadToEnd();
            sr.Close();
        }

        public void write(string filename)
        {
            filename = outputPath + "\\" + filename + ".cs";
            StreamWriter sw = new StreamWriter(filename);
            sw.Write(content);
            sw.Close();
            Console.WriteLine("Write class template as " + filename);
        }
    }
}
