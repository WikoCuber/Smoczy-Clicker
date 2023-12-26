namespace SC_UI.Forms
{
    partial class MainForm
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
            mainPanel = new Panel();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.Black;
            mainPanel.Location = new Point(-1, -2);
            mainPanel.Margin = new Padding(4, 3, 4, 3);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1049, 594);
            mainPanel.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1028, 571);
            Controls.Add(mainPanel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = Properties.Resources.Logo;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.Manual;
            Text = "Smoczy Clicker";
            FormClosed += MainForm_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
    }
}

