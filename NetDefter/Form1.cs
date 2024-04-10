using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetDefter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string DosyaÝsmi;//Dosya ismi tanýmladýðýýz yer

        private void Form1_Load(object sender, EventArgs e)
        {
            DosyaÝsmi = "";
            DurumCubuguLbl1.Text = "";

        }

        private void MenuYeni_Click(object sender, EventArgs e)
        {
            if (Dosya.Modified)
            {
                DialogResult dr;
                dr = MessageBox.Show("Kaydetmek Ýstiyor Musunuz ? ", "Yeni Belge", MessageBoxButtons.YesNoCancel);
                if (dr == DialogResult.Yes)
                {
                    MenuKaydet_Click(sender, e);
                    Dosya.Clear();
                    DosyaÝsmi = "";
                    DurumCubuguLbl1.Text = "Yeni Belge";
                }
                else if (dr == DialogResult.No)
                {
                    DosyaÝsmi = "";
                    DurumCubuguLbl1.Text = "Yeni Belge";
                    Dosya.Clear();
                }
            }
        }

        private void MenuAc_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Dosya.LoadFile(openFileDialog1.FileName);
                DosyaÝsmi = openFileDialog1.FileName;
                int yer = DosyaÝsmi.LastIndexOf("\\");
                DurumCubuguLbl1.Text = DosyaÝsmi.Substring(yer + 1, DosyaÝsmi.Length - yer - 1);
            }
        }

        private void MenuKaydet_Click(object sender, EventArgs e)
        {
            if (Dosya.Modified)
            {
                if (DosyaÝsmi != "")
                {
                    Dosya.SaveFile(DosyaÝsmi);
                    int s = DosyaÝsmi.LastIndexOf("\\");
                    DurumCubuguLbl1.Text = DosyaÝsmi.Substring(s + 1, DosyaÝsmi.Length - s - 1) + " Kaydedildi";
                }
                else
                {
                    MenuFarkliKaydet_Click(sender, e);
                }
            }
        }

        private void MenuFarkliKaydet_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Dosya.SaveFile(saveFileDialog1.FileName);
                DosyaÝsmi = saveFileDialog1.FileName;
                int s = DosyaÝsmi.LastIndexOf("\\");
                DurumCubuguLbl1.Text = DosyaÝsmi.Substring(s + 1, DosyaÝsmi.Length - s - 1) + " Olarak Kaydedildi";
            }

        }

        private void MenuCikis_Click(object sender, EventArgs e)
        {
            if (Dosya.Modified)
            {
                DialogResult dr;
                dr = MessageBox.Show("Deðiþiklikler Kaydetmek Ýstiyor Musunuz ? ", "Yeni Belge", MessageBoxButtons.YesNoCancel);
                if (dr == DialogResult.Yes)
                {
                    MenuKaydet_Click(sender, e);
                    Application.Exit();
                }
                else if (dr == DialogResult.No)
                {
                    Application.Exit();
                }

            }

            Application.Exit();
        }

        private void MenuKopyala_Click(object sender, EventArgs e)
        {
            Dosya.Copy();
        }

        private void MenuJes_Click(object sender, EventArgs e)
        {
            Dosya.Cut();
        }

        private void MenuYapýstýr_Click(object sender, EventArgs e)
        {
            Dosya.Paste();
        }

        private void MenuYazitipi_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = fontDialog1.ShowDialog();
            if (dr == DialogResult.OK)
                Dosya.SelectionFont = fontDialog1.Font;


        }

        private void MenuRenk_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = colorDialog1.ShowDialog();
            if (dr == DialogResult.OK)
                Dosya.SelectionColor = colorDialog1.Color;

        }

        private void MenuArkaplan_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = colorDialog1.ShowDialog();
            if (dr == DialogResult.OK)
                Dosya.BackColor = colorDialog1.Color;
        }

        private void Dosya_TextChanged(object sender, EventArgs e)
        {
            DurumCubuguLbl1.Text = "Metin Deðiþti";
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Dosya.Modified)
            {
                DialogResult dr;
                dr = MessageBox.Show("Deðiþiklikler Kaydetmek Ýstiyor Musunuz ? ", "Yeni Belge", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    MenuKaydet_Click(sender, e);
                    Application.Exit();
                }
                else if (dr == DialogResult.No)
                {
                    Application.Exit();
                }
               
            }
            Application.Exit();
        }

      

        private void AracCubuguYeni_Click(object sender, EventArgs e)
        {
            MenuYeni_Click(sender,e);
        }

        private void AracCubuguAc_Click(object sender, EventArgs e)
        {
            MenuAc_Click (sender,e);
        }

        private void AracCubuguKaydet_Click(object sender, EventArgs e)
        {
            MenuKaydet_Click(sender,e);
        }

        private void AracCubuguFKaydet_Click(object sender, EventArgs e)
        {
            MenuFarkliKaydet_Click(sender,e);
        }

        private void AracCubuguKes_Click(object sender, EventArgs e)
        {
            MenuJes_Click(sender,e);
        }

        private void AracCubuguKopyala_Click(object sender, EventArgs e)
        {
            MenuKopyala_Click(sender,e);
        }

        private void AracCubuguYapýþtýr_Click(object sender, EventArgs e)
        {
            MenuYapýstýr_Click(sender,e);
        }

        private void AracCubuguKalýn_Click(object sender, EventArgs e)
        {
            Font yenifont = Dosya.SelectionFont;
            Dosya.SelectionFont = (new Font(yenifont.FontFamily, yenifont.Size, yenifont.Bold ? FontStyle.Regular : FontStyle.Bold));

        }

        private void AracCubuguÝtalik_Click(object sender, EventArgs e)
        {
            Font yenifont = Dosya.SelectionFont;
            Dosya.SelectionFont = (new Font(yenifont.FontFamily, yenifont.Size, yenifont.Bold ? FontStyle.Regular : FontStyle.Italic));

        }

        private void AracCubuguAltýCizili_Click(object sender, EventArgs e)
        {
            Font yenifont = Dosya.SelectionFont;
            Dosya.SelectionFont = (new Font(yenifont.FontFamily, yenifont.Size, yenifont.Bold ? FontStyle.Regular : FontStyle.Underline));

        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuJes_Click(sender,e);
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            MenuKopyala_Click(sender,e);
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            MenuYapýstýr_Click(sender,e);
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            MenuYazitipi_Click(sender,e);
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            MenuRenk_Click(sender,e);
        }

        private void AracCubuguYazdýr_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
           
            printPreviewDialog1.ShowDialog();
       
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(Dosya.Text,new Font(fontDialog1.Font.FontFamily ,fontDialog1.Font.Size ,fontDialog1.Font.Style), Brushes.Black,e.MarginBounds.Top,e.MarginBounds.Left );// new Font(fontDialog1.Font.Name , fontDialog1.Font.Size, FontStyle.Regular), Brushes.Black, e.MarginBounds.Top, e.MarginBounds.Left);
            e.HasMorePages = true ;
        }

        private void yazdýrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AracCubuguYazdýr_Click(sender, e);
        }

        private void MenuHakkinda_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

      

        

       

      

       

    }
}