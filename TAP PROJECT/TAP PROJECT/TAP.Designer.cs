namespace TAP_PROJECT
{
    partial class TAP
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
            UI_Message_Lbl = new Label();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            dataGridView1 = new DataGridView();
            UI_TargetAddress_TxtBox = new TextBox();
            UI_KnownHosts_Lbl = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // UI_Message_Lbl
            // 
            UI_Message_Lbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UI_Message_Lbl.Location = new Point(12, 12);
            UI_Message_Lbl.Name = "UI_Message_Lbl";
            UI_Message_Lbl.Size = new Size(100, 23);
            UI_Message_Lbl.TabIndex = 0;
            UI_Message_Lbl.Text = "Chat Text";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(92, 9);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(675, 29);
            textBox1.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 269);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(187, 184);
            listBox1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(254, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(534, 381);
            dataGridView1.TabIndex = 3;
            // 
            // UI_TargetAddress_TxtBox
            // 
            UI_TargetAddress_TxtBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UI_TargetAddress_TxtBox.Location = new Point(12, 117);
            UI_TargetAddress_TxtBox.Name = "UI_TargetAddress_TxtBox";
            UI_TargetAddress_TxtBox.Size = new Size(187, 29);
            UI_TargetAddress_TxtBox.TabIndex = 5;
            // 
            // UI_KnownHosts_Lbl
            // 
            UI_KnownHosts_Lbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UI_KnownHosts_Lbl.Location = new Point(12, 243);
            UI_KnownHosts_Lbl.Name = "UI_KnownHosts_Lbl";
            UI_KnownHosts_Lbl.Size = new Size(100, 23);
            UI_KnownHosts_Lbl.TabIndex = 6;
            UI_KnownHosts_Lbl.Text = "Nickname:";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 91);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 7;
            label3.Text = "Chat Text";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(12, 178);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(187, 29);
            textBox3.TabIndex = 5;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 152);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 7;
            label4.Text = "Chat Text";
            // 
            // TAP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(UI_KnownHosts_Lbl);
            Controls.Add(textBox3);
            Controls.Add(UI_TargetAddress_TxtBox);
            Controls.Add(dataGridView1);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Controls.Add(UI_Message_Lbl);
            Name = "TAP";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UI_Message_Lbl;
        private TextBox textBox1;
        private ListBox listBox1;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private TextBox UI_TargetAddress_TxtBox;
        private Label UI_KnownHosts_Lbl;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
    }
}
