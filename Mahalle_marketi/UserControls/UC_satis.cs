﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace Mahalle_marketi.UserControls
{
    public partial class UC_satis : UserControl
    {
        
        public static int urun_Bk;
        public static int miktar;
        public int guncellenmesi_istenen_miktar;
        public int toplam_tutar;

        public UC_satis()
        {
            InitializeComponent(); 
        }
        private void UC_satis_Load(object sender, EventArgs e)
        {
            comboBoxSatis.SelectedIndex = 0;
        }

        private void comboBoxSatis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxSatis.Text == "Peşin satış")
            {
                textBoxIsim.Visible = false;
                labelisimSoyisim.Visible = false;
            }
            else
            {
                textBoxIsim.Visible = true;
                labelisimSoyisim.Visible = true;
            }
        }

        public void toplam_tutari_guncelle()
        {
            toplam_tutar = 0;
            foreach (DataGridViewRow row in DataGridViewSatisEkrani.Rows)
            {
                toplam_tutar += (int)DataGridViewSatisEkrani.Rows[row.Index].Cells[5].Value;
            }
            labelToplamTutar.Text = toplam_tutar.ToString() + ".00 ₺";
        }

        private void btn_urun_ekle_Click(object sender, EventArgs e)
        {

            AddProductForm urunEkle_ekrani = new AddProductForm();
            urunEkle_ekrani.ShowDialog();

            urun_Bk = urunEkle_ekrani.urun_Bk;
            miktar = urunEkle_ekrani.miktar;

            Ürün urun = DbUrun.find_urunByBk(urun_Bk);
            if (urun != null)
            {
                var tutar = miktar * urun.Urun_satisFiyati;
                DataGridViewSatisEkrani.Rows.Add(urun.Urun_barKd, urun.Urun_adi, miktar, urun.Urun_miktarBirimi, urun.Urun_satisFiyati, tutar);
                toplam_tutari_guncelle();
            }



        }

        private void DataGridViewSatisEkrani_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                guncellenmesi_istenen_miktar = (int)DataGridViewSatisEkrani.Rows[e.RowIndex].Cells[2].Value;
                satis_miktari_guncelle miktari_guncelle = new satis_miktari_guncelle();
                miktari_guncelle.index = guncellenmesi_istenen_miktar - 1;
                miktari_guncelle.ShowDialog();

                DataGridViewSatisEkrani.Rows[e.RowIndex].Cells[2].Value = miktari_guncelle.guncellenen_miktar;
                int miktar = (int)DataGridViewSatisEkrani.Rows[e.RowIndex].Cells[2].Value;
                int fiyat = (int)DataGridViewSatisEkrani.Rows[e.RowIndex].Cells[4].Value;
                int tutar = fiyat * miktar;
                DataGridViewSatisEkrani.Rows[e.RowIndex].Cells[5].Value = tutar;
                toplam_tutari_guncelle();
                return;
            }
            if (e.ColumnIndex == 7)
            {
                DataGridViewSatisEkrani.Rows.RemoveAt(DataGridViewSatisEkrani.SelectedRows[0].Index);
                toplam_tutari_guncelle();
            }
        }
    }
}
