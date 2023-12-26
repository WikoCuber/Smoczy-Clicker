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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.othersButton = new SC_UI.FormHelper.InvisibleButton();
            this.miningButton = new SC_UI.FormHelper.InvisibleButton();
            this.pvpButton = new SC_UI.FormHelper.InvisibleButton();
            this.bindsButton = new SC_UI.FormHelper.InvisibleButton();
            this.leftButton = new SC_UI.FormHelper.InvisibleButton();
            this.rightButton = new SC_UI.FormHelper.InvisibleButton();
            this.backgroundDelayNumeric = new System.Windows.Forms.NumericUpDown();
            this.commandDelayNumeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundDelayNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandDelayNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // othersButton
            // 
            this.othersButton.BackColor = System.Drawing.Color.Transparent;
            this.othersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.othersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.othersButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.othersButton.Location = new System.Drawing.Point(12, 104);
            this.othersButton.Name = "othersButton";
            this.othersButton.Size = new System.Drawing.Size(111, 34);
            this.othersButton.TabIndex = 62;
            this.othersButton.TabStop = false;
            this.othersButton.UseVisualStyleBackColor = true;
            this.othersButton.Click += new System.EventHandler(this.othersButton_Click);
            // 
            // miningButton
            // 
            this.miningButton.BackColor = System.Drawing.Color.Transparent;
            this.miningButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.miningButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.miningButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.miningButton.Location = new System.Drawing.Point(13, 64);
            this.miningButton.Name = "miningButton";
            this.miningButton.Size = new System.Drawing.Size(111, 34);
            this.miningButton.TabIndex = 61;
            this.miningButton.TabStop = false;
            this.miningButton.UseVisualStyleBackColor = true;
            this.miningButton.Click += new System.EventHandler(this.miningButton_Click);
            // 
            // pvpButton
            // 
            this.pvpButton.BackColor = System.Drawing.Color.Transparent;
            this.pvpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pvpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.pvpButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.pvpButton.Location = new System.Drawing.Point(12, 24);
            this.pvpButton.Name = "pvpButton";
            this.pvpButton.Size = new System.Drawing.Size(111, 34);
            this.pvpButton.TabIndex = 60;
            this.pvpButton.TabStop = false;
            this.pvpButton.UseVisualStyleBackColor = true;
            this.pvpButton.Click += new System.EventHandler(this.pvpButton_Click);
            // 
            // bindsButton
            // 
            this.bindsButton.BackColor = System.Drawing.Color.Transparent;
            this.bindsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bindsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bindsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.bindsButton.Location = new System.Drawing.Point(13, 146);
            this.bindsButton.Name = "bindsButton";
            this.bindsButton.Size = new System.Drawing.Size(111, 33);
            this.bindsButton.TabIndex = 64;
            this.bindsButton.TabStop = false;
            this.bindsButton.UseVisualStyleBackColor = true;
            this.bindsButton.Click += new System.EventHandler(this.bindsButton_Click);
            // 
            // leftButton
            // 
            this.leftButton.BackColor = System.Drawing.Color.Transparent;
            this.leftButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.leftButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(162)))), ((int)(((byte)(162)))));
            this.leftButton.Location = new System.Drawing.Point(535, 22);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(72, 27);
            this.leftButton.TabIndex = 65;
            this.leftButton.TabStop = false;
            this.leftButton.Text = "button1";
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.BackColor = System.Drawing.Color.Transparent;
            this.rightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rightButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(162)))), ((int)(((byte)(162)))));
            this.rightButton.Location = new System.Drawing.Point(540, 49);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(72, 24);
            this.rightButton.TabIndex = 66;
            this.rightButton.TabStop = false;
            this.rightButton.Text = "button1";
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // backgroundDelayNumeric
            // 
            this.backgroundDelayNumeric.Location = new System.Drawing.Point(293, 72);
            this.backgroundDelayNumeric.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.backgroundDelayNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.backgroundDelayNumeric.Name = "backgroundDelayNumeric";
            this.backgroundDelayNumeric.Size = new System.Drawing.Size(50, 20);
            this.backgroundDelayNumeric.TabIndex = 80;
            this.backgroundDelayNumeric.TabStop = false;
            this.backgroundDelayNumeric.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.backgroundDelayNumeric.ValueChanged += new System.EventHandler(this.backgroundDelayNumeric_ValueChanged);
            this.backgroundDelayNumeric.KeyUp += new System.Windows.Forms.KeyEventHandler(this.backgroundDelayNumeric_KeyUp);
            // 
            // commandDelayNumeric
            // 
            this.commandDelayNumeric.Location = new System.Drawing.Point(352, 96);
            this.commandDelayNumeric.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.commandDelayNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.commandDelayNumeric.Name = "commandDelayNumeric";
            this.commandDelayNumeric.Size = new System.Drawing.Size(50, 20);
            this.commandDelayNumeric.TabIndex = 81;
            this.commandDelayNumeric.TabStop = false;
            this.commandDelayNumeric.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.commandDelayNumeric.ValueChanged += new System.EventHandler(this.commandDelayNumeric_ValueChanged);
            this.commandDelayNumeric.KeyUp += new System.Windows.Forms.KeyEventHandler(this.commandDelayNumeric_KeyUp);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = SC_UI.Properties.Resources.Settings;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 497);
            this.Controls.Add(this.commandDelayNumeric);
            this.Controls.Add(this.backgroundDelayNumeric);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.leftButton);
            this.Controls.Add(this.bindsButton);
            this.Controls.Add(this.othersButton);
            this.Controls.Add(this.miningButton);
            this.Controls.Add(this.pvpButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = SC_UI.Properties.Resources.Logo;
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Smoczy Clicker";
            ((System.ComponentModel.ISupportInitialize)(this.backgroundDelayNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandDelayNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FormHelper.InvisibleButton othersButton;
        private FormHelper.InvisibleButton miningButton;
        private FormHelper.InvisibleButton pvpButton;
        private FormHelper.InvisibleButton bindsButton;
        private FormHelper.InvisibleButton leftButton;
        private FormHelper.InvisibleButton rightButton;
        private System.Windows.Forms.NumericUpDown backgroundDelayNumeric;
        private System.Windows.Forms.NumericUpDown commandDelayNumeric;
    }
}

