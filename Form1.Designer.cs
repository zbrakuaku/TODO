namespace ToDO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label6 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            label8 = new Label();
            panel2 = new Panel();
            checkedListBox1 = new CheckedListBox();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AccessibleRole = AccessibleRole.TitleBar;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(24, 24);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(33, 0);
            label2.Name = "label2";
            label2.Size = new Size(104, 18);
            label2.TabIndex = 1;
            label2.Text = "Johnny Depp";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Controls.Add(label5);
            flowLayoutPanel1.Location = new Point(12, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(200, 401);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // label3
            // 
            label3.Cursor = Cursors.Hand;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(3, 24);
            label3.Name = "label3";
            label3.Padding = new Padding(20, 30, 0, 0);
            label3.Size = new Size(197, 47);
            label3.TabIndex = 2;
            label3.Text = "My day";
            // 
            // label4
            // 
            label4.Cursor = Cursors.Hand;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.Location = new Point(3, 71);
            label4.Name = "label4";
            label4.Padding = new Padding(20, 20, 0, 0);
            label4.Size = new Size(197, 47);
            label4.TabIndex = 3;
            label4.Text = "Importatnt";
            // 
            // label5
            // 
            label5.Cursor = Cursors.Hand;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label5.Location = new Point(3, 118);
            label5.Name = "label5";
            label5.Padding = new Padding(20, 20, 0, 0);
            label5.Size = new Size(197, 47);
            label5.TabIndex = 4;
            label5.Text = "Plans";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.MediumPurple;
            flowLayoutPanel2.Controls.Add(label6);
            flowLayoutPanel2.Location = new Point(218, 12);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(709, 118);
            flowLayoutPanel2.TabIndex = 3;
            // 
            // label6
            // 
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Padding = new Padding(20, 30, 0, 0);
            label6.Size = new Size(706, 118);
            label6.TabIndex = 5;
            label6.Text = "My day";
            label6.Click += label6_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label7);
            panel1.Location = new Point(12, 419);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 84);
            panel1.TabIndex = 5;
            // 
            // label7
            // 
            label7.Cursor = Cursors.Hand;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label7.Image = (Image)resources.GetObject("label7.Image");
            label7.ImageAlign = ContentAlignment.MiddleLeft;
            label7.Location = new Point(21, 19);
            label7.Name = "label7";
            label7.Size = new Size(102, 36);
            label7.TabIndex = 0;
            label7.Text = "New List";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Cursor = Cursors.Hand;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label8.Image = (Image)resources.GetObject("label8.Image");
            label8.ImageAlign = ContentAlignment.MiddleLeft;
            label8.Location = new Point(593, 322);
            label8.Name = "label8";
            label8.Size = new Size(102, 36);
            label8.TabIndex = 1;
            label8.Text = "clear all";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(label8);
            panel2.Controls.Add(checkedListBox1);
            panel2.Location = new Point(218, 136);
            panel2.Name = "panel2";
            panel2.Size = new Size(709, 367);
            panel2.TabIndex = 6;
            // 
            // checkedListBox1
            // 
            checkedListBox1.BackColor = SystemColors.Control;
            checkedListBox1.Cursor = Cursors.IBeam;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(3, 3);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(703, 364);
            checkedListBox1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 515);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label3;
        private Label label4;
        private Label label5;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label6;
        private Panel panel1;
        private Label label7;
        private Label label8;
        private Panel panel2;
        private CheckedListBox checkedListBox1;
    }
}
