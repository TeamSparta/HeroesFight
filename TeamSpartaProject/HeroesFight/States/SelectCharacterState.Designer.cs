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
            this.components = new System.ComponentModel.Container();
            this.label_Warrior = new System.Windows.Forms.Label();
            this.label_Archer = new System.Windows.Forms.Label();
            this.warriorPictureBox = new System.Windows.Forms.PictureBox();
            this.archerPictureBox = new System.Windows.Forms.PictureBox();
            this.Lbl_PickClass = new System.Windows.Forms.Label();
            this.warriorTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.archerTooltip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.warriorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.archerPictureBox)).BeginInit();
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
            // warriorPictureBox
            // 
            this.warriorPictureBox.Image = global::HeroesFight.Properties.Resources.Warrior;
            this.warriorPictureBox.Location = new System.Drawing.Point(83, 155);
            this.warriorPictureBox.Name = "warriorPictureBox";
            this.warriorPictureBox.Size = new System.Drawing.Size(186, 295);
            this.warriorPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.warriorPictureBox.TabIndex = 4;
            this.warriorPictureBox.TabStop = false;
            this.warriorPictureBox.Click += new System.EventHandler(this.OnWarriorPictureBoxClick);
            // 
            // archerPictureBox
            // 
            this.archerPictureBox.Image = global::HeroesFight.Properties.Resources.Archer;
            this.archerPictureBox.Location = new System.Drawing.Point(536, 155);
            this.archerPictureBox.Name = "archerPictureBox";
            this.archerPictureBox.Size = new System.Drawing.Size(186, 295);
            this.archerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.archerPictureBox.TabIndex = 5;
            this.archerPictureBox.TabStop = false;
            this.archerPictureBox.Click += new System.EventHandler(this.OnArcherPictureBoxClick);
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
            this.Controls.Add(this.archerPictureBox);
            this.Controls.Add(this.warriorPictureBox);
            this.Controls.Add(this.label_Archer);
            this.Controls.Add(this.label_Warrior);
            this.Name = "SelectCharacterState";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FirstLevelRoundOneState";
            this.Load += new System.EventHandler(this.SelectCharacterState_Load);
            ((System.ComponentModel.ISupportInitialize)(this.warriorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.archerPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Warrior;
        private System.Windows.Forms.Label label_Archer;
        private System.Windows.Forms.PictureBox warriorPictureBox;
        private System.Windows.Forms.PictureBox archerPictureBox;
        private System.Windows.Forms.Label Lbl_PickClass;
        private System.Windows.Forms.ToolTip warriorTooltip;
        private System.Windows.Forms.ToolTip archerTooltip;
    }
}