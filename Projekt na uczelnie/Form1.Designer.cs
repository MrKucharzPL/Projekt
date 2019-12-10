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
            this.categoryPanel = new System.Windows.Forms.Panel();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.loginButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.loginInfo = new System.Windows.Forms.Label();
            this.loginText = new System.Windows.Forms.TextBox();
            this.loggedPanel = new System.Windows.Forms.Panel();
            this.moneyCountLabel = new System.Windows.Forms.Label();
            this.moneyTextLabel = new System.Windows.Forms.Label();
            this.surNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.registerPanel = new System.Windows.Forms.Panel();
            this.eMessage0 = new System.Windows.Forms.Label();
            this.rRegisterBtn = new System.Windows.Forms.Button();
            this.rSurNameTxt = new System.Windows.Forms.TextBox();
            this.rFirstNameTxt = new System.Windows.Forms.TextBox();
            this.rEmailTxt = new System.Windows.Forms.TextBox();
            this.rRePasswordTxt = new System.Windows.Forms.TextBox();
            this.rPasswordTxt = new System.Windows.Forms.TextBox();
            this.rLoginTxt = new System.Windows.Forms.TextBox();
            this.rSurNameLabel = new System.Windows.Forms.Label();
            this.rFirstNameLabel = new System.Windows.Forms.Label();
            this.rEmailLabel = new System.Windows.Forms.Label();
            this.rRePasswordLabel = new System.Windows.Forms.Label();
            this.rPasswordLabel = new System.Windows.Forms.Label();
            this.rLoginLabel = new System.Windows.Forms.Label();
            this.rTopicLabel = new System.Windows.Forms.Label();
            this.eMessage1 = new System.Windows.Forms.Label();
            this.eMessage2 = new System.Windows.Forms.Label();
            this.eMessage3 = new System.Windows.Forms.Label();
            this.eMessage4 = new System.Windows.Forms.Label();
            this.eMessage5 = new System.Windows.Forms.Label();
            this.categoryPanel.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.loggedPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.registerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoryPanel
            // 
            this.categoryPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.categoryPanel.BackColor = System.Drawing.Color.IndianRed;
            this.categoryPanel.Controls.Add(this.loginPanel);
            this.categoryPanel.Controls.Add(this.loggedPanel);
            this.categoryPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.categoryPanel.Location = new System.Drawing.Point(0, 0);
            this.categoryPanel.Name = "categoryPanel";
            this.categoryPanel.Size = new System.Drawing.Size(288, 681);
            this.categoryPanel.TabIndex = 0;
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.RosyBrown;
            this.loginPanel.Controls.Add(this.loginButton);
            this.loginPanel.Controls.Add(this.registerButton);
            this.loginPanel.Controls.Add(this.passwordLabel);
            this.loginPanel.Controls.Add(this.loginLabel);
            this.loginPanel.Controls.Add(this.passwordText);
            this.loginPanel.Controls.Add(this.loginInfo);
            this.loginPanel.Controls.Add(this.loginText);
            this.loginPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.loginPanel.Location = new System.Drawing.Point(0, 0);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(288, 146);
            this.loginPanel.TabIndex = 0;
            // 
            // loginButton
            // 
            this.loginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.loginButton.BackColor = System.Drawing.Color.Gray;
            this.loginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginButton.Location = new System.Drawing.Point(100, 114);
            this.loginButton.Margin = new System.Windows.Forms.Padding(0);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(188, 32);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Zaloguj";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.registerButton.BackColor = System.Drawing.Color.Gray;
            this.registerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.registerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerButton.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.registerButton.Location = new System.Drawing.Point(0, 114);
            this.registerButton.Margin = new System.Windows.Forms.Padding(0);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(100, 32);
            this.registerButton.TabIndex = 6;
            this.registerButton.Text = "Zarajestruj";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passwordLabel.Location = new System.Drawing.Point(7, 53);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(74, 25);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "HASŁO:";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginLabel.Location = new System.Drawing.Point(7, 16);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(76, 25);
            this.loginLabel.TabIndex = 4;
            this.loginLabel.Text = "LOGIN: ";
            // 
            // passwordText
            // 
            this.passwordText.Font = new System.Drawing.Font("Ebrima", 12F);
            this.passwordText.Location = new System.Drawing.Point(100, 51);
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '*';
            this.passwordText.Size = new System.Drawing.Size(180, 29);
            this.passwordText.TabIndex = 3;
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
            // loginText
            // 
            this.loginText.Font = new System.Drawing.Font("Ebrima", 12F);
            this.loginText.Location = new System.Drawing.Point(100, 12);
            this.loginText.MaxLength = 14;
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(180, 29);
            this.loginText.TabIndex = 1;
            // 
            // loggedPanel
            // 
            this.loggedPanel.BackColor = System.Drawing.Color.RosyBrown;
            this.loggedPanel.Controls.Add(this.moneyCountLabel);
            this.loggedPanel.Controls.Add(this.moneyTextLabel);
            this.loggedPanel.Controls.Add(this.surNameLabel);
            this.loggedPanel.Controls.Add(this.firstNameLabel);
            this.loggedPanel.Location = new System.Drawing.Point(0, 0);
            this.loggedPanel.Name = "loggedPanel";
            this.loggedPanel.Size = new System.Drawing.Size(288, 146);
            this.loggedPanel.TabIndex = 6;
            this.loggedPanel.Visible = false;
            // 
            // moneyCountLabel
            // 
            this.moneyCountLabel.AutoSize = true;
            this.moneyCountLabel.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.moneyCountLabel.Location = new System.Drawing.Point(96, 118);
            this.moneyCountLabel.Name = "moneyCountLabel";
            this.moneyCountLabel.Size = new System.Drawing.Size(19, 21);
            this.moneyCountLabel.TabIndex = 8;
            this.moneyCountLabel.Text = "0";
            // 
            // moneyTextLabel
            // 
            this.moneyTextLabel.AutoSize = true;
            this.moneyTextLabel.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.moneyTextLabel.Location = new System.Drawing.Point(3, 118);
            this.moneyTextLabel.Name = "moneyTextLabel";
            this.moneyTextLabel.Size = new System.Drawing.Size(87, 21);
            this.moneyTextLabel.TabIndex = 7;
            this.moneyTextLabel.Text = "Stan konta:";
            // 
            // surNameLabel
            // 
            this.surNameLabel.AutoSize = true;
            this.surNameLabel.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.surNameLabel.Location = new System.Drawing.Point(3, 32);
            this.surNameLabel.Name = "surNameLabel";
            this.surNameLabel.Size = new System.Drawing.Size(74, 21);
            this.surNameLabel.TabIndex = 6;
            this.surNameLabel.Text = "surName";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.firstNameLabel.Location = new System.Drawing.Point(3, 9);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(79, 21);
            this.firstNameLabel.TabIndex = 5;
            this.firstNameLabel.Text = "firstName";
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.registerPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(288, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(976, 681);
            this.mainPanel.TabIndex = 1;
            // 
            // registerPanel
            // 
            this.registerPanel.Controls.Add(this.eMessage5);
            this.registerPanel.Controls.Add(this.eMessage4);
            this.registerPanel.Controls.Add(this.eMessage3);
            this.registerPanel.Controls.Add(this.eMessage2);
            this.registerPanel.Controls.Add(this.eMessage1);
            this.registerPanel.Controls.Add(this.eMessage0);
            this.registerPanel.Controls.Add(this.rRegisterBtn);
            this.registerPanel.Controls.Add(this.rSurNameTxt);
            this.registerPanel.Controls.Add(this.rFirstNameTxt);
            this.registerPanel.Controls.Add(this.rEmailTxt);
            this.registerPanel.Controls.Add(this.rRePasswordTxt);
            this.registerPanel.Controls.Add(this.rPasswordTxt);
            this.registerPanel.Controls.Add(this.rLoginTxt);
            this.registerPanel.Controls.Add(this.rSurNameLabel);
            this.registerPanel.Controls.Add(this.rFirstNameLabel);
            this.registerPanel.Controls.Add(this.rEmailLabel);
            this.registerPanel.Controls.Add(this.rRePasswordLabel);
            this.registerPanel.Controls.Add(this.rPasswordLabel);
            this.registerPanel.Controls.Add(this.rLoginLabel);
            this.registerPanel.Controls.Add(this.rTopicLabel);
            this.registerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registerPanel.Location = new System.Drawing.Point(0, 0);
            this.registerPanel.Name = "registerPanel";
            this.registerPanel.Size = new System.Drawing.Size(976, 681);
            this.registerPanel.TabIndex = 0;
            this.registerPanel.Visible = false;
            // 
            // eMessage0
            // 
            this.eMessage0.AutoSize = true;
            this.eMessage0.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eMessage0.ForeColor = System.Drawing.Color.Red;
            this.eMessage0.Location = new System.Drawing.Point(530, 143);
            this.eMessage0.Margin = new System.Windows.Forms.Padding(5);
            this.eMessage0.Name = "eMessage0";
            this.eMessage0.Size = new System.Drawing.Size(112, 21);
            this.eMessage0.TabIndex = 20;
            this.eMessage0.Text = "Błędny login!";
            this.eMessage0.Visible = false;
            // 
            // rRegisterBtn
            // 
            this.rRegisterBtn.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rRegisterBtn.Location = new System.Drawing.Point(308, 405);
            this.rRegisterBtn.Name = "rRegisterBtn";
            this.rRegisterBtn.Size = new System.Drawing.Size(214, 39);
            this.rRegisterBtn.TabIndex = 18;
            this.rRegisterBtn.Text = "Zarejestruj się";
            this.rRegisterBtn.UseVisualStyleBackColor = true;
            this.rRegisterBtn.Click += new System.EventHandler(this.rRegisterBtn_Click);
            // 
            // rSurNameTxt
            // 
            this.rSurNameTxt.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rSurNameTxt.Location = new System.Drawing.Point(308, 347);
            this.rSurNameTxt.MaxLength = 14;
            this.rSurNameTxt.Name = "rSurNameTxt";
            this.rSurNameTxt.Size = new System.Drawing.Size(214, 33);
            this.rSurNameTxt.TabIndex = 17;
            // 
            // rFirstNameTxt
            // 
            this.rFirstNameTxt.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rFirstNameTxt.Location = new System.Drawing.Point(308, 305);
            this.rFirstNameTxt.MaxLength = 14;
            this.rFirstNameTxt.Name = "rFirstNameTxt";
            this.rFirstNameTxt.Size = new System.Drawing.Size(214, 33);
            this.rFirstNameTxt.TabIndex = 16;
            // 
            // rEmailTxt
            // 
            this.rEmailTxt.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rEmailTxt.Location = new System.Drawing.Point(308, 263);
            this.rEmailTxt.MaxLength = 14;
            this.rEmailTxt.Name = "rEmailTxt";
            this.rEmailTxt.Size = new System.Drawing.Size(214, 33);
            this.rEmailTxt.TabIndex = 15;
            // 
            // rRePasswordTxt
            // 
            this.rRePasswordTxt.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rRePasswordTxt.Location = new System.Drawing.Point(308, 221);
            this.rRePasswordTxt.MaxLength = 14;
            this.rRePasswordTxt.Name = "rRePasswordTxt";
            this.rRePasswordTxt.Size = new System.Drawing.Size(214, 33);
            this.rRePasswordTxt.TabIndex = 14;
            // 
            // rPasswordTxt
            // 
            this.rPasswordTxt.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rPasswordTxt.Location = new System.Drawing.Point(308, 179);
            this.rPasswordTxt.MaxLength = 14;
            this.rPasswordTxt.Name = "rPasswordTxt";
            this.rPasswordTxt.Size = new System.Drawing.Size(214, 33);
            this.rPasswordTxt.TabIndex = 13;
            // 
            // rLoginTxt
            // 
            this.rLoginTxt.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rLoginTxt.Location = new System.Drawing.Point(308, 137);
            this.rLoginTxt.MaxLength = 14;
            this.rLoginTxt.Name = "rLoginTxt";
            this.rLoginTxt.Size = new System.Drawing.Size(214, 33);
            this.rLoginTxt.TabIndex = 12;
            // 
            // rSurNameLabel
            // 
            this.rSurNameLabel.AutoSize = true;
            this.rSurNameLabel.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rSurNameLabel.Location = new System.Drawing.Point(133, 348);
            this.rSurNameLabel.Margin = new System.Windows.Forms.Padding(5);
            this.rSurNameLabel.Name = "rSurNameLabel";
            this.rSurNameLabel.Size = new System.Drawing.Size(120, 32);
            this.rSurNameLabel.TabIndex = 11;
            this.rSurNameLabel.Text = "Nazwisko:";
            // 
            // rFirstNameLabel
            // 
            this.rFirstNameLabel.AutoSize = true;
            this.rFirstNameLabel.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rFirstNameLabel.Location = new System.Drawing.Point(134, 306);
            this.rFirstNameLabel.Margin = new System.Windows.Forms.Padding(5);
            this.rFirstNameLabel.Name = "rFirstNameLabel";
            this.rFirstNameLabel.Size = new System.Drawing.Size(66, 32);
            this.rFirstNameLabel.TabIndex = 10;
            this.rFirstNameLabel.Text = "Imię:";
            // 
            // rEmailLabel
            // 
            this.rEmailLabel.AutoSize = true;
            this.rEmailLabel.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rEmailLabel.Location = new System.Drawing.Point(133, 264);
            this.rEmailLabel.Margin = new System.Windows.Forms.Padding(5);
            this.rEmailLabel.Name = "rEmailLabel";
            this.rEmailLabel.Size = new System.Drawing.Size(155, 32);
            this.rEmailLabel.TabIndex = 9;
            this.rEmailLabel.Text = "Adres e-mail:";
            // 
            // rRePasswordLabel
            // 
            this.rRePasswordLabel.AutoSize = true;
            this.rRePasswordLabel.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rRePasswordLabel.Location = new System.Drawing.Point(134, 222);
            this.rRePasswordLabel.Margin = new System.Windows.Forms.Padding(5);
            this.rRePasswordLabel.Name = "rRePasswordLabel";
            this.rRePasswordLabel.Size = new System.Drawing.Size(169, 32);
            this.rRePasswordLabel.TabIndex = 8;
            this.rRePasswordLabel.Text = "Powtórz hasło:";
            // 
            // rPasswordLabel
            // 
            this.rPasswordLabel.AutoSize = true;
            this.rPasswordLabel.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rPasswordLabel.Location = new System.Drawing.Point(133, 180);
            this.rPasswordLabel.Margin = new System.Windows.Forms.Padding(5);
            this.rPasswordLabel.Name = "rPasswordLabel";
            this.rPasswordLabel.Size = new System.Drawing.Size(80, 32);
            this.rPasswordLabel.TabIndex = 7;
            this.rPasswordLabel.Text = "Hasło:";
            // 
            // rLoginLabel
            // 
            this.rLoginLabel.AutoSize = true;
            this.rLoginLabel.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rLoginLabel.Location = new System.Drawing.Point(134, 138);
            this.rLoginLabel.Margin = new System.Windows.Forms.Padding(5);
            this.rLoginLabel.Name = "rLoginLabel";
            this.rLoginLabel.Size = new System.Drawing.Size(79, 32);
            this.rLoginLabel.TabIndex = 5;
            this.rLoginLabel.Text = "Login:";
            // 
            // rTopicLabel
            // 
            this.rTopicLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rTopicLabel.AutoSize = true;
            this.rTopicLabel.Font = new System.Drawing.Font("Ebrima", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rTopicLabel.Location = new System.Drawing.Point(297, 9);
            this.rTopicLabel.Name = "rTopicLabel";
            this.rTopicLabel.Size = new System.Drawing.Size(358, 65);
            this.rTopicLabel.TabIndex = 0;
            this.rTopicLabel.Text = "Panel rejestracji";
            // 
            // eMessage1
            // 
            this.eMessage1.AutoSize = true;
            this.eMessage1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eMessage1.ForeColor = System.Drawing.Color.Red;
            this.eMessage1.Location = new System.Drawing.Point(530, 185);
            this.eMessage1.Margin = new System.Windows.Forms.Padding(5);
            this.eMessage1.Name = "eMessage1";
            this.eMessage1.Size = new System.Drawing.Size(113, 21);
            this.eMessage1.TabIndex = 21;
            this.eMessage1.Text = "Błędne hasło!";
            this.eMessage1.Visible = false;
            // 
            // eMessage2
            // 
            this.eMessage2.AutoSize = true;
            this.eMessage2.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eMessage2.ForeColor = System.Drawing.Color.Red;
            this.eMessage2.Location = new System.Drawing.Point(530, 227);
            this.eMessage2.Margin = new System.Windows.Forms.Padding(5);
            this.eMessage2.Name = "eMessage2";
            this.eMessage2.Size = new System.Drawing.Size(113, 21);
            this.eMessage2.TabIndex = 22;
            this.eMessage2.Text = "Błędne hasło!";
            this.eMessage2.Visible = false;
            // 
            // eMessage3
            // 
            this.eMessage3.AutoSize = true;
            this.eMessage3.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eMessage3.ForeColor = System.Drawing.Color.Red;
            this.eMessage3.Location = new System.Drawing.Point(530, 269);
            this.eMessage3.Margin = new System.Windows.Forms.Padding(5);
            this.eMessage3.Name = "eMessage3";
            this.eMessage3.Size = new System.Drawing.Size(166, 21);
            this.eMessage3.TabIndex = 23;
            this.eMessage3.Text = "Błędny adres e-mail!";
            this.eMessage3.Visible = false;
            // 
            // eMessage4
            // 
            this.eMessage4.AutoSize = true;
            this.eMessage4.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eMessage4.ForeColor = System.Drawing.Color.Red;
            this.eMessage4.Location = new System.Drawing.Point(530, 311);
            this.eMessage4.Margin = new System.Windows.Forms.Padding(5);
            this.eMessage4.Name = "eMessage4";
            this.eMessage4.Size = new System.Drawing.Size(106, 21);
            this.eMessage4.TabIndex = 24;
            this.eMessage4.Text = "Błędne Imię!";
            this.eMessage4.Visible = false;
            // 
            // eMessage5
            // 
            this.eMessage5.AutoSize = true;
            this.eMessage5.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eMessage5.ForeColor = System.Drawing.Color.Red;
            this.eMessage5.Location = new System.Drawing.Point(530, 353);
            this.eMessage5.Margin = new System.Windows.Forms.Padding(5);
            this.eMessage5.Name = "eMessage5";
            this.eMessage5.Size = new System.Drawing.Size(143, 21);
            this.eMessage5.TabIndex = 25;
            this.eMessage5.Text = "Błędne nazwisko!";
            this.eMessage5.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.categoryPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.categoryPanel.ResumeLayout(false);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.loggedPanel.ResumeLayout(false);
            this.loggedPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.registerPanel.ResumeLayout(false);
            this.registerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel categoryPanel;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox loginText;
        private System.Windows.Forms.Label loginInfo;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Panel loggedPanel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label surNameLabel;
        private System.Windows.Forms.Label moneyCountLabel;
        private System.Windows.Forms.Label moneyTextLabel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel registerPanel;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.TextBox rSurNameTxt;
        private System.Windows.Forms.TextBox rFirstNameTxt;
        private System.Windows.Forms.TextBox rEmailTxt;
        private System.Windows.Forms.TextBox rRePasswordTxt;
        private System.Windows.Forms.TextBox rPasswordTxt;
        private System.Windows.Forms.TextBox rLoginTxt;
        private System.Windows.Forms.Label rSurNameLabel;
        private System.Windows.Forms.Label rFirstNameLabel;
        private System.Windows.Forms.Label rEmailLabel;
        private System.Windows.Forms.Label rRePasswordLabel;
        private System.Windows.Forms.Label rPasswordLabel;
        private System.Windows.Forms.Label rLoginLabel;
        private System.Windows.Forms.Label rTopicLabel;
        private System.Windows.Forms.Button rRegisterBtn;
        private System.Windows.Forms.Label eMessage0;
        private System.Windows.Forms.Label eMessage5;
        private System.Windows.Forms.Label eMessage4;
        private System.Windows.Forms.Label eMessage3;
        private System.Windows.Forms.Label eMessage2;
        private System.Windows.Forms.Label eMessage1;
    }
}

