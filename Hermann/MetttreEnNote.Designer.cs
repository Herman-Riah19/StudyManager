/*
 * Created by SharpDevelop.
 * User: Hermann
 * Date: 09/09/2019
 * Time: 16:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Hermann
{
	partial class MetttreEnNote
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox Note1;
		private System.Windows.Forms.TextBox Note2;
		private System.Windows.Forms.TextBox Note3;
		private System.Windows.Forms.TextBox Note6;
		private System.Windows.Forms.TextBox Note5;
		private System.Windows.Forms.TextBox Note4;
		private System.Windows.Forms.Label labelNote6;
		private System.Windows.Forms.Label labelNote5;
		private System.Windows.Forms.Label labelNote1;
		private System.Windows.Forms.Label labelNote2;
		private System.Windows.Forms.Label labelNote3;
		private System.Windows.Forms.Label labelNote4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button Annuler;
		private System.Windows.Forms.Button Enregistrer;
		private System.Windows.Forms.NumericUpDown numBulletin;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox NumeroTrouver;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MetttreEnNote));
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.NumeroTrouver = new System.Windows.Forms.ComboBox();
			this.numBulletin = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.Enregistrer = new System.Windows.Forms.Button();
			this.Annuler = new System.Windows.Forms.Button();
			this.Note1 = new System.Windows.Forms.TextBox();
			this.Note2 = new System.Windows.Forms.TextBox();
			this.Note3 = new System.Windows.Forms.TextBox();
			this.Note6 = new System.Windows.Forms.TextBox();
			this.Note5 = new System.Windows.Forms.TextBox();
			this.Note4 = new System.Windows.Forms.TextBox();
			this.labelNote6 = new System.Windows.Forms.Label();
			this.labelNote5 = new System.Windows.Forms.Label();
			this.labelNote1 = new System.Windows.Forms.Label();
			this.labelNote2 = new System.Windows.Forms.Label();
			this.labelNote3 = new System.Windows.Forms.Label();
			this.labelNote4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numBulletin)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(56)))), ((int)(((byte)(63)))));
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(529, 27);
			this.panel1.TabIndex = 1;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(499, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(30, 27);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 3;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.PictureBox2Click);
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Left;
			this.label1.Font = new System.Drawing.Font("Californian FB", 9.75F);
			this.label1.Location = new System.Drawing.Point(31, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 27);
			this.label1.TabIndex = 2;
			this.label1.Text = "Mise en Note";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(31, 27);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.NumeroTrouver);
			this.panel2.Controls.Add(this.numBulletin);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.Enregistrer);
			this.panel2.Controls.Add(this.Annuler);
			this.panel2.Controls.Add(this.Note1);
			this.panel2.Controls.Add(this.Note2);
			this.panel2.Controls.Add(this.Note3);
			this.panel2.Controls.Add(this.Note6);
			this.panel2.Controls.Add(this.Note5);
			this.panel2.Controls.Add(this.Note4);
			this.panel2.Controls.Add(this.labelNote6);
			this.panel2.Controls.Add(this.labelNote5);
			this.panel2.Controls.Add(this.labelNote1);
			this.panel2.Controls.Add(this.labelNote2);
			this.panel2.Controls.Add(this.labelNote3);
			this.panel2.Controls.Add(this.labelNote4);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 27);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(529, 306);
			this.panel2.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Californian FB", 9.75F);
			this.label3.Location = new System.Drawing.Point(41, 30);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(90, 27);
			this.label3.TabIndex = 31;
			this.label3.Text = "Numero :";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// NumeroTrouver
			// 
			this.NumeroTrouver.FormattingEnabled = true;
			this.NumeroTrouver.Location = new System.Drawing.Point(180, 36);
			this.NumeroTrouver.Name = "NumeroTrouver";
			this.NumeroTrouver.Size = new System.Drawing.Size(152, 21);
			this.NumeroTrouver.TabIndex = 30;
			// 
			// numBulletin
			// 
			this.numBulletin.Location = new System.Drawing.Point(384, 6);
			this.numBulletin.Maximum = new decimal(new int[] {
			9999999,
			0,
			0,
			0});
			this.numBulletin.Name = "numBulletin";
			this.numBulletin.Size = new System.Drawing.Size(142, 20);
			this.numBulletin.TabIndex = 28;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Californian FB", 9.75F);
			this.label5.Location = new System.Drawing.Point(254, 3);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(131, 27);
			this.label5.TabIndex = 27;
			this.label5.Text = "Bulletin numero :";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Enregistrer
			// 
			this.Enregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(56)))), ((int)(((byte)(63)))));
			this.Enregistrer.FlatAppearance.BorderSize = 0;
			this.Enregistrer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
			this.Enregistrer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
			this.Enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Enregistrer.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Enregistrer.ForeColor = System.Drawing.Color.Transparent;
			this.Enregistrer.Location = new System.Drawing.Point(31, 255);
			this.Enregistrer.Name = "Enregistrer";
			this.Enregistrer.Size = new System.Drawing.Size(176, 39);
			this.Enregistrer.TabIndex = 23;
			this.Enregistrer.Text = "Enregistrer";
			this.Enregistrer.UseVisualStyleBackColor = false;
			this.Enregistrer.Click += new System.EventHandler(this.EnregistrerClick);
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
			this.Annuler.Location = new System.Drawing.Point(309, 255);
			this.Annuler.Name = "Annuler";
			this.Annuler.Size = new System.Drawing.Size(176, 39);
			this.Annuler.TabIndex = 21;
			this.Annuler.Text = "Annuler";
			this.Annuler.UseVisualStyleBackColor = false;
			this.Annuler.Click += new System.EventHandler(this.AnnulerClick);
			// 
			// Note1
			// 
			this.Note1.Location = new System.Drawing.Point(87, 129);
			this.Note1.Name = "Note1";
			this.Note1.Size = new System.Drawing.Size(120, 20);
			this.Note1.TabIndex = 19;
			// 
			// Note2
			// 
			this.Note2.Location = new System.Drawing.Point(87, 164);
			this.Note2.Name = "Note2";
			this.Note2.Size = new System.Drawing.Size(120, 20);
			this.Note2.TabIndex = 18;
			// 
			// Note3
			// 
			this.Note3.Location = new System.Drawing.Point(87, 211);
			this.Note3.Name = "Note3";
			this.Note3.Size = new System.Drawing.Size(120, 20);
			this.Note3.TabIndex = 17;
			// 
			// Note6
			// 
			this.Note6.Location = new System.Drawing.Point(365, 211);
			this.Note6.Name = "Note6";
			this.Note6.Size = new System.Drawing.Size(120, 20);
			this.Note6.TabIndex = 16;
			// 
			// Note5
			// 
			this.Note5.Location = new System.Drawing.Point(365, 164);
			this.Note5.Name = "Note5";
			this.Note5.Size = new System.Drawing.Size(120, 20);
			this.Note5.TabIndex = 15;
			// 
			// Note4
			// 
			this.Note4.Location = new System.Drawing.Point(365, 126);
			this.Note4.Name = "Note4";
			this.Note4.Size = new System.Drawing.Size(120, 20);
			this.Note4.TabIndex = 14;
			// 
			// labelNote6
			// 
			this.labelNote6.Font = new System.Drawing.Font("Californian FB", 9.75F);
			this.labelNote6.Location = new System.Drawing.Point(295, 211);
			this.labelNote6.Name = "labelNote6";
			this.labelNote6.Size = new System.Drawing.Size(90, 27);
			this.labelNote6.TabIndex = 13;
			this.labelNote6.Text = "Note 6:";
			this.labelNote6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelNote5
			// 
			this.labelNote5.Font = new System.Drawing.Font("Californian FB", 9.75F);
			this.labelNote5.Location = new System.Drawing.Point(295, 164);
			this.labelNote5.Name = "labelNote5";
			this.labelNote5.Size = new System.Drawing.Size(90, 27);
			this.labelNote5.TabIndex = 12;
			this.labelNote5.Text = "Note 5:";
			this.labelNote5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelNote1
			// 
			this.labelNote1.Font = new System.Drawing.Font("Californian FB", 9.75F);
			this.labelNote1.Location = new System.Drawing.Point(12, 126);
			this.labelNote1.Name = "labelNote1";
			this.labelNote1.Size = new System.Drawing.Size(90, 27);
			this.labelNote1.TabIndex = 11;
			this.labelNote1.Text = "Note 1 :";
			this.labelNote1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelNote2
			// 
			this.labelNote2.Font = new System.Drawing.Font("Californian FB", 9.75F);
			this.labelNote2.Location = new System.Drawing.Point(12, 164);
			this.labelNote2.Name = "labelNote2";
			this.labelNote2.Size = new System.Drawing.Size(90, 27);
			this.labelNote2.TabIndex = 10;
			this.labelNote2.Text = "Note 2:";
			this.labelNote2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelNote3
			// 
			this.labelNote3.Font = new System.Drawing.Font("Californian FB", 9.75F);
			this.labelNote3.Location = new System.Drawing.Point(12, 211);
			this.labelNote3.Name = "labelNote3";
			this.labelNote3.Size = new System.Drawing.Size(90, 27);
			this.labelNote3.TabIndex = 9;
			this.labelNote3.Text = "Note 3:";
			this.labelNote3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelNote4
			// 
			this.labelNote4.Font = new System.Drawing.Font("Californian FB", 9.75F);
			this.labelNote4.Location = new System.Drawing.Point(295, 126);
			this.labelNote4.Name = "labelNote4";
			this.labelNote4.Size = new System.Drawing.Size(90, 27);
			this.labelNote4.TabIndex = 8;
			this.labelNote4.Text = "Note 4:";
			this.labelNote4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Californian FB", 9.75F);
			this.label2.Location = new System.Drawing.Point(0, 3);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 27);
			this.label2.TabIndex = 3;
			this.label2.Text = "L\'Etudiant";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MetttreEnNote
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(529, 333);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MetttreEnNote";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MetttreEnNote";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numBulletin)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
