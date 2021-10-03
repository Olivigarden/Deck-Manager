
namespace DeckManager
{
    partial class DeckManager
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newDeckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeal = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.lblRemainingCards = new System.Windows.Forms.Label();
            this.picBack = new System.Windows.Forms.PictureBox();
            this.picFront = new System.Windows.Forms.PictureBox();
            this.lblBack = new System.Windows.Forms.Label();
            this.lblFront = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFront)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDeckToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newDeckToolStripMenuItem
            // 
            this.newDeckToolStripMenuItem.Name = "newDeckToolStripMenuItem";
            this.newDeckToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.newDeckToolStripMenuItem.Text = "New Deck";
            this.newDeckToolStripMenuItem.Click += new System.EventHandler(this.newDeckToolStripMenuItem_Click);
            // 
            // btnDeal
            // 
            this.btnDeal.Enabled = false;
            this.btnDeal.Location = new System.Drawing.Point(12, 27);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(98, 52);
            this.btnDeal.TabIndex = 2;
            this.btnDeal.Text = "Draw";
            this.btnDeal.UseVisualStyleBackColor = true;
            this.btnDeal.Click += new System.EventHandler(this.btnDeal_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Enabled = false;
            this.btnUndo.Location = new System.Drawing.Point(116, 27);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(98, 52);
            this.btnUndo.TabIndex = 3;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // lblRemainingCards
            // 
            this.lblRemainingCards.AutoSize = true;
            this.lblRemainingCards.Location = new System.Drawing.Point(12, 82);
            this.lblRemainingCards.Name = "lblRemainingCards";
            this.lblRemainingCards.Size = new System.Drawing.Size(58, 13);
            this.lblRemainingCards.TabIndex = 6;
            this.lblRemainingCards.Text = "Cards Left:";
            // 
            // picBack
            // 
            this.picBack.Location = new System.Drawing.Point(12, 118);
            this.picBack.Name = "picBack";
            this.picBack.Size = new System.Drawing.Size(380, 320);
            this.picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBack.TabIndex = 7;
            this.picBack.TabStop = false;
            // 
            // picFront
            // 
            this.picFront.Location = new System.Drawing.Point(408, 118);
            this.picFront.Name = "picFront";
            this.picFront.Size = new System.Drawing.Size(380, 320);
            this.picFront.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFront.TabIndex = 8;
            this.picFront.TabStop = false;
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Location = new System.Drawing.Point(148, 102);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(85, 13);
            this.lblBack.TabIndex = 9;
            this.lblBack.Text = "Next Card Back:";
            // 
            // lblFront
            // 
            this.lblFront.AutoSize = true;
            this.lblFront.Location = new System.Drawing.Point(567, 102);
            this.lblFront.Name = "lblFront";
            this.lblFront.Size = new System.Drawing.Size(68, 13);
            this.lblFront.TabIndex = 10;
            this.lblFront.Text = "Drawn Front:";
            // 
            // DeckManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFront);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.picFront);
            this.Controls.Add(this.picBack);
            this.Controls.Add(this.lblRemainingCards);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnDeal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DeckManager";
            this.Text = "Deck Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFront)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newDeckToolStripMenuItem;
        private System.Windows.Forms.Button btnDeal;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Label lblRemainingCards;
        private System.Windows.Forms.PictureBox picBack;
        private System.Windows.Forms.PictureBox picFront;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Label lblFront;
    }
}

