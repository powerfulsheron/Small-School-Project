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
    public partial class Form3 : Form
    {
        int codeLigue;
        private MySqlDataAdapter mySqlDataAdapter1;
        public Form3()
        {
            InitializeComponent();
        }
        public DataGridView Dgv { get; set; }
        private void btnValiderLigue_Click(object sender, EventArgs e)
        {
             var connectionString = "SERVER=localhost" + ";" + "DATABASE=m2l" + ";" + "UID=root" + ";" + "PASSWORD=" + ";" + "CHARSET=utf8" + ";";
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();                       
                var query = "SELECT * FROM ligue ORDER BY CodeLigue DESC LIMIT 1;";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int myInt = reader.GetInt32("CodeLigue");
  
                            codeLigue = myInt+1;

                        }

                    }
                }
                using (MySqlCommand cmd = new MySqlCommand("INSERT INTO ligue(CodeLigue,NomLigue,SportLigue,NomTresorier,PrenomTresorier,AdresseTresorier,CodePostalTresorier,CommuneTresorier) VALUES(@CodeLigue, @NomLigue,@SportLigue,@NomTresorier,@PrenomTresorier,@AdresseTresorier,@CodePostalTresorier,@CommuneTresorier)", connection))
                {
                    cmd.Parameters.AddWithValue("@CodeLigue", codeLigue);
                   // cmd.Parameters.AddWithValue("@CodeLigue", MySqlDbType.Int16);
                   // cmd.Parameters["@CodeLigue"].Value = codeLigue;
                   // cmd.Parameters.AddWithValue("@NomLigue", MySqlDbType.VarChar);
                   // cmd.Parameters["@CodeLigue"].Value = "Ligue Lorraine " + afficheurSportLigue.Text;
                   // cmd.Parameters.AddWithValue("@SportLigue", MySqlDbType.VarChar);
                   // cmd.Parameters["@SportLigue"].Value = afficheurSportLigue.Text;
                   // cmd.Parameters.AddWithValue("@NomTresorier", MySqlDbType.VarChar);
                   // cmd.Parameters["@NomTresorier"].Value = afficheurNomTresorier.Text;
                   // cmd.Parameters.AddWithValue("@PrenomTresorier", MySqlDbType.VarChar);
                   // cmd.Parameters["@PrenomTresorier"].Value = afficheurPrenomTresorier.Text;
                   // cmd.Parameters.AddWithValue("@AdresseTresorier", MySqlDbType.VarChar);
                   // cmd.Parameters["@AdresseTresorier"].Value = afficheurAdresseTresorier.Text;
                   // cmd.Parameters.AddWithValue("@CodePostalTresorier", MySqlDbType.VarChar);
                   // cmd.Parameters["@CodePostalTresorier"].Value = afficheurCpTresorier.Text;
                   // cmd.Parameters.AddWithValue("@CommuneTresorier", MySqlDbType.VarChar);
                   // cmd.Parameters["@CommuneTresorier"].Value = afficheurCommuneTresorier.Text;
                   // cmd.ExecuteNonQuery();

                    cmd.Parameters.AddWithValue("@NomLigue", "Ligue Lorraine "+ afficheurSportLigue.Text);
                    cmd.Parameters.AddWithValue("@SportLigue", afficheurSportLigue.Text);
                    cmd.Parameters.AddWithValue("@NomTresorier", afficheurNomTresorier.Text);
                    cmd.Parameters.AddWithValue("@PrenomTresorier", afficheurPrenomTresorier.Text);
                    cmd.Parameters.AddWithValue("@AdresseTresorier", afficheurAdresseTresorier.Text);
                    cmd.Parameters.AddWithValue("@CodePostalTresorier", afficheurCpTresorier.Text);
                    cmd.Parameters.AddWithValue("@CommuneTresorier", afficheurCommuneTresorier.Text);
                    cmd.ExecuteNonQuery();
                   
                }
            }
            mySqlDataAdapter1 = new MySqlDataAdapter("select CodeLigue as 'Code ligue', NomLigue as 'Nom Ligue', SportLigue as 'Sport ligue', NomTresorier as 'Nom trésorier', PrenomTresorier as 'Prénom trésorier', AdresseTresorier as 'Adresse trésorier',CodePostalTresorier as 'Code postal trésorier', CommuneTresorier as 'Commune trésorier' from ligue", "SERVER=localhost" + ";" + "DATABASE=m2l" + ";" + "UID=root" + ";" + "PASSWORD=" + ";" + "CHARSET=utf8" + ";");
            // mySqlDataAdapter1 = new MySqlDataAdapter("select * from ligue", "SERVER=localhost" + ";" + "DATABASE=m2l" + ";" + "UID=root" + ";" + "PASSWORD=" + ";" + "CHARSET=utf8" + ";");
            DataSet DS1 = new DataSet();
            mySqlDataAdapter1.Fill(DS1);
            Dgv.DataSource = DS1.Tables[0];
            Dgv.Columns[0].Width = 50;
            Dgv.Columns[1].Width = 150;
            this.Close();
                        }
        } 



    }

