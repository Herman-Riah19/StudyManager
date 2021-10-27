/*
 * Created by SharpDevelop.
 * User: Hermann
 * Date: 09/09/2019
 * Time: 16:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hermann
{
	/// <summary>
	/// Description of MetttreEnNote.
	/// </summary>
	public partial class MetttreEnNote : Form
	{
		BD_Class bd = new BD_Class();
		public MetttreEnNote()
		{
			InitializeComponent();
			addListEtudiant ();
		}
		
		public void addListEtudiant (){
			MySqlConnection cnx = new MySqlConnection ("database=gestion_etudiant; server=localhost; user id=root; pwd=");
			cnx.Open();
			MySqlCommand cmd = new MySqlCommand ("SELECT tableetudiant.Id_etudiant FROM tableetudiant", cnx);
			MySqlDataReader data = cmd.ExecuteReader ();
			
			while (data.Read ()) {
				string num = data.GetString ("Id_etudiant");
				NumeroTrouver.Items.Add (num);
			}
		}
		
		void PictureBox2Click(object sender, EventArgs e)
		{
			Close ();
		}

		void AnnulerClick(object sender, EventArgs e)
		{
			Close ();
		}
		
		void EnregistrerClick(object sender, EventArgs e)
		{
			int num = int.Parse (NumeroTrouver.Text.Trim());
			
			int numbull = int.Parse (numBulletin.Value.ToString());
			double Not1 = double.Parse (Note1.Text.Trim());
			double Not2 = double.Parse (Note2.Text.Trim());
			double Not3 = double.Parse (Note3.Text.Trim());
			double Not4 = double.Parse (Note4.Text.Trim());
			double Not5 = double.Parse (Note5.Text.Trim());
			double Not6 = double.Parse (Note6.Text.Trim());

			if (testDesNote(Not1,Not2,Not3,Not4,Not5,Not6) == false){
				MessageBox.Show("Le note est illogique...\n il faut qu'il soit inferieur ou égale à 20 et supérieur à 0","Attention");
				return;
			}else{
				Matiere mat = new Matiere(Not1,Not2,Not3,Not4,Not5,Not6);
				bd.miseEnNote(numbull,ref mat,ref num);
				
				MessageBox.Show("Ajoute note reusssit");
				Close();
			}
		}
		
		private bool testDesNote (double Not1,double Not2,double Not3, double Not4,double Not5,double Not6){
			if (Not1 < 0 && Not1 > 20)
				return false;
			if (Not2 < 0 && Not2 > 20)
				return false;
			if (Not3 < 0 && Not3 > 20)
				return false;
			if (Not4 < 0 && Not4 > 20)
				return false;
			if (Not5 < 0 && Not5 > 20)
				return false;
			if (Not6 < 0 && Not6 > 20)
				return false;
			return true;
		}
	}
}
