
namespace Lab16_API_WinForms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbIsComplete = new System.Windows.Forms.CheckBox();
            this.tbSuche = new System.Windows.Forms.TextBox();
            this.btnSuche = new System.Windows.Forms.Button();
            this.btnNeu = new System.Windows.Forms.Button();
            this.btnBearbeiten = new System.Windows.Forms.Button();
            this.btnLoeschen = new System.Windows.Forms.Button();
            this.dgItems = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(15, 25);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(773, 20);
            this.tbId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(15, 64);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(773, 20);
            this.tbName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "IsComplete";
            // 
            // cbIsComplete
            // 
            this.cbIsComplete.AutoSize = true;
            this.cbIsComplete.Location = new System.Drawing.Point(15, 103);
            this.cbIsComplete.Name = "cbIsComplete";
            this.cbIsComplete.Size = new System.Drawing.Size(15, 14);
            this.cbIsComplete.TabIndex = 5;
            this.cbIsComplete.UseVisualStyleBackColor = true;
            // 
            // tbSuche
            // 
            this.tbSuche.Location = new System.Drawing.Point(15, 141);
            this.tbSuche.Name = "tbSuche";
            this.tbSuche.Size = new System.Drawing.Size(109, 20);
            this.tbSuche.TabIndex = 6;
            // 
            // btnSuche
            // 
            this.btnSuche.Location = new System.Drawing.Point(130, 139);
            this.btnSuche.Name = "btnSuche";
            this.btnSuche.Size = new System.Drawing.Size(160, 23);
            this.btnSuche.TabIndex = 7;
            this.btnSuche.Text = "Suche";
            this.btnSuche.UseVisualStyleBackColor = true;
            this.btnSuche.Click += new System.EventHandler(this.btnSuche_Click);
            // 
            // btnNeu
            // 
            this.btnNeu.Location = new System.Drawing.Point(296, 139);
            this.btnNeu.Name = "btnNeu";
            this.btnNeu.Size = new System.Drawing.Size(160, 23);
            this.btnNeu.TabIndex = 8;
            this.btnNeu.Text = "Neu";
            this.btnNeu.UseVisualStyleBackColor = true;
            this.btnNeu.Click += new System.EventHandler(this.btnNeu_Click);
            // 
            // btnBearbeiten
            // 
            this.btnBearbeiten.Location = new System.Drawing.Point(462, 139);
            this.btnBearbeiten.Name = "btnBearbeiten";
            this.btnBearbeiten.Size = new System.Drawing.Size(160, 23);
            this.btnBearbeiten.TabIndex = 9;
            this.btnBearbeiten.Text = "Bearbeiten";
            this.btnBearbeiten.UseVisualStyleBackColor = true;
            this.btnBearbeiten.Click += new System.EventHandler(this.btnBearbeiten_Click);
            // 
            // btnLoeschen
            // 
            this.btnLoeschen.Location = new System.Drawing.Point(628, 139);
            this.btnLoeschen.Name = "btnLoeschen";
            this.btnLoeschen.Size = new System.Drawing.Size(160, 23);
            this.btnLoeschen.TabIndex = 10;
            this.btnLoeschen.Text = "Löschen";
            this.btnLoeschen.UseVisualStyleBackColor = true;
            this.btnLoeschen.Click += new System.EventHandler(this.btnLoeschen_Click);
            // 
            // dgItems
            // 
            this.dgItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItems.Location = new System.Drawing.Point(15, 188);
            this.dgItems.Name = "dgItems";
            this.dgItems.Size = new System.Drawing.Size(773, 250);
            this.dgItems.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgItems);
            this.Controls.Add(this.btnLoeschen);
            this.Controls.Add(this.btnBearbeiten);
            this.Controls.Add(this.btnNeu);
            this.Controls.Add(this.btnSuche);
            this.Controls.Add(this.tbSuche);
            this.Controls.Add(this.cbIsComplete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbIsComplete;
        private System.Windows.Forms.TextBox tbSuche;
        private System.Windows.Forms.Button btnSuche;
        private System.Windows.Forms.Button btnNeu;
        private System.Windows.Forms.Button btnBearbeiten;
        private System.Windows.Forms.Button btnLoeschen;
        private System.Windows.Forms.DataGridView dgItems;
    }
}

