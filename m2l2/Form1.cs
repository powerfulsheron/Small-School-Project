using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using System.Globalization;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Threading;
using System.Security.Cryptography;




namespace m2l2
{
    public partial class form : Form
    {
        public DBConnect ConnectionBdd = new DBConnect();
        private string utilisateur;
        private string totalTtc;
        private string numeroFacture;
        private string codeLigue;      
        private string quantiteAffranchissement;
        private string quantitePhotocouleur;
        private string quantitePhotoNb;
        private string quantiteTraceur;
        private double prixAffranchissement;
        private double prixPhotocouleur;
        private double prixPhotoNb;
        private double prixTraceur;
        private string montantAffranchissement;
        private string montantPhotocouleur;
        private string montantPhotoNb;
        private string montantTraceur;
        private string nomLigue;
        private string nomTresorier;
        private string prenomTresorier;
        private string adresseTresorier;
        private string codePostalTresorier;
        private string communeTresorier;
        private string dateFacture;
        private string dateEcheance;
        //int indexRowLigue;
        //int indexRowPrestation;
        int indexRowListeFacture;
        private Form2 f2;
        private Form3 f3;
        private Form4 f4;
        private MySqlDataAdapter mySqlDataAdapter1;
        private MySqlDataAdapter mySqlDataAdapter2;
        private MySqlDataAdapter mySqlDataAdapter3;
        private MySqlDataAdapter mySqlDataAdapter4;
        private MySqlDataAdapter mySqlDataAdapter5;
        public form()
        {
            InitializeComponent();
          

            // Remplissage manuel des datagrids ligue et presta

            //  this.dataGridView1.Rows.Add("411007", "Ligue Lorraine Escrime", "Valérie LAHEURTE", "Escrime");
            //  this.dataGridView1.Rows.Add("411008", "Ligue Lorraine de FootBall", "Pierre LENOIR", "Football");
            //  this.dataGridView1.Rows.Add("411009", "Ligue Lorraine de Basket", "Mohamed BOURGARD", "Basket");
            //  this.dataGridView1.Rows.Add("411010", "Ligue Lorraine de Baby-Foot", "Sylvain DELAHOUSSE", "Baby-Foot");
            //  this.dataGridViewPrestation.Rows.Add("AFFRAN", "Affranchissement", "3,33");
            //  this.dataGridViewPrestation.Rows.Add("PHOTOCOULEUR", "Photocopies couleur", "0,24");
            //  this.dataGridViewPrestation.Rows.Add("PHOTON&B", "Photocopies Noir et Blanc", "0,055");
            //  this.dataGridViewPrestation.Rows.Add("TRACEUR", "Utilisation du traceur", "0,356");          
         

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //private void btnAjouterChamp_Click(object sender, EventArgs e)
        //{
        //    this.dataGridView1.Rows.Add(afficheurCodeLigue.Text, afficheurNomLigue.Text, afficheurGestionnaire.Text, afficheurSport.Text);
        //    afficheurCodeLigue.Text = "";
        //    afficheurGestionnaire.Text = "";
        //    afficheurNomLigue.Text = "";
        //    afficheurSport.Text = "";
        //}

  


        //  private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        // {

        //    afficheurCodeLigue.Text = dataGridView1.Rows[e.RowIndex].Cells["CodeLigue"].Value.ToString();
        //     afficheurNomLigue.Text = dataGridView1.Rows[e.RowIndex].Cells["NomLigue"].Value.ToString();
        //   afficheurGestionnaire.Text = dataGridView1.Rows[e.RowIndex].Cells["SportLigue"].Value.ToString();
        // afficheurSport.Text = dataGridView1.Rows[e.RowIndex].Cells["NomTresorier"].Value.ToString();
        //indexRowLigue = e.RowIndex;
        //}

        //private void btnModifierLigue_Click(object sender, EventArgs e)
        //{
        //DataGridViewRow newDataRow = dataGridView1.Rows[indexRowLigue];
        //newDataRow.Cells[0].Value = afficheurCodeLigue.Text;
        //newDataRow.Cells[1].Value = afficheurNomLigue.Text;
        //newDataRow.Cells[2].Value = afficheurGestionnaire.Text;
        //newDataRow.Cells[3].Value = afficheurSport.Text;

        //}


        // private void btnModifierPrestation_Click(object sender, EventArgs e)
        //{
        //   DataGridViewRow newDataRow = dataGridView1.Rows[indexRowPrestation];
        //  newDataRow.Cells[0].Value = afficheurReference.Text;
        // newDataRow.Cells[1].Value = afficheurDesignation.Text;
        // newDataRow.Cells[2].Value = afficheurPrix.Text;
        // }


        private void btnFacture_Click(object sender, EventArgs e)
        {
            //btnPrestations.Visible = false;
            //btnFacture.Visible = false;
            //btnLigues.Visible = false;
            //btnListe.Visible = false;
            //btnRetour.Visible = true;
            //module.Text = "CREER FACTURE";
            f2 = new Form2();
            f2.ShowDialog();

        }

 

        private void dataGridView1_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            DataTable changes1 = ((DataTable)dataGridView1.DataSource).GetChanges();

            if (changes1 != null)
            {
                MySqlCommandBuilder mcb = new MySqlCommandBuilder(mySqlDataAdapter1);
                mySqlDataAdapter1.UpdateCommand = mcb.GetUpdateCommand();
                mySqlDataAdapter1.Update(changes1);
                ((DataTable)dataGridView1.DataSource).AcceptChanges();
            }
        }

