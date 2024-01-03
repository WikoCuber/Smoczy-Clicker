using SC_UI.Helpers;

namespace SC_UI.Forms
{
    partial class PvPForm
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
            othersNavButton = new InvisibleButton();
            rightClickerBindButton = new InvisibleButton();
            leftClickerBindButton = new InvisibleButton();
            rightClickerCpsNumeric = new NumericUpDown();
            leftClickerCpsNumeric = new NumericUpDown();
            settingsNavButton = new InvisibleButton();
            armorDelayNumeric = new NumericUpDown();
            armor3OnCheckBox = new CheckBox();
            armor2OnCheckBox = new CheckBox();
            armor1OnCheckBox = new CheckBox();
            fishingRodBindButton = new InvisibleButton();
            snowballBindButton = new InvisibleButton();
            snowballOnCheckBox = new CheckBox();
            fishingRodOnCheckBox = new CheckBox();
            snowballDelayNumeric = new NumericUpDown();
            fishingRodDelayNumeric = new NumericUpDown();
            armor3BindButton = new InvisibleButton();
            armor2BindButton = new InvisibleButton();
            armor1BindButton = new InvisibleButton();
            armorStatusButton = new InvisibleButton();
            snowballFishingRodStatusButton = new InvisibleButton();
            clickerStatusButton = new InvisibleButton();
            snowballFishingRodStatusPicBox = new PictureBox();
            armorStatusPicBox = new PictureBox();
            clickerStatusPicBox = new PictureBox();
            leftClickerPanel = new Panel();
            leftClickerDHRadioButton = new RadioButton();
            leftClickerPCRadioButton = new RadioButton();
            leftClickerOCRadioButton = new RadioButton();
            rightClickerPanel = new Panel();
            rightClickerDHRadioButton = new RadioButton();
            rightClickerPCRadioButton = new RadioButton();
            rightClickerOCRadioButton = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)rightClickerCpsNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leftClickerCpsNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)armorDelayNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)snowballDelayNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fishingRodDelayNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)snowballFishingRodStatusPicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)armorStatusPicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clickerStatusPicBox).BeginInit();
            leftClickerPanel.SuspendLayout();
            rightClickerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // miningNavButton
            // 
            miningNavButton.BackColor = Color.Transparent;
            miningNavButton.FlatStyle = FlatStyle.Flat;
            miningNavButton.Font = new Font("Microsoft Sans Serif", 8.25F);
            miningNavButton.ForeColor = Color.FromArgb(68, 68, 68);
            miningNavButton.Location = new Point(14, 74);
            miningNavButton.Margin = new Padding(4, 3, 4, 3);
            miningNavButton.Name = "miningNavButton";
            miningNavButton.Size = new Size(130, 39);
            miningNavButton.TabIndex = 23;
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
            bindsNavButton.Location = new Point(14, 168);
            bindsNavButton.Margin = new Padding(4, 3, 4, 3);
            bindsNavButton.Name = "bindsNavButton";
            bindsNavButton.Size = new Size(130, 39);
            bindsNavButton.TabIndex = 26;
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
            othersNavButton.Location = new Point(14, 120);
            othersNavButton.Margin = new Padding(4, 3, 4, 3);
            othersNavButton.Name = "othersNavButton";
            othersNavButton.Size = new Size(130, 39);
            othersNavButton.TabIndex = 25;
            othersNavButton.TabStop = false;
            othersNavButton.UseVisualStyleBackColor = true;
            othersNavButton.Click += othersNavButton_Click;
            // 
            // rightClickerBindButton
            // 
            rightClickerBindButton.BackColor = Color.Transparent;
            rightClickerBindButton.FlatStyle = FlatStyle.Flat;
            rightClickerBindButton.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            rightClickerBindButton.ForeColor = Color.FromArgb(162, 162, 162);
            rightClickerBindButton.Location = new Point(772, 94);
            rightClickerBindButton.Margin = new Padding(4, 3, 4, 3);
            rightClickerBindButton.Name = "rightClickerBindButton";
            rightClickerBindButton.Size = new Size(80, 27);
            rightClickerBindButton.TabIndex = 27;
            rightClickerBindButton.TabStop = false;
            rightClickerBindButton.UseVisualStyleBackColor = true;
            rightClickerBindButton.Click += rightClickerBindButton_Click;
            // 
            // leftClickerBindButton
            // 
            leftClickerBindButton.BackColor = Color.Transparent;
            leftClickerBindButton.FlatStyle = FlatStyle.Flat;
            leftClickerBindButton.Font = new Font("Microsoft Sans Serif", 8.25F);
            leftClickerBindButton.ForeColor = Color.FromArgb(162, 162, 162);
            leftClickerBindButton.Location = new Point(266, 94);
            leftClickerBindButton.Margin = new Padding(4, 3, 4, 3);
            leftClickerBindButton.Name = "leftClickerBindButton";
            leftClickerBindButton.Size = new Size(80, 27);
            leftClickerBindButton.TabIndex = 28;
            leftClickerBindButton.TabStop = false;
            leftClickerBindButton.UseVisualStyleBackColor = true;
            leftClickerBindButton.Click += leftClickerBindButton_Click;
            // 
            // rightClickerCpsNumeric
            // 
            rightClickerCpsNumeric.Location = new Point(716, 149);
            rightClickerCpsNumeric.Margin = new Padding(4, 3, 4, 3);
            rightClickerCpsNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            rightClickerCpsNumeric.Name = "rightClickerCpsNumeric";
            rightClickerCpsNumeric.Size = new Size(58, 23);
            rightClickerCpsNumeric.TabIndex = 61;
            rightClickerCpsNumeric.TabStop = false;
            rightClickerCpsNumeric.Value = new decimal(new int[] { 2, 0, 0, 0 });
            rightClickerCpsNumeric.ValueChanged += rightClickerCpsNumeric_ValueChanged;
            // 
            // leftClickerCpsNumeric
            // 
            leftClickerCpsNumeric.Location = new Point(211, 148);
            leftClickerCpsNumeric.Margin = new Padding(4, 3, 4, 3);
            leftClickerCpsNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            leftClickerCpsNumeric.Name = "leftClickerCpsNumeric";
            leftClickerCpsNumeric.Size = new Size(58, 23);
            leftClickerCpsNumeric.TabIndex = 62;
            leftClickerCpsNumeric.TabStop = false;
            leftClickerCpsNumeric.Value = new decimal(new int[] { 2, 0, 0, 0 });
            leftClickerCpsNumeric.ValueChanged += leftClickerCpsNumeric_ValueChanged;
            // 
            // settingsNavButton
            // 
            settingsNavButton.BackColor = Color.Transparent;
            settingsNavButton.FlatStyle = FlatStyle.Flat;
            settingsNavButton.Font = new Font("Microsoft Sans Serif", 8.25F);
            settingsNavButton.ForeColor = Color.FromArgb(68, 68, 68);
            settingsNavButton.Location = new Point(14, 213);
            settingsNavButton.Margin = new Padding(4, 3, 4, 3);
            settingsNavButton.Name = "settingsNavButton";
            settingsNavButton.Size = new Size(130, 39);
            settingsNavButton.TabIndex = 63;
            settingsNavButton.TabStop = false;
            settingsNavButton.UseVisualStyleBackColor = true;
            settingsNavButton.Click += settingsNavButton_Click;
            // 
            // armorDelayNumeric
            // 
            armorDelayNumeric.Location = new Point(296, 357);
            armorDelayNumeric.Margin = new Padding(4, 3, 4, 3);
            armorDelayNumeric.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            armorDelayNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            armorDelayNumeric.Name = "armorDelayNumeric";
            armorDelayNumeric.Size = new Size(58, 23);
            armorDelayNumeric.TabIndex = 68;
            armorDelayNumeric.TabStop = false;
            armorDelayNumeric.Value = new decimal(new int[] { 2, 0, 0, 0 });
            armorDelayNumeric.ValueChanged += armorDelayNumeric_ValueChanged;
            // 
            // armor3OnCheckBox
            // 
            armor3OnCheckBox.AutoSize = true;
            armor3OnCheckBox.Location = new Point(163, 437);
            armor3OnCheckBox.Margin = new Padding(4, 3, 4, 3);
            armor3OnCheckBox.Name = "armor3OnCheckBox";
            armor3OnCheckBox.Size = new Size(15, 14);
            armor3OnCheckBox.TabIndex = 78;
            armor3OnCheckBox.TabStop = false;
            armor3OnCheckBox.UseVisualStyleBackColor = true;
            armor3OnCheckBox.CheckedChanged += armor3OnCheckBox_CheckedChanged;
            // 
            // armor2OnCheckBox
            // 
            armor2OnCheckBox.AutoSize = true;
            armor2OnCheckBox.Location = new Point(163, 412);
            armor2OnCheckBox.Margin = new Padding(4, 3, 4, 3);
            armor2OnCheckBox.Name = "armor2OnCheckBox";
            armor2OnCheckBox.Size = new Size(15, 14);
            armor2OnCheckBox.TabIndex = 77;
            armor2OnCheckBox.TabStop = false;
            armor2OnCheckBox.UseVisualStyleBackColor = true;
            armor2OnCheckBox.CheckedChanged += armor2OnCheckBox_CheckedChanged;
            // 
            // armor1OnCheckBox
            // 
            armor1OnCheckBox.AutoSize = true;
            armor1OnCheckBox.Location = new Point(163, 385);
            armor1OnCheckBox.Margin = new Padding(4, 3, 4, 3);
            armor1OnCheckBox.Name = "armor1OnCheckBox";
            armor1OnCheckBox.Size = new Size(15, 14);
            armor1OnCheckBox.TabIndex = 76;
            armor1OnCheckBox.TabStop = false;
            armor1OnCheckBox.UseVisualStyleBackColor = true;
            armor1OnCheckBox.CheckedChanged += armor1OnCheckBox_CheckedChanged;
            // 
            // fishingRodBindButton
            // 
            fishingRodBindButton.BackColor = Color.Transparent;
            fishingRodBindButton.FlatStyle = FlatStyle.Flat;
            fishingRodBindButton.Font = new Font("Microsoft Sans Serif", 8.25F);
            fishingRodBindButton.ForeColor = Color.FromArgb(162, 162, 162);
            fishingRodBindButton.Location = new Point(771, 407);
            fishingRodBindButton.Margin = new Padding(4, 3, 4, 3);
            fishingRodBindButton.Name = "fishingRodBindButton";
            fishingRodBindButton.Size = new Size(80, 27);
            fishingRodBindButton.TabIndex = 79;
            fishingRodBindButton.TabStop = false;
            fishingRodBindButton.UseVisualStyleBackColor = true;
            fishingRodBindButton.Click += fishingRodBindButton_Click;
            // 
            // snowballBindButton
            // 
            snowballBindButton.BackColor = Color.Transparent;
            snowballBindButton.FlatStyle = FlatStyle.Flat;
            snowballBindButton.Font = new Font("Microsoft Sans Serif", 8.25F);
            snowballBindButton.ForeColor = Color.FromArgb(162, 162, 162);
            snowballBindButton.Location = new Point(780, 352);
            snowballBindButton.Margin = new Padding(4, 3, 4, 3);
            snowballBindButton.Name = "snowballBindButton";
            snowballBindButton.Size = new Size(80, 27);
            snowballBindButton.TabIndex = 80;
            snowballBindButton.TabStop = false;
            snowballBindButton.UseVisualStyleBackColor = true;
            snowballBindButton.Click += snowballBindButton_Click;
            // 
            // snowballOnCheckBox
            // 
            snowballOnCheckBox.AutoSize = true;
            snowballOnCheckBox.Location = new Point(671, 359);
            snowballOnCheckBox.Margin = new Padding(4, 3, 4, 3);
            snowballOnCheckBox.Name = "snowballOnCheckBox";
            snowballOnCheckBox.Size = new Size(15, 14);
            snowballOnCheckBox.TabIndex = 84;
            snowballOnCheckBox.TabStop = false;
            snowballOnCheckBox.UseVisualStyleBackColor = true;
            snowballOnCheckBox.CheckedChanged += snowballOnCheckBox_CheckedChanged;
            // 
            // fishingRodOnCheckBox
            // 
            fishingRodOnCheckBox.AutoSize = true;
            fishingRodOnCheckBox.Location = new Point(671, 413);
            fishingRodOnCheckBox.Margin = new Padding(4, 3, 4, 3);
            fishingRodOnCheckBox.Name = "fishingRodOnCheckBox";
            fishingRodOnCheckBox.Size = new Size(15, 14);
            fishingRodOnCheckBox.TabIndex = 83;
            fishingRodOnCheckBox.TabStop = false;
            fishingRodOnCheckBox.UseVisualStyleBackColor = true;
            fishingRodOnCheckBox.CheckedChanged += fishingRodOnCheckBox_CheckedChanged;
            // 
            // snowballDelayNumeric
            // 
            snowballDelayNumeric.Location = new Point(798, 383);
            snowballDelayNumeric.Margin = new Padding(4, 3, 4, 3);
            snowballDelayNumeric.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            snowballDelayNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            snowballDelayNumeric.Name = "snowballDelayNumeric";
            snowballDelayNumeric.Size = new Size(58, 23);
            snowballDelayNumeric.TabIndex = 82;
            snowballDelayNumeric.TabStop = false;
            snowballDelayNumeric.Value = new decimal(new int[] { 2, 0, 0, 0 });
            snowballDelayNumeric.ValueChanged += snowballDelayNumeric_ValueChanged;
            // 
            // fishingRodDelayNumeric
            // 
            fishingRodDelayNumeric.Location = new Point(797, 437);
            fishingRodDelayNumeric.Margin = new Padding(4, 3, 4, 3);
            fishingRodDelayNumeric.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            fishingRodDelayNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            fishingRodDelayNumeric.Name = "fishingRodDelayNumeric";
            fishingRodDelayNumeric.Size = new Size(58, 23);
            fishingRodDelayNumeric.TabIndex = 81;
            fishingRodDelayNumeric.TabStop = false;
            fishingRodDelayNumeric.Value = new decimal(new int[] { 2, 0, 0, 0 });
            fishingRodDelayNumeric.ValueChanged += fishingRodDelayNumeric_ValueChanged;
            // 
            // armor3BindButton
            // 
            armor3BindButton.BackColor = Color.Transparent;
            armor3BindButton.FlatStyle = FlatStyle.Flat;
            armor3BindButton.Font = new Font("Microsoft Sans Serif", 8.25F);
            armor3BindButton.ForeColor = Color.FromArgb(162, 162, 162);
            armor3BindButton.Location = new Point(375, 435);
            armor3BindButton.Margin = new Padding(4, 3, 4, 3);
            armor3BindButton.Name = "armor3BindButton";
            armor3BindButton.Size = new Size(80, 27);
            armor3BindButton.TabIndex = 85;
            armor3BindButton.TabStop = false;
            armor3BindButton.UseVisualStyleBackColor = true;
            armor3BindButton.Click += armor3BindButton_Click;
            // 
            // armor2BindButton
            // 
            armor2BindButton.BackColor = Color.Transparent;
            armor2BindButton.FlatStyle = FlatStyle.Flat;
            armor2BindButton.Font = new Font("Microsoft Sans Serif", 8.25F);
            armor2BindButton.ForeColor = Color.FromArgb(162, 162, 162);
            armor2BindButton.Location = new Point(375, 407);
            armor2BindButton.Margin = new Padding(4, 3, 4, 3);
            armor2BindButton.Name = "armor2BindButton";
            armor2BindButton.Size = new Size(80, 27);
            armor2BindButton.TabIndex = 86;
            armor2BindButton.TabStop = false;
            armor2BindButton.UseVisualStyleBackColor = true;
            armor2BindButton.Click += armor2BindButton_Click;
            // 
            // armor1BindButton
            // 
            armor1BindButton.BackColor = Color.Transparent;
            armor1BindButton.FlatStyle = FlatStyle.Flat;
            armor1BindButton.Font = new Font("Microsoft Sans Serif", 8.25F);
            armor1BindButton.ForeColor = Color.FromArgb(162, 162, 162);
            armor1BindButton.Location = new Point(374, 378);
            armor1BindButton.Margin = new Padding(4, 3, 4, 3);
            armor1BindButton.Name = "armor1BindButton";
            armor1BindButton.Size = new Size(80, 27);
            armor1BindButton.TabIndex = 87;
            armor1BindButton.TabStop = false;
            armor1BindButton.UseVisualStyleBackColor = true;
            armor1BindButton.Click += armor1BindButton_Click;
            // 
            // armorStatusButton
            // 
            armorStatusButton.BackColor = Color.Transparent;
            armorStatusButton.FlatStyle = FlatStyle.Flat;
            armorStatusButton.Font = new Font("Microsoft Sans Serif", 8.25F);
            armorStatusButton.ForeColor = Color.FromArgb(68, 68, 68);
            armorStatusButton.Location = new Point(153, 299);
            armorStatusButton.Margin = new Padding(4, 3, 4, 3);
            armorStatusButton.Name = "armorStatusButton";
            armorStatusButton.Size = new Size(145, 27);
            armorStatusButton.TabIndex = 91;
            armorStatusButton.TabStop = false;
            armorStatusButton.UseVisualStyleBackColor = true;
            armorStatusButton.Click += armorStatusButton_Click;
            // 
            // snowballFishingRodStatusButton
            // 
            snowballFishingRodStatusButton.BackColor = Color.Transparent;
            snowballFishingRodStatusButton.FlatStyle = FlatStyle.Flat;
            snowballFishingRodStatusButton.Font = new Font("Microsoft Sans Serif", 8.25F);
            snowballFishingRodStatusButton.ForeColor = Color.FromArgb(68, 68, 68);
            snowballFishingRodStatusButton.Location = new Point(654, 300);
            snowballFishingRodStatusButton.Margin = new Padding(4, 3, 4, 3);
            snowballFishingRodStatusButton.Name = "snowballFishingRodStatusButton";
            snowballFishingRodStatusButton.Size = new Size(145, 27);
            snowballFishingRodStatusButton.TabIndex = 92;
            snowballFishingRodStatusButton.TabStop = false;
            snowballFishingRodStatusButton.UseVisualStyleBackColor = true;
            snowballFishingRodStatusButton.Click += snowballFishingRodStatusButton_Click;
            // 
            // clickerStatusButton
            // 
            clickerStatusButton.BackColor = Color.Transparent;
            clickerStatusButton.FlatStyle = FlatStyle.Flat;
            clickerStatusButton.Font = new Font("Microsoft Sans Serif", 8.25F);
            clickerStatusButton.ForeColor = Color.FromArgb(68, 68, 68);
            clickerStatusButton.Location = new Point(470, 58);
            clickerStatusButton.Margin = new Padding(4, 3, 4, 3);
            clickerStatusButton.Name = "clickerStatusButton";
            clickerStatusButton.Size = new Size(145, 27);
            clickerStatusButton.TabIndex = 93;
            clickerStatusButton.TabStop = false;
            clickerStatusButton.UseVisualStyleBackColor = true;
            clickerStatusButton.Click += clickerStatusButton_Click;
            // 
            // snowballFishingRodStatusPicBox
            // 
            snowballFishingRodStatusPicBox.BackColor = Color.Transparent;
            snowballFishingRodStatusPicBox.BackgroundImage = Properties.Resources.Yes;
            snowballFishingRodStatusPicBox.BackgroundImageLayout = ImageLayout.Stretch;
            snowballFishingRodStatusPicBox.Location = new Point(776, 302);
            snowballFishingRodStatusPicBox.Margin = new Padding(4, 3, 4, 3);
            snowballFishingRodStatusPicBox.Name = "snowballFishingRodStatusPicBox";
            snowballFishingRodStatusPicBox.Size = new Size(23, 23);
            snowballFishingRodStatusPicBox.TabIndex = 88;
            snowballFishingRodStatusPicBox.TabStop = false;
            snowballFishingRodStatusPicBox.Click += snowballFishingRodStatusButton_Click;
            // 
            // armorStatusPicBox
            // 
            armorStatusPicBox.BackColor = Color.Transparent;
            armorStatusPicBox.BackgroundImage = Properties.Resources.Yes;
            armorStatusPicBox.BackgroundImageLayout = ImageLayout.Stretch;
            armorStatusPicBox.Location = new Point(274, 301);
            armorStatusPicBox.Margin = new Padding(4, 3, 4, 3);
            armorStatusPicBox.Name = "armorStatusPicBox";
            armorStatusPicBox.Size = new Size(23, 23);
            armorStatusPicBox.TabIndex = 89;
            armorStatusPicBox.TabStop = false;
            armorStatusPicBox.Click += armorStatusButton_Click;
            // 
            // clickerStatusPicBox
            // 
            clickerStatusPicBox.BackColor = Color.Transparent;
            clickerStatusPicBox.BackgroundImage = Properties.Resources.Yes;
            clickerStatusPicBox.BackgroundImageLayout = ImageLayout.Stretch;
            clickerStatusPicBox.Location = new Point(592, 60);
            clickerStatusPicBox.Margin = new Padding(4, 3, 4, 3);
            clickerStatusPicBox.Name = "clickerStatusPicBox";
            clickerStatusPicBox.Size = new Size(23, 23);
            clickerStatusPicBox.TabIndex = 90;
            clickerStatusPicBox.TabStop = false;
            clickerStatusPicBox.Click += clickerStatusButton_Click;
            // 
            // leftClickerPanel
            // 
            leftClickerPanel.BackColor = Color.Transparent;
            leftClickerPanel.Controls.Add(leftClickerDHRadioButton);
            leftClickerPanel.Controls.Add(leftClickerPCRadioButton);
            leftClickerPanel.Controls.Add(leftClickerOCRadioButton);
            leftClickerPanel.Location = new Point(197, 178);
            leftClickerPanel.Margin = new Padding(4, 3, 4, 3);
            leftClickerPanel.Name = "leftClickerPanel";
            leftClickerPanel.Size = new Size(28, 74);
            leftClickerPanel.TabIndex = 94;
            // 
            // leftClickerDHRadioButton
            // 
            leftClickerDHRadioButton.AutoSize = true;
            leftClickerDHRadioButton.Location = new Point(5, 59);
            leftClickerDHRadioButton.Margin = new Padding(4, 3, 4, 3);
            leftClickerDHRadioButton.Name = "leftClickerDHRadioButton";
            leftClickerDHRadioButton.Size = new Size(14, 13);
            leftClickerDHRadioButton.TabIndex = 2;
            leftClickerDHRadioButton.UseVisualStyleBackColor = true;
            leftClickerDHRadioButton.CheckedChanged += leftClickerDHRadioButton_CheckedChanged;
            // 
            // leftClickerPCRadioButton
            // 
            leftClickerPCRadioButton.AutoSize = true;
            leftClickerPCRadioButton.Location = new Point(5, 31);
            leftClickerPCRadioButton.Margin = new Padding(4, 3, 4, 3);
            leftClickerPCRadioButton.Name = "leftClickerPCRadioButton";
            leftClickerPCRadioButton.Size = new Size(14, 13);
            leftClickerPCRadioButton.TabIndex = 1;
            leftClickerPCRadioButton.UseVisualStyleBackColor = true;
            leftClickerPCRadioButton.CheckedChanged += leftClickerPCRadioButton_CheckedChanged;
            // 
            // leftClickerOCRadioButton
            // 
            leftClickerOCRadioButton.AutoSize = true;
            leftClickerOCRadioButton.Location = new Point(5, 5);
            leftClickerOCRadioButton.Margin = new Padding(4, 3, 4, 3);
            leftClickerOCRadioButton.Name = "leftClickerOCRadioButton";
            leftClickerOCRadioButton.Size = new Size(14, 13);
            leftClickerOCRadioButton.TabIndex = 0;
            leftClickerOCRadioButton.UseVisualStyleBackColor = true;
            leftClickerOCRadioButton.CheckedChanged += leftClickerOCRadioButton_CheckedChanged;
            // 
            // rightClickerPanel
            // 
            rightClickerPanel.BackColor = Color.Transparent;
            rightClickerPanel.Controls.Add(rightClickerDHRadioButton);
            rightClickerPanel.Controls.Add(rightClickerPCRadioButton);
            rightClickerPanel.Controls.Add(rightClickerOCRadioButton);
            rightClickerPanel.Location = new Point(701, 175);
            rightClickerPanel.Margin = new Padding(4, 3, 4, 3);
            rightClickerPanel.Name = "rightClickerPanel";
            rightClickerPanel.Size = new Size(27, 77);
            rightClickerPanel.TabIndex = 95;
            // 
            // rightClickerDHRadioButton
            // 
            rightClickerDHRadioButton.AutoSize = true;
            rightClickerDHRadioButton.Location = new Point(5, 61);
            rightClickerDHRadioButton.Margin = new Padding(4, 3, 4, 3);
            rightClickerDHRadioButton.Name = "rightClickerDHRadioButton";
            rightClickerDHRadioButton.Size = new Size(14, 13);
            rightClickerDHRadioButton.TabIndex = 2;
            rightClickerDHRadioButton.UseVisualStyleBackColor = true;
            rightClickerDHRadioButton.CheckedChanged += rightClickerDHRadioButton_CheckedChanged;
            // 
            // rightClickerPCRadioButton
            // 
            rightClickerPCRadioButton.AutoSize = true;
            rightClickerPCRadioButton.Location = new Point(5, 31);
            rightClickerPCRadioButton.Margin = new Padding(4, 3, 4, 3);
            rightClickerPCRadioButton.Name = "rightClickerPCRadioButton";
            rightClickerPCRadioButton.Size = new Size(14, 13);
            rightClickerPCRadioButton.TabIndex = 1;
            rightClickerPCRadioButton.UseVisualStyleBackColor = true;
            rightClickerPCRadioButton.CheckedChanged += rightClickerPCRadioButton_CheckedChanged;
            // 
            // rightClickerOCRadioButton
            // 
            rightClickerOCRadioButton.AutoSize = true;
            rightClickerOCRadioButton.Location = new Point(5, 5);
            rightClickerOCRadioButton.Margin = new Padding(4, 3, 4, 3);
            rightClickerOCRadioButton.Name = "rightClickerOCRadioButton";
            rightClickerOCRadioButton.Size = new Size(14, 13);
            rightClickerOCRadioButton.TabIndex = 0;
            rightClickerOCRadioButton.UseVisualStyleBackColor = true;
            rightClickerOCRadioButton.CheckedChanged += rightClickerOCRadioButton_CheckedChanged;
            // 
            // PvPForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = Properties.Resources.PvP;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1029, 573);
            Controls.Add(clickerStatusPicBox);
            Controls.Add(rightClickerPanel);
            Controls.Add(leftClickerPanel);
            Controls.Add(armorStatusPicBox);
            Controls.Add(snowballFishingRodStatusPicBox);
            Controls.Add(clickerStatusButton);
            Controls.Add(snowballFishingRodStatusButton);
            Controls.Add(armorStatusButton);
            Controls.Add(armor3BindButton);
            Controls.Add(armor2BindButton);
            Controls.Add(armor1BindButton);
            Controls.Add(snowballOnCheckBox);
            Controls.Add(fishingRodOnCheckBox);
            Controls.Add(snowballDelayNumeric);
            Controls.Add(fishingRodDelayNumeric);
            Controls.Add(fishingRodBindButton);
            Controls.Add(snowballBindButton);
            Controls.Add(armor3OnCheckBox);
            Controls.Add(armor2OnCheckBox);
            Controls.Add(armor1OnCheckBox);
            Controls.Add(armorDelayNumeric);
            Controls.Add(settingsNavButton);
            Controls.Add(leftClickerCpsNumeric);
            Controls.Add(rightClickerCpsNumeric);
            Controls.Add(leftClickerBindButton);
            Controls.Add(rightClickerBindButton);
            Controls.Add(bindsNavButton);
            Controls.Add(othersNavButton);
            Controls.Add(miningNavButton);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = Properties.Resources.Logo;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "PvPForm";
            StartPosition = FormStartPosition.Manual;
            Text = "Smoczy Clicker";
            ((System.ComponentModel.ISupportInitialize)rightClickerCpsNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)leftClickerCpsNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)armorDelayNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)snowballDelayNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)fishingRodDelayNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)snowballFishingRodStatusPicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)armorStatusPicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)clickerStatusPicBox).EndInit();
            leftClickerPanel.ResumeLayout(false);
            leftClickerPanel.PerformLayout();
            rightClickerPanel.ResumeLayout(false);
            rightClickerPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private InvisibleButton miningNavButton;
        private InvisibleButton bindsNavButton;
        private InvisibleButton othersNavButton;
        private InvisibleButton rightClickerBindButton;
        private InvisibleButton leftClickerBindButton;
        private System.Windows.Forms.NumericUpDown rightClickerCpsNumeric;
        private System.Windows.Forms.NumericUpDown leftClickerCpsNumeric;
        private InvisibleButton settingsNavButton;
        private System.Windows.Forms.NumericUpDown armorDelayNumeric;
        private System.Windows.Forms.CheckBox armor3OnCheckBox;
        private System.Windows.Forms.CheckBox armor2OnCheckBox;
        private System.Windows.Forms.CheckBox armor1OnCheckBox;
        private InvisibleButton fishingRodBindButton;
        private InvisibleButton snowballBindButton;
        private System.Windows.Forms.CheckBox snowballOnCheckBox;
        private System.Windows.Forms.CheckBox fishingRodOnCheckBox;
        private System.Windows.Forms.NumericUpDown snowballDelayNumeric;
        private System.Windows.Forms.NumericUpDown fishingRodDelayNumeric;
        private InvisibleButton armor3BindButton;
        private InvisibleButton armor2BindButton;
        private InvisibleButton armor1BindButton;
        private InvisibleButton armorStatusButton;
        private InvisibleButton snowballFishingRodStatusButton;
        private InvisibleButton clickerStatusButton;
        private System.Windows.Forms.PictureBox snowballFishingRodStatusPicBox;
        private System.Windows.Forms.PictureBox armorStatusPicBox;
        private System.Windows.Forms.PictureBox clickerStatusPicBox;
        private System.Windows.Forms.Panel leftClickerPanel;
        private System.Windows.Forms.RadioButton leftClickerPCRadioButton;
        private System.Windows.Forms.RadioButton leftClickerOCRadioButton;
        private System.Windows.Forms.Panel rightClickerPanel;
        private System.Windows.Forms.RadioButton rightClickerPCRadioButton;
        private System.Windows.Forms.RadioButton rightClickerOCRadioButton;
        private System.Windows.Forms.RadioButton leftClickerDHRadioButton;
        private System.Windows.Forms.RadioButton rightClickerDHRadioButton;
    }
}

