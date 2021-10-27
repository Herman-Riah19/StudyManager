/*
 * Created by SharpDevelop.
 * User: Hermann
 * Date: 03/09/2019
 * Time: 17:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Hermann
{
	/// <summary>
	/// Description of Matiere.
	/// </summary>
	public class Matiere
	{
		public double Note1 {get; set; }
		public double Note2 {get; set; }
		public double Note3 {get; set; }
		public double Note4 {get; set; }
		public double Note5 {get; set; }
		public double Note6 {get; set; }
		public double Moyenne {get; set; }
		public string Mention {get; set; }
		public string Commentaire {get; set; }
		public Matiere()
		{
			this.Note1 = 0;
			this.Note2 = 0;
			this.Note3 = 0;
			this.Note4 = 0;
			this.Note5 = 0;
			this.Note6 = 0;
			this.Moyenne = 0;
			this.Mention = choixMention();
			this.Commentaire = lesCommentaires ();
		}
		
		public Matiere(double Not1,double Not2,double Not3,double Not4,double Not5,double Not6)
		{
			this.Note1 = Not1;
			this.Note2 = Not2;
			this.Note3 = Not3;
			this.Note4 = Not4;
			this.Note5 = Not5;
			this.Note6 = Not6;
			this.Moyenne = GetMoyenne (Not1,Not2,Not3,Not4,Not5,Not6);
			this.Mention = choixMention();
			this.Commentaire = lesCommentaires ();
		}
		
		public double GetMoyenne (double Not1,double Not2,double Not3,double Not4,double Not5,double Not6){
			double mye = Not1 + Not2 + Not3 + Not4 + Not5 + Not6;
			mye /= 6;
			return mye;
		}
		
		private string choixMention (){
			if (this.Moyenne < 10)
				return "Mauvais";
			else if (this.Moyenne >= 10 && this.Moyenne < 12)
				return "Passable";
			else if (this.Moyenne >= 12 && this.Moyenne < 14.5)
				return "Assez Bien";
			else if (this.Moyenne >= 14.5 && this.Moyenne < 17)
				return "Bien";
			else if (this.Moyenne >= 17)
				return "Très Bien";
			return "Null";
		}
		
		private string lesCommentaires (){
			if (this.Moyenne < 0 && this.Moyenne > 20)
				return "Erreur";
			if (this.Moyenne < 10)
				return "Vous êtes Eliminer";
			if (this.Moyenne >= 10 && this.Moyenne < 15)
				return "Bien mais pas assez";
			if (this.Moyenne >= 15 && this.Moyenne < 17)
				return "Bien Continuer";
			if (this.Moyenne > 17)
				return "Excellent travail felicitation";
			return "Rien";
		}
		
	}
}
