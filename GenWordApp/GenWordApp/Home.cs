using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace GenWordApp
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        Microsoft.Office.Interop.Word.Application SystemInstance = new Microsoft.Office.Interop.Word.Application();
        Microsoft.Office.Interop.Word.Application AppInstance;
        OpenFileDialog openFileDialog = new OpenFileDialog();

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                AppInstance = new Microsoft.Office.Interop.Word.Application();
                AppInstance.Visible = true;
                AppInstance.Caption = "GenWord";
                foreach(Microsoft.Office.Core.COMAddIn CurrentAddin in AppInstance.COMAddIns)
                {
                    if (CurrentAddin.Description == "GWAddIn")
                    {
                        CurrentAddin.Connect = false;
                        CurrentAddin.Connect = true;
                    }
                }
                Document document = AppInstance.Documents.Open(openFileDialog.FileName);
                MessageBox.Show("File Opened");

            }
        }
    }
}
