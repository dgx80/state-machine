using System;
using System.Collections.Generic;
using System.Text;
using CodeGenerator.Template;

namespace CodeGenerator.Builder
{
    class ActionBuilder
    {
        ClassTemplate fileTemplate;

        public ActionBuilder()
        {
        }

        public void createAction(string outputPath)
        {
            string s;
            Console.WriteLine("namespace?");
            string namespaceName = Console.ReadLine();
            Console.WriteLine("action name?");
            string actionName = Console.ReadLine();
            Console.WriteLine("run one time?");
            s = Console.ReadLine();
            bool isOnce = bool.Parse(s);

            actionName = actionName.Substring(0, 1).ToUpper() + actionName.Substring(1);
            string className = actionName + "Action";
            fileTemplate = new ClassTemplate(Properties.Resources.Action, outputPath);
            fileTemplate.replace("%namepsace_name%", namespaceName);
            fileTemplate.replace("%class_name%", className);
            fileTemplate.replace("%is_once%", isOnce.ToString().ToLower());
            fileTemplate.write(className);
        }
    }
}
