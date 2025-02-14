using BtkKitapTakip.Db;
using BtkKitapTakip.Modeller;
using System.ComponentModel;

namespace BtkKitapTakip
{
    public partial class Form1 : Form
    {

        BindingList<DbKategori> bList;
        KitapDbContext context = new KitapDbContext();

        public Form1()
        {
            InitializeComponent();


            var liste = context.Kategoriler.ToList();

            bList = new BindingList<DbKategori>(liste);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = bList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DbKategori kat in bList)
            {
                if (kat.Id == 0)
                {
                    context.Kategoriler.Add(kat);
                }
            }

            context.SaveChanges();
            MessageBox.Show("Kayýt Edildi");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == colSil.Index)
            {
                DbKategori kat = dataGridView1.Rows[e.RowIndex].DataBoundItem as DbKategori;
                if (kat != null)
                {
                    var cevap = MessageBox.Show(kat.KategoriAdi + " silinsin mi?", "Uyarý", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (cevap == DialogResult.Yes)
                    {
                        //1-bList
                        //2-EfCore 

                        bList.Remove(kat);
                        context.Kategoriler.Remove(kat);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float solBosluk = e.MarginBounds.Left;
            float ustBosluk = e.MarginBounds.Top;

            Font fnt = new Font("Arial", 16);
            Font fnt2 = new Font("Arial", 12);

            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;

            StringFormat sf2 = new StringFormat();
            sf.Alignment = StringAlignment.Near;
            sf.LineAlignment = StringAlignment.Center;

            e.Graphics.DrawString("Kategori Listesi", fnt, Brushes.Black,

                new RectangleF(solBosluk, ustBosluk, e.MarginBounds.Width, 40), sf);

            float offset = ustBosluk + 60;

            foreach (var kat in bList)
            {
                e.Graphics.DrawString(kat.KategoriAdi, fnt2, Brushes.Black,

                new RectangleF(solBosluk, offset, e.MarginBounds.Width, 40), sf2);
                
                offset += fnt2.GetHeight(e.Graphics) + 10;
            }

           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
                printPreviewControl1.Zoom = 10 / 100f;
            if (comboBox1.SelectedIndex == 1)
                printPreviewControl1.Zoom = 50/100f;
            if (comboBox1.SelectedIndex == 2)
                printPreviewControl1.Zoom = 100/100f;
            if (comboBox1.SelectedIndex == 3)
                printPreviewControl1.Zoom = 200 / 100f; 


        }
    }
}
