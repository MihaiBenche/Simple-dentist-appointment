using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StomatologMk2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.programariDataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'programariDataSet1.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.programariDataSet1.Table);

        }

        private void programat_aCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((userBox.Text == "admin@secretariat.ro") & (passBox.Text == "1234"))
            {            
                MessageBox.Show("Sunteti logat", "Login", MessageBoxButtons.OKCancel);
                groupBox1.Visible = false;
            }
            else
                MessageBox.Show("User-ul sau parola sunt incorecte", "OK");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Sigur doriti sa inchideti?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Doriti sa salvati progresul?", "Iesire", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Validate();
                this.tableBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.programariDataSet1);
                this.Close();
            }
            else 
            {
                this.Close();
            };

        }
    }
}
