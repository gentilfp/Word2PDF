namespace Word2Pdf
{
    partial class frmMain
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
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.btnPathOuput = new System.Windows.Forms.Button();
            this.btnPathInput = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.gbMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.btnConvert);
            this.gbMain.Controls.Add(this.btnPathOuput);
            this.gbMain.Controls.Add(this.btnPathInput);
            this.gbMain.Controls.Add(this.txtOutput);
            this.gbMain.Controls.Add(this.txtInput);
            this.gbMain.Location = new System.Drawing.Point(12, 12);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(437, 143);
            this.gbMain.TabIndex = 4;
            this.gbMain.TabStop = false;
            this.gbMain.Text = "Easy Word to PDF Converter";
            // 
            // btnPathOuput
            // 
            this.btnPathOuput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPathOuput.Location = new System.Drawing.Point(320, 63);
            this.btnPathOuput.Name = "btnPathOuput";
            this.btnPathOuput.Size = new System.Drawing.Size(99, 23);
            this.btnPathOuput.TabIndex = 7;
            this.btnPathOuput.Text = "Output Folder";
            this.btnPathOuput.UseVisualStyleBackColor = true;
            this.btnPathOuput.Click += new System.EventHandler(this.btnPathOuput_Click);
            // 
            // btnPathInput
            // 
            this.btnPathInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPathInput.Location = new System.Drawing.Point(320, 25);
            this.btnPathInput.Name = "btnPathInput";
            this.btnPathInput.Size = new System.Drawing.Size(99, 23);
            this.btnPathInput.TabIndex = 6;
            this.btnPathInput.Text = "Input File";
            this.btnPathInput.UseVisualStyleBackColor = true;
            this.btnPathInput.Click += new System.EventHandler(this.btnPathInput_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(11, 65);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(303, 20);
            this.txtOutput.TabIndex = 5;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(11, 27);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(303, 20);
            this.txtInput.TabIndex = 4;
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(138, 91);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(123, 46);
            this.btnConvert.TabIndex = 8;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 167);
            this.Controls.Add(this.gbMain);
            this.Name = "frmMain";
            this.Text = "Word2PDF";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnPathOuput;
        private System.Windows.Forms.Button btnPathInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TextBox txtInput;
    }
}

