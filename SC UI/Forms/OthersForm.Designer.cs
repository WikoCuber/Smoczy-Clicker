using SC_UI.Helpers;

namespace SC_UI.Forms
{
    partial class OthersForm
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
            miningNavButton = new InvisibleButton();
            bindsNavButton = new InvisibleButton();
            pvpNavButton = new InvisibleButton();
            depositDelayNumeric = new NumericUpDown();
            pickaxe6RadioButton = new RadioButton();
            pickaxe5RadioButton = new RadioButton();
            pickaxe4RadioButton = new RadioButton();
            drawingCoordinateButton = new InvisibleButton();
            effectsCoordinateButton = new InvisibleButton();
            settingsNavButton = new InvisibleButton();
            voidBindButton = new InvisibleButton();
            drawingBindButton = new InvisibleButton();
            effectsBindButton = new InvisibleButton();
            mathewBindButton = new InvisibleButton();
            altingBindButton = new InvisibleButton();
            dabingBindButton = new InvisibleButton();
            depositBindButton = new InvisibleButton();
            voidStatusButton = new InvisibleButton();
            dabingStatusButton = new InvisibleButton();
            mathewStatusButton = new InvisibleButton();
            altingStatusButton = new InvisibleButton();
            effectsDrawingStatusButton = new InvisibleButton();
            depositStatusButton = new InvisibleButton();
            voidStatusPicBox = new PictureBox();
            dabingStatusPicBox = new PictureBox();
            mathewStatusPicBox = new PictureBox();
            altingStatusPicBox = new PictureBox();
            effectsDrawingStatusPicBox = new PictureBox();
            depositStatusPicBox = new PictureBox();
            effectsOnCheckBox = new CheckBox();
            drawingOnCheckBox = new CheckBox();
            dabingTypeComboBox = new ComboBox();
            voidDelayNumeric = new NumericUpDown();
            intelligentVoidCheckBox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)depositDelayNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)voidStatusPicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dabingStatusPicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mathewStatusPicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)altingStatusPicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)effectsDrawingStatusPicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)depositStatusPicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)voidDelayNumeric).BeginInit();
            SuspendLayout();
            // 
            // miningNavButton
            // 
            miningNavButton.BackColor = Color.Transparent;
            miningNavButton.FlatStyle = FlatStyle.Flat;
            miningNavButton.Font = new Font("Microsoft Sans Serif", 8.25F);
            miningNavButton.ForeColor = Color.FromArgb(68, 68, 68);
            miningNavButton.Location = new Point(16, 74);
            miningNavButton.Name = "miningNavButton";
            miningNavButton.Size = new Size(130, 39);
            miningNavButton.TabIndex = 22;
            miningNavButton.TabStop = false;
            miningNavButton.UseVisualStyleBackColor = true;
            miningNavButton.Click += miningNavButton_Click;
            // 
            // bindsNavButton
            // 
            bindsNavButton.BackColor = Color.Transparent;
            bindsNavButton.FlatStyle = FlatStyle.Flat;
            bindsNavButton.Font = new Font("Microsoft Sans Serif", 8.25F);
            bindsNavButton.ForeColor = Color.FromArgb(68, 68, 68);
            bindsNavButton.Location = new Point(16, 167);
            bindsNavButton.Name = "bindsNavButton";
            bindsNavButton.Size = new Size(130, 39);
            bindsNavButton.TabIndex = 25;
            bindsNavButton.TabStop = false;
            bindsNavButton.UseVisualStyleBackColor = true;
            bindsNavButton.Click += bindsNavButton_Click;
            // 
            // pvpNavButton
            // 
            pvpNavButton.BackColor = Color.Transparent;
            pvpNavButton.FlatStyle = FlatStyle.Flat;
            pvpNavButton.Font = new Font("Microsoft Sans Serif", 8.25F);
            pvpNavButton.ForeColor = Color.FromArgb(68, 68, 68);
            pvpNavButton.Location = new Point(14, 28);
            pvpNavButton.Name = "pvpNavButton";
            pvpNavButton.Size = new Size(130, 39);
            pvpNavButton.TabIndex = 24;
            pvpNavButton.TabStop = false;
            pvpNavButton.UseVisualStyleBackColor = true;
            pvpNavButton.Click += pvpNavButton_Click;
            // 
            // depositDelayNumeric
            // 
            depositDelayNumeric.Location = new Point(301, 169);
            depositDelayNumeric.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            depositDelayNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            depositDelayNumeric.Name = "depositDelayNumeric";
            depositDelayNumeric.Size = new Size(58, 20);
            depositDelayNumeric.TabIndex = 66;
            depositDelayNumeric.TabStop = false;
            depositDelayNumeric.Value = new decimal(new int[] { 2, 0, 0, 0 });
            depositDelayNumeric.ValueChanged += depositDelayNumeric_ValueChanged;
            // 
            // pickaxe6RadioButton
            // 
            pickaxe6RadioButton.AutoSize = true;
            pickaxe6RadioButton.Location = new Point(915, 171);
            pickaxe6RadioButton.Name = "pickaxe6RadioButton";
            pickaxe6RadioButton.Size = new Size(14, 13);
            pickaxe6RadioButton.TabIndex = 68;
            pickaxe6RadioButton.UseVisualStyleBackColor = true;
            pickaxe6RadioButton.CheckedChanged += pickaxe6RadioButton_CheckedChanged;
            // 
            // pickaxe5RadioButton
            // 
            pickaxe5RadioButton.AutoSize = true;
            pickaxe5RadioButton.Location = new Point(915, 198);
            pickaxe5RadioButton.Name = "pickaxe5RadioButton";
            pickaxe5RadioButton.Size = new Size(14, 13);
            pickaxe5RadioButton.TabIndex = 69;
            pickaxe5RadioButton.UseVisualStyleBackColor = true;
            pickaxe5RadioButton.CheckedChanged += pickaxe5RadioButton_CheckedChanged;
            // 
            // pickaxe4RadioButton
            // 
            pickaxe4RadioButton.AutoSize = true;
            pickaxe4RadioButton.Location = new Point(915, 227);
            pickaxe4RadioButton.Name = "pickaxe4RadioButton";
            pickaxe4RadioButton.Size = new Size(14, 13);
            pickaxe4RadioButton.TabIndex = 70;
            pickaxe4RadioButton.UseVisualStyleBackColor = true;
            pickaxe4RadioButton.CheckedChanged += pickaxe4RadioButton_CheckedChanged;
            // 
            // drawingCoordinateButton
            // 
            drawingCoordinateButton.BackColor = Color.Transparent;
            drawingCoordinateButton.FlatStyle = FlatStyle.Flat;
            drawingCoordinateButton.ForeColor = Color.FromArgb(162, 162, 162);
            drawingCoordinateButton.Location = new Point(587, 192);
            drawingCoordinateButton.Name = "drawingCoordinateButton";
            drawingCoordinateButton.Size = new Size(80, 27);
            drawingCoordinateButton.TabIndex = 76;
            drawingCoordinateButton.TabStop = false;
            drawingCoordinateButton.UseVisualStyleBackColor = true;
            drawingCoordinateButton.Click += drawingCoordinateButtons_Click;
            // 
            // effectsCoordinateButton
            // 
            effectsCoordinateButton.BackColor = Color.Transparent;
            effectsCoordinateButton.FlatStyle = FlatStyle.Flat;
            effectsCoordinateButton.ForeColor = Color.FromArgb(162, 162, 162);
            effectsCoordinateButton.Location = new Point(585, 137);
            effectsCoordinateButton.Name = "effectsCoordinateButton";
            effectsCoordinateButton.Size = new Size(80, 27);
            effectsCoordinateButton.TabIndex = 77;
            effectsCoordinateButton.TabStop = false;
            effectsCoordinateButton.UseVisualStyleBackColor = true;
            effectsCoordinateButton.Click += effectsCoordinateButtons_Click;
            // 
            // settingsNavButton
            // 
            settingsNavButton.BackColor = Color.Transparent;
            settingsNavButton.FlatStyle = FlatStyle.Flat;
            settingsNavButton.Font = new Font("Microsoft Sans Serif", 8.25F);
            settingsNavButton.ForeColor = Color.FromArgb(68, 68, 68);
            settingsNavButton.Location = new Point(16, 214);
            settingsNavButton.Name = "settingsNavButton";
            settingsNavButton.Size = new Size(130, 39);
            settingsNavButton.TabIndex = 80;
            settingsNavButton.TabStop = false;
            settingsNavButton.UseVisualStyleBackColor = true;
            settingsNavButton.Click += settingsNavButton_Click;
            // 
            // voidBindButton
            // 
            voidBindButton.BackColor = Color.Transparent;
            voidBindButton.FlatStyle = FlatStyle.Flat;
            voidBindButton.Font = new Font("Microsoft Sans Serif", 8.25F);
            voidBindButton.ForeColor = Color.FromArgb(162, 162, 162);
            voidBindButton.Location = new Point(586, 342);
            voidBindButton.Name = "voidBindButton";
            voidBindButton.Size = new Size(80, 27);
            voidBindButton.TabIndex = 84;
            voidBindButton.TabStop = false;
            voidBindButton.UseVisualStyleBackColor = true;
            voidBindButton.Click += voidBindButton_Click;
            // 
            // drawingBindButton
            // 
            drawingBindButton.BackColor = Color.Transparent;
            drawingBindButton.FlatStyle = FlatStyle.Flat;
            drawingBindButton.Font = new Font("Microsoft Sans Serif", 8.25F);
            drawingBindButton.ForeColor = Color.FromArgb(162, 162, 162);
            drawingBindButton.Location = new Point(625, 165);
            drawingBindButton.Name = "drawingBindButton";
            drawingBindButton.Size = new Size(80, 27);
            drawingBindButton.TabIndex = 85;
            drawingBindButton.TabStop = false;
            drawingBindButton.UseVisualStyleBackColor = true;
            drawingBindButton.Click += drawingBindButton_Click;
            // 
            // effectsBindButton
            // 
            effectsBindButton.BackColor = Color.Transparent;
            effectsBindButton.FlatStyle = FlatStyle.Flat;
            effectsBindButton.Font = new Font("Microsoft Sans Serif", 8.25F);
            effectsBindButton.ForeColor = Color.FromArgb(162, 162, 162);
            effectsBindButton.Location = new Point(598, 110);
            effectsBindButton.Name = "effectsBindButton";
            effectsBindButton.Size = new Size(80, 27);
            effectsBindButton.TabIndex = 86;
            effectsBindButton.TabStop = false;
            effectsBindButton.UseVisualStyleBackColor = true;
            effectsBindButton.Click += effectsBindButton_Click;
            // 
            // mathewBindButton
            // 
            mathewBindButton.BackColor = Color.Transparent;
            mathewBindButton.FlatStyle = FlatStyle.Flat;
            mathewBindButton.Font = new Font("Microsoft Sans Serif", 8.25F);
            mathewBindButton.ForeColor = Color.FromArgb(162, 162, 162);
            mathewBindButton.Location = new Point(945, 110);
            mathewBindButton.Name = "mathewBindButton";
            mathewBindButton.Size = new Size(80, 27);
            mathewBindButton.TabIndex = 87;
            mathewBindButton.TabStop = false;
            mathewBindButton.UseVisualStyleBackColor = true;
            mathewBindButton.Click += mathewBindButton_Click;
            // 
            // altingBindButton
            // 
            altingBindButton.BackColor = Color.Transparent;
            altingBindButton.FlatStyle = FlatStyle.Flat;
            altingBindButton.Font = new Font("Microsoft Sans Serif", 8.25F);
            altingBindButton.ForeColor = Color.FromArgb(162, 162, 162);
            altingBindButton.Location = new Point(274, 348);
            altingBindButton.Name = "altingBindButton";
            altingBindButton.Size = new Size(80, 27);
            altingBindButton.TabIndex = 88;
            altingBindButton.TabStop = false;
            altingBindButton.UseVisualStyleBackColor = true;
            altingBindButton.Click += altingBindButton_Click;
            // 
            // dabingBindButton
            // 
            dabingBindButton.BackColor = Color.Transparent;
            dabingBindButton.FlatStyle = FlatStyle.Flat;
            dabingBindButton.Font = new Font("Microsoft Sans Serif", 8.25F);
            dabingBindButton.ForeColor = Color.FromArgb(162, 162, 162);
            dabingBindButton.Location = new Point(939, 348);
            dabingBindButton.Name = "dabingBindButton";
            dabingBindButton.Size = new Size(80, 27);
            dabingBindButton.TabIndex = 89;
            dabingBindButton.TabStop = false;
            dabingBindButton.UseVisualStyleBackColor = true;
            dabingBindButton.Click += dabingBindButton_Click;
            // 
            // depositBindButton
            // 
            depositBindButton.BackColor = Color.Transparent;
            depositBindButton.FlatStyle = FlatStyle.Flat;
            depositBindButton.Font = new Font("Microsoft Sans Serif", 8.25F);
            depositBindButton.ForeColor = Color.FromArgb(162, 162, 162);
            depositBindButton.Location = new Point(272, 110);
            depositBindButton.Name = "depositBindButton";
            depositBindButton.Size = new Size(80, 27);
            depositBindButton.TabIndex = 90;
            depositBindButton.TabStop = false;
            depositBindButton.UseVisualStyleBackColor = true;
            depositBindButton.Click += depositBindButton_Click;
            // 
            // voidStatusButton
            // 
            voidStatusButton.BackColor = Color.Transparent;
            voidStatusButton.FlatStyle = FlatStyle.Flat;
            voidStatusButton.Font = new Font("Microsoft Sans Serif", 8.25F);
            voidStatusButton.ForeColor = Color.FromArgb(68, 68, 68);
            voidStatusButton.Location = new Point(470, 291);
            voidStatusButton.Name = "voidStatusButton";
            voidStatusButton.Size = new Size(145, 27);
            voidStatusButton.TabIndex = 105;
            voidStatusButton.TabStop = false;
            voidStatusButton.UseVisualStyleBackColor = true;
            voidStatusButton.Click += voidStatusButton_Click;
            // 
            // dabingStatusButton
            // 
            dabingStatusButton.BackColor = Color.Transparent;
            dabingStatusButton.FlatStyle = FlatStyle.Flat;
            dabingStatusButton.Font = new Font("Microsoft Sans Serif", 8.25F);
            dabingStatusButton.ForeColor = Color.FromArgb(68, 68, 68);
            dabingStatusButton.Location = new Point(823, 296);
            dabingStatusButton.Name = "dabingStatusButton";
            dabingStatusButton.Size = new Size(145, 27);
            dabingStatusButton.TabIndex = 103;
            dabingStatusButton.TabStop = false;
            dabingStatusButton.UseVisualStyleBackColor = true;
            dabingStatusButton.Click += dabingStatusButton_Click;
            // 
            // mathewStatusButton
            // 
            mathewStatusButton.BackColor = Color.Transparent;
            mathewStatusButton.FlatStyle = FlatStyle.Flat;
            mathewStatusButton.Font = new Font("Microsoft Sans Serif", 8.25F);
            mathewStatusButton.ForeColor = Color.FromArgb(68, 68, 68);
            mathewStatusButton.Location = new Point(829, 60);
            mathewStatusButton.Name = "mathewStatusButton";
            mathewStatusButton.Size = new Size(145, 27);
            mathewStatusButton.TabIndex = 102;
            mathewStatusButton.TabStop = false;
            mathewStatusButton.UseVisualStyleBackColor = true;
            mathewStatusButton.Click += mathewStatusButton_Click;
            // 
            // altingStatusButton
            // 
            altingStatusButton.BackColor = Color.Transparent;
            altingStatusButton.FlatStyle = FlatStyle.Flat;
            altingStatusButton.Font = new Font("Microsoft Sans Serif", 8.25F);
            altingStatusButton.ForeColor = Color.FromArgb(68, 68, 68);
            altingStatusButton.Location = new Point(157, 295);
            altingStatusButton.Name = "altingStatusButton";
            altingStatusButton.Size = new Size(145, 27);
            altingStatusButton.TabIndex = 101;
            altingStatusButton.TabStop = false;
            altingStatusButton.UseVisualStyleBackColor = true;
            altingStatusButton.Click += altingStatusButton_Click;
            // 
            // effectsDrawingStatusButton
            // 
            effectsDrawingStatusButton.BackColor = Color.Transparent;
            effectsDrawingStatusButton.FlatStyle = FlatStyle.Flat;
            effectsDrawingStatusButton.Font = new Font("Microsoft Sans Serif", 8.25F);
            effectsDrawingStatusButton.ForeColor = Color.FromArgb(68, 68, 68);
            effectsDrawingStatusButton.Location = new Point(471, 56);
            effectsDrawingStatusButton.Name = "effectsDrawingStatusButton";
            effectsDrawingStatusButton.Size = new Size(145, 27);
            effectsDrawingStatusButton.TabIndex = 100;
            effectsDrawingStatusButton.TabStop = false;
            effectsDrawingStatusButton.UseVisualStyleBackColor = true;
            effectsDrawingStatusButton.Click += effectsDrawingStatusButton_Click;
            // 
            // depositStatusButton
            // 
            depositStatusButton.BackColor = Color.Transparent;
            depositStatusButton.FlatStyle = FlatStyle.Flat;
            depositStatusButton.Font = new Font("Microsoft Sans Serif", 8.25F);
            depositStatusButton.ForeColor = Color.FromArgb(68, 68, 68);
            depositStatusButton.Location = new Point(157, 58);
            depositStatusButton.Name = "depositStatusButton";
            depositStatusButton.Size = new Size(145, 27);
            depositStatusButton.TabIndex = 99;
            depositStatusButton.TabStop = false;
            depositStatusButton.UseVisualStyleBackColor = true;
            depositStatusButton.Click += depositStatusButton_Click;
            // 
            // voidStatusPicBox
            // 
            voidStatusPicBox.BackColor = Color.Transparent;
            voidStatusPicBox.BackgroundImage = Properties.Resources.Yes;
            voidStatusPicBox.BackgroundImageLayout = ImageLayout.Stretch;
            voidStatusPicBox.Location = new Point(591, 293);
            voidStatusPicBox.Name = "voidStatusPicBox";
            voidStatusPicBox.Size = new Size(23, 23);
            voidStatusPicBox.TabIndex = 98;
            voidStatusPicBox.TabStop = false;
            voidStatusPicBox.Click += voidStatusButton_Click;
            // 
            // dabingStatusPicBox
            // 
            dabingStatusPicBox.BackColor = Color.Transparent;
            dabingStatusPicBox.BackgroundImage = Properties.Resources.Yes;
            dabingStatusPicBox.BackgroundImageLayout = ImageLayout.Stretch;
            dabingStatusPicBox.Location = new Point(944, 298);
            dabingStatusPicBox.Name = "dabingStatusPicBox";
            dabingStatusPicBox.Size = new Size(23, 23);
            dabingStatusPicBox.TabIndex = 96;
            dabingStatusPicBox.TabStop = false;
            dabingStatusPicBox.Click += dabingStatusButton_Click;
            // 
            // mathewStatusPicBox
            // 
            mathewStatusPicBox.BackColor = Color.Transparent;
            mathewStatusPicBox.BackgroundImage = Properties.Resources.Yes;
            mathewStatusPicBox.BackgroundImageLayout = ImageLayout.Stretch;
            mathewStatusPicBox.Location = new Point(950, 62);
            mathewStatusPicBox.Name = "mathewStatusPicBox";
            mathewStatusPicBox.Size = new Size(23, 23);
            mathewStatusPicBox.TabIndex = 95;
            mathewStatusPicBox.TabStop = false;
            mathewStatusPicBox.Click += mathewStatusButton_Click;
            // 
            // altingStatusPicBox
            // 
            altingStatusPicBox.BackColor = Color.Transparent;
            altingStatusPicBox.BackgroundImage = Properties.Resources.Yes;
            altingStatusPicBox.BackgroundImageLayout = ImageLayout.Stretch;
            altingStatusPicBox.Location = new Point(278, 298);
            altingStatusPicBox.Name = "altingStatusPicBox";
            altingStatusPicBox.Size = new Size(23, 23);
            altingStatusPicBox.TabIndex = 94;
            altingStatusPicBox.TabStop = false;
            altingStatusPicBox.Click += altingStatusButton_Click;
            // 
            // effectsDrawingStatusPicBox
            // 
            effectsDrawingStatusPicBox.BackColor = Color.Transparent;
            effectsDrawingStatusPicBox.BackgroundImage = Properties.Resources.Yes;
            effectsDrawingStatusPicBox.BackgroundImageLayout = ImageLayout.Stretch;
            effectsDrawingStatusPicBox.Location = new Point(593, 58);
            effectsDrawingStatusPicBox.Name = "effectsDrawingStatusPicBox";
            effectsDrawingStatusPicBox.Size = new Size(23, 23);
            effectsDrawingStatusPicBox.TabIndex = 93;
            effectsDrawingStatusPicBox.TabStop = false;
            effectsDrawingStatusPicBox.Click += effectsDrawingStatusButton_Click;
            // 
            // depositStatusPicBox
            // 
            depositStatusPicBox.BackColor = Color.Transparent;
            depositStatusPicBox.BackgroundImage = Properties.Resources.Yes;
            depositStatusPicBox.BackgroundImageLayout = ImageLayout.Stretch;
            depositStatusPicBox.Location = new Point(278, 60);
            depositStatusPicBox.Name = "depositStatusPicBox";
            depositStatusPicBox.Size = new Size(23, 23);
            depositStatusPicBox.TabIndex = 92;
            depositStatusPicBox.TabStop = false;
            depositStatusPicBox.Click += depositStatusButton_Click;
            // 
            // effectsOnCheckBox
            // 
            effectsOnCheckBox.AutoSize = true;
            effectsOnCheckBox.Location = new Point(482, 116);
            effectsOnCheckBox.Name = "effectsOnCheckBox";
            effectsOnCheckBox.Size = new Size(15, 14);
            effectsOnCheckBox.TabIndex = 108;
            effectsOnCheckBox.TabStop = false;
            effectsOnCheckBox.UseVisualStyleBackColor = true;
            effectsOnCheckBox.CheckedChanged += effectsOnCheckBox_CheckedChanged;
            // 
            // drawingOnCheckBox
            // 
            drawingOnCheckBox.AutoSize = true;
            drawingOnCheckBox.Location = new Point(484, 169);
            drawingOnCheckBox.Name = "drawingOnCheckBox";
            drawingOnCheckBox.Size = new Size(15, 14);
            drawingOnCheckBox.TabIndex = 109;
            drawingOnCheckBox.TabStop = false;
            drawingOnCheckBox.UseVisualStyleBackColor = true;
            drawingOnCheckBox.CheckedChanged += drawingOnCheckBox_CheckedChanged;
            // 
            // dabingTypeComboBox
            // 
            dabingTypeComboBox.FormattingEnabled = true;
            dabingTypeComboBox.Items.AddRange(new object[] { "Spam", "Trzymanie" });
            dabingTypeComboBox.Location = new Point(893, 405);
            dabingTypeComboBox.Name = "dabingTypeComboBox";
            dabingTypeComboBox.Size = new Size(110, 21);
            dabingTypeComboBox.TabIndex = 110;
            dabingTypeComboBox.SelectedIndexChanged += dabingTypeComboBox_SelectedIndexChanged;
            // 
            // voidDelayNumeric
            // 
            voidDelayNumeric.Location = new Point(614, 455);
            voidDelayNumeric.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            voidDelayNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            voidDelayNumeric.Name = "voidDelayNumeric";
            voidDelayNumeric.Size = new Size(58, 20);
            voidDelayNumeric.TabIndex = 111;
            voidDelayNumeric.TabStop = false;
            voidDelayNumeric.Value = new decimal(new int[] { 2, 0, 0, 0 });
            voidDelayNumeric.ValueChanged += voidDelayNumeric_ValueChanged;
            // 
            // intelligentVoidCheckBox
            // 
            intelligentVoidCheckBox.AutoSize = true;
            intelligentVoidCheckBox.Location = new Point(693, 407);
            intelligentVoidCheckBox.Name = "intelligentVoidCheckBox";
            intelligentVoidCheckBox.Size = new Size(15, 14);
            intelligentVoidCheckBox.TabIndex = 112;
            intelligentVoidCheckBox.TabStop = false;
            intelligentVoidCheckBox.UseVisualStyleBackColor = true;
            intelligentVoidCheckBox.CheckedChanged += intelligentVoidCheckBox_CheckedChanged;
            // 
            // OthersForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = Properties.Resources.Others;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1029, 573);
            Controls.Add(intelligentVoidCheckBox);
            Controls.Add(voidDelayNumeric);
            Controls.Add(dabingTypeComboBox);
            Controls.Add(drawingOnCheckBox);
            Controls.Add(effectsOnCheckBox);
            Controls.Add(voidStatusPicBox);
            Controls.Add(dabingStatusPicBox);
            Controls.Add(mathewStatusPicBox);
            Controls.Add(altingStatusPicBox);
            Controls.Add(effectsDrawingStatusPicBox);
            Controls.Add(depositStatusPicBox);
            Controls.Add(voidStatusButton);
            Controls.Add(dabingStatusButton);
            Controls.Add(mathewStatusButton);
            Controls.Add(altingStatusButton);
            Controls.Add(effectsDrawingStatusButton);
            Controls.Add(depositStatusButton);
            Controls.Add(voidBindButton);
            Controls.Add(drawingBindButton);
            Controls.Add(effectsBindButton);
            Controls.Add(mathewBindButton);
            Controls.Add(altingBindButton);
            Controls.Add(dabingBindButton);
            Controls.Add(depositBindButton);
            Controls.Add(settingsNavButton);
            Controls.Add(effectsCoordinateButton);
            Controls.Add(drawingCoordinateButton);
            Controls.Add(pickaxe4RadioButton);
            Controls.Add(pickaxe5RadioButton);
            Controls.Add(pickaxe6RadioButton);
            Controls.Add(depositDelayNumeric);
            Controls.Add(bindsNavButton);
            Controls.Add(pvpNavButton);
            Controls.Add(miningNavButton);
            DoubleBuffered = true;
            Font = new Font("Microsoft Sans Serif", 8.25F);
            FormBorderStyle = FormBorderStyle.None;
            Icon = Properties.Resources.Logo;
            MaximizeBox = false;
            Name = "OthersForm";
            StartPosition = FormStartPosition.Manual;
            Text = "Smoczy Clicker";
            ((System.ComponentModel.ISupportInitialize)depositDelayNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)voidStatusPicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)dabingStatusPicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)mathewStatusPicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)altingStatusPicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)effectsDrawingStatusPicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)depositStatusPicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)voidDelayNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private InvisibleButton miningNavButton;
        private InvisibleButton bindsNavButton;
        private InvisibleButton pvpNavButton;
        private System.Windows.Forms.NumericUpDown depositDelayNumeric;
        private System.Windows.Forms.RadioButton pickaxe6RadioButton;
        private System.Windows.Forms.RadioButton pickaxe5RadioButton;
        private System.Windows.Forms.RadioButton pickaxe4RadioButton;
        private InvisibleButton drawingCoordinateButton;
        private InvisibleButton effectsCoordinateButton;
        private InvisibleButton settingsNavButton;
        private InvisibleButton voidBindButton;
        private InvisibleButton drawingBindButton;
        private InvisibleButton effectsBindButton;
        private InvisibleButton mathewBindButton;
        private InvisibleButton altingBindButton;
        private InvisibleButton dabingBindButton;
        private InvisibleButton depositBindButton;
        private InvisibleButton voidStatusButton;
        private InvisibleButton dabingStatusButton;
        private InvisibleButton mathewStatusButton;
        private InvisibleButton altingStatusButton;
        private InvisibleButton effectsDrawingStatusButton;
        private InvisibleButton depositStatusButton;
        private System.Windows.Forms.PictureBox voidStatusPicBox;
        private System.Windows.Forms.PictureBox dabingStatusPicBox;
        private System.Windows.Forms.PictureBox mathewStatusPicBox;
        private System.Windows.Forms.PictureBox altingStatusPicBox;
        private System.Windows.Forms.PictureBox effectsDrawingStatusPicBox;
        private System.Windows.Forms.PictureBox depositStatusPicBox;
        private System.Windows.Forms.CheckBox effectsOnCheckBox;
        private System.Windows.Forms.CheckBox drawingOnCheckBox;
        private System.Windows.Forms.ComboBox dabingTypeComboBox;
        private NumericUpDown voidDelayNumeric;
        private CheckBox intelligentVoidCheckBox;
    }
}

