namespace AIAlgorithms
{
    partial class Tree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tree));
            this.gamePanel = new System.Windows.Forms.Panel();
            this.DFS = new System.Windows.Forms.Button();
            this.BFS = new System.Windows.Forms.Button();
            this.BSearch = new System.Windows.Forms.Button();
            this.GSearch = new System.Windows.Forms.Button();
            this.EUCBB = new System.Windows.Forms.Button();
            this.beamWidthTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InitializeButton = new System.Windows.Forms.Button();
            this.FoundPathlabel = new System.Windows.Forms.Label();
            this.return_bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gamePanel
            // 
            this.gamePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gamePanel.BackgroundImage")));
            this.gamePanel.Location = new System.Drawing.Point(12, 12);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(688, 354);
            this.gamePanel.TabIndex = 0;
            // 
            // DFS
            // 
            this.DFS.Location = new System.Drawing.Point(731, 47);
            this.DFS.Name = "DFS";
            this.DFS.Size = new System.Drawing.Size(155, 23);
            this.DFS.TabIndex = 1;
            this.DFS.Text = "DFS";
            this.DFS.UseVisualStyleBackColor = true;
            this.DFS.Click += new System.EventHandler(this.DFS_Click);
            // 
            // BFS
            // 
            this.BFS.Location = new System.Drawing.Point(731, 96);
            this.BFS.Name = "BFS";
            this.BFS.Size = new System.Drawing.Size(155, 23);
            this.BFS.TabIndex = 2;
            this.BFS.Text = "BFS";
            this.BFS.UseVisualStyleBackColor = true;
            this.BFS.Click += new System.EventHandler(this.BFS_Click);
            // 
            // BSearch
            // 
            this.BSearch.Location = new System.Drawing.Point(731, 150);
            this.BSearch.Name = "BSearch";
            this.BSearch.Size = new System.Drawing.Size(92, 23);
            this.BSearch.TabIndex = 3;
            this.BSearch.Text = "BeamSearch";
            this.BSearch.UseVisualStyleBackColor = true;
            this.BSearch.Click += new System.EventHandler(this.BeamSearch_Click);
            // 
            // GSearch
            // 
            this.GSearch.Location = new System.Drawing.Point(731, 204);
            this.GSearch.Name = "GSearch";
            this.GSearch.Size = new System.Drawing.Size(155, 23);
            this.GSearch.TabIndex = 4;
            this.GSearch.Text = "GreedySearch";
            this.GSearch.UseVisualStyleBackColor = true;
            this.GSearch.Click += new System.EventHandler(this.GreedySearch_Click);
            // 
            // EUCBB
            // 
            this.EUCBB.Location = new System.Drawing.Point(731, 256);
            this.EUCBB.Name = "EUCBB";
            this.EUCBB.Size = new System.Drawing.Size(156, 23);
            this.EUCBB.TabIndex = 5;
            this.EUCBB.Text = "Extended Uniform Cost BB";
            this.EUCBB.UseVisualStyleBackColor = true;
            this.EUCBB.Click += new System.EventHandler(this.EUCBB_Click);
            // 
            // beamWidthTextBox
            // 
            this.beamWidthTextBox.Location = new System.Drawing.Point(829, 152);
            this.beamWidthTextBox.Name = "beamWidthTextBox";
            this.beamWidthTextBox.Size = new System.Drawing.Size(57, 20);
            this.beamWidthTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(826, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "beamWidth";
            // 
            // InitializeButton
            // 
            this.InitializeButton.Location = new System.Drawing.Point(731, 306);
            this.InitializeButton.Name = "InitializeButton";
            this.InitializeButton.Size = new System.Drawing.Size(155, 23);
            this.InitializeButton.TabIndex = 8;
            this.InitializeButton.Text = "Initialize";
            this.InitializeButton.UseVisualStyleBackColor = true;
            this.InitializeButton.Click += new System.EventHandler(this.InitializeButton_Click);
            // 
            // FoundPathlabel
            // 
            this.FoundPathlabel.AutoSize = true;
            this.FoundPathlabel.Location = new System.Drawing.Point(22, 375);
            this.FoundPathlabel.Name = "FoundPathlabel";
            this.FoundPathlabel.Size = new System.Drawing.Size(32, 13);
            this.FoundPathlabel.TabIndex = 9;
            this.FoundPathlabel.Text = "Path:";
            // 
            // return_bt
            // 
            this.return_bt.Location = new System.Drawing.Point(772, 343);
            this.return_bt.Name = "return_bt";
            this.return_bt.Size = new System.Drawing.Size(75, 23);
            this.return_bt.TabIndex = 29;
            this.return_bt.Text = "Retourner";
            this.return_bt.UseVisualStyleBackColor = true;
            this.return_bt.Click += new System.EventHandler(this.return_bt_Click);
            // 
            // Tree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 397);
            this.Controls.Add(this.return_bt);
            this.Controls.Add(this.FoundPathlabel);
            this.Controls.Add(this.InitializeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.beamWidthTextBox);
            this.Controls.Add(this.EUCBB);
            this.Controls.Add(this.GSearch);
            this.Controls.Add(this.BSearch);
            this.Controls.Add(this.BFS);
            this.Controls.Add(this.DFS);
            this.Controls.Add(this.gamePanel);
            this.Name = "Tree";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Button DFS;
        private System.Windows.Forms.Button BFS;
        private System.Windows.Forms.Button BSearch;
        private System.Windows.Forms.Button GSearch;
        private System.Windows.Forms.Button EUCBB;
        private System.Windows.Forms.TextBox beamWidthTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button InitializeButton;
        private System.Windows.Forms.Label FoundPathlabel;
        private System.Windows.Forms.Button return_bt;



    }
}

