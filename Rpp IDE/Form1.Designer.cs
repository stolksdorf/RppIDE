namespace Rpp_IDE
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbFunctions = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.cbCompile = new System.Windows.Forms.CheckBox();
            this.Save = new System.Windows.Forms.Button();
            this.btnCompile = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tbRpp = new System.Windows.Forms.TextBox();
            this.tbRsl = new System.Windows.Forms.TextBox();
            this.tbErrors = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lbFunctions);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btnOpen);
            this.splitContainer1.Panel1.Controls.Add(this.cbCompile);
            this.splitContainer1.Panel1.Controls.Add(this.Save);
            this.splitContainer1.Panel1.Controls.Add(this.btnCompile);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(681, 416);
            this.splitContainer1.SplitterDistance = 99;
            this.splitContainer1.TabIndex = 0;
            // 
            // lbFunctions
            // 
            this.lbFunctions.FormattingEnabled = true;
            this.lbFunctions.Location = new System.Drawing.Point(12, 148);
            this.lbFunctions.Name = "lbFunctions";
            this.lbFunctions.Size = new System.Drawing.Size(75, 95);
            this.lbFunctions.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Functions";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(15, 64);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(53, 23);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // cbCompile
            // 
            this.cbCompile.AutoSize = true;
            this.cbCompile.Location = new System.Drawing.Point(12, 41);
            this.cbCompile.Name = "cbCompile";
            this.cbCompile.Size = new System.Drawing.Size(88, 17);
            this.cbCompile.TabIndex = 2;
            this.cbCompile.Text = "Auto-Compile";
            this.cbCompile.UseVisualStyleBackColor = true;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(15, 93);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(53, 23);
            this.Save.TabIndex = 1;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // btnCompile
            // 
            this.btnCompile.Location = new System.Drawing.Point(12, 12);
            this.btnCompile.Name = "btnCompile";
            this.btnCompile.Size = new System.Drawing.Size(75, 23);
            this.btnCompile.TabIndex = 0;
            this.btnCompile.Text = "Compile";
            this.btnCompile.UseVisualStyleBackColor = true;
            this.btnCompile.Click += new System.EventHandler(this.btnCompile_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tbRpp);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tbRsl);
            this.splitContainer2.Panel2.Controls.Add(this.tbErrors);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Size = new System.Drawing.Size(578, 416);
            this.splitContainer2.SplitterDistance = 306;
            this.splitContainer2.TabIndex = 0;
            // 
            // tbRpp
            // 
            this.tbRpp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbRpp.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRpp.Location = new System.Drawing.Point(0, 0);
            this.tbRpp.Multiline = true;
            this.tbRpp.Name = "tbRpp";
            this.tbRpp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRpp.Size = new System.Drawing.Size(306, 416);
            this.tbRpp.TabIndex = 0;
            this.tbRpp.TextChanged += new System.EventHandler(this.tbRpp_TextChanged);
            // 
            // tbRsl
            // 
            this.tbRsl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRsl.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRsl.Location = new System.Drawing.Point(3, 3);
            this.tbRsl.Multiline = true;
            this.tbRsl.Name = "tbRsl";
            this.tbRsl.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRsl.Size = new System.Drawing.Size(262, 303);
            this.tbRsl.TabIndex = 9;
            // 
            // tbErrors
            // 
            this.tbErrors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbErrors.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbErrors.Location = new System.Drawing.Point(2, 325);
            this.tbErrors.Multiline = true;
            this.tbErrors.Name = "tbErrors";
            this.tbErrors.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbErrors.Size = new System.Drawing.Size(263, 79);
            this.tbErrors.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Errors";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "R++ Files|*.rpp|R++ Library File|*.rll|RSL Files|*.prg|All Files|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "RSL File|*.prg";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 416);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "R++ Compiler IDE";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox lbFunctions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.CheckBox cbCompile;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button btnCompile;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox tbRpp;
        private System.Windows.Forms.TextBox tbErrors;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRsl;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;

    }
}

