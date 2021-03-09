using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = "Лабораторная работа №2";
            Height = 400;
            Width = 600;
            StartPosition = FormStartPosition.CenterScreen;
            KeyPreview = true;
            toolTip1.SetToolTip(button1, "Закрывает окно");
            toolTip1.SetToolTip(button2, "Устанавливает цвет формы на зеленый");
            toolTip1.SetToolTip(button3, "Устанавливает цвет формы на серый");
            toolTip1.SetToolTip(comboBox1,"Устанавливает иконку курсора");
            toolTip1.SetToolTip(comboBox2,"Устанавливает цвет формы");
            toolTip1.SetToolTip(checkBox1,"Запрещяет закрывать окно");
            toolTip1.SetToolTip(checkBox2, "Скрывает кнопку закрыть");
            toolTip1.SetToolTip(checkBox3, "Деактивирует кнопку");
            toolTip1.SetToolTip(checkBox4, "Убирает границы окна");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.X && e.Alt)
                this.Close();

            if (e.KeyCode == Keys.Up)
                this.Location = new Point(this.Location.X, this.Location.Y - 5);
            else if (e.KeyCode == Keys.Down)
                this.Location = new Point(this.Location.X, this.Location.Y + 5);
            else if (e.KeyCode == Keys.Right)
                this.Location = new Point(this.Location.X + 5, this.Location.Y);
            else if (e.KeyCode == Keys.Left)
                this.Location = new Point(this.Location.X - 5, this.Location.Y);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '+')
            {
                this.Width  += 10;
                this.Height += 10;
            }
            else if(e.KeyChar == '-')
            {
                this.Width  -= 10;
                this.Height -= 10;
            }
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Поменять цвет?", "Форма запроса", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question) == DialogResult.Yes) BackColor = Color.Green;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    Cursor = Cursors.Default;
                    break;
                case 1:
                    Cursor = Cursors.Hand;
                    break;
                case 2:
                    Cursor = Cursors.AppStarting;
                    break;
                case 3:
                    Cursor = Cursors.WaitCursor;
                    break;
            }
        }


        private void checkBox2_Click(object sender, EventArgs e)
        {
            button1.Visible = !checkBox2.Checked;
        }

        private void checkBox3_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = !checkBox3.Checked;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox2.SelectedIndex)
            {
                case 0:
                    this.BackColor = Color.White;
                    break;
                case 1:
                    this.BackColor = Color.Red;
                    break;
                case 2:
                    this.BackColor = Color.Green;
                    break;
                case 3:
                    this.BackColor = Color.Blue;
                    break;
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = checkBox1.Checked;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            FormBorderStyle = checkBox4.Checked ? FormBorderStyle.Sizable : FormBorderStyle.None;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
