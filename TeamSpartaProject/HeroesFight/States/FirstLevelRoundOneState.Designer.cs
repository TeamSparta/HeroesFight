namespace HeroesFight.States
{
    partial class FirstLevelRoundOneState
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
            this.Btn_Attack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Attack
            // 
            this.Btn_Attack.Location = new System.Drawing.Point(342, 246);
            this.Btn_Attack.Name = "Btn_Attack";
            this.Btn_Attack.Size = new System.Drawing.Size(75, 23);
            this.Btn_Attack.TabIndex = 0;
            this.Btn_Attack.Text = "Battle!";
            this.Btn_Attack.UseVisualStyleBackColor = true;
            this.Btn_Attack.Click += new System.EventHandler(this.OnBattleButtonClick);
            // 
            // FirstLevelRoundOneState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HeroesFight.Properties.Resources.LevelOneBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(793, 584);
            this.Controls.Add(this.Btn_Attack);
            this.Name = "FirstLevelRoundOneState";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FirstLevelForm";
            this.Load += new System.EventHandler(this.FirstLevelForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Attack;
    }
}