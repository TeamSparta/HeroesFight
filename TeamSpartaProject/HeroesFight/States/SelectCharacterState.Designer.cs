namespace HeroesFight.States
{
    partial class SelectCharacterState
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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Lbl_PickClass = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Warrior
            // 
            this.label_Warrior.AutoSize = true;
            this.label_Warrior.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Warrior.Location = new System.Drawing.Point(140, 122);
            this.label_Warrior.Name = "label_Warrior";
            this.label_Warrior.Size = new System.Drawing.Size(55, 17);
            this.label_Warrior.TabIndex = 0;
            this.label_Warrior.Text = "Warrior";
            // 
            // label_Archer
            // 
            this.label_Archer.AutoSize = true;
            this.label_Archer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Archer.Location = new System.Drawing.Point(608, 122);
            this.label_Archer.Name = "label_Archer";
            this.label_Archer.Size = new System.Drawing.Size(50, 17);
            this.label_Archer.TabIndex = 1;
            this.label_Archer.Text = "Archer";
            // 
            // radioBtn_Warrior
            // 
            this.radioBtn_Warrior.AutoSize = true;
            this.radioBtn_Warrior.Location = new System.Drawing.Point(143, 470);
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
            this.radioBtn_Archer.Location = new System.Drawing.Point(592, 470);
            this.radioBtn_Archer.Name = "radioBtn_Archer";
            this.radioBtn_Archer.Size = new System.Drawing.Size(56, 17);
            this.radioBtn_Archer.TabIndex = 3;
            this.radioBtn_Archer.TabStop = true;
            this.radioBtn_Archer.Text = "Archer";
            this.radioBtn_Archer.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HeroesFight.Properties.Resources.Warrior;
            this.pictureBox1.Location = new System.Drawing.Point(83, 155);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 295);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.OnWarriorPictureBoxClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HeroesFight.Properties.Resources.Archer;
            this.pictureBox2.Location = new System.Drawing.Point(536, 155);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(186, 295);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.OnArcherPictureBoxClick);
            // 
            // Lbl_PickClass
            // 
            this.Lbl_PickClass.AutoSize = true;
            this.Lbl_PickClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_PickClass.Location = new System.Drawing.Point(324, 93);
            this.Lbl_PickClass.Name = "Lbl_PickClass";
            this.Lbl_PickClass.Size = new System.Drawing.Size(116, 20);
            this.Lbl_PickClass.TabIndex = 7;
            this.Lbl_PickClass.Text = "Pick your class:";
            this.Lbl_PickClass.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SelectCharacterState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HeroesFight.Properties.Resources.PickClassBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(793, 584);
            this.Controls.Add(this.Lbl_PickClass);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radioBtn_Archer);
            this.Controls.Add(this.radioBtn_Warrior);
            this.Controls.Add(this.label_Archer);
            this.Controls.Add(this.label_Warrior);
            this.Name = "SelectCharacterState";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HeroesFightForm";
            this.Load += new System.EventHandler(this.SelectCharacterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Warrior;
        private System.Windows.Forms.Label label_Archer;
        private System.Windows.Forms.RadioButton radioBtn_Warrior;
        private System.Windows.Forms.RadioButton radioBtn_Archer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Lbl_PickClass;
    }
}