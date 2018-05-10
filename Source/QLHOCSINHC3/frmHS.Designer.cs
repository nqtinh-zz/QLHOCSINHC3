namespace QLHOCSINHC3
{
    partial class frmHS
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnTTLop = new System.Windows.Forms.Button();
            this.btnTTHs = new System.Windows.Forms.Button();
            this.btnTTDiem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tra cứu thông tin ";
            // 
            // btnTTLop
            // 
            this.btnTTLop.Location = new System.Drawing.Point(79, 53);
            this.btnTTLop.Name = "btnTTLop";
            this.btnTTLop.Size = new System.Drawing.Size(122, 52);
            this.btnTTLop.TabIndex = 1;
            this.btnTTLop.Text = "Tra cứu thông tin lớp học";
            this.btnTTLop.UseVisualStyleBackColor = true;
            this.btnTTLop.Click += new System.EventHandler(this.btnTTLop_Click);
            // 
            // btnTTHs
            // 
            this.btnTTHs.Location = new System.Drawing.Point(302, 53);
            this.btnTTHs.Name = "btnTTHs";
            this.btnTTHs.Size = new System.Drawing.Size(135, 52);
            this.btnTTHs.TabIndex = 2;
            this.btnTTHs.Text = "Tra cứu thông tin học sinh";
            this.btnTTHs.UseVisualStyleBackColor = true;
            this.btnTTHs.Click += new System.EventHandler(this.btnTTHs_Click);
            // 
            // btnTTDiem
            // 
            this.btnTTDiem.Location = new System.Drawing.Point(548, 53);
            this.btnTTDiem.Name = "btnTTDiem";
            this.btnTTDiem.Size = new System.Drawing.Size(125, 52);
            this.btnTTDiem.TabIndex = 3;
            this.btnTTDiem.Text = "Tra cứu thông tin điểm";
            this.btnTTDiem.UseVisualStyleBackColor = true;
            this.btnTTDiem.Click += new System.EventHandler(this.btnTTDiem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(70, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(845, 458);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // frmHS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 638);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnTTDiem);
            this.Controls.Add(this.btnTTHs);
            this.Controls.Add(this.btnTTLop);
            this.Controls.Add(this.label1);
            this.Name = "frmHS";
            this.Text = "frmHS";
            this.Load += new System.EventHandler(this.frmHS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTTLop;
        private System.Windows.Forms.Button btnTTHs;
        private System.Windows.Forms.Button btnTTDiem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}