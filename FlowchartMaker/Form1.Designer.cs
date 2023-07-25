namespace FlowchartMaker
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddStart = new System.Windows.Forms.CheckBox();
            this.btnRemoveLast = new System.Windows.Forms.Button();
            this.txtNodeText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 409);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // btnAddStart
            // 
            this.btnAddStart.AutoSize = true;
            this.btnAddStart.Location = new System.Drawing.Point(659, 415);
            this.btnAddStart.Name = "btnAddStart";
            this.btnAddStart.Size = new System.Drawing.Size(118, 17);
            this.btnAddStart.TabIndex = 1;
            this.btnAddStart.Text = "Start Adding Nodes";
            this.btnAddStart.UseVisualStyleBackColor = true;
            this.btnAddStart.CheckedChanged += new System.EventHandler(this.btnAddStart_CheckedChanged);
            // 
            // btnRemoveLast
            // 
            this.btnRemoveLast.Location = new System.Drawing.Point(22, 415);
            this.btnRemoveLast.Name = "btnRemoveLast";
            this.btnRemoveLast.Size = new System.Drawing.Size(87, 23);
            this.btnRemoveLast.TabIndex = 3;
            this.btnRemoveLast.Text = "Remove Last";
            this.btnRemoveLast.UseVisualStyleBackColor = true;
            this.btnRemoveLast.Click += new System.EventHandler(this.btnRemoveLast_Click);
            // 
            // txtNodeText
            // 
            this.txtNodeText.Enabled = false;
            this.txtNodeText.Location = new System.Drawing.Point(124, 417);
            this.txtNodeText.Multiline = true;
            this.txtNodeText.Name = "txtNodeText";
            this.txtNodeText.Size = new System.Drawing.Size(87, 22);
            this.txtNodeText.TabIndex = 4;
            this.txtNodeText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNodeText.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNodeText);
            this.Controls.Add(this.btnRemoveLast);
            this.Controls.Add(this.btnAddStart);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox btnAddStart;
        private System.Windows.Forms.Button btnRemoveLast;
        private System.Windows.Forms.TextBox txtNodeText;
    }
}

