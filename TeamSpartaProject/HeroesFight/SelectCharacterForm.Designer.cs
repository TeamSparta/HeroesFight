namespace HeroesFight
{
    partial class SelectCharacterForm
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
            this.label_Warrior = new System.Windows.Forms.Label();
            this.label_Archer = new System.Windows.Forms.Label();
            this.radioBtn_Warrior = new System.Windows.Forms.RadioButton();
            this.radioBtn_Archer = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label_Warrior
            // 
            this.label_Warrior.AutoSize = true;
            this.label_Warrior.Location = new System.Drawing.Point(108, 108);
            this.label_Warrior.Name = "label_Warrior";
            this.label_Warrior.Size = new System.Drawing.Size(41, 13);
            this.label_Warrior.TabIndex = 0;
            this.label_Warrior.Text = "Warrior";
            // 
            // label_Archer
            // 
            this.label_Archer.AutoSize = true;
            this.label_Archer.Location = new System.Drawing.Point(380, 98);
            this.label_Archer.Name = "label_Archer";
            this.label_Archer.Size = new System.Drawing.Size(38, 13);
            this.label_Archer.TabIndex = 1;
            this.label_Archer.Text = "Archer";
            // 
            // radioBtn_Warrior
            // 
            this.radioBtn_Warrior.AutoSize = true;
            this.radioBtn_Warrior.Location = new System.Drawing.Point(95, 217);
            this.radioBtn_Warrior.Name = "radioBtn_Warrior";
            this.radioBtn_Warrior.Size = new System.Drawing.Size(59, 17);
            this.radioBtn_Warrior.TabIndex = 2;
            this.radioBtn_Warrior.TabStop = true;
            this.radioBtn_Warrior.Text = "Warrior";
            this.radioBtn_Warrior.UseVisualStyleBackColor = true;
            // 
            // radioBtn_Archer
            // 
            this.radioBtn_Archer.AutoSize = true;
            this.radioBtn_Archer.Location = new System.Drawing.Point(311, 217);
            this.radioBtn_Archer.Name = "radioBtn_Archer";
            this.radioBtn_Archer.Size = new System.Drawing.Size(56, 17);
            this.radioBtn_Archer.TabIndex = 3;
            this.radioBtn_Archer.TabStop = true;
            this.radioBtn_Archer.Text = "Archer";
            this.radioBtn_Archer.UseVisualStyleBackColor = true;
            // 
            // SelectCharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 514);
            this.Controls.Add(this.radioBtn_Archer);
            this.Controls.Add(this.radioBtn_Warrior);
            this.Controls.Add(this.label_Archer);
            this.Controls.Add(this.label_Warrior);
            this.Name = "SelectCharacterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectCharacterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Warrior;
        private System.Windows.Forms.Label label_Archer;
        private System.Windows.Forms.RadioButton radioBtn_Warrior;
        private System.Windows.Forms.RadioButton radioBtn_Archer;
    }
}