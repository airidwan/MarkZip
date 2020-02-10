using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarkZip {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            if(!System.Diagnostics.Debugger.IsAttached) {
                //var DllFiles = new DirectoryInfo(".\\Lib").GetFiles("*.dll");

                //AppDomain.CurrentDomain.AssemblyResolve += (sender, args) => {
                //    var dll =  Properties.Resources.ResourceManager.GetObject(args.Name); //DllFiles.FirstOrDefault(fi => fi.Name == args.Name);
                //    if(dll == null) {
                //        return null;
                //    }
                //    //Assembly.Load()
                //    return Assembly.Load(dll.ToString());
                //};
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FMain());
        }
    }
}
