/*
 * Marf Flash Player
 * Licence: GNU General Public License v3.0
 * https://github.com/Marfjeh/MFClient/blob/main/LICENSE
 * 
 */

using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MFClient
{
    public partial class Form1 : Form
    {
        private readonly ChromiumWebBrowser browser; 
        readonly string _path = Directory.GetCurrentDirectory();
        readonly string _appdatapath = Environment.SpecialFolder.ApplicationData.ToString();
       

        public Form1()
        {
            InitializeComponent();

            CefSettings settings = new CefSettings();
            settings.UserAgent = Properties.Settings.Default.UserAgent;
            settings.CefCommandLineArgs.Add("enable-npapi", "1");
            settings.CefCommandLineArgs.Add("ppapi-flash-path", _path + "\\pepflashplayer.dll");
            settings.CefCommandLineArgs.Add("ppapi-flash-version", Properties.Settings.Default.PepperFlashPlayerVersion);
            settings.CefCommandLineArgs.Add("persist_session_cookies", "1");
            settings.CefCommandLineArgs.Add("autoplay-policy", "no-user-gesture-required");
            settings.CachePath = System.Environment.GetEnvironmentVariable("APPDATA") + "/MFClient/Cache";

            Cef.EnableHighDPISupport();
            Cef.Initialize(settings);
            browser = new ChromiumWebBrowser(Properties.Settings.Default.URL);
            browserPanel.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
            browser.AddressChanged += Browser_AddressChanged;
            browser.LoadError += Browser_LoadError;
            browser.LoadingStateChanged += Browser_LoadingStateChanged;
            browser.MenuHandler = new MenuHandler();
        }

        private void Browser_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {
            browser.InvokeOnUiThreadIfRequired(delegate ()
            {
                if (browser.IsLoading)
                {
                    loadingPanel.Visible = true;
                }
                else
                {
                    loadingPanel.Visible = false;
                }
            });
        }

        private void Browser_LoadError(object sender, LoadErrorEventArgs e)
        {
            if (MessageBox.Show("I'm sorry. There was a problem loading the page. " + e.ErrorText + " " +  e.ErrorCode + "\n\nDo you want to try again?", Properties.Settings.Default.Window_Title, MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            browser.Load(Properties.Settings.Default.URL);
        }

        private void Browser_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            if (toolPanel.Visible)
            browser.InvokeOnUiThreadIfRequired(delegate ()
            {
                textBox1.Text = e.Address.ToString();
            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = Properties.Settings.Default.Window_Title;
            if (Properties.Settings.Default.ShowNavigationBar)
            {
                toolPanel.Visible = true;
            }
            if (Properties.Settings.Default.ShowDebugMenu)
            {
                debugmenu.Visible = true;
            }

        }

        private void openDevToolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            browser.ShowDevTools();
        }

        private void reloadPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            browser.Reload();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            browser.Back();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            browser.Forward();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            browser.Reload();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            browser.Load("https://www.google.com");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            browser.Load(textBox1.Text);
        }

        private void toolPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            loadingPanel.Visible = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            browser.Dispose();
            Cef.Shutdown();
        }
    }
}
