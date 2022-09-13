using System;
using System.IO;

namespace FastCode
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Log.Title("FastCode 1.0", ConsoleColor.DarkCyan);
                string makefile_path = "";
                bool force = false;
                if (args.Length == 0)
                {
                    Log.Text("Informe o arquivo makefile:", ConsoleColor.Blue);
                    makefile_path = Console.ReadLine();
                }
                else if (args.Length >= 1)
                {
                    makefile_path = args[0];
                    if (args.Length == 2) {
                        force = args[1] == "-force";
                    }
                }

                

                helpers.Compiler compiler = new helpers.Compiler();
                compiler.LoadMakefile(makefile_path);
                compiler.LoadProject();
                compiler.LoadTemplates();
                compiler.Build(force);

            } catch (Exception ex) {
                Log.Error(ex.Message);
            }
            
        }
    }
}
