namespace DessinVrai
{
    partial class Dessin
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dessin));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.deplacement = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deplacement});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(284, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // deplacement
            // 
            this.deplacement.CheckOnClick = true;
            this.deplacement.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deplacement.Image = ((System.Drawing.Image)(resources.GetObject("deplacement.Image")));
            this.deplacement.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deplacement.Name = "deplacement";
            this.deplacement.Size = new System.Drawing.Size(23, 22);
            this.deplacement.Text = "Déplacement";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Dessin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dessin";
            this.Text = "Dessin";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Dessin_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Dessin_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Dessin_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Dessin_MouseUp);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton deplacement;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

