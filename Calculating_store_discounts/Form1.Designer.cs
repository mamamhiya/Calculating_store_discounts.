namespace Calculating_store_discounts_
{
    partial class โปรแกรมคำนวนส่วนลดของร้านค้า
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
            tb_total = new TextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            label3 = new Label();
            button1 = new Button();
            label1 = new Label();
            memY = new CheckBox();
            tb_receipt = new TextBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // tb_total
            // 
            tb_total.Location = new Point(128, 62);
            tb_total.Name = "tb_total";
            tb_total.Size = new Size(270, 30);
            tb_total.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 62);
            label2.Name = "label2";
            label2.Size = new Size(91, 31);
            label2.TabIndex = 2;
            label2.Text = "ยอดสั่งซื้อ :";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Pink;
            groupBox1.BackgroundImageLayout = ImageLayout.None;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(memY);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tb_total);
            groupBox1.Location = new Point(32, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(523, 250);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "คำนวน";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(408, 61);
            label3.Name = "label3";
            label3.Size = new Size(45, 31);
            label3.TabIndex = 7;
            label3.Text = "บาท";
            // 
            // button1
            // 
            button1.Location = new Point(359, 117);
            button1.Name = "button1";
            button1.Size = new Size(94, 46);
            button1.TabIndex = 6;
            button1.Text = "คำนวน";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            button1.MouseEnter += button1_MouseEnter;
            button1.MouseLeave += button1_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 132);
            label1.Name = "label1";
            label1.Size = new Size(71, 31);
            label1.TabIndex = 4;
            label1.Text = "สมาชิก :";
            // 
            // memY
            // 
            memY.AutoSize = true;
            memY.Location = new Point(128, 132);
            memY.Name = "memY";
            memY.Size = new Size(51, 35);
            memY.TabIndex = 3;
            memY.Text = "ใช่";
            memY.UseVisualStyleBackColor = true;
            // 
            // tb_receipt
            // 
            tb_receipt.Location = new Point(31, 29);
            tb_receipt.Multiline = true;
            tb_receipt.Name = "tb_receipt";
            tb_receipt.Size = new Size(460, 195);
            tb_receipt.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.GradientInactiveCaption;
            groupBox2.Controls.Add(tb_receipt);
            groupBox2.Location = new Point(32, 325);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(523, 250);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "ใบเสร็จ";
            // 
            // โปรแกรมคำนวนส่วนลดของร้านค้า
            // 
            AutoScaleDimensions = new SizeF(10F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(664, 606);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Chakra Petch", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "โปรแกรมคำนวนส่วนลดของร้านค้า";
            Text = "โปรแกรมคำนวนส่วนลดของร้านค้า";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox tb_total;
        private Label label2;
        private GroupBox groupBox1;
        private Label label1;
        private CheckBox memY;
        private Button button1;
        private TextBox tb_receipt;
        private Label label3;
        private GroupBox groupBox2;
    }
}
