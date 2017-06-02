using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Printing.Models;
using System.Configuration;
using System.Data.OleDb;

namespace Printing
{
    public partial class Sells : Form
    {
        public Sells()
        {
            InitializeComponent();
        }

        private List<CartItem> shoppingCart = new List<CartItem>();
        private int numberOfItemsPerPage = 0;
        private int numberOfItemsPrintedSoFar = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            ItemNameComboBox.SelectedValueChanged -= ItemNameComboBox_SelectedValueChanged;
            ItemNameComboBox.DataSource = GetProductName();
            ItemNameComboBox.DisplayMember = "ProductName";
            ItemNameComboBox.ValueMember = "ProductPrice";
            ItemNameComboBox.SelectedIndex = -1;
            ItemNameComboBox.SelectedValueChanged += ItemNameComboBox_SelectedValueChanged;
        }

        private DataTable GetProductName()
        {
            DataTable dtProduct = new DataTable();
            string connSrtring = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            using (OleDbConnection con = new OleDbConnection(connSrtring))
            {
                using (OleDbCommand cmd = new OleDbCommand("SELECT ProductName, ProductPrice FROM Products WHERE IsActive = true", con))
                {
                    con.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();
                    dtProduct.Load(reader);

                }
            }
            return dtProduct;
        }

        private void CancelOrderButton_Click(object sender, EventArgs e)//отмена заказа, режим чтения
        {
            NewOrderButton.Enabled = true;
            PrintOrderButton.Enabled = false;
            PrintPreviewButton.Enabled = false;
            CancelOrderButton.Enabled = false;

            ItemGroupBox.Enabled = false;

            ClientNameTextBox.Clear();
            //возврат
            ItemNameComboBox.SelectedIndex = -1;
            QuantityTextBox.Clear();
            UnitPriceTextBox.Clear();

            TotalAmountextBox.Text = "0";
            TotalSalesTexBox.Text = "0";
            TotalToPayBox.Text = "0";

            CartDataGridView.DataSource = null;
            shoppingCart.Clear();
        }

        private void NewOrderButton_Click(object sender, EventArgs e)//добавление нового заказа, режим ввода 
        {
            NewOrderButton.Enabled = false;
            PrintOrderButton.Enabled = true;
            PrintPreviewButton.Enabled = true;
            CancelOrderButton.Enabled = true;

            ItemGroupBox.Enabled = true;

            ClientNameTextBox.Focus();
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (IsValidated())
            {
                CartItem item = new CartItem()
                {
                    ItemName = ItemNameComboBox.Text,
                    Quantity = Convert.ToInt16(QuantityTextBox.Text.Trim()),
                    UnitPrice = Convert.ToDecimal(UnitPriceTextBox.Text.Trim()),
                    TotalPrice = Convert.ToInt16(QuantityTextBox.Text.Trim()) * Convert.ToDecimal(UnitPriceTextBox.Text.Trim())
                };
                // Array, Collection, List, DataTable and DataSet
                shoppingCart.Add(item);
                CartDataGridView.DataSource = null;
                CartDataGridView.DataSource = shoppingCart;

                //Статус общая сумма (в грн.)
                decimal totalAmount = shoppingCart.Sum(x => x.TotalPrice);
                TotalAmountextBox.Text = totalAmount.ToString();

                //Статус ПДВ(12%)
                decimal totalSalesTex = (12 * totalAmount) / 100;
                TotalSalesTexBox.Text = totalSalesTex.ToString();

                //Статус Итог (в грн.)
                decimal totalToPay = totalAmount + totalSalesTex;
                TotalToPayBox.Text = totalToPay.ToString();

                ItemNameComboBox.SelectedIndex = -1;
                QuantityTextBox.Clear();
                UnitPriceTextBox.Clear();


            }
        }

