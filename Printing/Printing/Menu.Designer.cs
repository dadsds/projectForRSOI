namespace Printing
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.ExitFromAccount = new System.Windows.Forms.Button();
            this.See = new System.Windows.Forms.Button();
            this.Sells = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExitFromAccount
            // 
            this.ExitFromAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitFromAccount.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitFromAccount.Location = new System.Drawing.Point(62, 210);
            this.ExitFromAccount.Name = "ExitFromAccount";
            this.ExitFromAccount.Size = new System.Drawing.Size(314, 65);
            this.ExitFromAccount.TabIndex = 7;
            this.ExitFromAccount.Text = "Вийти з профілю";
            this.ExitFromAccount.UseVisualStyleBackColor = true;
            this.ExitFromAccount.Click += new System.EventHandler(this.ExitFromAccount_Click);
            // 
            // See
            // 
            this.See.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.See.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.See.Location = new System.Drawing.Point(62, 122);
            this.See.Name = "See";
            this.See.Size = new System.Drawing.Size(314, 67);
            this.See.TabIndex = 6;
            this.See.Text = "Списки товарів";
            this.See.UseVisualStyleBackColor = true;
            this.See.Click += new System.EventHandler(this.See_Click);
            // 
            // Sells
            // 
            this.Sells.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sells.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sells.Location = new System.Drawing.Point(62, 39);
            this.Sells.Name = "Sells";
            this.Sells.Size = new System.Drawing.Size(314, 62);
            this.Sells.TabIndex = 5;
            this.Sells.Text = "Продажа товара";
            this.Sells.UseVisualStyleBackColor = true;
            this.Sells.Click += new System.EventHandler(this.Sells_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 327);
            this.Controls.Add(this.ExitFromAccount);
            this.Controls.Add(this.See);
            this.Controls.Add(this.Sells);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitFromAccount;
        private System.Windows.Forms.Button See;
        private System.Windows.Forms.Button Sells;
    }
}