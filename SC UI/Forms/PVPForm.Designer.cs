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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PvPForm));
            this.miningButton = new SC_UI.FormHelper.InvisibleButton();
            this.bindsButton = new SC_UI.FormHelper.InvisibleButton();
            this.othersButton = new SC_UI.FormHelper.InvisibleButton();
            this.rightBindButton = new SC_UI.FormHelper.InvisibleButton();
            this.leftBindButton = new SC_UI.FormHelper.InvisibleButton();
            this.rightCpsNumeric = new System.Windows.Forms.NumericUpDown();
            this.leftCpsNumeric = new System.Windows.Forms.NumericUpDown();
            this.settingsButton = new SC_UI.FormHelper.InvisibleButton();
            this.armorDelayNumeric = new System.Windows.Forms.NumericUpDown();
            this.armor3OnCheckBox = new System.Windows.Forms.CheckBox();
            this.armor2OnCheckBox = new System.Windows.Forms.CheckBox();
            this.armor1OnCheckBox = new System.Windows.Forms.CheckBox();
            this.fishingRodBindButton = new SC_UI.FormHelper.InvisibleButton();
            this.snowballBindButton = new SC_UI.FormHelper.InvisibleButton();
            this.snowballOnCheckBox = new System.Windows.Forms.CheckBox();
            this.fishingRodOnCheckBox = new System.Windows.Forms.CheckBox();
            this.snowballDelayNumeric = new System.Windows.Forms.NumericUpDown();
            this.fishingRodDelayNumeric = new System.Windows.Forms.NumericUpDown();
            this.armor3BindButton = new SC_UI.FormHelper.InvisibleButton();
            this.armor2BindButton = new SC_UI.FormHelper.InvisibleButton();
            this.armor1BindButton = new SC_UI.FormHelper.InvisibleButton();
            this.armorButton = new SC_UI.FormHelper.InvisibleButton();
            this.snowballButton = new SC_UI.FormHelper.InvisibleButton();
            this.macroButton = new SC_UI.FormHelper.InvisibleButton();
            this.snowballPicBox = new System.Windows.Forms.PictureBox();
            this.armorPicBox = new System.Windows.Forms.PictureBox();
            this.macroPicBox = new System.Windows.Forms.PictureBox();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.leftDHRadioButton = new System.Windows.Forms.RadioButton();
            this.leftPCRadioButton = new System.Windows.Forms.RadioButton();
            this.leftOCRadioButton = new System.Windows.Forms.RadioButton();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.rightDHRadioButton = new System.Windows.Forms.RadioButton();
            this.rightPCRadioButton = new System.Windows.Forms.RadioButton();
            this.rightOCRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.rightCpsNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftCpsNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.armorDelayNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snowballDelayNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fishingRodDelayNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snowballPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.armorPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.macroPicBox)).BeginInit();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // miningButton
            // 
            this.miningButton.BackColor = System.Drawing.Color.Transparent;
            this.miningButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.miningButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.miningButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.miningButton.Location = new System.Drawing.Point(12, 64);
            this.miningButton.Name = "miningButton";
            this.miningButton.Size = new System.Drawing.Size(112, 34);
            this.miningButton.TabIndex = 23;
            this.miningButton.TabStop = false;
            this.miningButton.UseVisualStyleBackColor = true;
            this.miningButton.Click += new System.EventHandler(this.miningButton_Click);
            // 
            // bindsButton
            // 
            this.bindsButton.BackColor = System.Drawing.Color.Transparent;
            this.bindsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bindsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bindsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.bindsButton.Location = new System.Drawing.Point(12, 146);
            this.bindsButton.Name = "bindsButton";
            this.bindsButton.Size = new System.Drawing.Size(112, 33);
            this.bindsButton.TabIndex = 26;
            this.bindsButton.TabStop = false;
            this.bindsButton.UseVisualStyleBackColor = true;
            this.bindsButton.Click += new System.EventHandler(this.bindsButton_Click);
            // 
            // othersButton
            // 
            this.othersButton.BackColor = System.Drawing.Color.Transparent;
            this.othersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.othersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.othersButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.othersButton.Location = new System.Drawing.Point(12, 104);
            this.othersButton.Name = "othersButton";
            this.othersButton.Size = new System.Drawing.Size(112, 34);
            this.othersButton.TabIndex = 25;
            this.othersButton.TabStop = false;
            this.othersButton.UseVisualStyleBackColor = true;
            this.othersButton.Click += new System.EventHandler(this.othersButton_Click);
            // 
            // rightBindButton
            // 
            this.rightBindButton.BackColor = System.Drawing.Color.Transparent;
            this.rightBindButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rightBindButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rightBindButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(162)))), ((int)(((byte)(162)))));
            this.rightBindButton.Location = new System.Drawing.Point(661, 80);
            this.rightBindButton.Name = "rightBindButton";
            this.rightBindButton.Size = new System.Drawing.Size(70, 26);
            this.rightBindButton.TabIndex = 27;
            this.rightBindButton.TabStop = false;
            this.rightBindButton.Text = "button1";
            this.rightBindButton.UseVisualStyleBackColor = true;
            this.rightBindButton.Click += new System.EventHandler(this.rightBindButton_Click);
            // 
            // leftBindButton
            // 
            this.leftBindButton.BackColor = System.Drawing.Color.Transparent;
            this.leftBindButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leftBindButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.leftBindButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(162)))), ((int)(((byte)(162)))));
            this.leftBindButton.Location = new System.Drawing.Point(228, 81);
            this.leftBindButton.Name = "leftBindButton";
            this.leftBindButton.Size = new System.Drawing.Size(70, 25);
            this.leftBindButton.TabIndex = 28;
            this.leftBindButton.TabStop = false;
            this.leftBindButton.Text = "button1";
            this.leftBindButton.UseVisualStyleBackColor = true;
            this.leftBindButton.Click += new System.EventHandler(this.leftBindButton_Click);
            // 
            // rightCpsNumeric
            // 
            this.rightCpsNumeric.Location = new System.Drawing.Point(614, 129);
            this.rightCpsNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rightCpsNumeric.Name = "rightCpsNumeric";
            this.rightCpsNumeric.Size = new System.Drawing.Size(50, 20);
            this.rightCpsNumeric.TabIndex = 61;
            this.rightCpsNumeric.TabStop = false;
            this.rightCpsNumeric.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.rightCpsNumeric.ValueChanged += new System.EventHandler(this.rightCpsNumeric_ValueChanged);
            this.rightCpsNumeric.KeyUp += new System.Windows.Forms.KeyEventHandler(this.rightCpsNumeric_KeyUp);
            // 
            // leftCpsNumeric
            // 
            this.leftCpsNumeric.Location = new System.Drawing.Point(181, 128);
            this.leftCpsNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.leftCpsNumeric.Name = "leftCpsNumeric";
            this.leftCpsNumeric.Size = new System.Drawing.Size(50, 20);
            this.leftCpsNumeric.TabIndex = 62;
            this.leftCpsNumeric.TabStop = false;
            this.leftCpsNumeric.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.leftCpsNumeric.ValueChanged += new System.EventHandler(this.leftCpsNumeric_ValueChanged);
            this.leftCpsNumeric.KeyUp += new System.Windows.Forms.KeyEventHandler(this.leftCpsNumeric_KeyUp);
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.Transparent;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.settingsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.settingsButton.Location = new System.Drawing.Point(12, 185);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(112, 33);
            this.settingsButton.TabIndex = 63;
            this.settingsButton.TabStop = false;
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // armorDelayNumeric
            // 
            this.armorDelayNumeric.Location = new System.Drawing.Point(254, 309);
            this.armorDelayNumeric.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.armorDelayNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.armorDelayNumeric.Name = "armorDelayNumeric";
            this.armorDelayNumeric.Size = new System.Drawing.Size(50, 20);
            this.armorDelayNumeric.TabIndex = 68;
            this.armorDelayNumeric.TabStop = false;
            this.armorDelayNumeric.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.armorDelayNumeric.ValueChanged += new System.EventHandler(this.armorDelayNumeric_ValueChanged);
            this.armorDelayNumeric.KeyUp += new System.Windows.Forms.KeyEventHandler(this.armorDelayNumeric_KeyUp);
            // 
            // armor3OnCheckBox
            // 
            this.armor3OnCheckBox.AutoSize = true;
            this.armor3OnCheckBox.Location = new System.Drawing.Point(140, 379);
            this.armor3OnCheckBox.Name = "armor3OnCheckBox";
            this.armor3OnCheckBox.Size = new System.Drawing.Size(15, 14);
            this.armor3OnCheckBox.TabIndex = 78;
            this.armor3OnCheckBox.TabStop = false;
            this.armor3OnCheckBox.UseVisualStyleBackColor = true;
            this.armor3OnCheckBox.CheckedChanged += new System.EventHandler(this.armor3OnCheckBox_CheckedChanged);
            // 
            // armor2OnCheckBox
            // 
            this.armor2OnCheckBox.AutoSize = true;
            this.armor2OnCheckBox.Location = new System.Drawing.Point(140, 357);
            this.armor2OnCheckBox.Name = "armor2OnCheckBox";
            this.armor2OnCheckBox.Size = new System.Drawing.Size(15, 14);
            this.armor2OnCheckBox.TabIndex = 77;
            this.armor2OnCheckBox.TabStop = false;
            this.armor2OnCheckBox.UseVisualStyleBackColor = true;
            this.armor2OnCheckBox.CheckedChanged += new System.EventHandler(this.armor2OnCheckBox_CheckedChanged);
            // 
            // armor1OnCheckBox
            // 
            this.armor1OnCheckBox.AutoSize = true;
            this.armor1OnCheckBox.Location = new System.Drawing.Point(140, 334);
            this.armor1OnCheckBox.Name = "armor1OnCheckBox";
            this.armor1OnCheckBox.Size = new System.Drawing.Size(15, 14);
            this.armor1OnCheckBox.TabIndex = 76;
            this.armor1OnCheckBox.TabStop = false;
            this.armor1OnCheckBox.UseVisualStyleBackColor = true;
            this.armor1OnCheckBox.CheckedChanged += new System.EventHandler(this.armor1OnCheckBox_CheckedChanged);
            // 
            // fishingRodBindButton
            // 
            this.fishingRodBindButton.BackColor = System.Drawing.Color.Transparent;
            this.fishingRodBindButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fishingRodBindButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fishingRodBindButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(162)))), ((int)(((byte)(162)))));
            this.fishingRodBindButton.Location = new System.Drawing.Point(660, 352);
            this.fishingRodBindButton.Name = "fishingRodBindButton";
            this.fishingRodBindButton.Size = new System.Drawing.Size(71, 25);
            this.fishingRodBindButton.TabIndex = 79;
            this.fishingRodBindButton.TabStop = false;
            this.fishingRodBindButton.Text = "button1";
            this.fishingRodBindButton.UseVisualStyleBackColor = true;
            this.fishingRodBindButton.Click += new System.EventHandler(this.fishingRodBindButton_Click);
            // 
            // snowballBindButton
            // 
            this.snowballBindButton.BackColor = System.Drawing.Color.Transparent;
            this.snowballBindButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.snowballBindButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.snowballBindButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(162)))), ((int)(((byte)(162)))));
            this.snowballBindButton.Location = new System.Drawing.Point(668, 305);
            this.snowballBindButton.Name = "snowballBindButton";
            this.snowballBindButton.Size = new System.Drawing.Size(71, 24);
            this.snowballBindButton.TabIndex = 80;
            this.snowballBindButton.TabStop = false;
            this.snowballBindButton.Text = "button1";
            this.snowballBindButton.UseVisualStyleBackColor = true;
            this.snowballBindButton.Click += new System.EventHandler(this.snowballBindButton_Click);
            // 
            // snowballOnCheckBox
            // 
            this.snowballOnCheckBox.AutoSize = true;
            this.snowballOnCheckBox.Location = new System.Drawing.Point(575, 311);
            this.snowballOnCheckBox.Name = "snowballOnCheckBox";
            this.snowballOnCheckBox.Size = new System.Drawing.Size(15, 14);
            this.snowballOnCheckBox.TabIndex = 84;
            this.snowballOnCheckBox.TabStop = false;
            this.snowballOnCheckBox.UseVisualStyleBackColor = true;
            this.snowballOnCheckBox.CheckedChanged += new System.EventHandler(this.snowballOnCheckBox_CheckedChanged);
            // 
            // fishingRodOnCheckBox
            // 
            this.fishingRodOnCheckBox.AutoSize = true;
            this.fishingRodOnCheckBox.Location = new System.Drawing.Point(575, 358);
            this.fishingRodOnCheckBox.Name = "fishingRodOnCheckBox";
            this.fishingRodOnCheckBox.Size = new System.Drawing.Size(15, 14);
            this.fishingRodOnCheckBox.TabIndex = 83;
            this.fishingRodOnCheckBox.TabStop = false;
            this.fishingRodOnCheckBox.UseVisualStyleBackColor = true;
            this.fishingRodOnCheckBox.CheckedChanged += new System.EventHandler(this.fishingRodOnCheckBox_CheckedChanged);
            // 
            // snowballDelayNumeric
            // 
            this.snowballDelayNumeric.Location = new System.Drawing.Point(684, 332);
            this.snowballDelayNumeric.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.snowballDelayNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.snowballDelayNumeric.Name = "snowballDelayNumeric";
            this.snowballDelayNumeric.Size = new System.Drawing.Size(50, 20);
            this.snowballDelayNumeric.TabIndex = 82;
            this.snowballDelayNumeric.TabStop = false;
            this.snowballDelayNumeric.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.snowballDelayNumeric.ValueChanged += new System.EventHandler(this.snowballDelayNumeric_ValueChanged);
            this.snowballDelayNumeric.KeyUp += new System.Windows.Forms.KeyEventHandler(this.snowballDelayNumeric_KeyUp);
            // 
            // fishingRodDelayNumeric
            // 
            this.fishingRodDelayNumeric.Location = new System.Drawing.Point(683, 379);
            this.fishingRodDelayNumeric.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.fishingRodDelayNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fishingRodDelayNumeric.Name = "fishingRodDelayNumeric";
            this.fishingRodDelayNumeric.Size = new System.Drawing.Size(50, 20);
            this.fishingRodDelayNumeric.TabIndex = 81;
            this.fishingRodDelayNumeric.TabStop = false;
            this.fishingRodDelayNumeric.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.fishingRodDelayNumeric.ValueChanged += new System.EventHandler(this.fishingRodDelayNumeric_ValueChanged);
            this.fishingRodDelayNumeric.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fishingRodDelayNumeric_KeyUp);
            // 
            // armor3BindButton
            // 
            this.armor3BindButton.BackColor = System.Drawing.Color.Transparent;
            this.armor3BindButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.armor3BindButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.armor3BindButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(162)))), ((int)(((byte)(162)))));
            this.armor3BindButton.Location = new System.Drawing.Point(321, 376);
            this.armor3BindButton.Name = "armor3BindButton";
            this.armor3BindButton.Size = new System.Drawing.Size(70, 25);
            this.armor3BindButton.TabIndex = 85;
            this.armor3BindButton.TabStop = false;
            this.armor3BindButton.Text = "button1";
            this.armor3BindButton.UseVisualStyleBackColor = true;
            this.armor3BindButton.Click += new System.EventHandler(this.armor3BindButton_Click);
            // 
            // armor2BindButton
            // 
            this.armor2BindButton.BackColor = System.Drawing.Color.Transparent;
            this.armor2BindButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.armor2BindButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.armor2BindButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(162)))), ((int)(((byte)(162)))));
            this.armor2BindButton.Location = new System.Drawing.Point(321, 352);
            this.armor2BindButton.Name = "armor2BindButton";
            this.armor2BindButton.Size = new System.Drawing.Size(71, 24);
            this.armor2BindButton.TabIndex = 86;
            this.armor2BindButton.TabStop = false;
            this.armor2BindButton.Text = "button1";
            this.armor2BindButton.UseVisualStyleBackColor = true;
            this.armor2BindButton.Click += new System.EventHandler(this.armor2BindButton_Click);
            // 
            // armor1BindButton
            // 
            this.armor1BindButton.BackColor = System.Drawing.Color.Transparent;
            this.armor1BindButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.armor1BindButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.armor1BindButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(162)))), ((int)(((byte)(162)))));
            this.armor1BindButton.Location = new System.Drawing.Point(321, 328);
            this.armor1BindButton.Name = "armor1BindButton";
            this.armor1BindButton.Size = new System.Drawing.Size(69, 23);
            this.armor1BindButton.TabIndex = 87;
            this.armor1BindButton.TabStop = false;
            this.armor1BindButton.Text = "button1";
            this.armor1BindButton.UseVisualStyleBackColor = true;
            this.armor1BindButton.Click += new System.EventHandler(this.armor1BindButton_Click);
            // 
            // armorButton
            // 
            this.armorButton.BackColor = System.Drawing.Color.Transparent;
            this.armorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.armorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.armorButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.armorButton.Location = new System.Drawing.Point(131, 259);
            this.armorButton.Name = "armorButton";
            this.armorButton.Size = new System.Drawing.Size(124, 23);
            this.armorButton.TabIndex = 91;
            this.armorButton.TabStop = false;
            this.armorButton.UseVisualStyleBackColor = true;
            this.armorButton.Click += new System.EventHandler(this.armorButton_Click);
            // 
            // snowballButton
            // 
            this.snowballButton.BackColor = System.Drawing.Color.Transparent;
            this.snowballButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.snowballButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.snowballButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.snowballButton.Location = new System.Drawing.Point(561, 259);
            this.snowballButton.Name = "snowballButton";
            this.snowballButton.Size = new System.Drawing.Size(124, 23);
            this.snowballButton.TabIndex = 92;
            this.snowballButton.TabStop = false;
            this.snowballButton.UseVisualStyleBackColor = true;
            this.snowballButton.Click += new System.EventHandler(this.snowballButton_Click);
            // 
            // macroButton
            // 
            this.macroButton.BackColor = System.Drawing.Color.Transparent;
            this.macroButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.macroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.macroButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.macroButton.Location = new System.Drawing.Point(403, 49);
            this.macroButton.Name = "macroButton";
            this.macroButton.Size = new System.Drawing.Size(124, 23);
            this.macroButton.TabIndex = 93;
            this.macroButton.TabStop = false;
            this.macroButton.UseVisualStyleBackColor = true;
            this.macroButton.Click += new System.EventHandler(this.macroButton_Click);
            // 
            // snowballPicBox
            // 
            this.snowballPicBox.BackColor = System.Drawing.Color.Transparent;
            this.snowballPicBox.BackgroundImage = SC_UI.Properties.Resources.Yes;
            this.snowballPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.snowballPicBox.Location = new System.Drawing.Point(665, 262);
            this.snowballPicBox.Name = "snowballPicBox";
            this.snowballPicBox.Size = new System.Drawing.Size(20, 20);
            this.snowballPicBox.TabIndex = 88;
            this.snowballPicBox.TabStop = false;
            // 
            // armorPicBox
            // 
            this.armorPicBox.BackColor = System.Drawing.Color.Transparent;
            this.armorPicBox.BackgroundImage = SC_UI.Properties.Resources.Yes;
            this.armorPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.armorPicBox.Location = new System.Drawing.Point(235, 261);
            this.armorPicBox.Name = "armorPicBox";
            this.armorPicBox.Size = new System.Drawing.Size(20, 20);
            this.armorPicBox.TabIndex = 89;
            this.armorPicBox.TabStop = false;
            // 
            // macroPicBox
            // 
            this.macroPicBox.BackColor = System.Drawing.Color.Transparent;
            this.macroPicBox.BackgroundImage = SC_UI.Properties.Resources.Yes;
            this.macroPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.macroPicBox.Location = new System.Drawing.Point(507, 52);
            this.macroPicBox.Name = "macroPicBox";
            this.macroPicBox.Size = new System.Drawing.Size(20, 20);
            this.macroPicBox.TabIndex = 90;
            this.macroPicBox.TabStop = false;
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.Transparent;
            this.leftPanel.Controls.Add(this.leftDHRadioButton);
            this.leftPanel.Controls.Add(this.leftPCRadioButton);
            this.leftPanel.Controls.Add(this.leftOCRadioButton);
            this.leftPanel.Location = new System.Drawing.Point(169, 154);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(24, 77);
            this.leftPanel.TabIndex = 94;
            // 
            // leftDHRadioButton
            // 
            this.leftDHRadioButton.AutoSize = true;
            this.leftDHRadioButton.Location = new System.Drawing.Point(4, 51);
            this.leftDHRadioButton.Name = "leftDHRadioButton";
            this.leftDHRadioButton.Size = new System.Drawing.Size(14, 13);
            this.leftDHRadioButton.TabIndex = 2;
            this.leftDHRadioButton.TabStop = true;
            this.leftDHRadioButton.UseVisualStyleBackColor = true;
            this.leftDHRadioButton.CheckedChanged += new System.EventHandler(this.leftDHRadioButton_CheckedChanged);
            // 
            // leftPCRadioButton
            // 
            this.leftPCRadioButton.AutoSize = true;
            this.leftPCRadioButton.Location = new System.Drawing.Point(4, 27);
            this.leftPCRadioButton.Name = "leftPCRadioButton";
            this.leftPCRadioButton.Size = new System.Drawing.Size(14, 13);
            this.leftPCRadioButton.TabIndex = 1;
            this.leftPCRadioButton.TabStop = true;
            this.leftPCRadioButton.UseVisualStyleBackColor = true;
            this.leftPCRadioButton.CheckedChanged += new System.EventHandler(this.leftPCRadioButton_CheckedChanged);
            // 
            // leftOCRadioButton
            // 
            this.leftOCRadioButton.AutoSize = true;
            this.leftOCRadioButton.Location = new System.Drawing.Point(4, 4);
            this.leftOCRadioButton.Name = "leftOCRadioButton";
            this.leftOCRadioButton.Size = new System.Drawing.Size(14, 13);
            this.leftOCRadioButton.TabIndex = 0;
            this.leftOCRadioButton.TabStop = true;
            this.leftOCRadioButton.UseVisualStyleBackColor = true;
            this.leftOCRadioButton.CheckedChanged += new System.EventHandler(this.leftOCRadioButton_CheckedChanged);
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.Transparent;
            this.rightPanel.Controls.Add(this.rightDHRadioButton);
            this.rightPanel.Controls.Add(this.rightPCRadioButton);
            this.rightPanel.Controls.Add(this.rightOCRadioButton);
            this.rightPanel.Location = new System.Drawing.Point(601, 152);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(23, 77);
            this.rightPanel.TabIndex = 95;
            // 
            // rightDHRadioButton
            // 
            this.rightDHRadioButton.AutoSize = true;
            this.rightDHRadioButton.Location = new System.Drawing.Point(4, 53);
            this.rightDHRadioButton.Name = "rightDHRadioButton";
            this.rightDHRadioButton.Size = new System.Drawing.Size(14, 13);
            this.rightDHRadioButton.TabIndex = 2;
            this.rightDHRadioButton.TabStop = true;
            this.rightDHRadioButton.UseVisualStyleBackColor = true;
            this.rightDHRadioButton.CheckedChanged += new System.EventHandler(this.rightDHRadioButton_CheckedChanged);
            // 
            // rightPCRadioButton
            // 
            this.rightPCRadioButton.AutoSize = true;
            this.rightPCRadioButton.Location = new System.Drawing.Point(4, 27);
            this.rightPCRadioButton.Name = "rightPCRadioButton";
            this.rightPCRadioButton.Size = new System.Drawing.Size(14, 13);
            this.rightPCRadioButton.TabIndex = 1;
            this.rightPCRadioButton.TabStop = true;
            this.rightPCRadioButton.UseVisualStyleBackColor = true;
            this.rightPCRadioButton.CheckedChanged += new System.EventHandler(this.rightPCRadioButton_CheckedChanged);
            // 
            // rightOCRadioButton
            // 
            this.rightOCRadioButton.AutoSize = true;
            this.rightOCRadioButton.Location = new System.Drawing.Point(4, 4);
            this.rightOCRadioButton.Name = "rightOCRadioButton";
            this.rightOCRadioButton.Size = new System.Drawing.Size(14, 13);
            this.rightOCRadioButton.TabIndex = 0;
            this.rightOCRadioButton.TabStop = true;
            this.rightOCRadioButton.UseVisualStyleBackColor = true;
            this.rightOCRadioButton.CheckedChanged += new System.EventHandler(this.rightOCRadioButton_CheckedChanged);
            // 
            // PVPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = SC_UI.Properties.Resources.PvP;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 497);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.macroPicBox);
            this.Controls.Add(this.armorPicBox);
            this.Controls.Add(this.snowballPicBox);
            this.Controls.Add(this.macroButton);
            this.Controls.Add(this.snowballButton);
            this.Controls.Add(this.armorButton);
            this.Controls.Add(this.armor3BindButton);
            this.Controls.Add(this.armor2BindButton);
            this.Controls.Add(this.armor1BindButton);
            this.Controls.Add(this.snowballOnCheckBox);
            this.Controls.Add(this.fishingRodOnCheckBox);
            this.Controls.Add(this.snowballDelayNumeric);
            this.Controls.Add(this.fishingRodDelayNumeric);
            this.Controls.Add(this.fishingRodBindButton);
            this.Controls.Add(this.snowballBindButton);
            this.Controls.Add(this.armor3OnCheckBox);
            this.Controls.Add(this.armor2OnCheckBox);
            this.Controls.Add(this.armor1OnCheckBox);
            this.Controls.Add(this.armorDelayNumeric);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.leftCpsNumeric);
            this.Controls.Add(this.rightCpsNumeric);
            this.Controls.Add(this.leftBindButton);
            this.Controls.Add(this.rightBindButton);
            this.Controls.Add(this.bindsButton);
            this.Controls.Add(this.othersButton);
            this.Controls.Add(this.miningButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = SC_UI.Properties.Resources.Logo;
            this.MaximizeBox = false;
            this.Name = "PVPForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Smoczy Clicker";
            ((System.ComponentModel.ISupportInitialize)(this.rightCpsNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftCpsNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.armorDelayNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snowballDelayNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fishingRodDelayNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snowballPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.armorPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.macroPicBox)).EndInit();
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FormHelper.InvisibleButton miningButton;
        private FormHelper.InvisibleButton bindsButton;
        private FormHelper.InvisibleButton othersButton;
        private FormHelper.InvisibleButton rightBindButton;
        private FormHelper.InvisibleButton leftBindButton;
        private System.Windows.Forms.NumericUpDown rightCpsNumeric;
        private System.Windows.Forms.NumericUpDown leftCpsNumeric;
        private FormHelper.InvisibleButton settingsButton;
        private System.Windows.Forms.NumericUpDown armorDelayNumeric;
        private System.Windows.Forms.CheckBox armor3OnCheckBox;
        private System.Windows.Forms.CheckBox armor2OnCheckBox;
        private System.Windows.Forms.CheckBox armor1OnCheckBox;
        private FormHelper.InvisibleButton fishingRodBindButton;
        private FormHelper.InvisibleButton snowballBindButton;
        private System.Windows.Forms.CheckBox snowballOnCheckBox;
        private System.Windows.Forms.CheckBox fishingRodOnCheckBox;
        private System.Windows.Forms.NumericUpDown snowballDelayNumeric;
        private System.Windows.Forms.NumericUpDown fishingRodDelayNumeric;
        private FormHelper.InvisibleButton armor3BindButton;
        private FormHelper.InvisibleButton armor2BindButton;
        private FormHelper.InvisibleButton armor1BindButton;
        private FormHelper.InvisibleButton armorButton;
        private FormHelper.InvisibleButton snowballButton;
        private FormHelper.InvisibleButton macroButton;
        private System.Windows.Forms.PictureBox snowballPicBox;
        private System.Windows.Forms.PictureBox armorPicBox;
        private System.Windows.Forms.PictureBox macroPicBox;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.RadioButton leftPCRadioButton;
        private System.Windows.Forms.RadioButton leftOCRadioButton;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.RadioButton rightPCRadioButton;
        private System.Windows.Forms.RadioButton rightOCRadioButton;
        private System.Windows.Forms.RadioButton leftDHRadioButton;
        private System.Windows.Forms.RadioButton rightDHRadioButton;
    }
}

