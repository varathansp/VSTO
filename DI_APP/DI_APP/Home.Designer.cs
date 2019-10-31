namespace DI_APP
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCloseDoc = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.DocumentList = new System.Windows.Forms.ListBox();
            this.btnActiveDoc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(25, 79);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(158, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Browse And Open File";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(25, 204);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(158, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Disconnect AddIn";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCloseDoc
            // 
            this.btnCloseDoc.Location = new System.Drawing.Point(25, 269);
            this.btnCloseDoc.Name = "btnCloseDoc";
            this.btnCloseDoc.Size = new System.Drawing.Size(158, 23);
            this.btnCloseDoc.TabIndex = 2;
            this.btnCloseDoc.Text = "Close";
            this.btnCloseDoc.UseVisualStyleBackColor = true;
            this.btnCloseDoc.Click += new System.EventHandler(this.btnCloseDoc_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(25, 144);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(158, 23);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect AddIn";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // DocumentList
            // 
            this.DocumentList.FormattingEnabled = true;
            this.DocumentList.Location = new System.Drawing.Point(369, 119);
            this.DocumentList.Name = "DocumentList";
            this.DocumentList.Size = new System.Drawing.Size(245, 186);
            this.DocumentList.TabIndex = 6;
            // 
            // btnActiveDoc
            // 
            this.btnActiveDoc.Location = new System.Drawing.Point(369, 79);
            this.btnActiveDoc.Name = "btnActiveDoc";
            this.btnActiveDoc.Size = new System.Drawing.Size(245, 23);
            this.btnActiveDoc.TabIndex = 7;
            this.btnActiveDoc.Text = "Active Documents List";
            this.btnActiveDoc.UseVisualStyleBackColor = true;
            this.btnActiveDoc.Click += new System.EventHandler(this.btnActiveDoc_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 372);
            this.Controls.Add(this.btnActiveDoc);
            this.Controls.Add(this.DocumentList);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnCloseDoc);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpen);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCloseDoc;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ListBox DocumentList;
        private System.Windows.Forms.Button btnActiveDoc;
    }
}