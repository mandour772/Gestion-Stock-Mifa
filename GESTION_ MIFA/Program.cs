using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace GESTION__MIFA
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DF.Formmenu ()); 
        }
        public static SqlConnection con = new SqlConnection();
        public static SqlCommand cmd = new SqlCommand();
        public static DataSet ds = new DataSet();
        public static SqlDataReader dr;
      

        public  static void Connecter()
        {
            if(con.State == ConnectionState.Closed || con.State ==ConnectionState.Broken)
            {
                con.ConnectionString = @"Data Source=DESKTOP-GT2GQAO;Initial Catalog=Gestion_stock_mifa;Integrated Security=True";
                con.Open();
            }
        }
        public static void Deconnecter()
        {
            if (con.State == ConnectionState.Open)
            {
               
                con.Close();
            }
        }


        // public static string stringcon = @"Data Source=DESKTOP-GT2GQAO;Initial Catalog=Gestion_stock_mifa;Integrated Security=True";

        /*public static SqlDataAdapter dap_categorie = new SqlDataAdapter("select * from categorie", stringcon);
        public static SqlDataAdapter dap_client = new SqlDataAdapter("select * from client", stringcon);
        public static SqlDataAdapter dap_commande = new SqlDataAdapter("select * from commande", stringcon); 
        public static SqlDataAdapter dap_livraison = new SqlDataAdapter("select * from livraison", stringcon);
        public static SqlDataAdapter dap_produit = new SqlDataAdapter("select * from produit", stringcon);
        public static SqlDataAdapter dap_utilisateur = new SqlDataAdapter("select * from utilisateur", stringcon);

        public static SqlDataAdapter dap = new SqlDataAdapter("", stringcon);*/


        public static void intit()
        {

           /* dap_categorie.Fill(ds, "categorie");
            dap_client.Fill(ds, "client");
            dap_commande.Fill(ds, "commande");
            dap_livraison.Fill(ds, "livraison");
            dap_produit.Fill(ds, "produit");
            dap_utilisateur.Fill(ds, "utilisateur");

           ds.Tables["categorie"].PrimaryKey = new DataColumn[] { ds.Tables["categorie"].Columns[0] };
            ds.Tables["client"].PrimaryKey = new DataColumn[] { ds.Tables["client"].Columns[0] };
            ds.Tables["stagiaire"].PrimaryKey = new DataColumn[] { ds.Tables["stagiaire"].Columns[0] };
            ds.Tables["stagiaire"].PrimaryKey = new DataColumn[] { ds.Tables["stagiaire"].Columns[0] };
            ds.Tables["stagiaire"].PrimaryKey = new DataColumn[] { ds.Tables["stagiaire"].Columns[0] };
            ds.Tables["utilisateur"].PrimaryKey = new DataColumn[] { ds.Tables["utilisateur"].Columns[0] };*/


        }

       /* public static void maj_stagiaire()
        {
            SqlCommandBuilder cb = new SqlCommandBuilder(dap_utilisateur);
            dap_utilisateur.Update(ds.Tables["utilisateur"]);
        }

        public static DataTable executetable(string req)
        {

            DataTable dt = new DataTable();
            dap.SelectCommand.CommandText = req;
            dap.Fill(dt);
            return dt;
        }*/

    }
}
