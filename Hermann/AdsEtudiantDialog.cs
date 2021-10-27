/*
 * Created by SharpDevelop.
 * User: Hermann
 * Date: 03/09/2019
 * Time: 17:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;

namespace Hermann
{
	/// <summary>
	/// Description of AdsEtudiantDialog.
	/// </summary>
	public partial class AdsEtudiantDialog : Form
	{
		BD_Class bd = new BD_Class();
		public AdsEtudiantDialog()
		{
			InitializeComponent();
		}
		void InscritClick(object sender, EventArgs e)
		{
			string nom, prenom, dateNaiss;
			int num, filiere; 
			nom = textNom.Text.Trim();
			prenom = textPrenom.Text.Trim();
			dateNaiss = textDateNaiss.Text.Trim();
			num = int.Parse (textMatricule.Text.Trim ());
			testFiliere(out filiere);
			
			string model = @"^\s*[0-3]?\s*\d\s*/\s*(0|1)?\s*\d\s*/\s*\d{4}\s*$";
			Regex reg = new Regex (model);
			if (reg.IsMatch (dateNaiss)){
				if (nom.Length > 0){
					if (prenom.Length > 0){
						if (dateNaiss.Length > 0){
							Etudiant newEtudiant = new Etudiant(nom, prenom, dateNaiss, num, filiere);
							bd.ajouteEtudiant(ref newEtudiant);
							
							textNom.Text = " ";
							textPrenom.Text =  " ";
						 	textDateNaiss.Text = " ";
							textMatricule.Text = "";
							
							Close();
						}
                	}
					else{
                        MessageBox.Show("il faut remplit le prénom d'étudiant", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
				}
                else{
                   	MessageBox.Show("il faut remplit le nom d'étudiant", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
			}
			
			else{
                MessageBox.Show("la format la date de naissance n'est pas réspécter jj/mm/aaaa  \n  Exemple  "+DateTime.Now.Day+"/"+DateTime.Now.Month+"/"+DateTime.Now.Year, "Erreure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
		}
		
		int choixFiliere(){
			if (RadioMA.Checked)
				return 1;
			else if (RadioTELECOM.Checked)
				return 2;
			else if (RadioTOUR.Checked)
				return 3;
			else if (RadioMC.Checked)
				return 4;
			else if (RadioIG.Checked)
				return 5;
			return 0;
		}
		
		void testFiliere(out int filiere){
			filiere = 0;
			if (RadioMA.Checked || RadioTELECOM.Checked || RadioIG.Checked || RadioTOUR.Checked || RadioMC.Checked)
				filiere = choixFiliere();
			else
				MessageBox.Show ("Veuiller cocher une Filiere s'il vous plais!!");
		}
		
		void PictureBox1Click(object sender, EventArgs e)
		{
			Close();
		}
		
		void AnnulerClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
