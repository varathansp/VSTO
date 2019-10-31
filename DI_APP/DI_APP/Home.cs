using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;



namespace DI_APP
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            SystemInstance = new Microsoft.Office.Interop.Word.Application();
            SystemInstance.DocumentBeforeClose += System_DocumentBeforeClose;
            AppInstance = new Microsoft.Office.Interop.Word.Application();
            AppInstance.DocumentBeforeClose += Application_DocumentBeforeClose;
            openFileDialog.Filter = "DOCX|*.docx";

        }

        Microsoft.Office.Interop.Word.Application SystemInstance;//= new Microsoft.Office.Interop.Word.Application();
        Microsoft.Office.Interop.Word.Application AppInstance;//= new Microsoft.Office.Interop.Word.Application();
        OpenFileDialog openFileDialog = new OpenFileDialog();


        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    AppInstance.Visible = true;
                    AppInstance.Caption = "GenWord";
                    foreach (Microsoft.Office.Core.COMAddIn CurrentAddin in AppInstance.COMAddIns)
                    {
                        if (CurrentAddin.Description == "TestAddIn")
                        {
                            CurrentAddin.Connect = false;
                            CurrentAddin.Connect = true;
                        }
                    }
                    Document document = AppInstance.Documents.Open(openFileDialog.FileName);
                    MessageBox.Show("File Opened");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void Application_DocumentBeforeClose(Document Doc, ref bool Cancel)
        {
            if (AppInstance.Documents.Count == 1)
            {
                AppInstance = new Microsoft.Office.Interop.Word.Application();
                AppInstance.DocumentBeforeClose += Application_DocumentBeforeClose;
            }
        }
        void System_DocumentBeforeClose(Document Doc, ref bool Cancel)
        {
            if (SystemInstance.Documents.Count == 1)
            {
                SystemInstance = new Microsoft.Office.Interop.Word.Application();
                SystemInstance.DocumentBeforeClose += System_DocumentBeforeClose;
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            foreach (Microsoft.Office.Core.COMAddIn CurrentAddin in AppInstance.COMAddIns)
            {
                if (CurrentAddin.Description == "TestAddIn")
                {
                    CurrentAddin.Connect = true;
                }

            }
            MessageBox.Show("AddIn Connected");
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            foreach (Microsoft.Office.Core.COMAddIn CurrentAddin in AppInstance.COMAddIns)
            {
                if (CurrentAddin.Description == "TestAddIn")
                {
                    CurrentAddin.Connect = false;
                }

            }
            MessageBox.Show("AddIn Disconnected");

        }

        private void btnCloseDoc_Click(object sender, EventArgs e)
        {
            if (AppInstance.Documents.Count == 0)
            {
                AppInstance.Quit();
            }
            if (SystemInstance.Documents.Count == 0)
            {
                SystemInstance.Quit();
            }
            this.Close();
        }

        private void btnActiveDoc_Click(object sender, EventArgs e)
        {
            DocumentList.Items.Clear();
            if (AppInstance != null)
            {
                foreach (Document Doc in AppInstance.Documents)
                {
                    DocumentList.Items.Add("Through App :: " + Doc.Name);
                }
            }
            if (SystemInstance != null)
            {
                foreach (Document Doc in SystemInstance.Documents)
                {
                    DocumentList.Items.Add("Direct System :: " + Doc.Name);
                }
            }

        }

    }
}
