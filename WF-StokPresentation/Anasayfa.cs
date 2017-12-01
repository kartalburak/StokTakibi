using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_StokPresentation
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void mitemcikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mitemUrunler_Click(object sender, EventArgs e)
        {
            StokIslemleri frm = new StokIslemleri();
            frm.tabGenel.SelectedIndex = 0;
            FormAcikmi(frm);
        }
        private void FormAcikmi(Form AcilacakForm)
        {
            bool acikmi = false;
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (AcilacakForm.Name == this.MdiChildren[i].Name)
                {
                    this.MdiChildren[i].Focus();
                    acikmi = true;
                }
            }
            if (acikmi == false)
            {
                AcilacakForm.MdiParent = this;
                AcilacakForm.Show();
            }
            else
            {
                AcilacakForm.Dispose();//Kullanılmayacak form nesnesini  hafızadan atdık
                //biz bunu yapmasakda garbage collector zamanı gelince zaten hafızadan atıcaktır.
            }
        }

        private void mitemStokHareket_Click(object sender, EventArgs e)
        {
            StokIslemleri frm = new StokIslemleri();
            frm.tabGenel.SelectedIndex = 1;
            FormAcikmi(frm);
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
