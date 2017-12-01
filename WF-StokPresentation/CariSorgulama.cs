using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF_StokPresentation.Models;
using WF_StokPresentation.Stok_BLL.Models;

namespace WF_StokPresentation
{
    public partial class CariSorgulama : Form
    {
        public CariSorgulama()
        {
            InitializeComponent();
        }
        CariService cs = new CariService();
       
        private void CariSorgulama_Load(object sender, EventArgs e)
        {

        }

        private void rbalicilar_CheckedChanged(object sender, EventArgs e)
        {
            Genel.CariTipi = "Alıcı";
            dgvCariler.DataSource = cs.AlıcıListe();
        }

        private void rbsaticilar_CheckedChanged(object sender, EventArgs e)
        {
            Genel.CariTipi = "Satıcı";
            dgvCariler.DataSource = cs.SatıcıListe();
        }

        private void rbTumCariler_CheckedChanged(object sender, EventArgs e)
        {
            dgvCariler.DataSource = cs.CariListele();
        }
        private void txtunvanagore_TextChanged(object sender, EventArgs e)
        {
            dgvCariler.DataSource = cs.UnvanaGoreListele(txtunvanagore.Text);
        }

        private void dgvCariler_DoubleClick(object sender, EventArgs e)
        {
            Genel.CariID = Convert.ToInt32(dgvCariler.SelectedRows[0].Cells[0].Value);
            Genel.CariTipi = dgvCariler.SelectedRows[0].Cells[1].Value.ToString();
            Genel.CariUnvan = dgvCariler.SelectedRows[0].Cells[2].Value.ToString();

            
          

            this.Close();



        }



    }
}
