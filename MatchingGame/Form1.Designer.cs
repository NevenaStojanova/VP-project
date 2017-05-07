namespace MatchingGame
{
    partial class StartForm
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
            this.lChoices = new System.Windows.Forms.Label();
            this.cbChoices = new System.Windows.Forms.ComboBox();
            this.btnInstructions = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lChoices
            // 
            this.lChoices.AutoSize = true;
            this.lChoices.Location = new System.Drawing.Point(12, 23);
            this.lChoices.Name = "lChoices";
            this.lChoices.Size = new System.Drawing.Size(135, 13);
            this.lChoices.TabIndex = 0;
            this.lChoices.Text = "Choose the size of the grid:";
            // 
            // cbChoices
            // 
            this.cbChoices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChoices.FormattingEnabled = true;
            this.cbChoices.Items.AddRange(new object[] {
            "2 X 2",
            "4 X 4",
            "6 X 6"});
            this.cbChoices.Location = new System.Drawing.Point(153, 20);
            this.cbChoices.Name = "cbChoices";
            this.cbChoices.Size = new System.Drawing.Size(121, 21);
            this.cbChoices.TabIndex = 1;
            // 
            // btnInstructions
            // 
            this.btnInstructions.Location = new System.Drawing.Point(153, 57);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Size = new System.Drawing.Size(121, 23);
            this.btnInstructions.TabIndex = 2;
            this.btnInstructions.Text = "Instructions";
            this.btnInstructions.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(153, 96);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(121, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 134);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnInstructions);
            this.Controls.Add(this.cbChoices);
            this.Controls.Add(this.lChoices);
            this.Name = "StartForm";
            this.Text = "Hello!";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.startForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lChoices;
        private System.Windows.Forms.ComboBox cbChoices;
        private System.Windows.Forms.Button btnInstructions;
        private System.Windows.Forms.Button btnStart;
    }
}

