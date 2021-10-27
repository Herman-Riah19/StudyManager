/*
 * Created by SharpDevelop.
 * User: Hermann
 * Date: 03/09/2019
 * Time: 17:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Hermann
{
	/// <summary>
	/// Description of Etudiant.
	/// </summary>
	public class Etudiant
	{
		public string Nom { get; set; }
		public string Prenom { get; set; }
		public string DateNaissance { get; set; }
		public int Numero { get; set;}
		public int Filiere {get; set;}
		public double Moyenne {get; set; } 
		public Etudiant(string nom, string prenom, string date, int id, double moyenne, int filiere)
		{
			this.Nom = nom;
			this.Prenom = prenom;
			this.DateNaissance = date; 
			this.Numero = id;
			this.Filiere = filiere;
			this.Moyenne = moyenne;
		}
		
		public Etudiant(string nom, string prenom, string date, int id, int filiere)
		{
			this.Nom = nom;
			this.Prenom = prenom;
			this.DateNaissance = date; 
			this.Numero = id;
			this.Filiere = filiere;
			this.Moyenne = 0;
		}
		
		public Etudiant(string nom, string prenom, string date, int id)
		{
			this.Nom = nom;
			this.Prenom = prenom;
			this.DateNaissance = date; 
			this.Numero = id;
			this.Filiere = 0;
			this.Moyenne = 0;
		}
	}
}
