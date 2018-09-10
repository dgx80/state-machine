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
        private string content;
        private string outputPath;

        public ClassTemplate(string aContent, string aOutputPath)
        {
            content = aContent;
            outputPath = aOutputPath;
        }

        public void replace(string old, string newstr)
        {
            content = content.Replace(old, newstr);
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
