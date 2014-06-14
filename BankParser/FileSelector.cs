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

namespace BankParser
{
    public partial class FileSelector : Form
    {
        private Parser _parser;
        private string _transactionText;

        public string TransactionText 
        {
            get { return _transactionText; }
            set
            {
                _transactionText = value;
                rtbTransactionData.Text = value;

                if (string.IsNullOrWhiteSpace(value))
                    btnCopyToClipboard.Enabled = false;
                else
                    btnCopyToClipboard.Enabled = true;
            }
        }

        public FileSelector()
        {
            _parser = new Parser();

            InitializeComponent();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            string filename = "";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                filename = Path.GetFullPath(fileDialog.FileName);
                txbFilename.Text = filename;
            }
        }

        private void btnCopyToClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(TransactionText);
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            if (_parser != null && !string.IsNullOrWhiteSpace(txbFilename.Text))
            {
                TransactionText = _parser.Parse(txbFilename.Text, dteDateFrom.Value.Date, dteDateTo.Value.Date);
            }
        }
    }
}
