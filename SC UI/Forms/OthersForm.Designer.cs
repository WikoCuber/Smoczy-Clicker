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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OthersForm));
            this.miningButton = new SC_UI.FormHelper.InvisibleButton();
            this.bindsButton = new SC_UI.FormHelper.InvisibleButton();
            this.pvpButton = new SC_UI.FormHelper.InvisibleButton();
            this.depositDelayNumeric = new System.Windows.Forms.NumericUpDown();
            this.pickaxe6RadioButton = new System.Windows.Forms.RadioButton();
            this.pickaxe5RadioButton = new System.Windows.Forms.RadioButton();
            this.pickaxe4RadioButton = new System.Windows.Forms.RadioButton();
            this.drawingPositionButton = new System.Windows.Forms.Button();
            this.effectsPositionButton = new System.Windows.Forms.Button();
            this.settingsButton = new SC_UI.FormHelper.InvisibleButton();
            this.voidBindButton = new SC_UI.FormHelper.InvisibleButton();
            this.drawingBindButton = new SC_UI.FormHelper.InvisibleButton();
            this.effectsBindButton = new SC_UI.FormHelper.InvisibleButton();
            this.mathewBindButton = new SC_UI.FormHelper.InvisibleButton();
            this.altingBindButton = new SC_UI.FormHelper.InvisibleButton();
            this.dabingBindButton = new SC_UI.FormHelper.InvisibleButton();
            this.depositBindButton = new SC_UI.FormHelper.InvisibleButton();
            this.voidButton = new SC_UI.FormHelper.InvisibleButton();
            this.dabingButton = new SC_UI.FormHelper.InvisibleButton();
            this.mathewButton = new SC_UI.FormHelper.InvisibleButton();
            this.altingButton = new SC_UI.FormHelper.InvisibleButton();
            this.effectsDrawingButton = new SC_UI.FormHelper.InvisibleButton();
            this.depositButton = new SC_UI.FormHelper.InvisibleButton();
            this.voidPicBox = new System.Windows.Forms.PictureBox();
            this.dabingPicBox = new System.Windows.Forms.PictureBox();
            this.mathewPicBox = new System.Windows.Forms.PictureBox();
            this.altingPicBox = new System.Windows.Forms.PictureBox();
            this.effectsDrawingPicBox = new System.Windows.Forms.PictureBox();
            this.depositPicBox = new System.Windows.Forms.PictureBox();
            this.effectsOnCheckBox = new System.Windows.Forms.CheckBox();
            this.drawingOnCheckBox = new System.Windows.Forms.CheckBox();
            this.dabingType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.depositDelayNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voidPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dabingPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mathewPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.altingPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.effectsDrawingPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // miningButton
            // 
            this.miningButton.BackColor = System.Drawing.Color.Transparent;
            this.miningButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.miningButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.miningButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.miningButton.Location = new System.Drawing.Point(13, 63);
            this.miningButton.Name = "miningButton";
            this.miningButton.Size = new System.Drawing.Size(110, 34);
            this.miningButton.TabIndex = 22;
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
            this.bindsButton.Location = new System.Drawing.Point(13, 146);
            this.bindsButton.Name = "bindsButton";
            this.bindsButton.Size = new System.Drawing.Size(109, 33);
            this.bindsButton.TabIndex = 25;
            this.bindsButton.TabStop = false;
            this.bindsButton.UseVisualStyleBackColor = true;
            this.bindsButton.Click += new System.EventHandler(this.bindsButton_Click);
            // 
            // pvpButton
            // 
            this.pvpButton.BackColor = System.Drawing.Color.Transparent;
            this.pvpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pvpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.pvpButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.pvpButton.Location = new System.Drawing.Point(13, 24);
            this.pvpButton.Name = "pvpButton";
            this.pvpButton.Size = new System.Drawing.Size(110, 32);
            this.pvpButton.TabIndex = 24;
            this.pvpButton.TabStop = false;
            this.pvpButton.UseVisualStyleBackColor = true;
            this.pvpButton.Click += new System.EventHandler(this.pvpButton_Click);
            // 
            // depositDelayNumeric
            // 
            this.depositDelayNumeric.Location = new System.Drawing.Point(258, 147);
            this.depositDelayNumeric.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.depositDelayNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.depositDelayNumeric.Name = "depositDelayNumeric";
            this.depositDelayNumeric.Size = new System.Drawing.Size(50, 20);
            this.depositDelayNumeric.TabIndex = 66;
            this.depositDelayNumeric.TabStop = false;
            this.depositDelayNumeric.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.depositDelayNumeric.ValueChanged += new System.EventHandler(this.depositDelayNumeric_ValueChanged);
            this.depositDelayNumeric.KeyUp += new System.Windows.Forms.KeyEventHandler(this.depositDelayNumeric_KeyUp);
            // 
            // pickaxe6RadioButton
            // 
            this.pickaxe6RadioButton.AutoSize = true;
            this.pickaxe6RadioButton.Location = new System.Drawing.Point(780, 148);
            this.pickaxe6RadioButton.Name = "pickaxe6RadioButton";
            this.pickaxe6RadioButton.Size = new System.Drawing.Size(14, 13);
            this.pickaxe6RadioButton.TabIndex = 68;
            this.pickaxe6RadioButton.UseVisualStyleBackColor = true;
            this.pickaxe6RadioButton.CheckedChanged += new System.EventHandler(this.pickaxe6RadioButton_CheckedChanged);
            // 
            // pickaxe5RadioButton
            // 
            this.pickaxe5RadioButton.AutoSize = true;
            this.pickaxe5RadioButton.Location = new System.Drawing.Point(780, 173);
            this.pickaxe5RadioButton.Name = "pickaxe5RadioButton";
            this.pickaxe5RadioButton.Size = new System.Drawing.Size(14, 13);
            this.pickaxe5RadioButton.TabIndex = 69;
            this.pickaxe5RadioButton.UseVisualStyleBackColor = true;
            this.pickaxe5RadioButton.CheckedChanged += new System.EventHandler(this.pickaxe5RadioButton_CheckedChanged);
            // 
            // pickaxe4RadioButton
            // 
            this.pickaxe4RadioButton.AutoSize = true;
            this.pickaxe4RadioButton.Location = new System.Drawing.Point(780, 195);
            this.pickaxe4RadioButton.Name = "pickaxe4RadioButton";
            this.pickaxe4RadioButton.Size = new System.Drawing.Size(14, 13);
            this.pickaxe4RadioButton.TabIndex = 70;
            this.pickaxe4RadioButton.UseVisualStyleBackColor = true;
            this.pickaxe4RadioButton.CheckedChanged += new System.EventHandler(this.pickaxe4RadioButton_CheckedChanged);
            // 
            // drawingPositionButton
            // 
            this.drawingPositionButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.drawingPositionButton.Location = new System.Drawing.Point(754, 378);
            this.drawingPositionButton.Name = "drawingPositionButton";
            this.drawingPositionButton.Size = new System.Drawing.Size(75, 23);
            this.drawingPositionButton.TabIndex = 76;
            this.drawingPositionButton.TabStop = false;
            this.drawingPositionButton.Text = "button1";
            this.drawingPositionButton.UseVisualStyleBackColor = true;
            this.drawingPositionButton.Click += new System.EventHandler(this.drawing_Click);
            // 
            // effectsPositionButton
            // 
            this.effectsPositionButton.Location = new System.Drawing.Point(754, 331);
            this.effectsPositionButton.Name = "effectsPositionButton";
            this.effectsPositionButton.Size = new System.Drawing.Size(75, 23);
            this.effectsPositionButton.TabIndex = 77;
            this.effectsPositionButton.TabStop = false;
            this.effectsPositionButton.Text = "button1";
            this.effectsPositionButton.UseVisualStyleBackColor = true;
            this.effectsPositionButton.Click += new System.EventHandler(this.effects_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.Transparent;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.settingsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.settingsButton.Location = new System.Drawing.Point(13, 185);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(109, 33);
            this.settingsButton.TabIndex = 80;
            this.settingsButton.TabStop = false;
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // voidBindButton
            // 
            this.voidBindButton.BackColor = System.Drawing.Color.Transparent;
            this.voidBindButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.voidBindButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.voidBindButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(162)))), ((int)(((byte)(162)))));
            this.voidBindButton.Location = new System.Drawing.Point(407, 305);
            this.voidBindButton.Name = "voidBindButton";
            this.voidBindButton.Size = new System.Drawing.Size(69, 25);
            this.voidBindButton.TabIndex = 84;
            this.voidBindButton.TabStop = false;
            this.voidBindButton.Text = "button1";
            this.voidBindButton.UseVisualStyleBackColor = true;
            this.voidBindButton.Click += new System.EventHandler(this.voidBindButton_Click);
            // 
            // drawingBindButton
            // 
            this.drawingBindButton.BackColor = System.Drawing.Color.Transparent;
            this.drawingBindButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drawingBindButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.drawingBindButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(162)))), ((int)(((byte)(162)))));
            this.drawingBindButton.Location = new System.Drawing.Point(787, 353);
            this.drawingBindButton.Name = "drawingBindButton";
            this.drawingBindButton.Size = new System.Drawing.Size(70, 24);
            this.drawingBindButton.TabIndex = 85;
            this.drawingBindButton.TabStop = false;
            this.drawingBindButton.Text = "button1";
            this.drawingBindButton.UseVisualStyleBackColor = true;
            this.drawingBindButton.Click += new System.EventHandler(this.drawingBindButton_Click);
            // 
            // effectsBindButton
            // 
            this.effectsBindButton.BackColor = System.Drawing.Color.Transparent;
            this.effectsBindButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.effectsBindButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.effectsBindButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(162)))), ((int)(((byte)(162)))));
            this.effectsBindButton.Location = new System.Drawing.Point(763, 305);
            this.effectsBindButton.Name = "effectsBindButton";
            this.effectsBindButton.Size = new System.Drawing.Size(72, 24);
            this.effectsBindButton.TabIndex = 86;
            this.effectsBindButton.TabStop = false;
            this.effectsBindButton.Text = "button1";
            this.effectsBindButton.UseVisualStyleBackColor = true;
            this.effectsBindButton.Click += new System.EventHandler(this.effectsBindButton_Click);
            // 
            // mathewBindButton
            // 
            this.mathewBindButton.BackColor = System.Drawing.Color.Transparent;
            this.mathewBindButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mathewBindButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.mathewBindButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(162)))), ((int)(((byte)(162)))));
            this.mathewBindButton.Location = new System.Drawing.Point(809, 95);
            this.mathewBindButton.Name = "mathewBindButton";
            this.mathewBindButton.Size = new System.Drawing.Size(70, 25);
            this.mathewBindButton.TabIndex = 87;
            this.mathewBindButton.TabStop = false;
            this.mathewBindButton.Text = "button1";
            this.mathewBindButton.UseVisualStyleBackColor = true;
            this.mathewBindButton.Click += new System.EventHandler(this.mathewBindButton_Click);
            // 
            // altingBindButton
            // 
            this.altingBindButton.BackColor = System.Drawing.Color.Transparent;
            this.altingBindButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.altingBindButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.altingBindButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(162)))), ((int)(((byte)(162)))));
            this.altingBindButton.Location = new System.Drawing.Point(232, 305);
            this.altingBindButton.Name = "altingBindButton";
            this.altingBindButton.Size = new System.Drawing.Size(70, 25);
            this.altingBindButton.TabIndex = 88;
            this.altingBindButton.TabStop = false;
            this.altingBindButton.Text = "button1";
            this.altingBindButton.UseVisualStyleBackColor = true;
            this.altingBindButton.Click += new System.EventHandler(this.altingBindButton_Click);
            // 
            // dabingBindButton
            // 
            this.dabingBindButton.BackColor = System.Drawing.Color.Transparent;
            this.dabingBindButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dabingBindButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dabingBindButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(162)))), ((int)(((byte)(162)))));
            this.dabingBindButton.Location = new System.Drawing.Point(582, 305);
            this.dabingBindButton.Name = "dabingBindButton";
            this.dabingBindButton.Size = new System.Drawing.Size(70, 25);
            this.dabingBindButton.TabIndex = 89;
            this.dabingBindButton.TabStop = false;
            this.dabingBindButton.Text = "button1";
            this.dabingBindButton.UseVisualStyleBackColor = true;
            this.dabingBindButton.Click += new System.EventHandler(this.dabingBindButton_Click);
            // 
            // depositBindButton
            // 
            this.depositBindButton.BackColor = System.Drawing.Color.Transparent;
            this.depositBindButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.depositBindButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.depositBindButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(162)))), ((int)(((byte)(162)))));
            this.depositBindButton.Location = new System.Drawing.Point(232, 95);
            this.depositBindButton.Name = "depositBindButton";
            this.depositBindButton.Size = new System.Drawing.Size(69, 25);
            this.depositBindButton.TabIndex = 90;
            this.depositBindButton.TabStop = false;
            this.depositBindButton.Text = "button1";
            this.depositBindButton.UseVisualStyleBackColor = true;
            this.depositBindButton.Click += new System.EventHandler(this.depositBindButton_Click);
            // 
            // voidButton
            // 
            this.voidButton.BackColor = System.Drawing.Color.Transparent;
            this.voidButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.voidButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.voidButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.voidButton.Location = new System.Drawing.Point(309, 259);
            this.voidButton.Name = "voidButton";
            this.voidButton.Size = new System.Drawing.Size(125, 23);
            this.voidButton.TabIndex = 105;
            this.voidButton.TabStop = false;
            this.voidButton.UseVisualStyleBackColor = true;
            this.voidButton.Click += new System.EventHandler(this.voidButton_Click);
            // 
            // dabingButton
            // 
            this.dabingButton.BackColor = System.Drawing.Color.Transparent;
            this.dabingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dabingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dabingButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dabingButton.Location = new System.Drawing.Point(483, 258);
            this.dabingButton.Name = "dabingButton";
            this.dabingButton.Size = new System.Drawing.Size(126, 23);
            this.dabingButton.TabIndex = 103;
            this.dabingButton.TabStop = false;
            this.dabingButton.UseVisualStyleBackColor = true;
            this.dabingButton.Click += new System.EventHandler(this.dabingButton_Click);
            // 
            // mathewButton
            // 
            this.mathewButton.BackColor = System.Drawing.Color.Transparent;
            this.mathewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mathewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.mathewButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.mathewButton.Location = new System.Drawing.Point(710, 50);
            this.mathewButton.Name = "mathewButton";
            this.mathewButton.Size = new System.Drawing.Size(125, 23);
            this.mathewButton.TabIndex = 102;
            this.mathewButton.TabStop = false;
            this.mathewButton.UseVisualStyleBackColor = true;
            this.mathewButton.Click += new System.EventHandler(this.mathewButton_Click);
            // 
            // altingButton
            // 
            this.altingButton.BackColor = System.Drawing.Color.Transparent;
            this.altingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.altingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.altingButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.altingButton.Location = new System.Drawing.Point(133, 261);
            this.altingButton.Name = "altingButton";
            this.altingButton.Size = new System.Drawing.Size(127, 23);
            this.altingButton.TabIndex = 101;
            this.altingButton.TabStop = false;
            this.altingButton.UseVisualStyleBackColor = true;
            this.altingButton.Click += new System.EventHandler(this.altingButton_Click);
            // 
            // effectsDrawingButton
            // 
            this.effectsDrawingButton.BackColor = System.Drawing.Color.Transparent;
            this.effectsDrawingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.effectsDrawingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.effectsDrawingButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.effectsDrawingButton.Location = new System.Drawing.Point(657, 258);
            this.effectsDrawingButton.Name = "effectsDrawingButton";
            this.effectsDrawingButton.Size = new System.Drawing.Size(124, 23);
            this.effectsDrawingButton.TabIndex = 100;
            this.effectsDrawingButton.TabStop = false;
            this.effectsDrawingButton.UseVisualStyleBackColor = true;
            this.effectsDrawingButton.Click += new System.EventHandler(this.effectsDrawingButton_Click);
            // 
            // depositButton
            // 
            this.depositButton.BackColor = System.Drawing.Color.Transparent;
            this.depositButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.depositButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.depositButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.depositButton.Location = new System.Drawing.Point(133, 48);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(127, 25);
            this.depositButton.TabIndex = 99;
            this.depositButton.TabStop = false;
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // voidPicBox
            // 
            this.voidPicBox.BackColor = System.Drawing.Color.Transparent;
            this.voidPicBox.BackgroundImage = SC_UI.Properties.Resources.Yes;
            this.voidPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.voidPicBox.Location = new System.Drawing.Point(412, 261);
            this.voidPicBox.Name = "voidPicBox";
            this.voidPicBox.Size = new System.Drawing.Size(20, 20);
            this.voidPicBox.TabIndex = 98;
            this.voidPicBox.TabStop = false;
            // 
            // dabingPicBox
            // 
            this.dabingPicBox.BackColor = System.Drawing.Color.Transparent;
            this.dabingPicBox.BackgroundImage = SC_UI.Properties.Resources.Yes;
            this.dabingPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dabingPicBox.Location = new System.Drawing.Point(589, 261);
            this.dabingPicBox.Name = "dabingPicBox";
            this.dabingPicBox.Size = new System.Drawing.Size(20, 20);
            this.dabingPicBox.TabIndex = 96;
            this.dabingPicBox.TabStop = false;
            // 
            // mathewPicBox
            // 
            this.mathewPicBox.BackColor = System.Drawing.Color.Transparent;
            this.mathewPicBox.BackgroundImage = SC_UI.Properties.Resources.Yes;
            this.mathewPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mathewPicBox.Location = new System.Drawing.Point(815, 53);
            this.mathewPicBox.Name = "mathewPicBox";
            this.mathewPicBox.Size = new System.Drawing.Size(20, 20);
            this.mathewPicBox.TabIndex = 95;
            this.mathewPicBox.TabStop = false;
            // 
            // altingPicBox
            // 
            this.altingPicBox.BackColor = System.Drawing.Color.Transparent;
            this.altingPicBox.BackgroundImage = SC_UI.Properties.Resources.Yes;
            this.altingPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.altingPicBox.Location = new System.Drawing.Point(238, 262);
            this.altingPicBox.Name = "altingPicBox";
            this.altingPicBox.Size = new System.Drawing.Size(20, 20);
            this.altingPicBox.TabIndex = 94;
            this.altingPicBox.TabStop = false;
            // 
            // effectsDrawingPicBox
            // 
            this.effectsDrawingPicBox.BackColor = System.Drawing.Color.Transparent;
            this.effectsDrawingPicBox.BackgroundImage = SC_UI.Properties.Resources.Yes;
            this.effectsDrawingPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.effectsDrawingPicBox.Location = new System.Drawing.Point(761, 261);
            this.effectsDrawingPicBox.Name = "effectsDrawingPicBox";
            this.effectsDrawingPicBox.Size = new System.Drawing.Size(20, 20);
            this.effectsDrawingPicBox.TabIndex = 93;
            this.effectsDrawingPicBox.TabStop = false;
            // 
            // depositPicBox
            // 
            this.depositPicBox.BackColor = System.Drawing.Color.Transparent;
            this.depositPicBox.BackgroundImage = SC_UI.Properties.Resources.Yes;
            this.depositPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.depositPicBox.Location = new System.Drawing.Point(240, 53);
            this.depositPicBox.Name = "depositPicBox";
            this.depositPicBox.Size = new System.Drawing.Size(20, 20);
            this.depositPicBox.TabIndex = 92;
            this.depositPicBox.TabStop = false;
            // 
            // effectsOnCheckBox
            // 
            this.effectsOnCheckBox.AutoSize = true;
            this.effectsOnCheckBox.Location = new System.Drawing.Point(670, 311);
            this.effectsOnCheckBox.Name = "effectsOnCheckBox";
            this.effectsOnCheckBox.Size = new System.Drawing.Size(15, 14);
            this.effectsOnCheckBox.TabIndex = 108;
            this.effectsOnCheckBox.TabStop = false;
            this.effectsOnCheckBox.UseVisualStyleBackColor = true;
            this.effectsOnCheckBox.CheckedChanged += new System.EventHandler(this.effectsOnCheckBox_CheckedChanged);
            // 
            // DrawingOnCheckBox
            // 
            this.drawingOnCheckBox.AutoSize = true;
            this.drawingOnCheckBox.Location = new System.Drawing.Point(670, 356);
            this.drawingOnCheckBox.Name = "DrawingOnCheckBox";
            this.drawingOnCheckBox.Size = new System.Drawing.Size(15, 14);
            this.drawingOnCheckBox.TabIndex = 109;
            this.drawingOnCheckBox.TabStop = false;
            this.drawingOnCheckBox.UseVisualStyleBackColor = true;
            this.drawingOnCheckBox.CheckedChanged += new System.EventHandler(this.drawingOnCheckBox_CheckedChanged);
            // 
            // dabingType
            // 
            this.dabingType.FormattingEnabled = true;
            this.dabingType.Items.AddRange(new object[] {
            "Spam",
            "Trzymanie"});
            this.dabingType.Location = new System.Drawing.Point(542, 353);
            this.dabingType.Name = "dabingType";
            this.dabingType.Size = new System.Drawing.Size(110, 21);
            this.dabingType.TabIndex = 110;
            this.dabingType.SelectedIndexChanged += new System.EventHandler(this.dabingType_SelectedIndexChanged);
            // 
            // OtherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = SC_UI.Properties.Resources.Others;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 497);
            this.Controls.Add(this.dabingType);
            this.Controls.Add(this.drawingOnCheckBox);
            this.Controls.Add(this.effectsOnCheckBox);
            this.Controls.Add(this.voidPicBox);
            this.Controls.Add(this.dabingPicBox);
            this.Controls.Add(this.mathewPicBox);
            this.Controls.Add(this.altingPicBox);
            this.Controls.Add(this.effectsDrawingPicBox);
            this.Controls.Add(this.depositPicBox);
            this.Controls.Add(this.voidButton);
            this.Controls.Add(this.dabingButton);
            this.Controls.Add(this.mathewButton);
            this.Controls.Add(this.altingButton);
            this.Controls.Add(this.effectsDrawingButton);
            this.Controls.Add(this.depositButton);
            this.Controls.Add(this.voidBindButton);
            this.Controls.Add(this.drawingBindButton);
            this.Controls.Add(this.effectsBindButton);
            this.Controls.Add(this.mathewBindButton);
            this.Controls.Add(this.altingBindButton);
            this.Controls.Add(this.dabingBindButton);
            this.Controls.Add(this.depositBindButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.effectsPositionButton);
            this.Controls.Add(this.drawingPositionButton);
            this.Controls.Add(this.pickaxe4RadioButton);
            this.Controls.Add(this.pickaxe5RadioButton);
            this.Controls.Add(this.pickaxe6RadioButton);
            this.Controls.Add(this.depositDelayNumeric);
            this.Controls.Add(this.bindsButton);
            this.Controls.Add(this.pvpButton);
            this.Controls.Add(this.miningButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = SC_UI.Properties.Resources.Logo;
            this.MaximizeBox = false;
            this.Name = "OtherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Smoczy Clicker";
            ((System.ComponentModel.ISupportInitialize)(this.depositDelayNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voidPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dabingPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mathewPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.altingPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.effectsDrawingPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FormHelper.InvisibleButton miningButton;
        private FormHelper.InvisibleButton bindsButton;
        private FormHelper.InvisibleButton pvpButton;
        private System.Windows.Forms.NumericUpDown depositDelayNumeric;
        private System.Windows.Forms.RadioButton pickaxe6RadioButton;
        private System.Windows.Forms.RadioButton pickaxe5RadioButton;
        private System.Windows.Forms.RadioButton pickaxe4RadioButton;
        private System.Windows.Forms.Button drawingPositionButton;
        private System.Windows.Forms.Button effectsPositionButton;
        private FormHelper.InvisibleButton settingsButton;
        private FormHelper.InvisibleButton voidBindButton;
        private FormHelper.InvisibleButton drawingBindButton;
        private FormHelper.InvisibleButton effectsBindButton;
        private FormHelper.InvisibleButton mathewBindButton;
        private FormHelper.InvisibleButton altingBindButton;
        private FormHelper.InvisibleButton dabingBindButton;
        private FormHelper.InvisibleButton depositBindButton;
        private FormHelper.InvisibleButton voidButton;
        private FormHelper.InvisibleButton dabingButton;
        private FormHelper.InvisibleButton mathewButton;
        private FormHelper.InvisibleButton altingButton;
        private FormHelper.InvisibleButton effectsDrawingButton;
        private FormHelper.InvisibleButton depositButton;
        private System.Windows.Forms.PictureBox voidPicBox;
        private System.Windows.Forms.PictureBox dabingPicBox;
        private System.Windows.Forms.PictureBox mathewPicBox;
        private System.Windows.Forms.PictureBox altingPicBox;
        private System.Windows.Forms.PictureBox effectsDrawingPicBox;
        private System.Windows.Forms.PictureBox depositPicBox;
        private System.Windows.Forms.CheckBox effectsOnCheckBox;
        private System.Windows.Forms.CheckBox drawingOnCheckBox;
        private System.Windows.Forms.ComboBox dabingType;
    }
}

