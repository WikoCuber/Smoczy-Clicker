using SC_UI.Helpers;

namespace SC_UI.Forms
{
    partial class MiningForm
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
            backgroundCheckBox = new CheckBox();
            slot1OnCheckBox = new CheckBox();
            slot2OnCheckBox = new CheckBox();
            slot3OnCheckBox = new CheckBox();
            slot4OnCheckBox = new CheckBox();
            slot5OnCheckBox = new CheckBox();
            dropOnCheckBox = new CheckBox();
            eatingOnCheckBox = new CheckBox();
            whichLapDropNumric = new NumericUpDown();
            whichLapEatingNumeric = new NumericUpDown();
            lenghtNumeric = new NumericUpDown();
            miningStatusPicBox = new PictureBox();
            addButton = new Button();
            commandsBindsPanel = new Panel();
            backgroundBPCheckBox = new CheckBox();
            bindRadioButton = new RadioButton();
            commandRadioButton = new RadioButton();
            miningBindButton = new InvisibleButton();
            pvpNavButton = new InvisibleButton();
            bindsNavButton = new InvisibleButton();
            othersNavButton = new InvisibleButton();
            miningStatusButton = new InvisibleButton();
            settingsNavButton = new InvisibleButton();
            ((System.ComponentModel.ISupportInitialize)whichLapDropNumric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)whichLapEatingNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lenghtNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)miningStatusPicBox).BeginInit();
            SuspendLayout();
            // 
            // backgroundCheckBox
            // 
            backgroundCheckBox.AutoSize = true;
            backgroundCheckBox.Location = new Point(329, 198);
            backgroundCheckBox.Margin = new Padding(4, 3, 4, 3);
            backgroundCheckBox.Name = "backgroundCheckBox";
            backgroundCheckBox.Size = new Size(15, 14);
            backgroundCheckBox.TabIndex = 26;
            backgroundCheckBox.TabStop = false;
            backgroundCheckBox.UseVisualStyleBackColor = true;
            backgroundCheckBox.CheckedChanged += backgroundCheckBox_CheckedChanged;
            // 
            // slot1OnCheckBox
            // 
            slot1OnCheckBox.AutoSize = true;
            slot1OnCheckBox.Location = new Point(393, 360);
            slot1OnCheckBox.Margin = new Padding(4, 3, 4, 3);
            slot1OnCheckBox.Name = "slot1OnCheckBox";
            slot1OnCheckBox.Size = new Size(15, 14);
            slot1OnCheckBox.TabIndex = 27;
            slot1OnCheckBox.TabStop = false;
            slot1OnCheckBox.UseVisualStyleBackColor = true;
            slot1OnCheckBox.CheckedChanged += slot1OnCheckBox_CheckedChanged;
            // 
            // slot2OnCheckBox
            // 
            slot2OnCheckBox.AutoSize = true;
            slot2OnCheckBox.Location = new Point(397, 388);
            slot2OnCheckBox.Margin = new Padding(4, 3, 4, 3);
            slot2OnCheckBox.Name = "slot2OnCheckBox";
            slot2OnCheckBox.Size = new Size(15, 14);
            slot2OnCheckBox.TabIndex = 28;
            slot2OnCheckBox.TabStop = false;
            slot2OnCheckBox.UseVisualStyleBackColor = true;
            slot2OnCheckBox.CheckedChanged += slot2OnCheckBox_CheckedChanged;
            // 
            // slot3OnCheckBox
            // 
            slot3OnCheckBox.AutoSize = true;
            slot3OnCheckBox.Location = new Point(396, 414);
            slot3OnCheckBox.Margin = new Padding(4, 3, 4, 3);
            slot3OnCheckBox.Name = "slot3OnCheckBox";
            slot3OnCheckBox.Size = new Size(15, 14);
            slot3OnCheckBox.TabIndex = 29;
            slot3OnCheckBox.TabStop = false;
            slot3OnCheckBox.UseVisualStyleBackColor = true;
            slot3OnCheckBox.CheckedChanged += slot3OnCheckBox_CheckedChanged;
            // 
            // slot4OnCheckBox
            // 
            slot4OnCheckBox.AutoSize = true;
            slot4OnCheckBox.Location = new Point(399, 441);
            slot4OnCheckBox.Margin = new Padding(4, 3, 4, 3);
            slot4OnCheckBox.Name = "slot4OnCheckBox";
            slot4OnCheckBox.Size = new Size(15, 14);
            slot4OnCheckBox.TabIndex = 30;
            slot4OnCheckBox.TabStop = false;
            slot4OnCheckBox.UseVisualStyleBackColor = true;
            slot4OnCheckBox.CheckedChanged += slot4OnCheckBox_CheckedChanged;
            // 
            // slot5OnCheckBox
            // 
            slot5OnCheckBox.AutoSize = true;
            slot5OnCheckBox.Location = new Point(398, 467);
            slot5OnCheckBox.Margin = new Padding(4, 3, 4, 3);
            slot5OnCheckBox.Name = "slot5OnCheckBox";
            slot5OnCheckBox.Size = new Size(15, 14);
            slot5OnCheckBox.TabIndex = 31;
            slot5OnCheckBox.TabStop = false;
            slot5OnCheckBox.UseVisualStyleBackColor = true;
            slot5OnCheckBox.CheckedChanged += slot5OnCheckBox_CheckedChanged;
            // 
            // dropOnCheckBox
            // 
            dropOnCheckBox.AutoSize = true;
            dropOnCheckBox.Location = new Point(160, 277);
            dropOnCheckBox.Margin = new Padding(4, 3, 4, 3);
            dropOnCheckBox.Name = "dropOnCheckBox";
            dropOnCheckBox.Size = new Size(15, 14);
            dropOnCheckBox.TabIndex = 37;
            dropOnCheckBox.TabStop = false;
            dropOnCheckBox.UseVisualStyleBackColor = true;
            dropOnCheckBox.CheckedChanged += dropOnCheckBox_CheckedChanged;
            // 
            // eatingOnCheckBox
            // 
            eatingOnCheckBox.AutoSize = true;
            eatingOnCheckBox.Location = new Point(159, 306);
            eatingOnCheckBox.Margin = new Padding(4, 3, 4, 3);
            eatingOnCheckBox.Name = "eatingOnCheckBox";
            eatingOnCheckBox.Size = new Size(15, 14);
            eatingOnCheckBox.TabIndex = 38;
            eatingOnCheckBox.TabStop = false;
            eatingOnCheckBox.UseVisualStyleBackColor = true;
            eatingOnCheckBox.CheckedChanged += eatingOnCheckBox_CheckedChanged;
            // 
            // whichLapDropNumric
            // 
            whichLapDropNumric.Location = new Point(330, 276);
            whichLapDropNumric.Margin = new Padding(4, 3, 4, 3);
            whichLapDropNumric.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            whichLapDropNumric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            whichLapDropNumric.Name = "whichLapDropNumric";
            whichLapDropNumric.Size = new Size(58, 23);
            whichLapDropNumric.TabIndex = 44;
            whichLapDropNumric.TabStop = false;
            whichLapDropNumric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            whichLapDropNumric.ValueChanged += whichLapDropNumeric_ValueChanged;
            // 
            // whichLapEatingNumeric
            // 
            whichLapEatingNumeric.Location = new Point(377, 303);
            whichLapEatingNumeric.Margin = new Padding(4, 3, 4, 3);
            whichLapEatingNumeric.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            whichLapEatingNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            whichLapEatingNumeric.Name = "whichLapEatingNumeric";
            whichLapEatingNumeric.Size = new Size(58, 23);
            whichLapEatingNumeric.TabIndex = 45;
            whichLapEatingNumeric.TabStop = false;
            whichLapEatingNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            whichLapEatingNumeric.ValueChanged += whichLapEatingNumeric_ValueChanged;
            // 
            // lenghtNumeric
            // 
            lenghtNumeric.Location = new Point(376, 165);
            lenghtNumeric.Margin = new Padding(4, 3, 4, 3);
            lenghtNumeric.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            lenghtNumeric.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            lenghtNumeric.Name = "lenghtNumeric";
            lenghtNumeric.Size = new Size(58, 23);
            lenghtNumeric.TabIndex = 58;
            lenghtNumeric.TabStop = false;
            lenghtNumeric.Value = new decimal(new int[] { 2, 0, 0, 0 });
            lenghtNumeric.ValueChanged += lenghtNumeric_ValueChanged;
            // 
            // miningStatusPicBox
            // 
            miningStatusPicBox.BackColor = Color.Transparent;
            miningStatusPicBox.BackgroundImage = Properties.Resources.Yes;
            miningStatusPicBox.BackgroundImageLayout = ImageLayout.Stretch;
            miningStatusPicBox.Location = new Point(278, 32);
            miningStatusPicBox.Margin = new Padding(4, 3, 4, 3);
            miningStatusPicBox.Name = "miningStatusPicBox";
            miningStatusPicBox.Size = new Size(23, 23);
            miningStatusPicBox.TabIndex = 68;
            miningStatusPicBox.TabStop = false;
            miningStatusPicBox.Click += miningStatusButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(798, 513);
            addButton.Margin = new Padding(4, 3, 4, 3);
            addButton.Name = "addButton";
            addButton.Size = new Size(88, 27);
            addButton.TabIndex = 69;
            addButton.Text = "Dodaj";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // commandsBindsPanel
            // 
            commandsBindsPanel.BackColor = Color.Transparent;
            commandsBindsPanel.Location = new Point(663, 90);
            commandsBindsPanel.Margin = new Padding(4, 3, 4, 3);
            commandsBindsPanel.Name = "commandsBindsPanel";
            commandsBindsPanel.Size = new Size(338, 404);
            commandsBindsPanel.TabIndex = 70;
            // 
            // backgroundBPCheckBox
            // 
            backgroundBPCheckBox.AutoSize = true;
            backgroundBPCheckBox.Location = new Point(414, 223);
            backgroundBPCheckBox.Margin = new Padding(4, 3, 4, 3);
            backgroundBPCheckBox.Name = "backgroundBPCheckBox";
            backgroundBPCheckBox.Size = new Size(15, 14);
            backgroundBPCheckBox.TabIndex = 71;
            backgroundBPCheckBox.TabStop = false;
            backgroundBPCheckBox.UseVisualStyleBackColor = true;
            backgroundBPCheckBox.CheckedChanged += backgroundBPCheckBox_CheckedChanged;
            // 
            // bindRadioButton
            // 
            bindRadioButton.AutoSize = true;
            bindRadioButton.Location = new Point(692, 63);
            bindRadioButton.Margin = new Padding(4, 3, 4, 3);
            bindRadioButton.Name = "bindRadioButton";
            bindRadioButton.Size = new Size(14, 13);
            bindRadioButton.TabIndex = 73;
            bindRadioButton.UseVisualStyleBackColor = true;
            bindRadioButton.CheckedChanged += bindRadioButton_CheckedChanged;
            // 
            // commandRadioButton
            // 
            commandRadioButton.AutoSize = true;
            commandRadioButton.Location = new Point(663, 36);
            commandRadioButton.Margin = new Padding(4, 3, 4, 3);
            commandRadioButton.Name = "commandRadioButton";
            commandRadioButton.Size = new Size(14, 13);
            commandRadioButton.TabIndex = 72;
            commandRadioButton.UseVisualStyleBackColor = true;
            commandRadioButton.CheckedChanged += commandRadioButton_CheckedChanged;
            // 
            // miningBindButton
            // 
            miningBindButton.BackColor = Color.Transparent;
            miningBindButton.FlatStyle = FlatStyle.Flat;
            miningBindButton.Font = new Font("Microsoft Sans Serif", 8.25F);
            miningBindButton.ForeColor = Color.FromArgb(162, 162, 162);
            miningBindButton.Location = new Point(270, 110);
            miningBindButton.Name = "miningBindButton";
            miningBindButton.Size = new Size(80, 27);
            miningBindButton.TabIndex = 66;
            miningBindButton.TabStop = false;
            miningBindButton.UseVisualStyleBackColor = true;
            miningBindButton.Click += miningBindButton_Click;
            // 
            // pvpNavButton
            // 
            pvpNavButton.BackColor = Color.Transparent;
            pvpNavButton.FlatStyle = FlatStyle.Flat;
            pvpNavButton.Font = new Font("Microsoft Sans Serif", 8.25F);
            pvpNavButton.ForeColor = Color.FromArgb(68, 68, 68);
            pvpNavButton.Location = new Point(16, 28);
            pvpNavButton.Name = "pvpNavButton";
            pvpNavButton.Size = new Size(130, 39);
            pvpNavButton.TabIndex = 21;
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
            bindsNavButton.Location = new Point(15, 166);
            bindsNavButton.Name = "bindsNavButton";
            bindsNavButton.Size = new Size(130, 39);
            bindsNavButton.TabIndex = 22;
            bindsNavButton.TabStop = false;
            bindsNavButton.UseVisualStyleBackColor = true;
            bindsNavButton.Click += bindsNavButton_Click;
            // 
            // othersNavButton
            // 
            othersNavButton.BackColor = Color.Transparent;
            othersNavButton.FlatStyle = FlatStyle.Flat;
            othersNavButton.Font = new Font("Microsoft Sans Serif", 8.25F);
            othersNavButton.ForeColor = Color.FromArgb(68, 68, 68);
            othersNavButton.Location = new Point(16, 121);
            othersNavButton.Name = "othersNavButton";
            othersNavButton.Size = new Size(130, 39);
            othersNavButton.TabIndex = 20;
            othersNavButton.TabStop = false;
            othersNavButton.UseVisualStyleBackColor = true;
            othersNavButton.Click += othersNavButton_Click;
            // 
            // miningStatusButton
            // 
            miningStatusButton.BackColor = Color.Transparent;
            miningStatusButton.FlatStyle = FlatStyle.Flat;
            miningStatusButton.Font = new Font("Microsoft Sans Serif", 8.25F);
            miningStatusButton.ForeColor = Color.FromArgb(68, 68, 68);
            miningStatusButton.Location = new Point(155, 30);
            miningStatusButton.Name = "miningStatusButton";
            miningStatusButton.Size = new Size(145, 27);
            miningStatusButton.TabIndex = 67;
            miningStatusButton.TabStop = false;
            miningStatusButton.UseVisualStyleBackColor = true;
            miningStatusButton.Click += miningStatusButton_Click;
            // 
            // settingsNavButton
            // 
            settingsNavButton.BackColor = Color.Transparent;
            settingsNavButton.FlatStyle = FlatStyle.Flat;
            settingsNavButton.Font = new Font("Microsoft Sans Serif", 8.25F);
            settingsNavButton.ForeColor = Color.FromArgb(68, 68, 68);
            settingsNavButton.Location = new Point(14, 214);
            settingsNavButton.Name = "settingsNavButton";
            settingsNavButton.Size = new Size(130, 39);
            settingsNavButton.TabIndex = 65;
            settingsNavButton.TabStop = false;
            settingsNavButton.UseVisualStyleBackColor = true;
            settingsNavButton.Click += settingsNavButton_Click;
            // 
            // MiningForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = Properties.Resources.Mining;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1029, 573);
            Controls.Add(bindRadioButton);
            Controls.Add(commandRadioButton);
            Controls.Add(backgroundBPCheckBox);
            Controls.Add(commandsBindsPanel);
            Controls.Add(addButton);
            Controls.Add(miningStatusPicBox);
            Controls.Add(lenghtNumeric);
            Controls.Add(whichLapEatingNumeric);
            Controls.Add(whichLapDropNumric);
            Controls.Add(eatingOnCheckBox);
            Controls.Add(dropOnCheckBox);
            Controls.Add(slot5OnCheckBox);
            Controls.Add(slot4OnCheckBox);
            Controls.Add(slot3OnCheckBox);
            Controls.Add(slot2OnCheckBox);
            Controls.Add(slot1OnCheckBox);
            Controls.Add(backgroundCheckBox);
            Controls.Add(bindsNavButton);
            Controls.Add(pvpNavButton);
            Controls.Add(othersNavButton);
            Controls.Add(miningBindButton);
            Controls.Add(miningStatusButton);
            Controls.Add(settingsNavButton);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = Properties.Resources.Logo;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "MiningForm";
            StartPosition = FormStartPosition.Manual;
            Text = "Smoczy Clicker";
            ((System.ComponentModel.ISupportInitialize)whichLapDropNumric).EndInit();
            ((System.ComponentModel.ISupportInitialize)whichLapEatingNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)lenghtNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)miningStatusPicBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private InvisibleButton othersNavButton;
        private InvisibleButton pvpNavButton;
        private System.Windows.Forms.CheckBox backgroundCheckBox;
        private System.Windows.Forms.CheckBox slot1OnCheckBox;
        private System.Windows.Forms.CheckBox slot2OnCheckBox;
        private System.Windows.Forms.CheckBox slot3OnCheckBox;
        private System.Windows.Forms.CheckBox slot4OnCheckBox;
        private System.Windows.Forms.CheckBox slot5OnCheckBox;
        private System.Windows.Forms.CheckBox dropOnCheckBox;
        private System.Windows.Forms.CheckBox eatingOnCheckBox;
        private System.Windows.Forms.NumericUpDown whichLapDropNumric;
        private System.Windows.Forms.NumericUpDown whichLapEatingNumeric;
        private System.Windows.Forms.NumericUpDown lenghtNumeric;
        private InvisibleButton bindsNavButton;
        private InvisibleButton settingsNavButton;
        private InvisibleButton miningBindButton;
        private InvisibleButton miningStatusButton;
        private System.Windows.Forms.PictureBox miningStatusPicBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Panel commandsBindsPanel;
        private System.Windows.Forms.CheckBox backgroundBPCheckBox;
        private System.Windows.Forms.RadioButton bindRadioButton;
        private System.Windows.Forms.RadioButton commandRadioButton;
    }
}

