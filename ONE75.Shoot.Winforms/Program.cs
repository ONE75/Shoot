using System;
using System.Linq;
using System.Windows.Forms;

namespace ONE75.Shoot.Winforms
{
    internal static class Program
    {
        private const string TooMuchParametersErrorMessage =
            "You've specified more than one parameter. I'm only going to look for the '/url=' parameter";

        private const string UnknownParameterErrorMessage =
            "You've specified an unknown parameter. I known only the '/url=' parameter";

        private const string UrlParameter = "/url=";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var swp = new ShowWebPage();

            if (args.Any())
            {
                bool moreThanOneParameter = args.Count() > 1;

                if (moreThanOneParameter)
                    MessageBox.Show(TooMuchParametersErrorMessage);
                
                // try to get the parameter and set URL
                var urlArgument = args.FirstOrDefault(arg => arg.StartsWith(UrlParameter));
                if (urlArgument == null)
                {
                    MessageBox.Show(UnknownParameterErrorMessage);
                    swp.TakeScreenShotWhenLoaded = false;
                }
                else
                {
                    swp.Url = urlArgument.Substring(UrlParameter.Length); // strip the '/url=' part
                }
            }
            Application.Run(swp);
        }
    }
}