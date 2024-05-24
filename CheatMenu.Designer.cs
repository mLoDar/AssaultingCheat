namespace AssaultingCheat
{
    partial class CheatMenu
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
            LabelMiscellaneous = new Label();
            CbUnlimitedAmmo = new CheckBox();
            CbGodmode = new CheckBox();
            CbBiggerMagazine = new CheckBox();
            CbBunnyhop = new CheckBox();
            SuspendLayout();
            // 
            // LabelMiscellaneous
            // 
            LabelMiscellaneous.AutoSize = true;
            LabelMiscellaneous.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelMiscellaneous.Location = new Point(15, 15);
            LabelMiscellaneous.Name = "LabelMiscellaneous";
            LabelMiscellaneous.Size = new Size(139, 22);
            LabelMiscellaneous.TabIndex = 6;
            LabelMiscellaneous.Text = "Miscellaneous:";
            // 
            // CbUnlimitedAmmo
            // 
            CbUnlimitedAmmo.AutoSize = true;
            CbUnlimitedAmmo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            CbUnlimitedAmmo.Location = new Point(29, 56);
            CbUnlimitedAmmo.Name = "CbUnlimitedAmmo";
            CbUnlimitedAmmo.Size = new Size(142, 24);
            CbUnlimitedAmmo.TabIndex = 7;
            CbUnlimitedAmmo.Text = "Unlimited ammo";
            CbUnlimitedAmmo.UseVisualStyleBackColor = true;
            // 
            // CbGodmode
            // 
            CbGodmode.AutoSize = true;
            CbGodmode.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            CbGodmode.Location = new Point(29, 86);
            CbGodmode.Name = "CbGodmode";
            CbGodmode.Size = new Size(95, 24);
            CbGodmode.TabIndex = 8;
            CbGodmode.Text = "Godmode";
            CbGodmode.UseVisualStyleBackColor = true;
            // 
            // CbBiggerMagazine
            // 
            CbBiggerMagazine.AutoSize = true;
            CbBiggerMagazine.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            CbBiggerMagazine.Location = new Point(29, 116);
            CbBiggerMagazine.Name = "CbBiggerMagazine";
            CbBiggerMagazine.Size = new Size(144, 24);
            CbBiggerMagazine.TabIndex = 9;
            CbBiggerMagazine.Text = "Bigger Magazine";
            CbBiggerMagazine.UseVisualStyleBackColor = true;
            // 
            // CbBunnyhop
            // 
            CbBunnyhop.AutoSize = true;
            CbBunnyhop.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            CbBunnyhop.Location = new Point(29, 146);
            CbBunnyhop.Name = "CbBunnyhop";
            CbBunnyhop.Size = new Size(99, 24);
            CbBunnyhop.TabIndex = 10;
            CbBunnyhop.Text = "Bunnyhop";
            CbBunnyhop.UseVisualStyleBackColor = true;
            // 
            // CheatMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 261);
            Controls.Add(CbBunnyhop);
            Controls.Add(CbBiggerMagazine);
            Controls.Add(CbGodmode);
            Controls.Add(CbUnlimitedAmmo);
            Controls.Add(LabelMiscellaneous);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CheatMenu";
            Opacity = 0.95D;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AssaultingCheat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label LabelMiscellaneous;
        private CheckBox CbUnlimitedAmmo;
        private CheckBox CbGodmode;
        private CheckBox CbBiggerMagazine;
        private CheckBox CbBunnyhop;
    }
}
