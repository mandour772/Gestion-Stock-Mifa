using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;



namespace GESTION__MIFA.DF
{
    
    
    public partial class Formconnexion : Form
    {
        private Gestion_stock_mifaEntities db;

        DC.FMconnexion fmc = new DC.FMconnexion();
        public Formconnexion()
        {
            InitializeComponent();
            
           
          
        }
       
          
       string testconnexion()
        {
            if(textBoxutilisateur.Text==""||textBoxutilisateur.Text== "Nom D'Utilisateur")
            {
                return "entre le nom";

            }
            if (textBoxmtp.Text == "" || textBoxmtp.Text == "Mot de Passe")
            {
                return "entre le mot de passe";

            }

              return null;

        }
                
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxutilisateur_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxutilisateur_Enter(object sender, EventArgs e)
        {
            if (textBoxutilisateur.Text == "Nom D'Utilisateur")
            {
                textBoxutilisateur.Text = " ";
                textBoxutilisateur.ForeColor = Color.WhiteSmoke;
            }
        }

        private void textBoxmtp_Enter(object sender, EventArgs e)
        {
            if (textBoxutilisateur.Text == "Mot de Passe")
            {
                textBoxutilisateur.Text = " ";
                textBoxutilisateur.ForeColor = Color.WhiteSmoke;
            }
        }
    
        private void button1_Click(object sender, EventArgs e)

        {
           

            bool tr = false;
            Program.cmd.CommandText = "select nom_utilisateur,mot_passe from utilisateur";
            Program.cmd.Connection = Program.con;
            Program.dr = Program.cmd.ExecuteReader();
                
            while(Program.dr.Read())
            {
                if(textBoxutilisateur.Text.Equals(Program.dr[0].ToString())
                     && textBoxutilisateur.Text.Equals(Program.dr[0].ToString()))
                {
                    tr = true;
                    break;
                }
            }
            if(tr == true)
            {
                this.Hide();
                Formmenu f = new Formmenu();
                f.Show();
            }
           // else
            //{
              //  MessageBox.Show("erreur");
                
           // }
           // Program.dr.Close();







        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
          /*  comboBox1.DisplayMember = "mot_passe";
            comboBox1.ValueMember = "nom_utilisateur";
            comboBox1.DataSource = Program.executetable("select * from utilisateur ");*/
        }

        private void textBoxmtp_TextChanged(object sender, EventArgs e)
        {

        }

        private void Formconnexion_Load(object sender, EventArgs e)
        {
            Program.Connecter();
        }
    }
}
