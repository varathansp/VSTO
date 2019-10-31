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
    public partial class TwoInstance : Form
    {
        public TwoInstance()
        {
            InitializeComponent();
        }
        Microsoft.Office.Interop.Word.Application app1 = new Microsoft.Office.Interop.Word.Application();
        Microsoft.Office.Interop.Word.Application app2 = new Microsoft.Office.Interop.Word.Application();

        
    
        private void btnOpen1_Click(object sender, EventArgs e)
        {
           
               
                app1.Visible = true;
                Document document = app1.Documents.Open(@"C:\Test\Test1.docx");

                MessageBox.Show("File One Opened ");
           
        }

        private void btnOpen2_Click(object sender, EventArgs e)
        {
            app2.Visible = true;
            Document document = app2.Documents.Open(@"C:\Test\Test2.docx");
            MessageBox.Show("File Two Opened ");
        }

        private void btnConnect1_Click(object sender, EventArgs e)
        {
            foreach (Microsoft.Office.Core.COMAddIn CurrentAddin in app1.COMAddIns)
            {
                if (CurrentAddin.Description == "TestAddIn")
                {
                    CurrentAddin.Connect = true;
                }

            }
            MessageBox.Show("AddIn Connected File 1");
        }

        private void btnConnect2_Click(object sender, EventArgs e)
        {
            foreach (Microsoft.Office.Core.COMAddIn CurrentAddin in app2.COMAddIns)
            {
                if (CurrentAddin.Description == "TestAddIn")
                {
                    CurrentAddin.Connect = true;
                }

            }
            MessageBox.Show("AddIn Connected File2");
        }

        private void btnDisconnect1_Click(object sender, EventArgs e)
        {
            foreach (Microsoft.Office.Core.COMAddIn CurrentAddin in app1.COMAddIns)
            {
                if (CurrentAddin.Description == "TestAddIn")
                {
                    CurrentAddin.Connect = false;
                }

            }
            MessageBox.Show("AddIn DisConnected File 1");
        }

        private void btnDisconnect2_Click(object sender, EventArgs e)
        {

            foreach (Microsoft.Office.Core.COMAddIn CurrentAddin in app2.COMAddIns)
            {
                if (CurrentAddin.Description == "TestAddIn")
                {
                    CurrentAddin.Connect = false;
                }

            }
            MessageBox.Show("AddIn DisConnected File2");
        }

        
    }
}
