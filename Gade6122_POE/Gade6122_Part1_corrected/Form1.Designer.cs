
namespace Gade6122_Part1_corrected
{
    partial class frm1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMap = new System.Windows.Forms.Label();
            this.lblAttackInfo = new System.Windows.Forms.Label();
            this.lblHeroStats = new System.Windows.Forms.Label();
            this.lblEnemyStats = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnShop3 = new System.Windows.Forms.Button();
            this.btnShop1 = new System.Windows.Forms.Button();
            this.btnShop2 = new System.Windows.Forms.Button();
            this.lblShops = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMap
            // 
            this.lblMap.AutoSize = true;
            this.lblMap.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMap.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMap.ForeColor = System.Drawing.Color.Red;
            this.lblMap.Location = new System.Drawing.Point(25, 32);
            this.lblMap.Name = "lblMap";
            this.lblMap.Size = new System.Drawing.Size(175, 21);
            this.lblMap.TabIndex = 0;
            this.lblMap.Text = "(map goes here)";
            this.lblMap.Click += new System.EventHandler(this.lblMap_Click);
            // 
            // lblAttackInfo
            // 
            this.lblAttackInfo.AutoSize = true;
            this.lblAttackInfo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAttackInfo.ForeColor = System.Drawing.Color.Red;
            this.lblAttackInfo.Location = new System.Drawing.Point(296, 384);
            this.lblAttackInfo.Name = "lblAttackInfo";
            this.lblAttackInfo.Size = new System.Drawing.Size(128, 15);
            this.lblAttackInfo.TabIndex = 1;
            this.lblAttackInfo.Text = "(attack info goes here)";
            this.lblAttackInfo.Click += new System.EventHandler(this.lblAttackInfo_Click);
            // 
            // lblHeroStats
            // 
            this.lblHeroStats.AutoSize = true;
            this.lblHeroStats.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHeroStats.ForeColor = System.Drawing.Color.Red;
            this.lblHeroStats.Location = new System.Drawing.Point(596, 35);
            this.lblHeroStats.Name = "lblHeroStats";
            this.lblHeroStats.Size = new System.Drawing.Size(113, 15);
            this.lblHeroStats.TabIndex = 2;
            this.lblHeroStats.Text = "(hero stats go here)";
            this.lblHeroStats.Click += new System.EventHandler(this.lblHeroStats_Click);
            // 
            // lblEnemyStats
            // 
            this.lblEnemyStats.AutoSize = true;
            this.lblEnemyStats.ForeColor = System.Drawing.Color.Red;
            this.lblEnemyStats.Location = new System.Drawing.Point(596, 191);
            this.lblEnemyStats.Name = "lblEnemyStats";
            this.lblEnemyStats.Size = new System.Drawing.Size(125, 15);
            this.lblEnemyStats.TabIndex = 3;
            this.lblEnemyStats.Text = "(enemy stats go here)";
            this.lblEnemyStats.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Black;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.ForeColor = System.Drawing.Color.Red;
            this.btnLoad.Location = new System.Drawing.Point(596, 360);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Black;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.Red;
            this.btnSave.Location = new System.Drawing.Point(687, 360);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnShop3
            // 
            this.btnShop3.BackColor = System.Drawing.Color.Black;
            this.btnShop3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShop3.ForeColor = System.Drawing.Color.Red;
            this.btnShop3.Location = new System.Drawing.Point(472, 331);
            this.btnShop3.Name = "btnShop3";
            this.btnShop3.Size = new System.Drawing.Size(85, 33);
            this.btnShop3.TabIndex = 6;
            this.btnShop3.Text = "(Shop3)";
            this.btnShop3.UseVisualStyleBackColor = false;
            this.btnShop3.Click += new System.EventHandler(this.btnShop3_Click);
            // 
            // btnShop1
            // 
            this.btnShop1.BackColor = System.Drawing.Color.Black;
            this.btnShop1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShop1.ForeColor = System.Drawing.Color.Red;
            this.btnShop1.Location = new System.Drawing.Point(290, 331);
            this.btnShop1.Name = "btnShop1";
            this.btnShop1.Size = new System.Drawing.Size(85, 33);
            this.btnShop1.TabIndex = 7;
            this.btnShop1.Text = "(Shop1)";
            this.btnShop1.UseVisualStyleBackColor = false;
            this.btnShop1.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnShop2
            // 
            this.btnShop2.BackColor = System.Drawing.Color.Black;
            this.btnShop2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShop2.ForeColor = System.Drawing.Color.Red;
            this.btnShop2.Location = new System.Drawing.Point(381, 331);
            this.btnShop2.Name = "btnShop2";
            this.btnShop2.Size = new System.Drawing.Size(85, 33);
            this.btnShop2.TabIndex = 8;
            this.btnShop2.Text = "(Shop2)";
            this.btnShop2.UseVisualStyleBackColor = false;
            this.btnShop2.Click += new System.EventHandler(this.btnShop2_Click);
            // 
            // lblShops
            // 
            this.lblShops.AutoSize = true;
            this.lblShops.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblShops.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblShops.ForeColor = System.Drawing.Color.Red;
            this.lblShops.Location = new System.Drawing.Point(402, 299);
            this.lblShops.Name = "lblShops";
            this.lblShops.Size = new System.Drawing.Size(47, 20);
            this.lblShops.TabIndex = 9;
            this.lblShops.Text = "Shop";
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblShops);
            this.Controls.Add(this.btnShop2);
            this.Controls.Add(this.btnShop1);
            this.Controls.Add(this.btnShop3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lblEnemyStats);
            this.Controls.Add(this.lblHeroStats);
            this.Controls.Add(this.lblAttackInfo);
            this.Controls.Add(this.lblMap);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "frm1";
            this.Text = "Swamp Game";
            this.Load += new System.EventHandler(this.frm1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMap;
        private System.Windows.Forms.Label lblAttackInfo;
        private System.Windows.Forms.Label lblHeroStats;
        private System.Windows.Forms.Label lblEnemyStats;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnShop3;
        private System.Windows.Forms.Button btnShop1;
        private System.Windows.Forms.Button btnShop2;
        private System.Windows.Forms.Label lblShops;
    }
}

