/*
 * Created by SharpDevelop.
 * User: Hermann
 * Date: 03/09/2019
 * Time: 16:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace Hermann
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		BD_Class bd = new BD_Class ();
		public MainForm()
		{
			InitializeComponent();
		}
		
		void AddEtudiantClick(object sender, EventArgs e)
		{
			AdsEtudiantDialog addEtud = new AdsEtudiantDialog();
			addEtud.Show();
		}
		
		void afficheListeEtudiant(){
			DataTable table = new DataTable ();
			table = bd.listEtudiant ();
			TableViewEtudiant.DataSource = table;
		}
		
		void ListEtudiantClick(object sender, EventArgs e)
		{
			afficheListeEtudiant ();
			tableNote.Visible = false;
			TableViewEtudiant.Visible = true;
		}
		
		void BtnHomeClick(object sender, EventArgs e)
		{
			TableViewEtudiant.Visible = false;
			tableNote.Visible = false;
		}
		
		void BtnListEtudiantClick(object sender, EventArgs e)
		{
			afficheListeEtudiant ();
			TableViewEtudiant.Visible = true;
		}
		
		void BtnBulletinClick(object sender, EventArgs e)
		{
			TableViewEtudiant.Visible = false;
			DataTable table = new DataTable();
			table = bd.listNote();
			tableNote.DataSource = table;
			tableNote.Visible = true;
		}
		void BtnEditerNoteClick(object sender, EventArgs e)
		{
			MetttreEnNote note = new MetttreEnNote();
			note.Show();
		}
		
		public void BtnMenuClick(object sender, EventArgs e)
		{
			if (panMenue.Width == 197){
				panMenue.Width = 55;
			}else{
				panMenue.Width = 197;
			}
		}
		void BtnAddEtudiantClick(object sender, EventArgs e)
		{
			AdsEtudiantDialog addEtud = new AdsEtudiantDialog();
			addEtud.Show();
		}
		void AjouteNoteClick(object sender, EventArgs e)
		{
			MetttreEnNote note = new MetttreEnNote ();
			note.Show ();
		}
		void Button2Click(object sender, EventArgs e)
		{
			Close ();
		}
		void Button1Click(object sender, EventArgs e)
		{
			EffaceEtudiant efface = new EffaceEtudiant();
			efface.Show();
		}
	}
}
