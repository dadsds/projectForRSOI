namespace Printing
{
    partial class Authorization
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.sign_in = new System.Windows.Forms.Button();
            this.PasName = new System.Windows.Forms.Label();
            this.LogName = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sign_in
            // 
            this.sign_in.BackColor = System.Drawing.SystemColors.Control;
            this.sign_in.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sign_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sign_in.Location = new System.Drawing.Point(170, 244);
            this.sign_in.Name = "sign_in";
            this.sign_in.Size = new System.Drawing.Size(176, 77);
            this.sign_in.TabIndex = 11;
            this.sign_in.Text = "Увійти";
            this.sign_in.UseVisualStyleBackColor = false;
            this.sign_in.Click += new System.EventHandler(this.sign_in_Click);
            // 
            // PasName
            // 
            this.PasName.AutoSize = true;
            this.PasName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasName.Location = new System.Drawing.Point(79, 134);
            this.PasName.Name = "PasName";
            this.PasName.Size = new System.Drawing.Size(86, 25);
            this.PasName.TabIndex = 10;
            this.PasName.Text = "Пароль";
            // 
            // LogName
            // 
            this.LogName.AutoSize = true;
            this.LogName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogName.Location = new System.Drawing.Point(79, 36);
            this.LogName.Name = "LogName";
            this.LogName.Size = new System.Drawing.Size(73, 25);
            this.LogName.TabIndex = 9;
            this.LogName.Text = "Логин";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(99, 173);
            this.Password.MaxLength = 20;
            this.Password.Multiline = true;
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(328, 25);
            this.Password.TabIndex = 8;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(99, 73);
            this.Login.MaxLength = 30;
            this.Login.Multiline = true;
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(328, 23);
            this.Login.TabIndex = 7;
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 353);
            this.Controls.Add(this.sign_in);
            this.Controls.Add(this.PasName);
            this.Controls.Add(this.LogName);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Authorization";
            this.Text = "Authorization";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sign_in;
        private System.Windows.Forms.Label PasName;
        private System.Windows.Forms.Label LogName;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Login;
    }
}