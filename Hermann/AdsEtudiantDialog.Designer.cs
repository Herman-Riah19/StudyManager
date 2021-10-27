/*
 * Created by SharpDevelop.
 * User: Hermann
 * Date: 03/09/2019
 * Time: 17:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Hermann
{
	partial class AdsEtudiantDialog
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		public System.Windows.Forms.Panel panInscription;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton RadioTOUR;
		private System.Windows.Forms.RadioButton RadioIG;
		private System.Windows.Forms.RadioButton RadioMC;
		private System.Windows.Forms.RadioButton RadioTELECOM;
		private System.Windows.Forms.RadioButton RadioMA;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button Annuler;
		private System.Windows.Forms.Button Inscrit;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.NumericUpDown textMatricule;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textPrenom;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textDateNaiss;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textNom;
		private System.Windows.Forms.Label label2;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdsEtudiantDialog));
			this.panInscription = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.RadioTOUR = new System.Windows.Forms.RadioButton();
			this.RadioIG = new System.Windows.Forms.RadioButton();
			this.RadioMC = new System.Windows.Forms.RadioButton();
			this.RadioTELECOM = new System.Windows.Forms.RadioButton();
			this.RadioMA = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.Annuler = new System.Windows.Forms.Button();
			this.Inscrit = new System.Windows.Forms.Button();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.textMatricule = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.textPrenom = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textDateNaiss = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textNom = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panInscription.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textMatricule)).BeginInit();
			this.SuspendLayout();
			// 
			// panInscription
			// 
			this.panInscription.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.panInscription.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.panInscription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panInscription.Controls.Add(this.panel1);
			this.panInscription.Controls.Add(this.groupBox2);
			this.panInscription.Controls.Add(this.groupBox1);
			this.panInscription.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panInscription.Location = new System.Drawing.Point(0, 0);
			this.panInscription.Name = "panInscription";
			this.panInscription.Size = new System.Drawing.Size(598, 410);
			this.panInscription.TabIndex = 9;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(56)))), ((int)(((byte)(63)))));
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(596, 24);
			this.panel1.TabIndex = 13;
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Left;
			this.label1.Font = new System.Drawing.Font("Californian FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(27, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(168, 24);
			this.label1.TabIndex = 2;
			this.label1.Text = "Dialogue Ajoute Etudiant";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(0, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(27, 24);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(562, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(34, 24);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.PictureBox1Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.RadioTOUR);
			this.groupBox2.Controls.Add(this.RadioIG);
			this.groupBox2.Controls.Add(this.RadioMC);
			this.groupBox2.Controls.Add(this.RadioTELECOM);
			this.groupBox2.Controls.Add(this.RadioMA);
			this.groupBox2.Location = new System.Drawing.Point(368, 57);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(216, 295);
			this.groupBox2.TabIndex = 12;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Filiere";
			// 
			// RadioTOUR
			// 
			this.RadioTOUR.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RadioTOUR.Location = new System.Drawing.Point(19, 105);
			this.RadioTOUR.Name = "RadioTOUR";
			this.RadioTOUR.Size = new System.Drawing.Size(150, 24);
			this.RadioTOUR.TabIndex = 4;
			this.RadioTOUR.TabStop = true;
			this.RadioTOUR.Text = "Tourisme";
			this.RadioTOUR.UseVisualStyleBackColor = true;
			// 
			// RadioIG
			// 
			this.RadioIG.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RadioIG.Location = new System.Drawing.Point(19, 177);
			this.RadioIG.Name = "RadioIG";
			this.RadioIG.Size = new System.Drawing.Size(184, 24);
			this.RadioIG.TabIndex = 3;
			this.RadioIG.TabStop = true;
			this.RadioIG.Text = "Informatique de gestion";
			this.RadioIG.UseVisualStyleBackColor = true;
			// 
			// RadioMC
			// 
			this.RadioMC.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RadioMC.Location = new System.Drawing.Point(19, 141);
			this.RadioMC.Name = "RadioMC";
			this.RadioMC.Size = new System.Drawing.Size(150, 24);
			this.RadioMC.TabIndex = 2;
			this.RadioMC.TabStop = true;
			this.RadioMC.Text = "Multimédia";
			this.RadioMC.UseVisualStyleBackColor = true;
			// 
			// RadioTELECOM
			// 
			this.RadioTELECOM.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RadioTELECOM.Location = new System.Drawing.Point(19, 69);
			this.RadioTELECOM.Name = "RadioTELECOM";
			this.RadioTELECOM.Size = new System.Drawing.Size(150, 24);
			this.RadioTELECOM.TabIndex = 1;
			this.RadioTELECOM.TabStop = true;
			this.RadioTELECOM.Text = "Télécommunication";
			this.RadioTELECOM.UseVisualStyleBackColor = true;
			// 
			// RadioMA
			// 
			this.RadioMA.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RadioMA.Location = new System.Drawing.Point(19, 32);
			this.RadioMA.Name = "RadioMA";
			this.RadioMA.Size = new System.Drawing.Size(184, 24);
			this.RadioMA.TabIndex = 0;
			this.RadioMA.TabStop = true;
			this.RadioMA.Text = "Management des Affaires";
			this.RadioMA.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.Annuler);
			this.groupBox1.Controls.Add(this.Inscrit);
			this.groupBox1.Controls.Add(this.pictureBox6);
			this.groupBox1.Controls.Add(this.textMatricule);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.textPrenom);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.textDateNaiss);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.textNom);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(20, 58);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(321, 295);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Inscription";
			// 
			// Annuler
			// 
			this.Annuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(56)))), ((int)(((byte)(63)))));
			this.Annuler.FlatAppearance.BorderSize = 0;
			this.Annuler.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
			this.Annuler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
			this.Annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Annuler.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Annuler.ForeColor = System.Drawing.Color.Transparent;
			this.Annuler.Location = new System.Drawing.Point(193, 223);
			this.Annuler.Name = "Annuler";
			this.Annuler.Size = new System.Drawing.Size(119, 39);
			this.Annuler.TabIndex = 20;
			this.Annuler.Text = "Annuler";
			this.Annuler.UseVisualStyleBackColor = false;
			this.Annuler.Click += new System.EventHandler(this.AnnulerClick);
			// 
			// Inscrit
			// 
			this.Inscrit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(56)))), ((int)(((byte)(63)))));
			this.Inscrit.FlatAppearance.BorderSize = 0;
			this.Inscrit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
			this.Inscrit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
			this.Inscrit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Inscrit.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Inscrit.ForeColor = System.Drawing.Color.Transparent;
			this.Inscrit.Location = new System.Drawing.Point(10, 223);
			this.Inscrit.Name = "Inscrit";
			this.Inscrit.Size = new System.Drawing.Size(119, 39);
			this.Inscrit.TabIndex = 19;
			this.Inscrit.Text = "Inscrit";
			this.Inscrit.UseVisualStyleBackColor = false;
			this.Inscrit.Click += new System.EventHandler(this.InscritClick);
			// 
			// pictureBox6
			// 
			this.pictureBox6.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(161, 314);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(50, 53);
			this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox6.TabIndex = 12;
			this.pictureBox6.TabStop = false;
			// 
			// textMatricule
			// 
			this.textMatricule.Location = new System.Drawing.Point(149, 163);
			this.textMatricule.Maximum = new decimal(new int[] {
			99999999,
			0,
			0,
			0});
			this.textMatricule.Name = "textMatricule";
			this.textMatricule.Size = new System.Drawing.Size(162, 20);
			this.textMatricule.TabIndex = 18;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(11, 162);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(304, 23);
			this.label5.TabIndex = 17;
			this.label5.Text = "Matricule :";
			// 
			// textPrenom
			// 
			this.textPrenom.Location = new System.Drawing.Point(151, 75);
			this.textPrenom.Name = "textPrenom";
			this.textPrenom.Size = new System.Drawing.Size(160, 20);
			this.textPrenom.TabIndex = 16;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(10, 79);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 15;
			this.label4.Text = "Prénom(s) :";
			// 
			// textDateNaiss
			// 
			this.textDateNaiss.Location = new System.Drawing.Point(151, 121);
			this.textDateNaiss.Name = "textDateNaiss";
			this.textDateNaiss.Size = new System.Drawing.Size(160, 20);
			this.textDateNaiss.TabIndex = 14;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(8, 121);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(145, 23);
			this.label3.TabIndex = 13;
			this.label3.Text = "Date de Naissance :";
			// 
			// textNom
			// 
			this.textNom.Location = new System.Drawing.Point(151, 32);
			this.textNom.Name = "textNom";
			this.textNom.Size = new System.Drawing.Size(160, 20);
			this.textNom.TabIndex = 12;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(11, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 11;
			this.label2.Text = "Nom :";
			// 
			// AdsEtudiantDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(598, 410);
			this.Controls.Add(this.panInscription);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AdsEtudiantDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AdsEtudiantDialog";
			this.panInscription.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textMatricule)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
