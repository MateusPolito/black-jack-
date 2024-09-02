namespace BlackJack
{
    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;

       
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code


        private void InitializeComponent()
        {
            this.btndeal = new System.Windows.Forms.Button();
            this.btnhit = new System.Windows.Forms.Button();
            this.btnstand = new System.Windows.Forms.Button();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.lblDealerScore = new System.Windows.Forms.Label();
            this.lbPlayerCards = new System.Windows.Forms.ListBox();
            this.lbDealerCards = new System.Windows.Forms.ListBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btndeal
            // 
            this.btndeal.Location = new System.Drawing.Point(363, 143);
            this.btndeal.Name = "btndeal";
            this.btndeal.Size = new System.Drawing.Size(75, 23);
            this.btndeal.TabIndex = 0;
            this.btndeal.Text = "Comecar";
            this.btndeal.UseVisualStyleBackColor = true;
            this.btndeal.Click += new System.EventHandler(this.btnDeal_Click);
            // 
            // btnhit
            // 
            this.btnhit.Location = new System.Drawing.Point(363, 198);
            this.btnhit.Name = "btnhit";
            this.btnhit.Size = new System.Drawing.Size(75, 23);
            this.btnhit.TabIndex = 1;
            this.btnhit.Text = "Puxar";
            this.btnhit.UseVisualStyleBackColor = true;
            this.btnhit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnstand
            // 
            this.btnstand.Location = new System.Drawing.Point(363, 259);
            this.btnstand.Name = "btnstand";
            this.btnstand.Size = new System.Drawing.Size(75, 23);
            this.btnstand.TabIndex = 2;
            this.btnstand.Text = "Parar";
            this.btnstand.UseVisualStyleBackColor = true;
            this.btnstand.Click += new System.EventHandler(this.btnStand_Click);
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.Location = new System.Drawing.Point(53, 53);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(64, 13);
            this.lblPlayerScore.TabIndex = 3;
            this.lblPlayerScore.Text = "PlayerScore";
            // 
            // lblDealerScore
            // 
            this.lblDealerScore.AutoSize = true;
            this.lblDealerScore.Location = new System.Drawing.Point(659, 53);
            this.lblDealerScore.Name = "lblDealerScore";
            this.lblDealerScore.Size = new System.Drawing.Size(66, 13);
            this.lblDealerScore.TabIndex = 4;
            this.lblDealerScore.Text = "DealerScore";
            // 
            // lbPlayerCards
            // 
            this.lbPlayerCards.FormattingEnabled = true;
            this.lbPlayerCards.Location = new System.Drawing.Point(56, 259);
            this.lbPlayerCards.Name = "lbPlayerCards";
            this.lbPlayerCards.Size = new System.Drawing.Size(120, 95);
            this.lbPlayerCards.TabIndex = 5;
            // 
            // lbDealerCards
            // 
            this.lbDealerCards.FormattingEnabled = true;
            this.lbDealerCards.Location = new System.Drawing.Point(627, 259);
            this.lbDealerCards.Name = "lbDealerCards";
            this.lbDealerCards.Size = new System.Drawing.Size(120, 95);
            this.lbDealerCards.TabIndex = 6;
            this.lbDealerCards.SelectedIndexChanged += new System.EventHandler(this.lbDealerCards_SelectedIndexChanged);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(363, 310);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lbDealerCards);
            this.Controls.Add(this.lbPlayerCards);
            this.Controls.Add(this.lblDealerScore);
            this.Controls.Add(this.lblPlayerScore);
            this.Controls.Add(this.btnstand);
            this.Controls.Add(this.btnhit);
            this.Controls.Add(this.btndeal);
            this.Name = "Form1";
            this.Text = "BlackJack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndeal;
        private System.Windows.Forms.Button btnhit;
        private System.Windows.Forms.Button btnstand;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblPlayerScore;
        private System.Windows.Forms.Label lblDealerScore;
        private System.Windows.Forms.ListBox lbPlayerCards;
        private System.Windows.Forms.ListBox lbDealerCards;
    }
}