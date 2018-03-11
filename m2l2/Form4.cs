using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace m2l2
{
    public partial class Form4 : Form
    {
        private MySqlDataAdapter mySqlDataAdapter1;
        public Form4()
        {
            InitializeComponent();
        }
        public DataGridView Dgv { get; set; }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnValiderPrestation_Click(object sender, EventArgs e)
        {
            var connectionString = "SERVER=localhost" + ";" + "DATABASE=m2l" + ";" + "UID=root" + ";" + "PASSWORD=" + ";" + "CHARSET=utf8" + ";";         
            using (var connection = new MySqlConnection(connectionString))
                        {
                            connection.Open();     
              using (MySqlCommand cmd = new MySqlCommand("INSERT INTO prestation(ReferencePrestation,NomPrestation,PrixUnitaireHT) VALUES(@ReferencePrestation,@NomPrestation,@PrixUnitaireHT)", connection))
                {
                    cmd.Parameters.AddWithValue("@ReferencePrestation",afficheurReferencePrestation.Text );
                    cmd.Parameters.AddWithValue("@NomPrestation", afficheurNomPrestation.Text);
                    cmd.Parameters.AddWithValue("@PrixUnitaireHT", afficheurPrixUnitaireHT.Text);

                    cmd.ExecuteNonQuery();
                   
                }
            mySqlDataAdapter1 = new MySqlDataAdapter("select ReferencePrestation as 'Référence prestation', NomPrestation as 'Nom Prestation',PrixUnitaireHT as 'Prix unitaire HT' from prestation", "SERVER=localhost" + ";" + "DATABASE=m2l" + ";" + "UID=root" + ";" + "PASSWORD=" + ";" + "CHARSET=utf8" + ";");
            // mySqlDataAdapter1 = new MySqlDataAdapter("select * from ligue", "SERVER=localhost" + ";" + "DATABASE=m2l" + ";" + "UID=root" + ";" + "PASSWORD=" + ";" + "CHARSET=utf8" + ";");
            DataSet DS1 = new DataSet();
            mySqlDataAdapter1.Fill(DS1);
            Dgv.DataSource = DS1.Tables[0];
            Dgv.Columns[0].Width = 115;
            Dgv.Columns[1].Width = 160;
            Dgv.Columns[2].Width = 50;
                        }
             
            this.Close();
            }
            
        }

       
     
    }

