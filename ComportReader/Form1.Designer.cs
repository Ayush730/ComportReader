namespace ComportReader
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.UI_cboPort = new System.Windows.Forms.ComboBox();
            this.UI_btnOpen = new System.Windows.Forms.Button();
            this.UI_btnClose = new System.Windows.Forms.Button();
            this.UI_txSerial = new System.Windows.Forms.RichTextBox();
            this.UI_btnSend = new System.Windows.Forms.Button();
            this.UI_txReceive = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.curSerial = new System.IO.Ports.SerialPort(this.components);
            this.UI_btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port:";
            // 
            // UI_cboPort
            // 
            this.UI_cboPort.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_cboPort.FormattingEnabled = true;
            this.UI_cboPort.Location = new System.Drawing.Point(54, 13);
            this.UI_cboPort.Name = "UI_cboPort";
            this.UI_cboPort.Size = new System.Drawing.Size(114, 21);
            this.UI_cboPort.TabIndex = 1;
            this.UI_cboPort.SelectedIndexChanged += new System.EventHandler(this.UI_cboPort_SelectedIndexChanged);
            // 
            // UI_btnOpen
            // 
            this.UI_btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_btnOpen.Location = new System.Drawing.Point(174, 13);
            this.UI_btnOpen.Name = "UI_btnOpen";
            this.UI_btnOpen.Size = new System.Drawing.Size(75, 23);
            this.UI_btnOpen.TabIndex = 2;
            this.UI_btnOpen.Text = "Open";
            this.UI_btnOpen.UseVisualStyleBackColor = true;
            this.UI_btnOpen.Click += new System.EventHandler(this.UI_btnOpen_Click);
            // 
            // UI_btnClose
            // 
            this.UI_btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_btnClose.Location = new System.Drawing.Point(264, 12);
            this.UI_btnClose.Name = "UI_btnClose";
            this.UI_btnClose.Size = new System.Drawing.Size(75, 23);
            this.UI_btnClose.TabIndex = 3;
            this.UI_btnClose.Text = "Close";
            this.UI_btnClose.UseVisualStyleBackColor = true;
            this.UI_btnClose.Click += new System.EventHandler(this.UI_btnClose_Click);
            // 
            // UI_txSerial
            // 
            this.UI_txSerial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_txSerial.Location = new System.Drawing.Point(54, 44);
            this.UI_txSerial.Name = "UI_txSerial";
            this.UI_txSerial.Size = new System.Drawing.Size(285, 97);
            this.UI_txSerial.TabIndex = 4;
            this.UI_txSerial.Text = "";
            // 
            // UI_btnSend
            // 
            this.UI_btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_btnSend.Location = new System.Drawing.Point(264, 146);
            this.UI_btnSend.Name = "UI_btnSend";
            this.UI_btnSend.Size = new System.Drawing.Size(75, 23);
            this.UI_btnSend.TabIndex = 5;
            this.UI_btnSend.Text = "Send";
            this.UI_btnSend.UseVisualStyleBackColor = true;
            this.UI_btnSend.Click += new System.EventHandler(this.UI_btnSend_Click);
            // 
            // UI_txReceive
            // 
            this.UI_txReceive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_txReceive.Location = new System.Drawing.Point(55, 175);
            this.UI_txReceive.Name = "UI_txReceive";
            this.UI_txReceive.Size = new System.Drawing.Size(284, 132);
            this.UI_txReceive.TabIndex = 6;
            this.UI_txReceive.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Serial:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Receive:";
            // 
            // UI_btnClear
            // 
            this.UI_btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_btnClear.Location = new System.Drawing.Point(264, 313);
            this.UI_btnClear.Name = "UI_btnClear";
            this.UI_btnClear.Size = new System.Drawing.Size(75, 23);
            this.UI_btnClear.TabIndex = 10;
            this.UI_btnClear.Text = "Clear";
            this.UI_btnClear.UseVisualStyleBackColor = true;
            this.UI_btnClear.Click += new System.EventHandler(this.UI_btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 361);
            this.Controls.Add(this.UI_btnClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UI_txReceive);
            this.Controls.Add(this.UI_btnSend);
            this.Controls.Add(this.UI_txSerial);
            this.Controls.Add(this.UI_btnClose);
            this.Controls.Add(this.UI_btnOpen);
            this.Controls.Add(this.UI_cboPort);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(350, 350);
            this.Name = "Form1";
            this.Text = "ComportReader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox UI_cboPort;
        private System.Windows.Forms.Button UI_btnOpen;
        private System.Windows.Forms.Button UI_btnClose;
        private System.Windows.Forms.RichTextBox UI_txSerial;
        private System.Windows.Forms.Button UI_btnSend;
        private System.Windows.Forms.RichTextBox UI_txReceive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.IO.Ports.SerialPort curSerial;
        private System.Windows.Forms.Button UI_btnClear;
    }
}

