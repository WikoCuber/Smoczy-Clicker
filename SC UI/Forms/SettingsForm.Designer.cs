using SC_UI.Helpers;

namespace SC_UI.Forms
{
    partial class SettingsForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            othersNavButton = new InvisibleButton();
            miningNavButton = new InvisibleButton();
            pvpNavButton = new InvisibleButton();
            bindsNavButton = new InvisibleButton();
            leftCoordniateButton = new InvisibleButton();
            rightCoordinateButton = new InvisibleButton();
            backgroundDelayNumeric = new NumericUpDown();
            commandDelayNumeric = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)backgroundDelayNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)commandDelayNumeric).BeginInit();
            SuspendLayout();
            // 
            // othersNavButton
            // 
            othersNavButton.BackColor = Color.Transparent;
            othersNavButton.FlatStyle = FlatStyle.Flat;
            othersNavButton.Font = new Font("Microsoft Sans Serif", 8.25F);
            othersNavButton.ForeColor = Color.FromArgb(68, 68, 68);
            othersNavButton.Location = new Point(14, 120);
            othersNavButton.Margin = new Padding(4, 3, 4, 3);
            othersNavButton.Name = "othersNavButton";
            othersNavButton.Size = new Size(130, 39);
            othersNavButton.TabIndex = 62;
            othersNavButton.TabStop = false;
            othersNavButton.UseVisualStyleBackColor = true;
            othersNavButton.Click += othersNavButton_Click;
            // 
            // miningNavButton
            // 
            miningNavButton.BackColor = Color.Transparent;
            miningNavButton.FlatStyle = FlatStyle.Flat;
            miningNavButton.Font = new Font("Microsoft Sans Serif", 8.25F);
            miningNavButton.ForeColor = Color.FromArgb(68, 68, 68);
            miningNavButton.Location = new Point(15, 74);
            miningNavButton.Margin = new Padding(4, 3, 4, 3);
            miningNavButton.Name = "miningNavButton";
            miningNavButton.Size = new Size(130, 39);
            miningNavButton.TabIndex = 61;
            miningNavButton.TabStop = false;
            miningNavButton.UseVisualStyleBackColor = true;
            miningNavButton.Click += miningNavButton_Click;
            // 
            // pvpNavButton
            // 
            pvpNavButton.BackColor = Color.Transparent;
            pvpNavButton.FlatStyle = FlatStyle.Flat;
            pvpNavButton.Font = new Font("Microsoft Sans Serif", 8.25F);
            pvpNavButton.ForeColor = Color.FromArgb(68, 68, 68);
            pvpNavButton.Location = new Point(14, 28);
            pvpNavButton.Margin = new Padding(4, 3, 4, 3);
            pvpNavButton.Name = "pvpNavButton";
            pvpNavButton.Size = new Size(130, 39);
            pvpNavButton.TabIndex = 60;
            pvpNavButton.TabStop = false;
            pvpNavButton.UseVisualStyleBackColor = true;
            pvpNavButton.Click += pvpNavButton_Click;
            // 
            // bindsNavButton
            // 
            bindsNavButton.BackColor = Color.Transparent;
            bindsNavButton.FlatStyle = FlatStyle.Flat;
            bindsNavButton.Font = new Font("Microsoft Sans Serif", 8.25F);
            bindsNavButton.ForeColor = Color.FromArgb(68, 68, 68);
            bindsNavButton.Location = new Point(15, 168);
            bindsNavButton.Margin = new Padding(4, 3, 4, 3);
            bindsNavButton.Name = "bindsNavButton";
            bindsNavButton.Size = new Size(130, 38);
            bindsNavButton.TabIndex = 64;
            bindsNavButton.TabStop = false;
            bindsNavButton.UseVisualStyleBackColor = true;
            bindsNavButton.Click += bindsNavButton_Click;
            // 
            // leftCoordniateButton
            // 
            leftCoordniateButton.BackColor = Color.Transparent;
            leftCoordniateButton.FlatStyle = FlatStyle.Flat;
            leftCoordniateButton.Font = new Font("Microsoft Sans Serif", 8.25F);
            leftCoordniateButton.ForeColor = Color.FromArgb(162, 162, 162);
            leftCoordniateButton.Location = new Point(625, 27);
            leftCoordniateButton.Margin = new Padding(4, 3, 4, 3);
            leftCoordniateButton.Name = "leftCoordniateButton";
            leftCoordniateButton.Size = new Size(80, 27);
            leftCoordniateButton.TabIndex = 65;
            leftCoordniateButton.TabStop = false;
            leftCoordniateButton.UseVisualStyleBackColor = true;
            leftCoordniateButton.Click += leftCoordinateButton_Click;
            // 
            // rightCoordinateButton
            // 
            rightCoordinateButton.BackColor = Color.Transparent;
            rightCoordinateButton.FlatStyle = FlatStyle.Flat;
            rightCoordinateButton.Font = new Font("Microsoft Sans Serif", 8.25F);
            rightCoordinateButton.ForeColor = Color.FromArgb(162, 162, 162);
            rightCoordinateButton.Location = new Point(632, 56);
            rightCoordinateButton.Margin = new Padding(4, 3, 4, 3);
            rightCoordinateButton.Name = "rightCoordinateButton";
            rightCoordinateButton.Size = new Size(80, 27);
            rightCoordinateButton.TabIndex = 66;
            rightCoordinateButton.TabStop = false;
            rightCoordinateButton.UseVisualStyleBackColor = true;
            rightCoordinateButton.Click += rightCoordinateButton_Click;
            // 
            // backgroundDelayNumeric
            // 
            backgroundDelayNumeric.Location = new Point(342, 83);
            backgroundDelayNumeric.Margin = new Padding(4, 3, 4, 3);
            backgroundDelayNumeric.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            backgroundDelayNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            backgroundDelayNumeric.Name = "backgroundDelayNumeric";
            backgroundDelayNumeric.Size = new Size(58, 23);
            backgroundDelayNumeric.TabIndex = 80;
            backgroundDelayNumeric.TabStop = false;
            backgroundDelayNumeric.Value = new decimal(new int[] { 2, 0, 0, 0 });
            backgroundDelayNumeric.ValueChanged += backgroundDelayNumeric_ValueChanged;
            // 
            // commandDelayNumeric
            // 
            commandDelayNumeric.Location = new Point(411, 111);
            commandDelayNumeric.Margin = new Padding(4, 3, 4, 3);
            commandDelayNumeric.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            commandDelayNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            commandDelayNumeric.Name = "commandDelayNumeric";
            commandDelayNumeric.Size = new Size(58, 23);
            commandDelayNumeric.TabIndex = 81;
            commandDelayNumeric.TabStop = false;
            commandDelayNumeric.Value = new decimal(new int[] { 2, 0, 0, 0 });
            commandDelayNumeric.ValueChanged += commandDelayNumeric_ValueChanged;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = Properties.Resources.Settings;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1029, 573);
            Controls.Add(commandDelayNumeric);
            Controls.Add(backgroundDelayNumeric);
            Controls.Add(rightCoordinateButton);
            Controls.Add(leftCoordniateButton);
            Controls.Add(bindsNavButton);
            Controls.Add(othersNavButton);
            Controls.Add(miningNavButton);
            Controls.Add(pvpNavButton);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = Properties.Resources.Logo;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "SettingsForm";
            StartPosition = FormStartPosition.Manual;
            Text = "Smoczy Clicker";
            ((System.ComponentModel.ISupportInitialize)backgroundDelayNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)commandDelayNumeric).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private InvisibleButton othersNavButton;
        private InvisibleButton miningNavButton;
        private InvisibleButton pvpNavButton;
        private InvisibleButton bindsNavButton;
        private InvisibleButton leftCoordniateButton;
        private InvisibleButton rightCoordinateButton;
        private System.Windows.Forms.NumericUpDown backgroundDelayNumeric;
        private System.Windows.Forms.NumericUpDown commandDelayNumeric;
    }
}

