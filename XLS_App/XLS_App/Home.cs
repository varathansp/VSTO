using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.IO;

namespace XLS_App
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private void Home_Load(object sender, EventArgs e)
        {
            Load_Files();
        }
        public void Load_Files()
        {
            string[] fileEntries = Directory.GetFiles(@"C:\Test\XLSX");
            foreach (string fileName in fileEntries)
            {
                FileListBox.Items.Add(fileName);
            }
        }
       
        private void btnXLS_Click(object sender, EventArgs e)
        {

            Microsoft.Office.Interop.Excel.Application ExcelApp= new Microsoft.Office.Interop.Excel.Application();
            ExcelApp.Visible = false;
            Microsoft.Office.Interop.Excel.Workbook oWB = (Microsoft.Office.Interop.Excel.Workbook)(ExcelApp.Workbooks.Add(""));
            Microsoft.Office.Interop.Excel.Worksheet oSheet;
            oSheet = oWB.ActiveSheet;
        
                oSheet.Cells[1, 1] = "Policy No";
                oSheet.Cells[1, 2] = "Holder Name";
                oSheet.Cells[1, 3] = "Coverage";
                oSheet.Cells[1, 4] = "Years";
                oSheet.Cells[1, 5] = "Premium";
                oSheet.Cells[1, 6] = "Status";

               
                string[] ValueString = new string[6];

                ValueString[0] = textPolicyNo.Text;
                ValueString[1] = textHolderName.Text;
                ValueString[2] = textCoverage.Text;
                ValueString[3] = textYears.Text;
                ValueString[4] = textPremium.Text;
                ValueString[5] = StatusBox.SelectedItem.ToString();

                //Fill A2:B6 with an array of values (First and Last Names).
                oSheet.get_Range("A2", "F2").Value2 = ValueString;

                ExcelApp.Visible = false;
                ExcelApp.UserControl = false;
                oWB.SaveAs("c:\\test\\XLSX\\PL"+textPolicyNo.Text+".xlsx", Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing,
                    false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                oWB.Close();
                ExcelApp.Quit();
                MessageBox.Show("XLSX File Created");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FileListBox.Items.Clear();
            Load_Files();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {

            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Workbook xlWorkbook = ExcelApp.Workbooks.Open(FileListBox.SelectedItem.ToString());
            Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Range xlRange = xlWorksheet.UsedRange;
            DetailsListBox.Items.Clear();
            for (int i = 0; i < 6; i++)
            {
                DetailsListBox.Items.Add(xlRange.Cells[2, i+1].Value2.ToString());
            }
            ExcelApp.Quit();
          
        }
       
        
    }
}
