using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESTION__MIFA.DF
{
    public partial class Formmenu : Form
    {
        public Formmenu()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
          ;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button5_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonclient_Click(object sender, EventArgs e)
        {
            panelcmd.Top = buttonclient.Top;
        }

        private void buttoncommande_Click(object sender, EventArgs e)
        {
            panelcmd.Top = buttoncommande.Top;
        }

        private void buttonlivraison_Click(object sender, EventArgs e)
        {
            panelcmd.Top = buttonlivraison.Top;
        }

        private void buttonproduit_Click(object sender, EventArgs e)
        {
            panelcmd.Top = buttonproduit.Top;
        }

        private void buttonutilisateur_Click(object sender, EventArgs e)
        {
            panelcmd.Top = buttonutilisateur.Top;
        }

        private void buttonsetting_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonconnexion_Click(object sender, EventArgs e)
        {
            Formconnexion fmc = new Formconnexion();
            fmc.ShowDialog();
        }
    }
}
