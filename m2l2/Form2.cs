using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using MySql.Data.MySqlClient;

namespace m2l2
{
    public partial class Form2 : Form
    {

        string gestionnaire;
        string ligue;
        string codeFacture;
        string adresseTresorier;
        string commune;
        string codePostal;
        DateTime dateTime = DateTime.UtcNow.Date;
        string codeClient;
        DateTime dernierJour = new DateTime(DateTime.UtcNow.Date.Year,
                                   DateTime.UtcNow.Date.Month,
                                   DateTime.DaysInMonth(DateTime.UtcNow.Date.Year,
                                                        DateTime.UtcNow.Date.Month));
        //string quantiteAffranchissement, quantitePhotocopieCouleur, quantitePhotocopieNb, quantiteTraceur, montantAffranchissement, montantPhotocopieCouleur, montantPhotocopieNb, montantTraceur;
   



        public Form2()
        {
          
            InitializeComponent();
            var connectionString = "SERVER=localhost" + ";" + "DATABASE=m2l" + ";" + "UID=root"+";" + "PASSWORD=" +";"+"CHARSET=utf8"+";";
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT NomLigue FROM ligue";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        //Iterate through the rows and add it to the combobox's items
                        while (reader.Read())
                        {
                              comboBox1.Items.Add(reader.GetString("NomLigue"));
                        }
                    }
                }
            }
        }
   

        private void Form2_Load(object sender, EventArgs e)
        {

        }
     

        private void btnGenererPdf_Click(object sender, EventArgs e)
        {
            string where = comboBox1.Text;
            var connectionString = "SERVER=localhost" + ";" + "DATABASE=m2l" + ";" + "UID=root" + ";" + "PASSWORD=" + ";" + "CHARSET=utf8" + ";";
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT * FROM ligue WHERE Nomligue='"+where+"'";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                           
                            gestionnaire = reader.GetString("NomTresorier")+" "+reader.GetString("PrenomTresorier");
                            ligue = where;
                            codeClient = reader.GetString("CodeLigue");
                            //adresseTresorier = reader.GetString("AdresseTresorier");
                            //codePostal = reader.GetString("CodePostalTresorier");
                            //commune = reader.GetString("CommuneTresorier");

                        }
                        
                    }
                }
                var query2 = "SELECT * FROM facture ORDER BY NumeroFacture DESC LIMIT 1;";
                using (var command = new MySqlCommand(query2, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string MyString = reader.GetString("NumeroFacture");
                            char[] MyChar = { 'F', 'C',' ' };
                            codeFacture = "FC "+(int.Parse(MyString.TrimStart(MyChar))+1).ToString();
                        
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

         
            btnGenererPdf.Visible = false;
            btnSauvegarder.Visible = true;
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
           // Chunk test3 = new Chunk("    " + adresseTresorier + "\n    " + codePostal + "\n    " + commune + "\n    FRANCE", adresse);
            test2.Add(test3);



            Paragraph adressestr = new Paragraph(" \n \n \n \n \n \n \n \n    "+ligue+" \n \n    A l'attention de "+gestionnaire+" \n", boldFont);
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
            Phrase ValDate = new Phrase(dateTime.ToString("dd/MM/yyyy"), adresse);
            Phrase ValNum = new Phrase(codeFacture, adresse);
            Phrase ValCodeCli = new Phrase(codeClient, adresse);
            Phrase ValDatecheance = new Phrase(dernierJour.ToString("dd/MM/yyyy"), adresse);

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
            Phrase totalTTC = new Phrase("\n\n\n\n\n\n\n\n\n\n\n\n\n                                                                                         TOTAL TTC                                   "+totalTtc.Text+"€", boldFont);
            Phrase montantAPayer = new Phrase("\n\n\n\n                                                                                         MONTANT A PAYER                    " + totalTtc.Text + "€", boldFont);   

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
            tableauLigneFact2.AddCell(afficheurAffranchissement.Text);
            tableauLigneFact2.AddCell("3,330");
            tableauLigneFact2.AddCell(montantAffranchissement.Text + "€");
            tableauLigneFact2.AddCell("PHOTOCOULEUR");
            tableauLigneFact2.AddCell("Photocopies couleur");
            tableauLigneFact2.AddCell(afficheurPhotocopieCouleur.Text);
            tableauLigneFact2.AddCell("0,240");
            tableauLigneFact2.AddCell(montantPhotocopiesCouleur.Text + "€");
            tableauLigneFact2.AddCell("PHOTON&B");
            tableauLigneFact2.AddCell("Photocopies noir et blanc");
            tableauLigneFact2.AddCell(afficheurPhotocopieNb.Text);
            tableauLigneFact2.AddCell("0,055");
            tableauLigneFact2.AddCell(montantPhotocopieNb.Text +"€");
            tableauLigneFact2.AddCell("TRACEUR");
            tableauLigneFact2.AddCell("Utilisation du traceur");
            tableauLigneFact2.AddCell(afficheurTraceur.Text);
            tableauLigneFact2.AddCell("0,356");
            tableauLigneFact2.AddCell(montantTraceur.Text + "€");
            nouveauDocument.Add(tableauLigneFact2);
            nouveauDocument.Add(totalTTC);
            nouveauDocument.Add(montantAPayer);
            Phrase footer = new Phrase("\n\n\nDéclaré à la préfecture de Meurthe et Moselle N°3898\nDomiciliation bancaire 10278 04065 00016911045 05\nMerci de bien vouloir préciser les références de la facture acquittée\nTVA non applicable",adresse);
            nouveauDocument.Add(footer);

            ////////////////////////////////////////////////////////////
            ////////////////////////Ferme le PDF////////////////////////
            ////////////////////////////////////////////////////////////
            nouveauDocument.Close();
            System.Diagnostics.Process.Start(@"c:\Users\OSN\Desktop\Chapter1_Example1.pdf");

        }
       
        private void btnSauvegarder_Click(object sender, EventArgs e)
        {
            btnSauvegarder.Visible = false;


            using (MySqlConnection cn = new MySqlConnection("SERVER=localhost" + ";" + "DATABASE=m2l" + ";" + "UID=root"+";" + "PASSWORD=" +";"+"CHARSET=utf8"+";"))
            {
                cn.Open();
                using (MySqlCommand cmd = new MySqlCommand("INSERT INTO facture(NumeroFacture,DateFacture,DateEcheance,CodeLigue,TotalTTC) VALUES(@NumeroFacture, @DateFacture,@DateEcheance,@CodeLigue,@TotalTTC)", cn))
                {
                    cmd.Parameters.AddWithValue("@NumeroFacture", codeFacture);
                    cmd.Parameters.AddWithValue("@DateFacture", dateTime);
                    cmd.Parameters.AddWithValue("@DateEcheance", dernierJour);
                    cmd.Parameters.AddWithValue("@CodeLigue", codeClient);
                    cmd.Parameters.AddWithValue("@TotalTTC", float.Parse(totalTtc.Text));
                    cmd.ExecuteNonQuery();
                   
                }
                using (MySqlCommand cmd = new MySqlCommand("INSERT INTO ligne_facture(NumeroFacture,ReferencePrestation,NomPrestation,Quantite) VALUES(@NumeroFacture, @ReferencePrestation,@NomPrestation,@Quantite)", cn))
                {
                    cmd.Parameters.AddWithValue("@NumeroFacture", codeFacture);
                    cmd.Parameters.AddWithValue("@ReferencePrestation", "AFFRAN");
                    cmd.Parameters.AddWithValue("@NomPrestation", "Affranchissement");
                    cmd.Parameters.AddWithValue("@Quantite", float.Parse(afficheurAffranchissement.Text));
                    cmd.ExecuteNonQuery();

                }
                using (MySqlCommand cmd = new MySqlCommand("INSERT INTO ligne_facture(NumeroFacture,ReferencePrestation,NomPrestation,Quantite) VALUES(@NumeroFacture, @ReferencePrestation,@NomPrestation,@Quantite)", cn))
                {
                    cmd.Parameters.AddWithValue("@NumeroFacture", codeFacture);
                    cmd.Parameters.AddWithValue("@ReferencePrestation", "PHOTOCOULEUR");
                    cmd.Parameters.AddWithValue("@NomPrestation", "Photocopies couleur");
                    cmd.Parameters.AddWithValue("@Quantite", float.Parse(afficheurPhotocopieCouleur.Text));
                    cmd.ExecuteNonQuery();

                }
                using (MySqlCommand cmd = new MySqlCommand("INSERT INTO ligne_facture(NumeroFacture,ReferencePrestation,NomPrestation,Quantite) VALUES(@NumeroFacture, @ReferencePrestation,@NomPrestation,@Quantite)", cn))
                {
                    cmd.Parameters.AddWithValue("@NumeroFacture", codeFacture);
                    cmd.Parameters.AddWithValue("@ReferencePrestation", "PHOTON&B");
                    cmd.Parameters.AddWithValue("@NomPrestation", "Photocopies Noir et Blanc");
                    cmd.Parameters.AddWithValue("@Quantite", float.Parse(afficheurPhotocopieNb.Text));
                    cmd.ExecuteNonQuery();

                }
                using (MySqlCommand cmd = new MySqlCommand("INSERT INTO ligne_facture(NumeroFacture,ReferencePrestation,NomPrestation,Quantite) VALUES(@NumeroFacture, @ReferencePrestation,@NomPrestation,@Quantite)", cn))
                {
                    cmd.Parameters.AddWithValue("@NumeroFacture", codeFacture);
                    cmd.Parameters.AddWithValue("@ReferencePrestation", "TRACEUR");
                    cmd.Parameters.AddWithValue("@NomPrestation", "Utilisation du traceur");
                    cmd.Parameters.AddWithValue("@Quantite", float.Parse(afficheurTraceur.Text));
                    cmd.ExecuteNonQuery();

                }
            }
            this.Close();
        }

        private void afficheurAffranchissement_TextChanged(object sender, EventArgs e)
        {
            if (afficheurAffranchissement.Text == "") { montantAffranchissement.Text = "0,00"; }
            else
            {
                montantAffranchissement.Text = (float.Parse(afficheurAffranchissement.Text) * float.Parse(prixAffranchissement.Text)).ToString("0.00");
            }
            totalTtc.Text = (float.Parse(montantTraceur.Text) + float.Parse(montantPhotocopiesCouleur.Text) + float.Parse(montantPhotocopieNb.Text) + float.Parse(montantAffranchissement.Text)).ToString("0.00");
        }

        private void afficheurPhotocopieCouleur_TextChanged(object sender, EventArgs e)
        {
            if (afficheurPhotocopieCouleur.Text == "") {montantPhotocopiesCouleur.Text = "0,00"; }
            else
            {
                montantPhotocopiesCouleur.Text = (float.Parse(afficheurPhotocopieCouleur.Text) * float.Parse(prixPhotocopieCouleur.Text)).ToString("0.00");
            }
            totalTtc.Text = (float.Parse(montantTraceur.Text) + float.Parse(montantPhotocopiesCouleur.Text) + float.Parse(montantPhotocopieNb.Text) + float.Parse(montantAffranchissement.Text)).ToString("0.00");
        }

        private void afficheurPhotocopieNb_TextChanged(object sender, EventArgs e)
        {
            if (afficheurPhotocopieNb.Text == "") { montantPhotocopieNb.Text = "0,00"; }
            else
            {
                montantPhotocopieNb.Text = (float.Parse(afficheurPhotocopieNb.Text) * float.Parse(prixPhotocopieNb.Text)).ToString("0.00");
            }
            totalTtc.Text = (float.Parse(montantTraceur.Text) + float.Parse(montantPhotocopiesCouleur.Text) + float.Parse(montantPhotocopieNb.Text) + float.Parse(montantAffranchissement.Text)).ToString("0.00");
        }

        private void afficheurTraceur_TextChanged(object sender, EventArgs e)
        {
            if (afficheurTraceur.Text == "") { montantTraceur.Text = "0,00"; }
            else
            {
                montantTraceur.Text = (float.Parse(afficheurTraceur.Text) * float.Parse(prixTraceur.Text)).ToString("0.00");
            }
            totalTtc.Text = (float.Parse(montantTraceur.Text) + float.Parse(montantPhotocopiesCouleur.Text) + float.Parse(montantPhotocopieNb.Text) + float.Parse(montantAffranchissement.Text)).ToString("0.00");
        }

    }
}
