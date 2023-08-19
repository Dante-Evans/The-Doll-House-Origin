using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Doll_House
{
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            Frm_Character_Select character_Select = new Frm_Character_Select();
            character_Select.Show();
        }
    }
}
