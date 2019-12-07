namespace Projekt_na_uczelnie
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.loginButton = new System.Windows.Forms.Button();
            this.loginText = new System.Windows.Forms.TextBox();
            this.loginInfo = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.LoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.LoginPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 681);
            this.panel1.TabIndex = 0;
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.RosyBrown;
            this.LoginPanel.Controls.Add(this.passwordText);
            this.LoginPanel.Controls.Add(this.loginInfo);
            this.LoginPanel.Controls.Add(this.loginText);
            this.LoginPanel.Controls.Add(this.loginButton);
            this.LoginPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoginPanel.Location = new System.Drawing.Point(0, 0);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(288, 146);
            this.LoginPanel.TabIndex = 0;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Gray;
            this.loginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loginButton.Location = new System.Drawing.Point(0, 123);
            this.loginButton.Margin = new System.Windows.Forms.Padding(0);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(288, 23);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Zaloguj";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // loginText
            // 
            this.loginText.Location = new System.Drawing.Point(73, 32);
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(100, 20);
            this.loginText.TabIndex = 1;
            this.loginText.TextChanged += new System.EventHandler(this.loginText_TextChanged);
            // 
            // loginInfo
            // 
            this.loginInfo.AutoSize = true;
            this.loginInfo.Location = new System.Drawing.Point(9, 98);
            this.loginInfo.Name = "loginInfo";
            this.loginInfo.Size = new System.Drawing.Size(40, 13);
            this.loginInfo.TabIndex = 2;
            this.loginInfo.Text = "Tu info";
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(73, 71);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(100, 20);
            this.passwordText.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox loginText;
        private System.Windows.Forms.Label loginInfo;
        private System.Windows.Forms.TextBox passwordText;
    }
}

