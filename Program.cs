using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Clipboard.SetText("design.patterns20cc");
            FacebookService.s_UseForamttedToStrings = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FacebookServiceSingleton facebookServiceSingleton = FacebookServiceSingleton.Instance;
            FormMain formMain = new FormMain(facebookServiceSingleton);
            formMain.Subscribe(formMain);
            Application.Run(formMain);
        }
    }
}
