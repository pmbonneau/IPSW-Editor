namespace IPSWlibUI
{
    partial class frmMain
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
            this.btnOpenIPSW = new System.Windows.Forms.Button();
            this.btnRebuildIPSW = new System.Windows.Forms.Button();
            this.btnListFilesIPSW = new System.Windows.Forms.Button();
            this.lbFilesIPSW = new System.Windows.Forms.ListBox();
            this.btnAddToFLashManifest = new System.Windows.Forms.Button();
            this.btnReadFlashManifest = new System.Windows.Forms.Button();
            this.btnAddFileToAllFlash = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenIPSW
            // 
            this.btnOpenIPSW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenIPSW.Location = new System.Drawing.Point(12, 12);
            this.btnOpenIPSW.Name = "btnOpenIPSW";
            this.btnOpenIPSW.Size = new System.Drawing.Size(154, 44);
            this.btnOpenIPSW.TabIndex = 0;
            this.btnOpenIPSW.Text = "Open IPSW";
            this.btnOpenIPSW.UseVisualStyleBackColor = true;
            this.btnOpenIPSW.Click += new System.EventHandler(this.btnOpenIPSW_Click);
            // 
            // btnRebuildIPSW
            // 
            this.btnRebuildIPSW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRebuildIPSW.Location = new System.Drawing.Point(12, 72);
            this.btnRebuildIPSW.Name = "btnRebuildIPSW";
            this.btnRebuildIPSW.Size = new System.Drawing.Size(154, 44);
            this.btnRebuildIPSW.TabIndex = 2;
            this.btnRebuildIPSW.Text = "Rebuild IPSW";
            this.btnRebuildIPSW.UseVisualStyleBackColor = true;
            this.btnRebuildIPSW.Click += new System.EventHandler(this.btnRebuildIPSW_Click);
            // 
            // btnListFilesIPSW
            // 
            this.btnListFilesIPSW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListFilesIPSW.Location = new System.Drawing.Point(12, 136);
            this.btnListFilesIPSW.Name = "btnListFilesIPSW";
            this.btnListFilesIPSW.Size = new System.Drawing.Size(154, 44);
            this.btnListFilesIPSW.TabIndex = 3;
            this.btnListFilesIPSW.Text = "List Files in IPSW";
            this.btnListFilesIPSW.UseVisualStyleBackColor = true;
            this.btnListFilesIPSW.Click += new System.EventHandler(this.btnListFilesIPSW_Click);
            // 
            // lbFilesIPSW
            // 
            this.lbFilesIPSW.FormattingEnabled = true;
            this.lbFilesIPSW.Location = new System.Drawing.Point(12, 197);
            this.lbFilesIPSW.Name = "lbFilesIPSW";
            this.lbFilesIPSW.Size = new System.Drawing.Size(540, 43);
            this.lbFilesIPSW.TabIndex = 4;
            // 
            // btnAddToFLashManifest
            // 
            this.btnAddToFLashManifest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToFLashManifest.Location = new System.Drawing.Point(203, 12);
            this.btnAddToFLashManifest.Name = "btnAddToFLashManifest";
            this.btnAddToFLashManifest.Size = new System.Drawing.Size(154, 44);
            this.btnAddToFLashManifest.TabIndex = 5;
            this.btnAddToFLashManifest.Text = "Add To Flash Manifest";
            this.btnAddToFLashManifest.UseVisualStyleBackColor = true;
            this.btnAddToFLashManifest.Click += new System.EventHandler(this.btnAddToFLashManifest_Click);
            // 
            // btnReadFlashManifest
            // 
            this.btnReadFlashManifest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadFlashManifest.Location = new System.Drawing.Point(203, 72);
            this.btnReadFlashManifest.Name = "btnReadFlashManifest";
            this.btnReadFlashManifest.Size = new System.Drawing.Size(154, 44);
            this.btnReadFlashManifest.TabIndex = 6;
            this.btnReadFlashManifest.Text = "Read Flash Manifest";
            this.btnReadFlashManifest.UseVisualStyleBackColor = true;
            this.btnReadFlashManifest.Click += new System.EventHandler(this.btnReadFlashManifest_Click);
            // 
            // btnAddFileToAllFlash
            // 
            this.btnAddFileToAllFlash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFileToAllFlash.Location = new System.Drawing.Point(203, 136);
            this.btnAddFileToAllFlash.Name = "btnAddFileToAllFlash";
            this.btnAddFileToAllFlash.Size = new System.Drawing.Size(154, 44);
            this.btnAddFileToAllFlash.TabIndex = 7;
            this.btnAddFileToAllFlash.Text = "Add File to All Flash";
            this.btnAddFileToAllFlash.UseVisualStyleBackColor = true;
            this.btnAddFileToAllFlash.Click += new System.EventHandler(this.btnAddFileToAllFlash_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 254);
            this.Controls.Add(this.btnAddFileToAllFlash);
            this.Controls.Add(this.btnReadFlashManifest);
            this.Controls.Add(this.btnAddToFLashManifest);
            this.Controls.Add(this.lbFilesIPSW);
            this.Controls.Add(this.btnListFilesIPSW);
            this.Controls.Add(this.btnRebuildIPSW);
            this.Controls.Add(this.btnOpenIPSW);
            this.Name = "frmMain";
            this.Text = "IPSW Editor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenIPSW;
        private System.Windows.Forms.Button btnRebuildIPSW;
        private System.Windows.Forms.Button btnListFilesIPSW;
        private System.Windows.Forms.ListBox lbFilesIPSW;
        private System.Windows.Forms.Button btnAddToFLashManifest;
        private System.Windows.Forms.Button btnReadFlashManifest;
        private System.Windows.Forms.Button btnAddFileToAllFlash;
    }
}

