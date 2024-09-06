namespace ThaiThanhNhat_Buoi1
{
    partial class GiaiPtB2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btngiai = new Button();
            btnxoa = new Button();
            btnthoat = new Button();
            txta = new TextBox();
            txtb = new TextBox();
            txtc = new TextBox();
            label7 = new Label();
            lblketqua = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(224, 29);
            label1.Name = "label1";
            label1.Size = new Size(335, 32);
            label1.TabIndex = 0;
            label1.Text = "GIẢI PHƯƠNG TRÌNH BẬC 2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 106);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 1;
            label2.Text = "A:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(111, 141);
            label3.Name = "label3";
            label3.Size = new Size(17, 15);
            label3.TabIndex = 2;
            label3.Text = "B:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(111, 171);
            label4.Name = "label4";
            label4.Size = new Size(18, 15);
            label4.TabIndex = 3;
            label4.Text = "C:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(208, 193);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 4;
            label5.Text = "KẾT QUẢ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(77, 271);
            label6.Name = "label6";
            label6.Size = new Size(85, 15);
            label6.TabIndex = 6;
            label6.Text = "Chọn Thao Tác";
            // 
            // btngiai
            // 
            btngiai.Location = new Point(111, 312);
            btngiai.Name = "btngiai";
            btngiai.Size = new Size(75, 23);
            btngiai.TabIndex = 7;
            btngiai.Text = "GIẢI";
            btngiai.UseVisualStyleBackColor = true;
            btngiai.Click += btngiai_Click;
            // 
            // btnxoa
            // 
            btnxoa.Location = new Point(208, 312);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(102, 23);
            btnxoa.TabIndex = 8;
            btnxoa.Text = "XÓA TRẮNG";
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnxoa_Click;
            // 
            // btnthoat
            // 
            btnthoat.Location = new Point(339, 312);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(75, 23);
            btnthoat.TabIndex = 9;
            btnthoat.Text = "THOÁT";
            btnthoat.UseVisualStyleBackColor = true;
            btnthoat.Click += btnthoat_Click;
            // 
            // txta
            // 
            txta.Location = new Point(159, 102);
            txta.Name = "txta";
            txta.Size = new Size(218, 23);
            txta.TabIndex = 10;
            // 
            // txtb
            // 
            txtb.Location = new Point(159, 133);
            txtb.Name = "txtb";
            txtb.Size = new Size(218, 23);
            txtb.TabIndex = 11;
            // 
            // txtc
            // 
            txtc.Location = new Point(159, 165);
            txtc.Name = "txtc";
            txtc.Size = new Size(218, 23);
            txtc.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(65, 70);
            label7.Name = "label7";
            label7.Size = new Size(64, 15);
            label7.TabIndex = 13;
            label7.Text = "Nhập a,b,c";
            // 
            // lblketqua
            // 
            lblketqua.BackColor = SystemColors.AppWorkspace;
            lblketqua.Location = new Point(124, 227);
            lblketqua.Name = "lblketqua";
            lblketqua.Size = new Size(268, 28);
            lblketqua.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblketqua);
            Controls.Add(label7);
            Controls.Add(txtc);
            Controls.Add(txtb);
            Controls.Add(txta);
            Controls.Add(btnthoat);
            Controls.Add(btnxoa);
            Controls.Add(btngiai);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btngiai;
        private Button btnxoa;
        private Button btnthoat;
        private TextBox txta;
        private TextBox txtb;
        private TextBox txtc;
        private Label label7;
        private Label lblketqua;
    }
}