        private bool IsValidated()
        {
            if (ClientNameTextBox.Text.Trim() == string.Empty)//если имя клиента не введено
            {
                MessageBox.Show("Введіть ПІБ касира!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClientNameTextBox.Focus();
                return false;
            }

            if (ItemNameComboBox.SelectedIndex == -1)//если имя товара не введено
            {
                MessageBox.Show("Виберіть товар!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (QuantityTextBox.Text.Trim() == string.Empty)//если количество не введено
            {
                MessageBox.Show("Введіть кількість!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                QuantityTextBox.Focus();
                return false;
            }
            else
            {
                int tempQuantity;
                bool isNumeric = int.TryParse(QuantityTextBox.Text.Trim(), out tempQuantity);// защита от некорректного ввода количества, должно вводиться int значение

                if (!isNumeric)// если не верно int знаечение
                {
                    MessageBox.Show("Кількість повинна бути цілим числом!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    QuantityTextBox.Clear();
                    QuantityTextBox.Focus();
                    return false;
                }
            }

            if (UnitPriceTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Введіть ціну за одиницю товару!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UnitPriceTextBox.Focus();
                return false;
            }
            else
            {
                decimal tempUnitPrice;
                bool isDecimal = decimal.TryParse(UnitPriceTextBox.Text.Trim(), out tempUnitPrice);// защита от некорректного ввода цену за единицу товара, должно вводиться decimal значение

                if (!isDecimal)// если не верно decimal знаечение
                {
                    MessageBox.Show("Ціна повинна бути десяткової!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    UnitPriceTextBox.Clear();
                    UnitPriceTextBox.Focus();
                    return false;
                }
                return true;
            }
        }

        private void CartDataGridView_MouseDown(object sender, MouseEventArgs e)//выбор удаляемой строки
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                var hti = CartDataGridView.HitTest(e.X, e.Y);
                CartDataGridView.Rows[hti.RowIndex].Selected = true;
                contextMenuStrip1.Show(CartDataGridView, e.X, e.Y);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)//удаление
        {
            int index = CartDataGridView.CurrentCell.RowIndex;
            shoppingCart.RemoveAt(index);
            CartDataGridView.DataSource = null;
            CartDataGridView.DataSource = shoppingCart;

            //Статус общая сумма (в грн.)
            decimal totalAmount = shoppingCart.Sum(x => x.TotalPrice);
            TotalAmountextBox.Text = totalAmount.ToString();

            //Статус НДС(18%)
            decimal totalSalesTex = (18 * totalAmount) / 100;
            TotalSalesTexBox.Text = totalSalesTex.ToString();

            //Статус Итог (в грн.)
            decimal totalToPay = totalAmount + totalSalesTex;
            TotalToPayBox.Text = totalToPay.ToString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)//содержание документ
        {
            e.Graphics.DrawString("Касир: " + ClientNameTextBox.Text.Trim(), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(25, 50));
            e.Graphics.DrawString("Дата и время: " + DateTime.Now, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 80));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 100));
            e.Graphics.DrawString("Назва товару", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(30, 120));
            e.Graphics.DrawString("Кількість", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(450, 120));
            e.Graphics.DrawString("Ціна за 1шт.", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(580, 120));
            e.Graphics.DrawString("Підсумок", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(720, 120));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 140));

            int yPos = 165;
            for (int i = numberOfItemsPrintedSoFar; i < shoppingCart.Count; i++)
            {
                numberOfItemsPerPage++;

                if (numberOfItemsPerPage <= 25)
                {
                    numberOfItemsPrintedSoFar++;

                    if (numberOfItemsPrintedSoFar <= shoppingCart.Count)
                    {
                        e.Graphics.DrawString(shoppingCart[i].ItemName, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(30, yPos));
                        e.Graphics.DrawString(shoppingCart[i].Quantity.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(490, yPos));
                        e.Graphics.DrawString(shoppingCart[i].UnitPrice.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(615, yPos));
                        e.Graphics.DrawString(shoppingCart[i].TotalPrice.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(720, yPos));
                        yPos += 30;
                    }
                    else
                    {
                        e.HasMorePages = false;
                    }
                }
                else 
                {
                    numberOfItemsPerPage = 0;
                    e.HasMorePages = true;
                    return;
                }
            }
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, yPos));
            e.Graphics.DrawString("Загальна сума:     " + TotalAmountextBox.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(575, yPos + 30));
            e.Graphics.DrawString("ПДВ 12%:             " + TotalSalesTexBox.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(575, yPos + 60));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, yPos + 90));
            e.Graphics.DrawString("Підсумок:                    " + TotalToPayBox.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(575, yPos + 120));

            //Сброс переменных
            numberOfItemsPerPage = 0;
            numberOfItemsPrintedSoFar = 0;
            
        }

        private void PrintPreviewButton_Click(object sender, EventArgs e)//Попередній перегляд чека
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void PrintOrderButton_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void ItemNameComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            decimal productPrice = Convert.ToDecimal(ItemNameComboBox.SelectedValue);
            UnitPriceTextBox.Text = productPrice.ToString();
        }

        private void CloseSells_Click(object sender, EventArgs e)
        {
            Close();
            Program.FormMenue.Visible = true;
        }
    }
}
