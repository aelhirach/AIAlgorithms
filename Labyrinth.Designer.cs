namespace AIAlgorithms
{
    partial class Labyrinth
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
            this.InitializeButton = new System.Windows.Forms.Button();
            this.beamWidthTextBox = new System.Windows.Forms.TextBox();
            this.EUCBB = new System.Windows.Forms.Button();
            this.GSearch = new System.Windows.Forms.Button();
            this.BSearch = new System.Windows.Forms.Button();
            this.BFS = new System.Windows.Forms.Button();
            this.DFS = new System.Windows.Forms.Button();
            this.pathLabel = new System.Windows.Forms.Label();
            this.FoundPathlabel = new System.Windows.Forms.Label();
            this.return_bt = new System.Windows.Forms.Button();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InitializeButton
            // 
            this.InitializeButton.Location = new System.Drawing.Point(1035, 328);
            this.InitializeButton.Name = "InitializeButton";
            this.InitializeButton.Size = new System.Drawing.Size(155, 21);
            this.InitializeButton.TabIndex = 15;
            this.InitializeButton.Text = "Initialize";
            this.InitializeButton.UseVisualStyleBackColor = true;
            this.InitializeButton.Click += new System.EventHandler(this.InitializeButton_Click);
            // 
            // beamWidthTextBox
            // 
            this.beamWidthTextBox.Location = new System.Drawing.Point(1133, 172);
            this.beamWidthTextBox.Name = "beamWidthTextBox";
            this.beamWidthTextBox.Size = new System.Drawing.Size(57, 20);
            this.beamWidthTextBox.TabIndex = 14;
            // 
            // EUCBB
            // 
            this.EUCBB.Location = new System.Drawing.Point(1035, 278);
            this.EUCBB.Name = "EUCBB";
            this.EUCBB.Size = new System.Drawing.Size(156, 21);
            this.EUCBB.TabIndex = 13;
            this.EUCBB.Text = "Extended Uniform Cost BB";
            this.EUCBB.UseVisualStyleBackColor = true;
            this.EUCBB.Click += new System.EventHandler(this.EUCBB_Click);
            // 
            // GSearch
            // 
            this.GSearch.Location = new System.Drawing.Point(1035, 226);
            this.GSearch.Name = "GSearch";
            this.GSearch.Size = new System.Drawing.Size(155, 21);
            this.GSearch.TabIndex = 12;
            this.GSearch.Text = "GreedySearch";
            this.GSearch.UseVisualStyleBackColor = true;
            this.GSearch.Click += new System.EventHandler(this.GreedySearch_Click);
            // 
            // BSearch
            // 
            this.BSearch.Location = new System.Drawing.Point(1035, 172);
            this.BSearch.Name = "BSearch";
            this.BSearch.Size = new System.Drawing.Size(92, 21);
            this.BSearch.TabIndex = 11;
            this.BSearch.Text = "BeamSearch";
            this.BSearch.UseVisualStyleBackColor = true;
            this.BSearch.Click += new System.EventHandler(this.BeamSearch_Click);
            // 
            // BFS
            // 
            this.BFS.Location = new System.Drawing.Point(1035, 118);
            this.BFS.Name = "BFS";
            this.BFS.Size = new System.Drawing.Size(155, 21);
            this.BFS.TabIndex = 10;
            this.BFS.Text = "BFS";
            this.BFS.UseVisualStyleBackColor = true;
            this.BFS.Click += new System.EventHandler(this.BFS_Click);
            // 
            // DFS
            // 
            this.DFS.Location = new System.Drawing.Point(1035, 69);
            this.DFS.Name = "DFS";
            this.DFS.Size = new System.Drawing.Size(155, 21);
            this.DFS.TabIndex = 9;
            this.DFS.Text = "DFS";
            this.DFS.UseVisualStyleBackColor = true;
            this.DFS.Click += new System.EventHandler(this.DFS_Click);
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(2, 573);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(35, 13);
            this.pathLabel.TabIndex = 16;
            this.pathLabel.Text = "Path :";
            // 
            // FoundPathlabel
            // 
            this.FoundPathlabel.AutoSize = true;
            this.FoundPathlabel.Location = new System.Drawing.Point(33, 573);
            this.FoundPathlabel.Name = "FoundPathlabel";
            this.FoundPathlabel.Size = new System.Drawing.Size(144, 13);
            this.FoundPathlabel.TabIndex = 17;
            this.FoundPathlabel.Text = "Choose algorithm to find path";
            // 
            // return_bt
            // 
            this.return_bt.Location = new System.Drawing.Point(1073, 384);
            this.return_bt.Name = "return_bt";
            this.return_bt.Size = new System.Drawing.Size(75, 21);
            this.return_bt.TabIndex = 28;
            this.return_bt.Text = "Retourner";
            this.return_bt.UseVisualStyleBackColor = true;
            this.return_bt.Click += new System.EventHandler(this.return_bt_Click);
            // 
            // gamePanel
            // 
            this.gamePanel.BackgroundImage = global::AIAlgorithms.Properties.Resources.Back;
            this.gamePanel.Location = new System.Drawing.Point(26, -2);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(988, 559);
            this.gamePanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1021, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Nombre des chemins dans la liste :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1188, 434);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "nb";
            // 
            // Labyrinth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 595);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.return_bt);
            this.Controls.Add(this.FoundPathlabel);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.InitializeButton);
            this.Controls.Add(this.beamWidthTextBox);
            this.Controls.Add(this.EUCBB);
            this.Controls.Add(this.GSearch);
            this.Controls.Add(this.BSearch);
            this.Controls.Add(this.BFS);
            this.Controls.Add(this.DFS);
            this.Controls.Add(this.gamePanel);
            this.Name = "Labyrinth";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Button InitializeButton;
        private System.Windows.Forms.TextBox beamWidthTextBox;
        private System.Windows.Forms.Button EUCBB;
        private System.Windows.Forms.Button GSearch;
        private System.Windows.Forms.Button BSearch;
        private System.Windows.Forms.Button BFS;
        private System.Windows.Forms.Button DFS;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Label FoundPathlabel;
        private System.Windows.Forms.Button return_bt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}