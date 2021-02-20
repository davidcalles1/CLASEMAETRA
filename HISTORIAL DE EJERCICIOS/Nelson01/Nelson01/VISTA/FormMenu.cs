using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nelson01.VISTA
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }
        //metodo "LOAD" es lo primero que cargara 
        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void cLICKPARAMASINFORMACIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAcercaDe frmAcerca = new FrmAcercaDe();
            frmAcerca.MdiParent = this;
            frmAcerca.Show();
        }
    }
}
