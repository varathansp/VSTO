using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FileWatcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Restarting...";
            watch();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            watch();
        }
        private void watch()
        {
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = @"C:\Test\XLSX";
            watcher.NotifyFilter = NotifyFilters.LastWrite;
            //watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite| NotifyFilters.FileName | NotifyFilters.DirectoryName;
            watcher.Filter = "*.*";
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.EnableRaisingEvents = true;
            lblMessage.Text = "Running...";
        }
        private void OnChanged(object source, FileSystemEventArgs e)
        {
            MessageBox.Show("Directory is Accessed : " + e.FullPath +" is created");
            
        }

    }
}