        private void dataGridViewPrestation_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            DataTable changes2 = ((DataTable)dataGridViewPrestation.DataSource).GetChanges();

            if (changes2 != null)
            {
                MySqlCommandBuilder mcb2 = new MySqlCommandBuilder(mySqlDataAdapter2);
                mySqlDataAdapter2.UpdateCommand = mcb2.GetUpdateCommand();
                mySqlDataAdapter2.Update(changes2);
                ((DataTable)dataGridViewPrestation.DataSource).AcceptChanges();
            }
        }

        private void btnImprimer_Click(object sender, EventArgs e)
        {

            numeroFacture = dataGridViewListeFacture.Rows[indexRowListeFacture].Cells[0].Value.ToString();
            dateFacture = dataGridViewListeFacture.Rows[indexRowListeFacture].Cells[1].Value.ToString().Substring(0,10);
            dateEcheance = dataGridViewListeFacture.Rows[indexRowListeFacture].Cells[2].Value.ToString().Substring(0,10);

            codeLigue = dataGridViewListeFacture.Rows[indexRowListeFacture].Cells[3].Value.ToString();
            totalTtc = dataGridViewListeFacture.Rows[indexRowListeFacture].Cells[4].Value.ToString();

            var connectionString = "SERVER=localhost" + ";" + "DATABASE=m2l" + ";" + "UID=root" + ";" + "PASSWORD=" + ";" + "CHARSET=utf8" + ";";
            List<string> quantites = new List<string>();

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT * FROM ligne_facture WHERE NumeroFacture='" + numeroFacture + "'";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                         quantites.Add(reader.GetString("Quantite"));                     
                        }
                        quantiteAffranchissement = float.Parse(quantites[0]).ToString("0.00");

                        quantitePhotocouleur = float.Parse(quantites[1]).ToString("0.00");

                        quantitePhotoNb = float.Parse(quantites[2]).ToString("0.00");

