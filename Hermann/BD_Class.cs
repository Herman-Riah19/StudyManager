/*
 * Created by SharpDevelop.
 * User: Hermann
 * Date: 03/09/2019
 * Time: 17:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace Hermann
{
	/// <summary>
	/// Description of BD_Class.
	/// </summary>
	public class BD_Class
	{

		private enum Mention{
			Null,
			Eliminer,
			Passable,
			AssezBien,
			Bien,
			TresBien
		}
		public MySqlConnection connexion;
		private MySqlCommand commande;
		public BD_Class(){
			connexion = new MySqlConnection ("database=gestion_etudiant; server=localhost; user id=root; pwd=");
			verificationDeConnexion();
			commande = new MySqlCommand();
			commande.Connection = connexion;
		}
		
		public BD_Class(Etudiant etudiant)
		{
			connexion = new MySqlConnection ("database=gestion_etudiant; server=localhost; user id=root; pwd=");
			verificationDeConnexion();
			commande = new MySqlCommand();
			commande.Connection = connexion;
		}
		
		public void ajouteEtudiant (ref Etudiant etudiant){
			try{
				    commande.CommandText = "INSERT INTO `tableEtudiant` (`Id_etudiant`, `Nom`, `Prenom`, `DateNaissance`, `Code_filiere`) VALUES ('"+ etudiant.Numero+"', '"+ etudiant.Nom +"', '"+ etudiant.Prenom +"', '"+ etudiant.DateNaissance +"', '"+etudiant.Filiere +"');";
				    commande.ExecuteReader();
					MessageBox.Show("l'ajoute d'étudiant est réeussit ", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch(MySqlException error){
				MessageBox.Show ("Inscription erreur cause de: " + error.ToString());
			}
		}
		
		public void effacerEtudiant (ref Etudiant etudiant){
			try{
				    commande.CommandText = "DELETE FROM `tableetudiant` WHERE `tableetudiant`.`Id_etudiant` = " + etudiant.Numero;
				    commande.ExecuteReader();
					MessageBox.Show("l'ajoute d'étudiant est réeussit ", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch(MySqlException error){
				MessageBox.Show ("Inscription erreur cause de: " + error.ToString());
			}
		}
		
		public void excecuteDeleteAll () {
			try{
				    commande.CommandText = "DELETE FROM `tableetudiant`";
				    commande.ExecuteReader();
					MessageBox.Show("l'efface des étudiants est réeussit ", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch(MySqlException error){
				MessageBox.Show ("Inscription erreur cause de: " + error.ToString());
			}
		}
		private void verificationDeConnexion(){
			try{
				connexion.Open();
				MessageBox.Show ("connexion");
			}catch{
				MessageBox.Show ("pas de connexion");
			}
		}
		
		public DataTable listEtudiant (){
			MySqlDataAdapter adapter = new MySqlDataAdapter ();
			try{
				commande.CommandText = "SELECT tableetudiant.Id_etudiant, tableetudiant.Nom,tableetudiant.Prenom, tableetudiant.DateNaissance, filiere.Denomination FROM tableetudiant,filiere WHERE tableetudiant.Code_filiere = filiere.Code_filiere";
				adapter.SelectCommand = commande;
				
				
			}catch(MySqlException erreur){
				MessageBox.Show ("l'erreur de selection est : " + erreur.ErrorCode);
			}
			
			Console.Write (adapter.ToString());
			DataTable table = new DataTable();
			adapter.Fill (table);
			return table;
		}
		
		public DataTable listNote (){
			MySqlDataAdapter adapter = new MySqlDataAdapter();
			try{
				commande.CommandText = "SELECT tableetudiant.Id_etudiant,tableetudiant.Nom, avoir_note.Note1,avoir_note.Note2,avoir_note.Note3,avoir_note.Note4,avoir_note.Note5,avoir_note.Note6,avoir_note.Moyenne,avoir_note.Mention,avoir_note.Commentaire FROM avoir_note,tableetudiant WHERE avoir_note.Id_etudiant = tableetudiant.Id_etudiant ";
				adapter.SelectCommand = commande;
				
			}catch(MySqlException error){
				MessageBox.Show ("l'erreur est : " + error.ToString());
			}
			
			DataTable table = new DataTable();
			adapter.Fill (table);
			return table;
		}
		
		public void miseEnNote (int id, ref Matiere matiere, ref int num){
			try{
				commande.CommandText = "INSERT INTO `avoir_note` (`Id_avoirNote`, `Note1`, `Note2`, `Note3`, `Note4`, `Note5`, `Note6`, `Moyenne`, `Mention`, `Commentaire`, `Id_etudiant`) VALUES ('"+id+"', '"+matiere.Note1+"', '"+matiere.Note2+"', '"+matiere.Note3+"', '"+matiere.Note4+"', '"+matiere.Note5+"', '"+matiere.Note6+"', '"+matiere.Moyenne+"', '"+matiere.Mention+"', '"+matiere.Commentaire+"', '"+num+"');"; 
				commande.ExecuteReader();
			}catch(MySqlException error){
				MessageBox.Show ("l'erreur est : " + error.ToString());
			}
		}

		public bool selection(int id){
			MySqlDataAdapter adapter = new MySqlDataAdapter();
			try{
				commande.CommandText = "SELECT * FROM tableetudiant WHERE Id_etudiant = " + id;
				adapter.SelectCommand = commande;
				
			}catch(MySqlException error){
				MessageBox.Show ("l'erreur est : " + error.ToString());
			}
			
			DataTable table = new DataTable();
			adapter.Fill(table);
			if (!table.IsInitialized)
				return false;
			return true;
		}
	}
}
