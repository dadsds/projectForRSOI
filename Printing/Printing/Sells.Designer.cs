namespace Printing
{
    partial class Sells
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sells));
            this.ItemGroupBox = new System.Windows.Forms.GroupBox();
            this.AddToCartButton = new System.Windows.Forms.Button();
            this.UnitPriceTextBox = new System.Windows.Forms.TextBox();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.UnitPricelabel = new System.Windows.Forms.Label();
            this.Quantitylabel = new System.Windows.Forms.Label();
            this.ItemNameComboBox = new System.Windows.Forms.ComboBox();
            this.ItemNameLabel = new System.Windows.Forms.Label();
            this.ClientNameTextBox = new System.Windows.Forms.TextBox();
            this.ClientNamelabel = new System.Windows.Forms.Label();
            this.NewOrderButton = new System.Windows.Forms.Button();
            this.PrintOrderButton = new System.Windows.Forms.Button();
            this.PrintPreviewButton = new System.Windows.Forms.Button();
            this.CartDataGridView = new System.Windows.Forms.DataGridView();
            this.CancelOrderButton = new System.Windows.Forms.Button();
            this.TotalAmountextBox = new System.Windows.Forms.TextBox();
            this.TotalAmountlabel = new System.Windows.Forms.Label();
            this.TotalSalesTexBox = new System.Windows.Forms.TextBox();
            this.SalesTexlabel = new System.Windows.Forms.Label();
            this.TotalToPayBox = new System.Windows.Forms.TextBox();
            this.TotalToPaylabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.CloseSells = new System.Windows.Forms.Button();
            this.ItemGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CartDataGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemGroupBox
            // 
            this.ItemGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemGroupBox.Controls.Add(this.AddToCartButton);
            this.ItemGroupBox.Controls.Add(this.UnitPriceTextBox);
            this.ItemGroupBox.Controls.Add(this.QuantityTextBox);
            this.ItemGroupBox.Controls.Add(this.UnitPricelabel);
            this.ItemGroupBox.Controls.Add(this.Quantitylabel);
            this.ItemGroupBox.Controls.Add(this.ItemNameComboBox);
            this.ItemGroupBox.Controls.Add(this.ItemNameLabel);
            this.ItemGroupBox.Controls.Add(this.ClientNameTextBox);
            this.ItemGroupBox.Controls.Add(this.ClientNamelabel);
            this.ItemGroupBox.Enabled = false;
            this.ItemGroupBox.Location = new System.Drawing.Point(16, 18);
            this.ItemGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.ItemGroupBox.Name = "ItemGroupBox";
            this.ItemGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.ItemGroupBox.Size = new System.Drawing.Size(743, 162);
            this.ItemGroupBox.TabIndex = 0;
            this.ItemGroupBox.TabStop = false;
            // 
            // AddToCartButton
            // 
            this.AddToCartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AddToCartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddToCartButton.Location = new System.Drawing.Point(587, 118);
            this.AddToCartButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddToCartButton.Name = "AddToCartButton";
            this.AddToCartButton.Size = new System.Drawing.Size(148, 37);
            this.AddToCartButton.TabIndex = 4;
            this.AddToCartButton.Text = "Додати";
            this.AddToCartButton.UseVisualStyleBackColor = false;
            this.AddToCartButton.Click += new System.EventHandler(this.AddToCartButton_Click);
            // 
            // UnitPriceTextBox
            // 
            this.UnitPriceTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UnitPriceTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UnitPriceTextBox.Location = new System.Drawing.Point(381, 121);
            this.UnitPriceTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.UnitPriceTextBox.Name = "UnitPriceTextBox";
            this.UnitPriceTextBox.ReadOnly = true;
            this.UnitPriceTextBox.Size = new System.Drawing.Size(185, 22);
            this.UnitPriceTextBox.TabIndex = 4;
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Location = new System.Drawing.Point(135, 121);
            this.QuantityTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(104, 22);
            this.QuantityTextBox.TabIndex = 3;
            // 
            // UnitPricelabel
            // 
            this.UnitPricelabel.AutoSize = true;
            this.UnitPricelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UnitPricelabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UnitPricelabel.Location = new System.Drawing.Point(255, 122);
            this.UnitPricelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UnitPricelabel.Name = "UnitPricelabel";
            this.UnitPricelabel.Size = new System.Drawing.Size(113, 20);
            this.UnitPricelabel.TabIndex = 5;
            this.UnitPricelabel.Text = "Ціна за 1шт:";
            // 
            // Quantitylabel
            // 
            this.Quantitylabel.AutoSize = true;
            this.Quantitylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Quantitylabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Quantitylabel.Location = new System.Drawing.Point(8, 122);
            this.Quantitylabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Quantitylabel.Name = "Quantitylabel";
            this.Quantitylabel.Size = new System.Drawing.Size(91, 20);
            this.Quantitylabel.TabIndex = 4;
            this.Quantitylabel.Text = "Кількість:";
            // 
            // ItemNameComboBox
            // 
            this.ItemNameComboBox.FormattingEnabled = true;
            this.ItemNameComboBox.Items.AddRange(new object[] {
            "Сандвич (Классик)",
            "Сандвич (Зингер)",
            "Сандвич (Твистер из тостера)",
            "Сандвич (Боксмастер из тостера)",
            "Сандвич (Биггер)",
            "Сандвич (Ай-Твистер Чиз)",
            "Сандвич (Сандерс)",
            "Сандвич (Твистер Веджи)",
            "Сандвич (Лонгер BBQ)",
            "Сандвич (Ай-Твистер Кентуки BBQ)",
            "Сандвич (Боксмастер Кентукки BBQ)",
            "Сандвич (Твистер Кентукки BBQ)",
            "Сандвич (Чизбургер Кентукки BBQ)",
            "Сандвич (Дабл Чикен Кентуки BBQ)",
            "Курица (1 Ножка)",
            "Курица (2 Ножки)",
            "Курица (3 Ножки)",
            "Курица (3 Стрипса)",
            "Курица (6 Стрипсов)",
            "Курица (9 Стрипсов)",
            "Курица (3 Крыла)",
            "Курица (6 Крыльев)",
            "Курица (9 Крыльев)",
            "Курица (Байтсы малые)",
            "Курица (Байтсы средние)",
            "Курица (Байтсы большие)",
            "Курица (Байтс Терияки)",
            "Курица (острые крылья с соусом Кентукки BBQ)",
            "Баскет (25 крыльев)",
            "Баскет (Дуэт с оригинальными стрипсами)",
            "Баскет (16 острых крыльев)",
            "Баскет (Стар-баскет)",
            "Баскет (Дуэт с острыми стрипсами)",
            "Баскет (Пати баскет с байтс)",
            "Снэк (Баскет фри)",
            "Снэк (Картофель фри стандартный)",
            "Снэк (Картофель фри малый)",
            "Снэк (Баскет Криспи Чипс)",
            "Снэк (Криспи Чипс)",
            "Снэк (Рисбокс теряки)",
            "Десерт (Мороженое \"Летняя фантазия\")",
            "Десерт (Мороженое в рожке \"Летнее\")",
            "Десерт (Ванильный Чизкейк Нью Йорк)",
            "Десерт (Айс Дрим)",
            "Десерт (Хот Пай Дуэт)",
            "Комбо (Обед для самых маленьких)",
            "Комбо (Снэкбокс со стрипсами острыми)",
            "Комбо (Снэкбокс со стрипсами оригинальными)",
            "Комбо (Снэкбокс с ай-твистером чиз)",
            "Комбо (Снэкбокс с ножкой)",
            "Соус (Кетчуп томатный)",
            "Соус (Терияки)",
            "Соус (Барбекю)",
            "Соус (Кисло-сладкий чили)",
            "Соус (Чесночный)",
            "Соус (Сырный оригинальный)",
            "Соус (Кентукки барбекью)"});
            this.ItemNameComboBox.Location = new System.Drawing.Point(185, 75);
            this.ItemNameComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.ItemNameComboBox.Name = "ItemNameComboBox";
            this.ItemNameComboBox.Size = new System.Drawing.Size(477, 24);
            this.ItemNameComboBox.TabIndex = 2;
            this.ItemNameComboBox.SelectedValueChanged += new System.EventHandler(this.ItemNameComboBox_SelectedValueChanged);
            // 
            // ItemNameLabel
            // 
            this.ItemNameLabel.AutoSize = true;
            this.ItemNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ItemNameLabel.Location = new System.Drawing.Point(8, 76);
            this.ItemNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ItemNameLabel.Name = "ItemNameLabel";
            this.ItemNameLabel.Size = new System.Drawing.Size(129, 20);
            this.ItemNameLabel.TabIndex = 2;
            this.ItemNameLabel.Text = "Назва товару:";
            // 
            // ClientNameTextBox
            // 
            this.ClientNameTextBox.Location = new System.Drawing.Point(92, 31);
            this.ClientNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ClientNameTextBox.Name = "ClientNameTextBox";
            this.ClientNameTextBox.Size = new System.Drawing.Size(451, 22);
            this.ClientNameTextBox.TabIndex = 0;
            // 
            // ClientNamelabel
            // 
            this.ClientNamelabel.AutoSize = true;
            this.ClientNamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientNamelabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientNamelabel.Location = new System.Drawing.Point(8, 32);
            this.ClientNamelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ClientNamelabel.Name = "ClientNamelabel";
            this.ClientNamelabel.Size = new System.Drawing.Size(64, 20);
            this.ClientNamelabel.TabIndex = 0;
            this.ClientNamelabel.Text = "Касир:";
            // 
            // NewOrderButton
            // 
            this.NewOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NewOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.NewOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewOrderButton.Location = new System.Drawing.Point(7, 12);
            this.NewOrderButton.Margin = new System.Windows.Forms.Padding(4);
            this.NewOrderButton.Name = "NewOrderButton";
            this.NewOrderButton.Size = new System.Drawing.Size(207, 34);
            this.NewOrderButton.TabIndex = 5;
            this.NewOrderButton.Text = "Нове замовлення";
            this.NewOrderButton.UseVisualStyleBackColor = false;
            this.NewOrderButton.Click += new System.EventHandler(this.NewOrderButton_Click);
            // 
            // PrintOrderButton
            // 
            this.PrintOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PrintOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PrintOrderButton.Enabled = false;
            this.PrintOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrintOrderButton.Location = new System.Drawing.Point(7, 66);
            this.PrintOrderButton.Margin = new System.Windows.Forms.Padding(4);
            this.PrintOrderButton.Name = "PrintOrderButton";
            this.PrintOrderButton.Size = new System.Drawing.Size(207, 36);
            this.PrintOrderButton.TabIndex = 6;
            this.PrintOrderButton.Text = "Роздрукувати чек";
            this.PrintOrderButton.UseVisualStyleBackColor = false;
            this.PrintOrderButton.Click += new System.EventHandler(this.PrintOrderButton_Click);
            // 
            // PrintPreviewButton
            // 
            this.PrintPreviewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PrintPreviewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PrintPreviewButton.Enabled = false;
            this.PrintPreviewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrintPreviewButton.Location = new System.Drawing.Point(7, 12);
            this.PrintPreviewButton.Margin = new System.Windows.Forms.Padding(4);
            this.PrintPreviewButton.Name = "PrintPreviewButton";
            this.PrintPreviewButton.Size = new System.Drawing.Size(207, 53);
            this.PrintPreviewButton.TabIndex = 7;
            this.PrintPreviewButton.Text = "Перегляд чека";
            this.PrintPreviewButton.UseVisualStyleBackColor = false;
            this.PrintPreviewButton.Click += new System.EventHandler(this.PrintPreviewButton_Click);
            // 
            // CartDataGridView
            // 
            this.CartDataGridView.AllowUserToAddRows = false;
            this.CartDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.CartDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CartDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CartDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CartDataGridView.Location = new System.Drawing.Point(16, 188);
            this.CartDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.CartDataGridView.MultiSelect = false;
            this.CartDataGridView.Name = "CartDataGridView";
            this.CartDataGridView.ReadOnly = true;
            this.CartDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CartDataGridView.Size = new System.Drawing.Size(971, 258);
            this.CartDataGridView.TabIndex = 5;
            this.CartDataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CartDataGridView_MouseDown);
            // 
            // CancelOrderButton
            // 
            this.CancelOrderButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CancelOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CancelOrderButton.Enabled = false;
            this.CancelOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelOrderButton.Location = new System.Drawing.Point(388, 464);
            this.CancelOrderButton.Margin = new System.Windows.Forms.Padding(4);
            this.CancelOrderButton.Name = "CancelOrderButton";
            this.CancelOrderButton.Size = new System.Drawing.Size(217, 65);
            this.CancelOrderButton.TabIndex = 8;
            this.CancelOrderButton.Text = "Відміна замовлення";
            this.CancelOrderButton.UseVisualStyleBackColor = false;
            this.CancelOrderButton.Click += new System.EventHandler(this.CancelOrderButton_Click);
            // 
            // TotalAmountextBox
            // 
            this.TotalAmountextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalAmountextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TotalAmountextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TotalAmountextBox.Location = new System.Drawing.Point(869, 454);
            this.TotalAmountextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TotalAmountextBox.Name = "TotalAmountextBox";
            this.TotalAmountextBox.ReadOnly = true;
            this.TotalAmountextBox.Size = new System.Drawing.Size(116, 22);
            this.TotalAmountextBox.TabIndex = 9;
            this.TotalAmountextBox.Text = "0";
            this.TotalAmountextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TotalAmountlabel
            // 
            this.TotalAmountlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalAmountlabel.AutoSize = true;
            this.TotalAmountlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TotalAmountlabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TotalAmountlabel.Location = new System.Drawing.Point(667, 455);
            this.TotalAmountlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalAmountlabel.Name = "TotalAmountlabel";
            this.TotalAmountlabel.Size = new System.Drawing.Size(198, 20);
            this.TotalAmountlabel.TabIndex = 8;
            this.TotalAmountlabel.Text = "Загальна сума (в грн):";
            // 
            // TotalSalesTexBox
            // 
            this.TotalSalesTexBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalSalesTexBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TotalSalesTexBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TotalSalesTexBox.Location = new System.Drawing.Point(869, 486);
            this.TotalSalesTexBox.Margin = new System.Windows.Forms.Padding(4);
            this.TotalSalesTexBox.Name = "TotalSalesTexBox";
            this.TotalSalesTexBox.ReadOnly = true;
            this.TotalSalesTexBox.Size = new System.Drawing.Size(116, 22);
            this.TotalSalesTexBox.TabIndex = 10;
            this.TotalSalesTexBox.Text = "0";
            this.TotalSalesTexBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SalesTexlabel
            // 
            this.SalesTexlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SalesTexlabel.AutoSize = true;
            this.SalesTexlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SalesTexlabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SalesTexlabel.Location = new System.Drawing.Point(760, 487);
            this.SalesTexlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SalesTexlabel.Name = "SalesTexlabel";
            this.SalesTexlabel.Size = new System.Drawing.Size(102, 20);
            this.SalesTexlabel.TabIndex = 10;
            this.SalesTexlabel.Text = "ПДВ (12%):";
            // 
            // TotalToPayBox
            // 
            this.TotalToPayBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalToPayBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TotalToPayBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TotalToPayBox.Location = new System.Drawing.Point(869, 518);
            this.TotalToPayBox.Margin = new System.Windows.Forms.Padding(4);
            this.TotalToPayBox.Name = "TotalToPayBox";
            this.TotalToPayBox.ReadOnly = true;
            this.TotalToPayBox.Size = new System.Drawing.Size(116, 22);
            this.TotalToPayBox.TabIndex = 11;
            this.TotalToPayBox.Text = "0";
            this.TotalToPayBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TotalToPaylabel
            // 
            this.TotalToPaylabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalToPaylabel.AutoSize = true;
            this.TotalToPaylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TotalToPaylabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TotalToPaylabel.Location = new System.Drawing.Point(710, 518);
            this.TotalToPaylabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalToPaylabel.Name = "TotalToPaylabel";
            this.TotalToPaylabel.Size = new System.Drawing.Size(155, 20);
            this.TotalToPaylabel.TabIndex = 12;
            this.TotalToPaylabel.Text = "Підсумок (в грн.):";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(129, 30);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.deleteToolStripMenuItem.Text = "&Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.PrintOrderButton);
            this.groupBox1.Controls.Add(this.PrintPreviewButton);
            this.groupBox1.Location = new System.Drawing.Point(767, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(220, 110);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.NewOrderButton);
            this.groupBox2.Location = new System.Drawing.Point(767, 128);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(220, 53);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // CloseSells
            // 
            this.CloseSells.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CloseSells.Location = new System.Drawing.Point(28, 464);
            this.CloseSells.Name = "CloseSells";
            this.CloseSells.Size = new System.Drawing.Size(109, 83);
            this.CloseSells.TabIndex = 16;
            this.CloseSells.Text = "Меню";
            this.CloseSells.UseVisualStyleBackColor = true;
            this.CloseSells.Click += new System.EventHandler(this.CloseSells_Click);
            // 
            // Sells
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1003, 559);
            this.Controls.Add(this.CloseSells);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TotalToPayBox);
            this.Controls.Add(this.TotalToPaylabel);
            this.Controls.Add(this.TotalSalesTexBox);
            this.Controls.Add(this.SalesTexlabel);
            this.Controls.Add(this.TotalAmountextBox);
            this.Controls.Add(this.TotalAmountlabel);
            this.Controls.Add(this.CancelOrderButton);
            this.Controls.Add(this.CartDataGridView);
            this.Controls.Add(this.ItemGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Sells";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sell";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ItemGroupBox.ResumeLayout(false);
            this.ItemGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CartDataGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ItemGroupBox;
        private System.Windows.Forms.Button AddToCartButton;
        private System.Windows.Forms.TextBox UnitPriceTextBox;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.Label UnitPricelabel;
        private System.Windows.Forms.Label Quantitylabel;
        private System.Windows.Forms.ComboBox ItemNameComboBox;
        private System.Windows.Forms.Label ItemNameLabel;
        private System.Windows.Forms.TextBox ClientNameTextBox;
        private System.Windows.Forms.Label ClientNamelabel;
        private System.Windows.Forms.Button NewOrderButton;
        private System.Windows.Forms.Button PrintOrderButton;
        private System.Windows.Forms.Button PrintPreviewButton;
        private System.Windows.Forms.DataGridView CartDataGridView;
        private System.Windows.Forms.Button CancelOrderButton;
        private System.Windows.Forms.TextBox TotalAmountextBox;
        private System.Windows.Forms.Label TotalAmountlabel;
        private System.Windows.Forms.TextBox TotalSalesTexBox;
        private System.Windows.Forms.Label SalesTexlabel;
        private System.Windows.Forms.TextBox TotalToPayBox;
        private System.Windows.Forms.Label TotalToPaylabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button CloseSells;
    }
}

