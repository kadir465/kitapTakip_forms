namespace BtkKitapTakip
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
            dataGridView1 = new DataGridView();
            colKategoriAdi = new DataGridViewTextBoxColumn();
            colSil = new DataGridViewButtonColumn();
            button1 = new Button();
            button2 = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewControl1 = new PrintPreviewControl();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colKategoriAdi, colSil });
            dataGridView1.Location = new Point(79, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(528, 294);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // colKategoriAdi
            // 
            colKategoriAdi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colKategoriAdi.DataPropertyName = "KategoriAdi";
            colKategoriAdi.FillWeight = 300F;
            colKategoriAdi.HeaderText = "Kategori İsimleri";
            colKategoriAdi.MinimumWidth = 6;
            colKategoriAdi.Name = "colKategoriAdi";
            // 
            // colSil
            // 
            colSil.HeaderText = "Sil";
            colSil.MinimumWidth = 6;
            colSil.Name = "colSil";
            colSil.Text = "Sil";
            colSil.UseColumnTextForButtonValue = true;
            colSil.Width = 125;
            // 
            // button1
            // 
            button1.Location = new Point(455, 362);
            button1.Name = "button1";
            button1.Size = new Size(152, 36);
            button1.TabIndex = 1;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(636, 51);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "Yazdır";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewControl1
            // 
            printPreviewControl1.AutoZoom = false;
            printPreviewControl1.Document = printDocument1;
            printPreviewControl1.Location = new Point(787, 18);
            printPreviewControl1.Name = "printPreviewControl1";
            printPreviewControl1.Size = new Size(395, 404);
            printPreviewControl1.TabIndex = 3;
            printPreviewControl1.Zoom = 0.26860564585115482D;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "10%", "50%", "100%", "200%" });
            comboBox1.Location = new Point(1188, 18);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(110, 28);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1334, 450);
            Controls.Add(comboBox1);
            Controls.Add(printPreviewControl1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private DataGridViewTextBoxColumn colKategoriAdi;
        private DataGridViewButtonColumn colSil;
        private Button button2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewControl printPreviewControl1;
        private ComboBox comboBox1;
    }
}
