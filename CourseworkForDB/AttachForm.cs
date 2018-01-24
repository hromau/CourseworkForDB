using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseworkForDB
{
    public partial class AttachForm : Form
    {
        public static string textBox { get; set; }
        public static List<string> comboBoxList { get; set; }
        public static bool c = false;

        public AttachForm()
        {
            InitializeComponent();
        }
        
        public AttachForm(string thisTableName)
        {        
            InitializeComponent();


            switch (thisTableName)
            {
                case "Contract":
                    {
                        richTextBox1.Text = "Введите Id писателя";
                        break;
                    }
                case "Writer":
                    {
                        richTextBox1.Text = "Введите Id контракта";
                        comboBox1.Text = "Кликните на книги автора";
                        foreach (var t in Program.model.Books)
                            comboBox1.Items.Add(t.Name);
                        break;
                    }
                case "Books":
                    {
                        richTextBox1.Text = "Введите фамилию автора";
                        comboBox1.Text = "Кликните на Id заказа";
                        foreach (var t in Program.model.Orders)
                            comboBox1.Items.Add(t.Id);
                        break;
                    }
                case "Orders":
                    {
                        richTextBox1.Text = "Введите название книги";
                        comboBox1.Text = "Кликните на заказчика";
                        foreach (var t in Program.model.Customers)
                            comboBox1.Items.Add(t.CustomerName);
                        break;
                    }
                case "Customers":
                    {
                        comboBox1.Text = "Кликните Id заказа";
                        foreach (var t in Program.model.Orders)
                            comboBox1.Items.Add(t.Id);
                        break;
                    }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c = true;
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxList.Add(comboBox1.SelectedItem.ToString());
        }
    }
}
