﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkIlkProje
{
    public partial class FrmIstatistik : Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }
        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void FrmIstatistik_Load(object sender, EventArgs e)
        {
            label2.Text = db.TBLKATEGORI.Count().ToString(); // count= say
            label3.Text = db.TBLURUN.Count().ToString();
            label5.Text = db.TBLMUSTERI.Count(x => x.DURUM == true).ToString();
            label7.Text = db.TBLMUSTERI.Count(x => x.DURUM == false).ToString();
            label11.Text = db.TBLURUN.Sum(x => x.STOK).ToString(); //sum = topla
            label21.Text = db.TBLSATIS.Sum(z => z.FIYAT) + " TL";
            label13.Text = (from x in db.TBLURUN orderby x.FIYAT descending select x.URUNAD).FirstOrDefault(); //descending = azalan orderby = sırala
            label15.Text = (from x in db.TBLURUN orderby x.FIYAT ascending select x.URUNAD).FirstOrDefault(); //ascending = artan orderby = sırala
            label9.Text = db.TBLURUN.Count(x => x.KATEGORI == 1).ToString();
            label17.Text = db.TBLURUN.Count(x=> x.URUNAD == "BUZDOLABI").ToString();
            label23.Text = (from x in db.TBLMUSTERI select x.SEHIR).Distinct().Count().ToString(); //distinct = tekrarsız saymak
            label19.Text = db.MARKAGETIR().FirstOrDefault();
        }
    }
}
