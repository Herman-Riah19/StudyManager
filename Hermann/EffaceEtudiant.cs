/*
 * Created by SharpDevelop.
 * User: Hermann
 * Date: 10/10/2019
 * Time: 19:20
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
	public partial class EffaceEtudiant : Form
	{
		BD_Class bd = new BD_Class ();
		public EffaceEtudiant()
		{
			InitializeComponent();
			Informations.Hide ();
		}
		void AnnulerClick(object sender, EventArgs e)
		{
			Close ();
		}
		void EffacerClick(object sender, EventArgs e)
		{
			string nom, prenom, dateNaiss;
			int num; 
			nom = textNom.Text.Trim();
			prenom = textPrenom.Text.Trim();
			dateNaiss = textDateNaiss.Text.Trim();
			num = int.Parse (textMatricule.Text.Trim ());
			
			string model = @"^\s*[0-3]?\s*\d\s*/\s*(0|1)?\s*\d\s*/\s*\d{4}\s*$";
			Regex reg = new Regex (model);
			if (reg.IsMatch (dateNaiss)){
				if (nom.Length > 0){
					if (prenom.Length > 0){
						if (dateNaiss.Length > 0){
							Etudiant etudiant = new Etudiant (nom, prenom, dateNaiss, num);
							bd.effacerEtudiant (ref etudiant);
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
		void AllStudantCheckedChanged(object sender, EventArgs e)
		{
	 		if (allStudant.Checked == true)
            {
                Informations.Hide();
                DialogResult repance = MessageBox.Show("Vous voullez vraimant supprimer tous les étudiants dans votre base de données ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (repance == DialogResult.Yes)
                {
                	bd.excecuteDeleteAll ();
                    MessageBox.Show("la suppression est réessite ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                    //effacer tous les étudiants
                }
                else
                {
                    allStudant.Checked = false;
                }
	 		}
		}
		
		void OneStudantCheckedChanged(object sender, EventArgs e)
		{
	        if (oneStudant.Checked == false)
            {
                Informations.Hide();
            }
            else
            {
                Informations.Show();
            }
		}
		
	}
}