                        quantiteTraceur = float.Parse(quantites[3]).ToString("0.00");
                    }
                    var query2 = "SELECT * FROM ligue WHERE CodeLigue='" + codeLigue + "'";
                    using (var command2 = new MySqlCommand(query2, connection))
                    {
                        using (var reader = command2.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                nomLigue = reader.GetString("NomLigue");
                                nomTresorier = reader.GetString("NomTresorier");
                                prenomTresorier = reader.GetString("PrenomTresorier");
                                // adresseTresorier=reader.GetString("AdresseTresorier");
                                // codePostalTresorier = reader.GetString("CodePostalTresorier");
                                // communeTresorier=reader.GetString("CommuneTresorier"); 

                                // gestionnaire = reader.GetString("NomTresorier") + " " + reader.GetString("PrenomTresorier");
                                //ligue = where;
                                //codeClient = reader.GetString("CodeLigue");
                                //adresseTresorier = reader.GetString("AdresseTresorier");
                                //codePostal = reader.GetString("CodePostalTresorier");
                                //commune = reader.GetString("CommuneTresorier");

                            }

                        }
                    }
                }
                prixAffranchissement = 3.330;
                prixPhotocouleur = 0.240;
                prixPhotoNb = 0.055;
                prixTraceur = 0.356;
                montantAffranchissement = (float.Parse(quantiteAffranchissement)* prixAffranchissement).ToString("0.00");
                montantPhotocouleur = (float.Parse(quantitePhotocouleur) * prixPhotocouleur).ToString("0.00");
                montantPhotoNb = (float.Parse(quantitePhotoNb) * prixPhotoNb).ToString("0.00");
                montantTraceur = (float.Parse(quantiteTraceur) * prixTraceur).ToString("0.00");

                Document nouveauDocument = new Document();


                FileStream fs = new FileStream(@"c:\Users\OSN\Desktop\Chapter1_Example1.pdf", FileMode.Create, FileAccess.Write, FileShare.None);
                PdfWriter writer = PdfWriter.GetInstance(nouveauDocument, fs);
                nouveauDocument.Open();


                //////////////////////////////////////////////////////////////////////////
                ////////////Déclaration des images et des varables de police//////////////
                //////////////////////////////////////////////////////////////////////////
                iTextSharp.text.Image CVCrosl = iTextSharp.text.Image.GetInstance("C:/Users/OSN/Desktop/CarteVisiteCrosl.JPG");
                //Image CVCrosl = Image.GetInstance("C:/Users/OSN/Desktop/CarteVisiteCrosl.JPG");
                iTextSharp.text.Image Logo = iTextSharp.text.Image.GetInstance("C:/Users/OSN/Desktop/LogoCrol.JPG");
                //Image Logo = Image.GetInstance("C:/Users/OSN/Desktop/LogoCrol.JPG");
                var boldFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10);
                var adresse = FontFactory.GetFont(FontFactory.HELVETICA, 10);
                var texte = FontFactory.GetFont(FontFactory.HELVETICA, 10);
                Chunk test = new Chunk();
                Phrase test2 = new Phrase(test);
                Chunk test3 = new Chunk("    Maison Régionale des Sports de Lorraine \n    13 rue Jean Moulin \n \n    54510 TOMBLAINE \n    FRANCE METROPOLITAINE", adresse);
                // Chunk test3 = new Chunk("    " + adresseTresorier + "\n    " + codePostalTresorier + "\n    " + communeTresorier + "\n    FRANCE", adresse);
                test2.Add(test3);



                Paragraph adressestr = new Paragraph(" \n \n \n \n \n \n \n \n    " + nomLigue + " \n \n    A l'attention de " + nomTresorier + " " + prenomTresorier + " \n", boldFont);
                adressestr.Add(test2);
                //////////////////////////////////////////////
                ///////////////Mise en Page PDF///////////////
                //////////////////////////////////////////////

                //////////////////HEAD (Adresse CROSL Et trésorier + LOGOS)////////////////////////

                int[] intTblWidth = { 8, 8, 3 };
                PdfPTable tableauHead = new PdfPTable(3);
                PdfPCell celluleHead = new PdfPCell();
                tableauHead.TotalWidth = 540;
                tableauHead.SetWidths(intTblWidth);
                tableauHead.DefaultCell.BorderColor = new BaseColor(255, 255, 255);
                tableauHead.LockedWidth = true;
                celluleHead.Colspan = 3;
                tableauHead.AddCell(celluleHead);
                tableauHead.AddCell(CVCrosl);
                tableauHead.AddCell(adressestr);
                tableauHead.AddCell(Logo);
                nouveauDocument.Add(tableauHead);

                ///////////////////En-tête de la facture//////////////////////////
                nouveauDocument.Add(new Phrase("FACTURE                                                                                                          ", boldFont));
                Phrase EcheanceText = new Phrase("ECHEANCE", texte);
                nouveauDocument.Add(EcheanceText);

                //////////////////Facture (Infos clients et dates)/////////////////////
                //Déclaration des contenus
                //A ne pas modifier !
                Phrase Date = new Phrase("Date", adresse);
                Phrase Numero = new Phrase("Numéro", adresse);
                Phrase CodeClient = new Phrase("Code Client", adresse);
                Phrase Echeance = new Phrase("Echéance", adresse);
                //A Modifier !
                Phrase ValDate = new Phrase(dateFacture, adresse);
                Phrase ValNum = new Phrase(numeroFacture, adresse);
                Phrase ValCodeCli = new Phrase(codeLigue, adresse);
                Phrase ValDatecheance = new Phrase(dateEcheance, adresse);
                // Phrase ValDatecheance = new Phrase(date.ToString("dd/MM/yyyy"), adresse);

                //Première ligne du tableau (Désignation des valeurs)
                int[] intTblWidth2 = { 4, 4, 4, 4, 4 };
                PdfPTable tableauFact1 = new PdfPTable(5);
                PdfPCell celluleFact1 = new PdfPCell();
                tableauFact1.TotalWidth = 540;
                tableauFact1.SetWidths(intTblWidth2);
                tableauFact1.DefaultCell.BorderColor = new BaseColor(255, 255, 255);
                tableauFact1.DefaultCell.BackgroundColor = new BaseColor(253, 253, 213);
                tableauFact1.LockedWidth = true;
                celluleFact1.Colspan = 5;
                tableauFact1.AddCell(Date);
                tableauFact1.AddCell(Numero);
                tableauFact1.AddCell("");
                tableauFact1.AddCell(CodeClient);
                tableauFact1.AddCell(Echeance);
                nouveauDocument.Add(tableauFact1);
                //Deuxième Ligne du tableau (avec les valeurs)
                PdfPTable tableauFact2 = new PdfPTable(5);
                PdfPCell celluleFact2 = new PdfPCell();
                tableauFact2.TotalWidth = 540;
                tableauFact2.SetWidths(intTblWidth2);
                tableauFact2.DefaultCell.BorderColor = new BaseColor(255, 255, 255);
                tableauFact2.LockedWidth = true;
                celluleFact2.Colspan = 5;
                tableauFact2.AddCell(ValDate);
                tableauFact2.AddCell(ValNum);
                tableauFact2.AddCell("");
                tableauFact2.AddCell(ValCodeCli);
                tableauFact2.AddCell(ValDatecheance);
                nouveauDocument.Add(tableauFact2);

                //////////////////Saut de ligne/////////////////////
                Phrase SautLigne = new Phrase("\n");
                nouveauDocument.Add(SautLigne);

                /////////////////////Ligne Facture (Prix et Quantité)////////////////////////
                //Déclaration des contenus
                //A ne pas Modifier
                Phrase Reference = new Phrase("Référence", adresse);
                Phrase Designation = new Phrase("Désignation", adresse);
                Phrase Quantite = new Phrase("Qté", adresse);
                Phrase PrixU = new Phrase("P.U. HT", adresse);
                Phrase MontantTTC = new Phrase("Montant TTC", adresse);
                //A Modifier
                Phrase ValRef = new Phrase("...........", adresse);
                Phrase ValDesign = new Phrase("..............................", adresse);
                Phrase ValQuantite = new Phrase("0,00", adresse);
                Phrase ValPrix = new Phrase("0,000", adresse);
                Phrase ValMontant = new Phrase("0,00", adresse);
                Phrase totalTTC = new Phrase("\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                                             TOTAL TTC                                   " + totalTtc + "€", boldFont);
                Phrase montantAPayer = new Phrase("\n\n\n\n                                                                                             MONTANT A PAYER                    " + totalTtc + "€", boldFont);

                //Première ligne du tableau
                int[] intTblWidth3 = { 4, 8, 2, 2, 4 };
                PdfPTable tableauLigneFact1 = new PdfPTable(5);
                PdfPCell celluleLigneFact1 = new PdfPCell();
                tableauLigneFact1.TotalWidth = 540;
                tableauLigneFact1.SetWidths(intTblWidth3);
                tableauLigneFact1.DefaultCell.BorderColor = new BaseColor(255, 255, 255);
                tableauLigneFact1.DefaultCell.BackgroundColor = new BaseColor(253, 253, 213);
                tableauLigneFact1.LockedWidth = true;
                celluleLigneFact1.Colspan = 5;
                tableauLigneFact1.AddCell(Reference);
                tableauLigneFact1.AddCell(Designation);
                tableauLigneFact1.AddCell(Quantite);
                tableauLigneFact1.AddCell(PrixU);
                tableauLigneFact1.AddCell(MontantTTC);
                nouveauDocument.Add(tableauLigneFact1);
                //Deuxième ligne du tableau
                PdfPTable tableauLigneFact2 = new PdfPTable(5);
                PdfPCell celluleLigneFact2 = new PdfPCell();
                tableauLigneFact2.TotalWidth = 540;
                tableauLigneFact2.SetWidths(intTblWidth3);
                tableauLigneFact2.DefaultCell.BorderColor = new BaseColor(255, 255, 255);
                tableauLigneFact2.LockedWidth = true;
                celluleLigneFact2.Colspan = 5;
                tableauLigneFact2.AddCell("AFFRAN");
                tableauLigneFact2.AddCell("Affranchissement");
                tableauLigneFact2.AddCell(quantiteAffranchissement);
                tableauLigneFact2.AddCell(prixAffranchissement.ToString()+"0");
                tableauLigneFact2.AddCell(montantAffranchissement + "€");
                tableauLigneFact2.AddCell("PHOTOCOULEUR");
                tableauLigneFact2.AddCell("Photocopies couleur");
                tableauLigneFact2.AddCell(quantitePhotocouleur);
                tableauLigneFact2.AddCell(prixPhotocouleur.ToString()+"0");
                tableauLigneFact2.AddCell(montantPhotocouleur + "€");
                tableauLigneFact2.AddCell("PHOTON&B");
                tableauLigneFact2.AddCell("Photocopies noir et blanc");
                tableauLigneFact2.AddCell(quantitePhotoNb);
                tableauLigneFact2.AddCell(prixPhotoNb.ToString());
                tableauLigneFact2.AddCell(montantPhotoNb + "€");
                tableauLigneFact2.AddCell("TRACEUR");
                tableauLigneFact2.AddCell("Utilisation du traceur");
                tableauLigneFact2.AddCell(quantiteTraceur);
                tableauLigneFact2.AddCell(prixTraceur.ToString());
                tableauLigneFact2.AddCell(montantTraceur + "€");
                nouveauDocument.Add(tableauLigneFact2);
                nouveauDocument.Add(totalTTC);
                nouveauDocument.Add(montantAPayer);
                Phrase footer = new Phrase("\n\n\nDéclaré à la préfecture de Meurthe et Moselle N°3898\nDomiciliation bancaire 10278 04065 00016911045 05\nMerci de bien vouloir préciser les références de la facture acquittée\nTVA non applicable", adresse);
                nouveauDocument.Add(footer);

                ////////////////////////////////////////////////////////////
                ////////////////////////Ferme le PDF////////////////////////
                ////////////////////////////////////////////////////////////
                nouveauDocument.Close();
                System.Diagnostics.Process.Start(@"c:\Users\OSN\Desktop\Chapter1_Example1.pdf");

            }
        }
        public class DBConnect
        {
            private MySqlConnection connection;
            private string server;
            private string database;
            private string uid;
            private string password;
            private string charset;

            //Constructor
            public DBConnect()
            {
                Initialize();
            }

            //Initialize values
            private void Initialize()
            {
                server = "localhost";
                database = "m2l";
                uid = "root";
                password = "";
                charset = "UTF8";
                string connectionString;
                connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";" + "CHARSET=" + charset + ";";

                connection = new MySqlConnection(connectionString);
            }

            //open connection to database
            private bool OpenConnection()
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (MySqlException ex)
                {
                    //When handling errors, you can your application's response based 
                    //on the error number.
                    //The two most common error numbers when connecting are as follows:
                    //0: Cannot connect to server.
                    //1045: Invalid user name and/or password.
                    switch (ex.Number)
                    {
                        case 0:
                            MessageBox.Show("Cannot connect to server.  Contact administrator");
                            break;

                        case 1045:
                            MessageBox.Show("Invalid username/password, please try again");
                            break;
                    }
                    return false;
                }
            }

            //Close connection
            private bool CloseConnection()
            {
                try
                {
                    connection.Close();
                    return true;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }

            //Insert statement
            public void Insert()
            {
                string query = "INSERT INTO tableinfo (name, age) VALUES('John Smith', '33')";

                //open connection
                if (this.OpenConnection() == true)
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    //Execute command
                    cmd.ExecuteNonQuery();

                    //close connection
                    this.CloseConnection();
                }
            }

            //Update statement
            public void Update()
            {
                string query = "UPDATE tableinfo SET name='Joe', age='22' WHERE name='John Smith'";

                //Open connection
                if (this.OpenConnection() == true)
                {
                    //create mysql command
                    MySqlCommand cmd = new MySqlCommand();
                    //Assign the query using CommandText
                    cmd.CommandText = query;
                    //Assign the connection using Connection
                    cmd.Connection = connection;

                    //Execute query
                    cmd.ExecuteNonQuery();

                    //close connection
                    this.CloseConnection();
                }
            }

            //Delete statement
            public void Delete()
            {
                string query = "DELETE FROM tableinfo WHERE name='John Smith'";

                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                }
            }

            //Select statement
            public List<string>[] Select()
            {
                string query = "SELECT * FROM ligue LIMIT 1";

                //Create a list to store the result
                List<string>[] list = new List<string>[4];
                list[0] = new List<string>();
                list[1] = new List<string>();
                list[2] = new List<string>();
                list[3] = new List<string>();

                //Open connection
                if (this.OpenConnection() == true)
                {
                    //Create Command
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    //Create a data reader and Execute the command
                    MySqlDataReader dataReader = cmd.ExecuteReader();


                    //Read the data and store them in the list
                    while (dataReader.Read())
                    {
                        list[0].Add(dataReader["CodeLigue"] + "");
                        list[1].Add(dataReader["NomLigue"] + "");
                        list[2].Add(dataReader["SportLigue"] + "");
                        list[3].Add(dataReader["NomTresorier"] + "");
                    }

                    //close Data Reader
                    dataReader.Close();

                    //close Connection 
                    this.CloseConnection();

                    //return list to be displayed
                    System.Console.WriteLine(list);
                    return list;
                }
                else
                {
                    return list;
                }
            }

            public string SelectLigue()
            {
                string query = "SELECT * FROM ligue LIMIT 1";
                string champLigue = "";

                //Open connection
                if (this.OpenConnection() == true)
                {
                    //Create Command
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    //Create a data reader and Execute the command
                    MySqlDataReader dataReader = cmd.ExecuteReader();


                    //Read the data and store them in the list
                    while (dataReader.Read())
                    {
                        champLigue = "\"" + dataReader["CodeLigue"] + "\",\"" + dataReader["NomLigue"] + "\",\"" + dataReader["SportLigue"] + "\",\"" + dataReader["NomTresorier"] + "\"";
                    }

                    //close Data Reader
                    dataReader.Close();

                    //close Connection 
                    this.CloseConnection();

                    //return list to be displayed

                    return champLigue;
                }
                else
                {
                    return champLigue;
                }
            }
            //Count statement
            public int Count()
            {
                string query = "SELECT Count(*) FROM tableinfo";
                int Count = -1;

                //Open Connection
                if (this.OpenConnection() == true)
                {
                    //Create Mysql Command
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    //ExecuteScalar will return one value
                    Count = int.Parse(cmd.ExecuteScalar() + "");

                    //close Connection
                    this.CloseConnection();

                    return Count;
                }
                else
                {
                    return Count;
                }
            }


        }

        private void dataGridViewListeFacture_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            indexRowListeFacture = e.RowIndex;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabAcceuil_Click(object sender, EventArgs e)
        {

        }

        private void tabLigue_Click(object sender, EventArgs e)
        {
          
        }

        private void tabPrestation_Click(object sender, EventArgs e)
        {
            
        }

        private void tabFacture_Click(object sender, EventArgs e)
        {

        }

        private void tab1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (utilisateur != "411000") // si l'utilisateur n'est pas admin on ne lui permet que de charger les grid avec des données qui lui correspondent.
            {
                mySqlDataAdapter1 = new MySqlDataAdapter("select CodeLigue as 'Code ligue', NomLigue as 'Nom Ligue', SportLigue as 'Sport ligue', NomTresorier as 'Nom trésorier', PrenomTresorier as 'Prénom trésorier', AdresseTresorier as 'Adresse trésorier',CodePostalTresorier as 'Code postal trésorier', CommuneTresorier as 'Commune trésorier' from ligue where CodeLigue=" + utilisateur, "SERVER=localhost" + ";" + "DATABASE=m2l" + ";" + "UID=root" + ";" + "PASSWORD=" + ";" + "CHARSET=utf8" + ";");
                // mySqlDataAdapter1 = new MySqlDataAdapter("select * from ligue", "SERVER=localhost" + ";" + "DATABASE=m2l" + ";" + "UID=root" + ";" + "PASSWORD=" + ";" + "CHARSET=utf8" + ";");
                DataSet DS1 = new DataSet();
                mySqlDataAdapter1.Fill(DS1);
                dataGridView1.DataSource = DS1.Tables[0];
                dataGridView1.Columns[0].Width = 50;
                dataGridView1.Columns[1].Width = 150;

                // dataGridView1.Columns[0].HeaderCell.Value = "Code ligue";
                // dataGridView1.Columns[1].HeaderCell.Value = "Nom ligue";
                // dataGridView1.Columns[2].HeaderCell.Value = "Sport";
                // dataGridView1.Columns[3].HeaderCell.Value = "Nom trésorier";
                // dataGridView1.Columns[4].HeaderCell.Value = "Prénom trésorier";
                // dataGridView1.Columns[5].HeaderCell.Value = "Adresse trésorier";
                // dataGridView1.Columns[6].HeaderCell.Value = "Code postal trésorier";
                // dataGridView1.Columns[7].HeaderCell.Value = "Commune trésorier";

                mySqlDataAdapter2 = new MySqlDataAdapter("select ReferencePrestation as 'Référence prestation', NomPrestation as 'Nom Prestation',PrixUnitaireHT as 'Prix unitaire HT' from prestation", "SERVER=localhost" + ";" + "DATABASE=m2l" + ";" + "UID=root" + ";" + "PASSWORD=" + ";" + "CHARSET=utf8" + ";");
                // mySqlDataAdapter2 = new MySqlDataAdapter("select * from prestation", "SERVER=localhost" + ";" + "DATABASE=m2l" + ";" + "UID=root" + ";" + "PASSWORD=" + ";" + "CHARSET=utf8" + ";");
                DataSet DS2 = new DataSet();
                mySqlDataAdapter2.Fill(DS2);
                dataGridViewPrestation.DataSource = DS2.Tables[0];
                dataGridViewPrestation.Columns[0].Width = 115;
                dataGridViewPrestation.Columns[1].Width = 160;
                dataGridViewPrestation.Columns[2].Width = 50;
                //dataGridViewPrestation.Columns[0].HeaderCell.Value = "Référence prestation";
                //dataGridViewPrestation.Columns[1].HeaderCell.Value = "Nom Prestation";
                //dataGridViewPrestation.Columns[2].HeaderCell.Value = "Prix unitaire HT";

                mySqlDataAdapter3 = new MySqlDataAdapter("select NumeroFacture as 'Numéro facture', DateFacture as 'Date facture',DateEcheance as 'Date écheance', CodeLigue as 'Code ligue', TotalTTC as 'Total ttc' from facture where CodeLigue="+utilisateur, "SERVER=localhost" + ";" + "DATABASE=m2l" + ";" + "UID=root" + ";" + "PASSWORD=" + ";" + "CHARSET=utf8" + ";");
                DataSet DS3 = new DataSet();
                mySqlDataAdapter3.Fill(DS3);
                dataGridViewListeFacture.DataSource = DS3.Tables[0];
            }
            else // si l'utilisateur est l'admin il charge toutes les données dans les grids.
            {
                mySqlDataAdapter1 = new MySqlDataAdapter("select CodeLigue as 'Code ligue', NomLigue as 'Nom Ligue', SportLigue as 'Sport ligue', NomTresorier as 'Nom trésorier', PrenomTresorier as 'Prénom trésorier', AdresseTresorier as 'Adresse trésorier',CodePostalTresorier as 'Code postal trésorier', CommuneTresorier as 'Commune trésorier' from ligue", "SERVER=localhost" + ";" + "DATABASE=m2l" + ";" + "UID=root" + ";" + "PASSWORD=" + ";" + "CHARSET=utf8" + ";");              
                DataSet DS1 = new DataSet();
                mySqlDataAdapter1.Fill(DS1);
                dataGridView1.DataSource = DS1.Tables[0];
                dataGridView1.Columns[0].Width = 50;
                dataGridView1.Columns[1].Width = 150;           

                mySqlDataAdapter2 = new MySqlDataAdapter("select ReferencePrestation as 'Référence prestation', NomPrestation as 'Nom Prestation',PrixUnitaireHT as 'Prix unitaire HT' from prestation", "SERVER=localhost" + ";" + "DATABASE=m2l" + ";" + "UID=root" + ";" + "PASSWORD=" + ";" + "CHARSET=utf8" + ";");   
                DataSet DS2 = new DataSet();
                mySqlDataAdapter2.Fill(DS2);
                dataGridViewPrestation.DataSource = DS2.Tables[0];
                dataGridViewPrestation.Columns[0].Width = 115;
                dataGridViewPrestation.Columns[1].Width = 160;
                dataGridViewPrestation.Columns[2].Width = 50;
               
                mySqlDataAdapter3 = new MySqlDataAdapter("select NumeroFacture as 'Numéro facture', DateFacture as 'Date facture',DateEcheance as 'Date écheance', CodeLigue as 'Code ligue', TotalTTC as 'Total ttc' from facture", "SERVER=localhost" + ";" + "DATABASE=m2l" + ";" + "UID=root" + ";" + "PASSWORD=" + ";" + "CHARSET=utf8" + ";");
                DataSet DS3 = new DataSet();
                mySqlDataAdapter3.Fill(DS3);
                dataGridViewListeFacture.DataSource = DS3.Tables[0];
            
            }
         
        }

        private void btnAjouterLigue_Click(object sender, EventArgs e)
        {
            f3 = new Form3();      
            f3.Dgv = this.dataGridView1;
            f3.ShowDialog();
        }

        public void Rafraichir() 
        {
            dataGridView1.Update();
            dataGridView1.Refresh();
            dataGridViewListeFacture.Update();
            dataGridViewListeFacture.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void btnAJouterPrestation_Click(object sender, EventArgs e)
        {
            f4 = new Form4();
            f4.Dgv = this.dataGridViewPrestation;
            f4.ShowDialog();
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            
            mySqlDataAdapter4 = new MySqlDataAdapter("select * from facture where CodeLigue="+e.Row.Cells[0].Value.ToString(), "SERVER=localhost" + ";" + "DATABASE=m2l" + ";" + "UID=root" + ";" + "PASSWORD=" + ";" + "CHARSET=utf8" + ";");
            DataTable DT1 = new DataTable();
            mySqlDataAdapter4.Fill(DT1);
            if (DT1.Rows.Count>0)
            {

                MessageBox.Show("Impossible de supprimer la ligue " + e.Row.Cells[0].Value.ToString() +", elle est utilisée.", "Erreur");
                e.Cancel = true;
            }
        }

        private void dataGridViewPrestation_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            mySqlDataAdapter4 = new MySqlDataAdapter("select * from ligne_facture where ReferencePrestation='"+ e.Row.Cells[0].Value.ToString()+"'", "SERVER=localhost" + ";" + "DATABASE=m2l" + ";" + "UID=root" + ";" + "PASSWORD=" + ";" + "CHARSET=utf8" + ";");
            DataTable DT1 = new DataTable();
            mySqlDataAdapter4.Fill(DT1);
            if (DT1.Rows.Count > 0)
            {
                MessageBox.Show("Impossible de supprimer la prestation "+e.Row.Cells[0].Value.ToString()+", elle est utilisée.", "Erreur");
                e.Cancel = true;
            }
        }



        static string Hash(string input) //methode pour retourner une string hashée en sha1
        {
            var hash = (new SHA1Managed()).ComputeHash(Encoding.UTF8.GetBytes(input));
            return string.Join("", hash.Select(b => b.ToString("x2")).ToArray());
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {         
            var connectionString = "SERVER=localhost" + ";" + "DATABASE=m2l" + ";" + "UID=root" + ";" + "PASSWORD=" + ";" + "CHARSET=utf8" + ";";
            using (var connection = new MySqlConnection(connectionString))
            {
               connection.Open();
               var query = "SELECT * FROM auth WHERE Login='" + Hash(afficheurLogin.Text) + "' AND MotDePasse='"+Hash(afficheurMdp.Text)+"';";
               using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            utilisateur = reader.GetString("CodeLigue");
                            
                        }

                    }
                }
            }            
            if (utilisateur==null)
            {
                MessageBox.Show("Le login et/ou le mot de passe semble incorrect.", "Erreur");
            }          
            else if (utilisateur != "411000")
            {
                tab1.Visible = true;
                panel1.Visible = false;
                dataGridView1.Visible = true;
                dataGridViewPrestation.Visible = true;
                dataGridViewListeFacture.Visible = true;
                dataGridView1.ReadOnly = true;
                dataGridViewPrestation.ReadOnly = true;
                dataGridViewListeFacture.ReadOnly = true;
                dataGridView1.AllowUserToDeleteRows = false;
                dataGridViewPrestation.AllowUserToDeleteRows = false;
                dataGridViewListeFacture.AllowUserToDeleteRows = false;
                btnAjouterLigue.Visible = false;
                btnAJouterPrestation.Visible = false;
                btnImprimer.Visible = true;
                btnFacture.Visible = false;
                btnImprimer.Left = (this.ClientSize.Width - btnImprimer.Width) / 2;
              //  btnImprimer.Top = (this.ClientSize.Height - btnImprimer.Height) / 2;

                mySqlDataAdapter1 = new MySqlDataAdapter("select CodeLigue as 'Code ligue', NomLigue as 'Nom Ligue', SportLigue as 'Sport ligue', NomTresorier as 'Nom trésorier', PrenomTresorier as 'Prénom trésorier', AdresseTresorier as 'Adresse trésorier',CodePostalTresorier as 'Code postal trésorier', CommuneTresorier as 'Commune trésorier' from ligue where CodeLigue="+utilisateur, "SERVER=localhost" + ";" + "DATABASE=m2l" + ";" + "UID=root" + ";" + "PASSWORD=" + ";" + "CHARSET=utf8" + ";");
                DataSet DS1 = new DataSet();
                mySqlDataAdapter1.Fill(DS1);
                dataGridView1.DataSource = DS1.Tables[0];
                dataGridView1.Columns[0].Width = 50;
                dataGridView1.Columns[1].Width = 150;

                mySqlDataAdapter2 = new MySqlDataAdapter("select ReferencePrestation as 'Référence prestation', NomPrestation as 'Nom Prestation',PrixUnitaireHT as 'Prix unitaire HT' from prestation", "SERVER=localhost" + ";" + "DATABASE=m2l" + ";" + "UID=root" + ";" + "PASSWORD=" + ";" + "CHARSET=utf8" + ";");
                DataSet DS2 = new DataSet();
                mySqlDataAdapter2.Fill(DS2);
                dataGridViewPrestation.DataSource = DS2.Tables[0];
                dataGridViewPrestation.Columns[0].Width = 115;
                dataGridViewPrestation.Columns[1].Width = 160;
                dataGridViewPrestation.Columns[2].Width = 50;

                mySqlDataAdapter3 = new MySqlDataAdapter("select NumeroFacture as 'Numéro facture', DateFacture as 'Date facture',DateEcheance as 'Date écheance', CodeLigue as 'Code ligue', TotalTTC as 'Total ttc' from facture where CodeLigue="+utilisateur, "SERVER=localhost" + ";" + "DATABASE=m2l" + ";" + "UID=root" + ";" + "PASSWORD=" + ";" + "CHARSET=utf8" + ";");
                DataSet DS3 = new DataSet();
                mySqlDataAdapter3.Fill(DS3);
                dataGridViewListeFacture.DataSource = DS3.Tables[0];
            }
            else
            {        
                tab1.Visible = true;
                panel1.Visible = false;
                dataGridView1.Visible = true;
                dataGridViewPrestation.Visible = true;
                dataGridViewListeFacture.Visible = true;
                btnImprimer.Visible = true;
                btnFacture.Visible = true;


                mySqlDataAdapter1 = new MySqlDataAdapter("select CodeLigue as 'Code ligue', NomLigue as 'Nom Ligue', SportLigue as 'Sport ligue', NomTresorier as 'Nom trésorier', PrenomTresorier as 'Prénom trésorier', AdresseTresorier as 'Adresse trésorier',CodePostalTresorier as 'Code postal trésorier', CommuneTresorier as 'Commune trésorier' from ligue", "SERVER=localhost" + ";" + "DATABASE=m2l" + ";" + "UID=root" + ";" + "PASSWORD=" + ";" + "CHARSET=utf8" + ";");
                DataSet DS1 = new DataSet();
                mySqlDataAdapter1.Fill(DS1);
                dataGridView1.DataSource = DS1.Tables[0];
                dataGridView1.Columns[0].Width = 50;
                dataGridView1.Columns[1].Width = 150;

                mySqlDataAdapter2 = new MySqlDataAdapter("select ReferencePrestation as 'Référence prestation', NomPrestation as 'Nom Prestation',PrixUnitaireHT as 'Prix unitaire HT' from prestation", "SERVER=localhost" + ";" + "DATABASE=m2l" + ";" + "UID=root" + ";" + "PASSWORD=" + ";" + "CHARSET=utf8" + ";");
                DataSet DS2 = new DataSet();
                mySqlDataAdapter2.Fill(DS2);
                dataGridViewPrestation.DataSource = DS2.Tables[0];
                dataGridViewPrestation.Columns[0].Width = 115;
                dataGridViewPrestation.Columns[1].Width = 160;
                dataGridViewPrestation.Columns[2].Width = 50;

                mySqlDataAdapter3 = new MySqlDataAdapter("select NumeroFacture as 'Numéro facture', DateFacture as 'Date facture',DateEcheance as 'Date écheance', CodeLigue as 'Code ligue', TotalTTC as 'Total ttc' from facture", "SERVER=localhost" + ";" + "DATABASE=m2l" + ";" + "UID=root" + ";" + "PASSWORD=" + ";" + "CHARSET=utf8" + ";");
                DataSet DS3 = new DataSet();
                mySqlDataAdapter3.Fill(DS3);
                dataGridViewListeFacture.DataSource = DS3.Tables[0];
            }

        }
     
    }
}

        
    
