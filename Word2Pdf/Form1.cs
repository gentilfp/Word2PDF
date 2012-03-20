using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using Microsoft.Office.Interop.Word;

namespace Word2Pdf
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void ClearTextBoxes()
        {
            txtInput.Clear();
            txtOutput.Clear();
        }

        private void btnPathInput_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtInput.Text = dlg.FileName;
            }
        }

        private void btnPathOuput_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtOutput.Text = dlg.SelectedPath;
            }
        }

        private void ConvertWord2PDF(string inputFile, string outputPath)
        {
            try
            {
                if (outputPath.Equals("") || !File.Exists(inputFile))
                {
                    throw new Exception("Either file does not exist or invalid output path");
                }

                // app to open the document belower
                Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
                Document wordDocument = new Document();

                // input variables
                object objInputFile = inputFile;
                object missParam = Type.Missing;                
                
                wordDocument = wordApp.Documents.Open(ref objInputFile, ref missParam, ref missParam, ref missParam,
                    ref missParam, ref missParam, ref missParam, ref missParam, ref missParam, ref missParam,
                    ref missParam, ref missParam, ref missParam, ref missParam, ref missParam, ref missParam);

                if (wordDocument != null)
                {
                    // make the convertion
                    wordDocument.ExportAsFixedFormat(outputPath, WdExportFormat.wdExportFormatPDF, false,
                        WdExportOptimizeFor.wdExportOptimizeForOnScreen, WdExportRange.wdExportAllDocument,
                        0, 0, WdExportItem.wdExportDocumentContent, true, true, 
                        WdExportCreateBookmarks.wdExportCreateWordBookmarks, true, true, false, ref missParam);                                                    
                }

                // close document and quit application
                wordDocument.Close();
                wordApp.Quit();

                MessageBox.Show("File successfully converted");
                ClearTextBoxes();
            }
            catch (Exception e)
            {                
                throw e;
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            ConvertWord2PDF(txtInput.Text, txtOutput.Text + "\\newPdf.pdf");
        }
    }
}
