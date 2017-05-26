namespace MatchingGame
{
    partial class MG2x2
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
            this.components = new System.ComponentModel.Container();
            this.tlp2x2 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tNotMatching = new System.Windows.Forms.Timer(this.components);
            this.tCountdown = new System.Windows.Forms.Timer(this.components);
            this.lTimeLeft = new System.Windows.Forms.Label();
            this.btnStartForm = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnMute = new System.Windows.Forms.Button();
            this.tlp2x2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp2x2
            // 
            this.tlp2x2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tlp2x2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tlp2x2.ColumnCount = 2;
            this.tlp2x2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp2x2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp2x2.Controls.Add(this.label4, 1, 1);
            this.tlp2x2.Controls.Add(this.label3, 0, 1);
            this.tlp2x2.Controls.Add(this.label2, 1, 0);
            this.tlp2x2.Controls.Add(this.label1, 0, 0);
            this.tlp2x2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlp2x2.Location = new System.Drawing.Point(0, 41);
            this.tlp2x2.Name = "tlp2x2";
            this.tlp2x2.RowCount = 2;
            this.tlp2x2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp2x2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp2x2.Size = new System.Drawing.Size(267, 267);
            this.tlp2x2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label4.Location = new System.Drawing.Point(137, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 131);
            this.label4.TabIndex = 3;
            this.label4.Text = "c";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label3.Location = new System.Drawing.Point(5, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 131);
            this.label3.TabIndex = 2;
            this.label3.Text = "c";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label2.Location = new System.Drawing.Point(137, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 130);
            this.label2.TabIndex = 1;
            this.label2.Text = "c";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label1.Location = new System.Drawing.Point(5, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 130);
            this.label1.TabIndex = 0;
            this.label1.Text = "c";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label_Click);
            // 
            // tNotMatching
            // 
            this.tNotMatching.Interval = 750;
            this.tNotMatching.Tick += new System.EventHandler(this.tNotMatching_Tick);
            // 
            // tCountdown
            // 
            this.tCountdown.Interval = 1000;
            this.tCountdown.Tick += new System.EventHandler(this.tCountdown_Tick);
            // 
            // lTimeLeft
            // 
            this.lTimeLeft.AutoSize = true;
            this.lTimeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTimeLeft.Location = new System.Drawing.Point(163, 9);
            this.lTimeLeft.Name = "lTimeLeft";
            this.lTimeLeft.Size = new System.Drawing.Size(55, 24);
            this.lTimeLeft.TabIndex = 1;
            this.lTimeLeft.Text = "00:20";
            // 
            // btnStartForm
            // 
            this.btnStartForm.FlatAppearance.BorderSize = 0;
            this.btnStartForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartForm.Location = new System.Drawing.Point(12, 9);
            this.btnStartForm.Name = "btnStartForm";
            this.btnStartForm.Size = new System.Drawing.Size(51, 23);
            this.btnStartForm.TabIndex = 2;
            this.btnStartForm.Text = "Menu";
            this.btnStartForm.UseVisualStyleBackColor = true;
            this.btnStartForm.Click += new System.EventHandler(this.btnStartForm_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.Transparent;
            this.btnNewGame.FlatAppearance.BorderSize = 0;
            this.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewGame.Location = new System.Drawing.Point(69, 9);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(72, 23);
            this.btnNewGame.TabIndex = 4;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnMute
            // 
            this.btnMute.BackgroundImage = global::MatchingGame.Properties.Resources.Mute_Icon;
            this.btnMute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMute.Location = new System.Drawing.Point(224, 5);
            this.btnMute.Name = "btnMute";
            this.btnMute.Size = new System.Drawing.Size(38, 30);
            this.btnMute.TabIndex = 3;
            this.btnMute.UseVisualStyleBackColor = true;
            this.btnMute.Click += new System.EventHandler(this.btnMute_Click);
            // 
            // MG2x2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 308);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnMute);
            this.Controls.Add(this.btnStartForm);
            this.Controls.Add(this.lTimeLeft);
            this.Controls.Add(this.tlp2x2);
            this.Name = "MG2x2";
            this.Text = "MG2x2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MG2x2_FormClosed);
            this.tlp2x2.ResumeLayout(false);
            this.tlp2x2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp2x2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tNotMatching;
        private System.Windows.Forms.Timer tCountdown;
        private System.Windows.Forms.Label lTimeLeft;
        private System.Windows.Forms.Button btnStartForm;
        private System.Windows.Forms.Button btnMute;
        private System.Windows.Forms.Button btnNewGame;
    }
}