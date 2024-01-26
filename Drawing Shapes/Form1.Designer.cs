namespace Drawing_Shapes
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
            this.DrawingPanel = new System.Windows.Forms.Panel();
            this.lstbxCordinations = new System.Windows.Forms.ListBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.btnAddCodrd = new System.Windows.Forms.Button();
            this.btnDraw = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditCord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DrawingPanel
            // 
            this.DrawingPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DrawingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DrawingPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.DrawingPanel.Location = new System.Drawing.Point(0, 0);
            this.DrawingPanel.Name = "DrawingPanel";
            this.DrawingPanel.Size = new System.Drawing.Size(450, 450);
            this.DrawingPanel.TabIndex = 0;
            this.DrawingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lstbxCordinations
            // 
            this.lstbxCordinations.Dock = System.Windows.Forms.DockStyle.Right;
            this.lstbxCordinations.FormattingEnabled = true;
            this.lstbxCordinations.Location = new System.Drawing.Point(663, 0);
            this.lstbxCordinations.Name = "lstbxCordinations";
            this.lstbxCordinations.Size = new System.Drawing.Size(137, 450);
            this.lstbxCordinations.TabIndex = 1;
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(519, 127);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(133, 20);
            this.txtX.TabIndex = 2;
            this.txtX.TextChanged += new System.EventHandler(this.txtX_TextChanged);
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(519, 158);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(133, 20);
            this.txtY.TabIndex = 2;
            this.txtY.TextChanged += new System.EventHandler(this.txtY_TextChanged);
            // 
            // btnAddCodrd
            // 
            this.btnAddCodrd.Enabled = false;
            this.btnAddCodrd.Location = new System.Drawing.Point(481, 212);
            this.btnAddCodrd.Name = "btnAddCodrd";
            this.btnAddCodrd.Size = new System.Drawing.Size(171, 23);
            this.btnAddCodrd.TabIndex = 3;
            this.btnAddCodrd.Text = ">>";
            this.btnAddCodrd.UseVisualStyleBackColor = true;
            this.btnAddCodrd.Click += new System.EventHandler(this.btnAddCodrd_Click);
            // 
            // btnDraw
            // 
            this.btnDraw.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDraw.Location = new System.Drawing.Point(450, 351);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(213, 99);
            this.btnDraw.TabIndex = 4;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(490, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "X = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(490, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Y =";
            // 
            // btnEditCord
            // 
            this.btnEditCord.Location = new System.Drawing.Point(481, 241);
            this.btnEditCord.Name = "btnEditCord";
            this.btnEditCord.Size = new System.Drawing.Size(171, 23);
            this.btnEditCord.TabIndex = 3;
            this.btnEditCord.Text = "<<";
            this.btnEditCord.UseVisualStyleBackColor = true;
            this.btnEditCord.Click += new System.EventHandler(this.btnEditCodrd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.btnEditCord);
            this.Controls.Add(this.btnAddCodrd);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.lstbxCordinations);
            this.Controls.Add(this.DrawingPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel DrawingPanel;
        private System.Windows.Forms.ListBox lstbxCordinations;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Button btnAddCodrd;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEditCord;
    }
}

