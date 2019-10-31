namespace DI_APP
{
    partial class TwoInstance
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
            this.btnOpen1 = new System.Windows.Forms.Button();
            this.btnOpen2 = new System.Windows.Forms.Button();
            this.btnConnect2 = new System.Windows.Forms.Button();
            this.btnConnect1 = new System.Windows.Forms.Button();
            this.btnDisconnect1 = new System.Windows.Forms.Button();
            this.btnDisconnect2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpen1
            // 
            this.btnOpen1.Location = new System.Drawing.Point(12, 51);
            this.btnOpen1.Name = "btnOpen1";
            this.btnOpen1.Size = new System.Drawing.Size(126, 23);
            this.btnOpen1.TabIndex = 0;
            this.btnOpen1.Text = "Open Doc 1";
            this.btnOpen1.UseVisualStyleBackColor = true;
            this.btnOpen1.Click += new System.EventHandler(this.btnOpen1_Click);
            // 
            // btnOpen2
            // 
            this.btnOpen2.Location = new System.Drawing.Point(197, 51);
            this.btnOpen2.Name = "btnOpen2";
            this.btnOpen2.Size = new System.Drawing.Size(135, 23);
            this.btnOpen2.TabIndex = 1;
            this.btnOpen2.Text = "Open Doc 2";
            this.btnOpen2.UseVisualStyleBackColor = true;
            this.btnOpen2.Click += new System.EventHandler(this.btnOpen2_Click);
            // 
            // btnConnect2
            // 
            this.btnConnect2.Location = new System.Drawing.Point(197, 110);
            this.btnConnect2.Name = "btnConnect2";
            this.btnConnect2.Size = new System.Drawing.Size(135, 23);
            this.btnConnect2.TabIndex = 2;
            this.btnConnect2.Text = "Connect Doc 2";
            this.btnConnect2.UseVisualStyleBackColor = true;
            this.btnConnect2.Click += new System.EventHandler(this.btnConnect2_Click);
            // 
            // btnConnect1
            // 
            this.btnConnect1.Location = new System.Drawing.Point(12, 110);
            this.btnConnect1.Name = "btnConnect1";
            this.btnConnect1.Size = new System.Drawing.Size(126, 23);
            this.btnConnect1.TabIndex = 3;
            this.btnConnect1.Text = "Connect Doc 1";
            this.btnConnect1.UseVisualStyleBackColor = true;
            this.btnConnect1.Click += new System.EventHandler(this.btnConnect1_Click);
            // 
            // btnDisconnect1
            // 
            this.btnDisconnect1.Location = new System.Drawing.Point(12, 168);
            this.btnDisconnect1.Name = "btnDisconnect1";
            this.btnDisconnect1.Size = new System.Drawing.Size(126, 23);
            this.btnDisconnect1.TabIndex = 4;
            this.btnDisconnect1.Text = "Disconnect Doc 1";
            this.btnDisconnect1.UseVisualStyleBackColor = true;
            this.btnDisconnect1.Click += new System.EventHandler(this.btnDisconnect1_Click);
            // 
            // btnDisconnect2
            // 
            this.btnDisconnect2.Location = new System.Drawing.Point(197, 168);
            this.btnDisconnect2.Name = "btnDisconnect2";
            this.btnDisconnect2.Size = new System.Drawing.Size(135, 23);
            this.btnDisconnect2.TabIndex = 5;
            this.btnDisconnect2.Text = "Disconnect Doc 2";
            this.btnDisconnect2.UseVisualStyleBackColor = true;
            this.btnDisconnect2.Click += new System.EventHandler(this.btnDisconnect2_Click);
            // 
            // TwoInstance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 235);
            this.Controls.Add(this.btnDisconnect2);
            this.Controls.Add(this.btnDisconnect1);
            this.Controls.Add(this.btnConnect1);
            this.Controls.Add(this.btnConnect2);
            this.Controls.Add(this.btnOpen2);
            this.Controls.Add(this.btnOpen1);
            this.Name = "TwoInstance";
            this.Text = "TwoInstance";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpen1;
        private System.Windows.Forms.Button btnOpen2;
        private System.Windows.Forms.Button btnConnect2;
        private System.Windows.Forms.Button btnConnect1;
        private System.Windows.Forms.Button btnDisconnect1;
        private System.Windows.Forms.Button btnDisconnect2;
    }
}