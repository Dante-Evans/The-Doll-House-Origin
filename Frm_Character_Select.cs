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
    public partial class Frm_Character_Select : Form
    {
        public Frm_Character_Select()
        {
            InitializeComponent();
        }

        private void Btn_Create_Click(object sender, EventArgs e)
        {
            //Once button pushed get the character information
            String char_Info = "";                            //Variable for the char info
            char_Info += "Name: " + Txt_Name.Text;            //Gets the character name

            //Test the gather
            MessageBox.Show(char_Info);
        }
    }
}
