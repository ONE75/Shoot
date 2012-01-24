using System;
using System.Drawing.Imaging;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ONE75.Shoot.Core;

namespace ONE75.Shoot.Winforms
{
    public partial class ShowWebPage : Form
    {
        // some of the data on the TomTom site is loaded async. 
        // When the WebBrower control thinks the page is loaded, the page is still loading so I delay the screenshot a little
        private Timer _timer;

        private const string DefaultUrl = "http://routes.tomtom.com";

        /// <summary>
        /// Gets or sets the URL that the webbrowser control will display
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets if a screenshot is created when the webbrowser has loaded the page
        /// </summary>
        public bool TakeScreenShotWhenLoaded { get; set; }

        public ShowWebPage()
        {
            this.Url = DefaultUrl;
            this.TakeScreenShotWhenLoaded = true; // default

            InitializeComponent();

            _timer = new Timer { Interval = 1000 };
            _timer.Tick += (s, ea) => CaptureScreenAndDuration();

            browser.DocumentCompleted += this.OnDocumentLoaded;
        }

        protected override void OnLoad(EventArgs e)
        {
            Run();
        }

        public void Run()
        {
            txtUrl.Text = this.Url;
            browser.Url = new Uri(txtUrl.Text);
        }

        private void OnDocumentLoaded(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (browser.ReadyState != WebBrowserReadyState.Complete)
                return;

            _timer.Start();
        }

        void CaptureScreenAndDuration()
        {
            _timer.Stop();

            if (browser.Document != null && browser.Document.Body != null)
                ShowDuration(browser.Document.Body.InnerText);

            Shoot();
        }

        void Shoot()
        {
            if (!this.TakeScreenShotWhenLoaded)
                return;

            var sc = new ScreenCapture();

            // capture this window, and save it
            bool notifyAfterSave;
            var fileName = GetFullPath(out notifyAfterSave);
           
            try
            {
                sc.CaptureWindowToFile(this.Handle, fileName, ImageFormat.Gif);
                if (notifyAfterSave)
                    MessageBox.Show(string.Format("Your screenshot is saved here: {0}", fileName), "Saved",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("An error has occurred while saving your screenshot", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string GetFullPath(out bool notify)
        {
            notify = false;

            string desktopFolder = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string fileName = string.Format("{0}.gif", DateTime.Now.ToString("yyyy-MM-dd HH_mm"));
            string targetFolder = Path.Combine(desktopFolder, "Shoot");

            if (!Directory.Exists(targetFolder))
            {
                Directory.CreateDirectory(targetFolder);
                notify = true;
            }

            string fullPath = Path.Combine(targetFolder, fileName);
            return fullPath;
        }

        private void ShowDuration(string textToSearch)
        {
            if (string.IsNullOrEmpty(textToSearch))
                return;

            var durationPattern = @"\d{1,}:\d{2}\s(hrs)"; // looks for text in the xx:xx hrs format
            var regex = new Regex(durationPattern);

            var match = regex.Match(textToSearch);
            var matches = 0;

            while (match.Success)
            {
                var subString = match.Groups[matches];
                statusLabel.Text = subString.Value;
                matches++;
                match = match.NextMatch();
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            this.Url = txtUrl.Text;
            Run();
        }

        private void miAbout_Click(object sender, EventArgs e)
        {
            var about = new About();
            about.ShowDialog(this);

        }
    }
}