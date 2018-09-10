using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeGenerator.Builder;

namespace CodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string outputPath = args[0];
            ActionBuilder builder = new ActionBuilder();
            builder.createAction(outputPath);
        }
    }
}
