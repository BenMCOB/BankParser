namespace BankParser
{
    partial class FileSelector
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
            this.txbFilename = new System.Windows.Forms.TextBox();
            this.rtbTransactionData = new System.Windows.Forms.RichTextBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.btnCopyToClipboard = new System.Windows.Forms.Button();
            this.lblTransactionData = new System.Windows.Forms.Label();
            this.lblFilename = new System.Windows.Forms.Label();
            this.dteDateFrom = new System.Windows.Forms.DateTimePicker();
            this.dteDateTo = new System.Windows.Forms.DateTimePicker();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.btnParse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbFilename
            // 
            this.txbFilename.Location = new System.Drawing.Point(47, 45);
            this.txbFilename.Name = "txbFilename";
            this.txbFilename.Size = new System.Drawing.Size(588, 22);
            this.txbFilename.TabIndex = 0;
            // 
            // rtbTransactionData
            // 
            this.rtbTransactionData.Location = new System.Drawing.Point(26, 177);
            this.rtbTransactionData.Name = "rtbTransactionData";
            this.rtbTransactionData.Size = new System.Drawing.Size(719, 156);
            this.rtbTransactionData.TabIndex = 2;
            this.rtbTransactionData.Text = "";
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(658, 39);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(87, 34);
            this.btnSelectFile.TabIndex = 3;
            this.btnSelectFile.Text = "Select File";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // btnCopyToClipboard
            // 
            this.btnCopyToClipboard.Location = new System.Drawing.Point(47, 367);
            this.btnCopyToClipboard.Name = "btnCopyToClipboard";
            this.btnCopyToClipboard.Size = new System.Drawing.Size(89, 50);
            this.btnCopyToClipboard.TabIndex = 4;
            this.btnCopyToClipboard.Text = "Copy to clipboard";
            this.btnCopyToClipboard.UseVisualStyleBackColor = true;
            this.btnCopyToClipboard.Click += new System.EventHandler(this.btnCopyToClipboard_Click);
            // 
            // lblTransactionData
            // 
            this.lblTransactionData.AutoSize = true;
            this.lblTransactionData.Location = new System.Drawing.Point(23, 157);
            this.lblTransactionData.Name = "lblTransactionData";
            this.lblTransactionData.Size = new System.Drawing.Size(121, 17);
            this.lblTransactionData.TabIndex = 5;
            this.lblTransactionData.Text = "Transaction Data:";
            // 
            // lblFilename
            // 
            this.lblFilename.AutoSize = true;
            this.lblFilename.Location = new System.Drawing.Point(44, 25);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(119, 17);
            this.lblFilename.TabIndex = 6;
            this.lblFilename.Text = "Bank file location:";
            // 
            // dteDateFrom
            // 
            this.dteDateFrom.Location = new System.Drawing.Point(128, 92);
            this.dteDateFrom.Name = "dteDateFrom";
            this.dteDateFrom.Size = new System.Drawing.Size(200, 22);
            this.dteDateFrom.TabIndex = 7;
            // 
            // dteDateTo
            // 
            this.dteDateTo.Location = new System.Drawing.Point(418, 92);
            this.dteDateTo.Name = "dteDateTo";
            this.dteDateTo.Size = new System.Drawing.Size(200, 22);
            this.dteDateTo.TabIndex = 8;
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.Location = new System.Drawing.Point(44, 97);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(78, 17);
            this.lblDateFrom.TabIndex = 9;
            this.lblDateFrom.Text = "Date From:";
            // 
            // lblDateTo
            // 
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.Location = new System.Drawing.Point(349, 97);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(63, 17);
            this.lblDateTo.TabIndex = 10;
            this.lblDateTo.Text = "Date To:";
            // 
            // btnParse
            // 
            this.btnParse.Location = new System.Drawing.Point(658, 87);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(87, 36);
            this.btnParse.TabIndex = 11;
            this.btnParse.Text = "Parse";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // FileSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 448);
            this.Controls.Add(this.btnParse);
            this.Controls.Add(this.lblDateTo);
            this.Controls.Add(this.lblDateFrom);
            this.Controls.Add(this.dteDateTo);
            this.Controls.Add(this.dteDateFrom);
            this.Controls.Add(this.lblFilename);
            this.Controls.Add(this.lblTransactionData);
            this.Controls.Add(this.btnCopyToClipboard);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.rtbTransactionData);
            this.Controls.Add(this.txbFilename);
            this.Name = "FileSelector";
            this.Text = "FileSelector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbFilename;
        private System.Windows.Forms.RichTextBox rtbTransactionData;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Button btnCopyToClipboard;
        private System.Windows.Forms.Label lblTransactionData;
        private System.Windows.Forms.Label lblFilename;
        private System.Windows.Forms.DateTimePicker dteDateFrom;
        private System.Windows.Forms.DateTimePicker dteDateTo;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.Button btnParse;
    }
}