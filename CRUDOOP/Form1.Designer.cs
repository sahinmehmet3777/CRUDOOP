namespace CRUDOOP
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AdTxt = new System.Windows.Forms.TextBox();
            this.SoyadTxt = new System.Windows.Forms.TextBox();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.IDTxt = new System.Windows.Forms.TextBox();
            this.ReadBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(148, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(116, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad :";
            // 
            // AdTxt
            // 
            this.AdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AdTxt.Location = new System.Drawing.Point(220, 72);
            this.AdTxt.Name = "AdTxt";
            this.AdTxt.Size = new System.Drawing.Size(100, 30);
            this.AdTxt.TabIndex = 2;
            // 
            // SoyadTxt
            // 
            this.SoyadTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SoyadTxt.Location = new System.Drawing.Point(220, 119);
            this.SoyadTxt.Name = "SoyadTxt";
            this.SoyadTxt.Size = new System.Drawing.Size(100, 30);
            this.SoyadTxt.TabIndex = 3;
            // 
            // CreateBtn
            // 
            this.CreateBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.CreateBtn.FlatAppearance.BorderSize = 2;
            this.CreateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateBtn.Location = new System.Drawing.Point(85, 198);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(75, 31);
            this.CreateBtn.TabIndex = 4;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = false;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 253);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(507, 219);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(373, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID :";
            // 
            // IDTxt
            // 
            this.IDTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IDTxt.Location = new System.Drawing.Point(439, 72);
            this.IDTxt.Name = "IDTxt";
            this.IDTxt.Size = new System.Drawing.Size(100, 30);
            this.IDTxt.TabIndex = 7;
            // 
            // ReadBtn
            // 
            this.ReadBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.ReadBtn.FlatAppearance.BorderSize = 2;
            this.ReadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReadBtn.Location = new System.Drawing.Point(181, 198);
            this.ReadBtn.Name = "ReadBtn";
            this.ReadBtn.Size = new System.Drawing.Size(75, 31);
            this.ReadBtn.TabIndex = 4;
            this.ReadBtn.Text = "Read";
            this.ReadBtn.UseVisualStyleBackColor = false;
            this.ReadBtn.Click += new System.EventHandler(this.ReadBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.UpdateBtn.FlatAppearance.BorderSize = 2;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.Location = new System.Drawing.Point(453, 155);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 31);
            this.UpdateBtn.TabIndex = 4;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.DeleteBtn.FlatAppearance.BorderSize = 2;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Location = new System.Drawing.Point(275, 198);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 31);
            this.DeleteBtn.TabIndex = 4;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.SearchBtn.FlatAppearance.BorderSize = 2;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Location = new System.Drawing.Point(453, 119);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 30);
            this.SearchBtn.TabIndex = 4;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(585, 512);
            this.Controls.Add(this.IDTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.ReadBtn);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.SoyadTxt);
            this.Controls.Add(this.AdTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çalışanlar Otomasyonu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ReadBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button SearchBtn;
        public System.Windows.Forms.TextBox IDTxt;
        public System.Windows.Forms.TextBox AdTxt;
        public System.Windows.Forms.TextBox SoyadTxt;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}

