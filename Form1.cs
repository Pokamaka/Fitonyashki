using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Фитоняшки
{
    public partial class Form1 : Form
    {
        double weight = 0; //вес
        double height = 0; //рост
        int age = 0; //возраст

        double imt = 0; //ИМТ
        double iw_k = 0; //идеальный вес по формуле Креффа
        double kof = 0; //коэфицент по запястью
        double iw_kup = 0; //идеальный вес по формуле Купера
        double iw_iw = 0; //идефльный вес по фиксированному коэфиценту
        double iw_lor = 0;//идеальный вес по 2-ой формуле Лоренца
        double calories = 0; //калорийность суточного рациона

        double muscul = 0; //мышцы
        double pechen = 0; //печень
        double mozg = 0; //головной мозг
        double heart = 0; //сердце
        double pochki = 0; //почки
        double ost = 0; //остальные органы
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            
            textBox_result.Text = " ";

            weight = Convert.ToDouble(textBox_weight.Text);
            height = Convert.ToDouble(textBox_height.Text);
            age = Convert.ToInt32(textBox_age.Text);
                
            height = height / 100;

            imt = weight / Math.Pow(height, 2);
            imt = Math.Round(imt, 1);

            if (imt < 18.5)
            {
                textBox_result.Text += $"Деффицит {imt}" + Environment.NewLine;
            }
            else if (imt < 25)
            {
                textBox_result.Text += $"Нормально {imt}" + Environment.NewLine;
            }
            else if (imt < 30)
            {
                textBox_result.Text += $"Избытачно {imt}" + Environment.NewLine;
            }
            else if (imt < 35)
            {
                textBox_result.Text += $"Ожирение 1 {imt}" + Environment.NewLine;
            }
            else if (imt < 40)
            {
                textBox_result.Text += $"Ожирение 2 {imt}" + Environment.NewLine;
            }
            else if (imt > 40)
            {
                textBox_result.Text += $"Ожирение 3 {imt}" + Environment.NewLine;
            }



            //Коэфицент для формулы Креффа
            if (this.radioButton_min.Checked == true)
            {
                kof = 0.9;
            }
            if (this.radioButton_middel.Checked == true)
            {
                kof = 1;
            }
            if (this.radioButton_max.Checked == true)
            {
                kof = 1.1;
            }

            //Формула Креффа
            if (height < 1.5)
            {
                iw_k = (height - 95 + (age / 10)) * 0.9 * kof;
            }
            if (height < 1.75)
            {
                iw_k = (height - 100 + (age / 10)) * 0.9 * kof;
            }
            if (height >= 1.75)
            {
                iw_k = (height - 110 + (age / 10)) * 0.9 * kof;              
            }
            textBox_result.Text += $"Ваш идеальный вес по формуле Креффа: {iw_k} кг" + Environment.NewLine;

            //Выбор пола и рассчёты по формулы Купера
            if (radioButton_woman.Checked == true)
            {
                iw_kup = (weight / (height * 100) * 3.5 / 2.54 - 108) * 0.453;
            }
            if (radioButton_man.Checked == true)
            {
                iw_kup = (weight / (height * 100) * 4 / 2.54 - 128) * 0.453;
            }
            textBox_result.Text += $"Ваш идеальный вес по формуле Куппера: {iw_kup} кг" + Environment.NewLine;

            //Расчёт идеального веса по фиксированному коэф
            if (radioButton_min.Checked == true)
            {
                if (age < 18)
                {
                    kof = 315;
                }
                else if (age < 25 && age >= 18)
                {
                    kof = 325;
                }
                else if (age > 40)
                {
                    kof = 335;
                }
            }
            if (radioButton_middel.Checked == true)
            {
                if (age < 18)
                {
                    kof = 325;
                }
                else if (age < 25 && age >= 18)
                {
                    kof = 345;
                }
                else if (age > 40)
                {
                    kof = 360;
                }
            }
            if (radioButton_max.Checked == true)
            {
                if (age < 18)
                {
                    kof = 355;
                }
                else if (age < 25 && age >= 18)
                {
                    kof = 370;
                }
                else if (age > 40)
                {
                    kof = 380;
                }
            }

            iw_iw = ((height * 100) * kof) / 1000;
            textBox_result.Text += $"Ваш идеальный вес: {iw_iw} кг" + Environment.NewLine;

            //идеальный вес по 2-ой формлу Лоренца
            if (age >= 18 && height >= 1.4)
            {
                double cash; //лок для роста в см
                cash = height * 100;
                if (radioButton_man.Checked == true)
                {
                    iw_lor = cash - 100 - ((cash - 150) / 2);
                }
                else if (radioButton_min.Checked == true)
                {
                    iw_lor = cash - 100 - ((cash - 150) / 4);
                }
                iw_lor = Math.Round(iw_lor, 1);
                textBox_result.Text += $"Ваш идеальный вес по 2-ой формуле Лоренца: {iw_lor} кг" + Environment.NewLine;
            }

            //калорийность суточного рациона
            if (radioButton_Sport_min.Checked == true)
            {
                kof = 1.2;
            }
            if (radioButton_sport_middel.Checked == true)
            {
                kof = 1.38;
            }
            if (radioButton_sport_high.Checked == true)
            {
                kof = 1.56;
            }
            if (radioButton_sport_very_high.Checked == true)
            {
                kof = 1.73;
            }
            if (radioButton_sport_super.Checked == true)
            {
                kof = 1.95;
            }
            if (radioButton_woman.Checked == true)
            {
                calories = (655 + (9.6 * weight) + (1.8 * (height * 100)) - (4.7 * age)) * kof;
            }
            if (radioButton_man.Checked == true)
            {
                calories = (66 + (13.7 * weight) + (5 * (height * 100)) - (6.8 * age)) * kof;
            }
            calories = Math.Round(calories, 0);
            textBox_result.Text += $"Ваша суточная потребность колорий: {calories} cl" + Environment.NewLine;

            //распределение калорий по органам
            muscul = calories / 100 * 26;
            pechen = calories / 100 * 26;
            mozg = calories / 100 * 18;
            heart = calories / 100 * 9;
            pochki = calories / 100 * 7;
            ost = calories / 100 * 14;

            textBox_result.Text += $"Для мышц потребуется: {muscul} cl" + Environment.NewLine;
            textBox_result.Text += $"Для печени потребуется: {pechen} cl" + Environment.NewLine;
            textBox_result.Text += $"Для головного мозга потребуется: {mozg} cl" + Environment.NewLine;
            textBox_result.Text += $"Для сердца потребуется: {heart} cl" + Environment.NewLine;
            textBox_result.Text += $"Для почек потребуется: {pochki} cl" + Environment.NewLine;
            textBox_result.Text += $"Для остальных органов потребуется: {ost} cl" + Environment.NewLine;
        }

        //проверка на ввод символов
        private void textBox_weight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textBox_weight.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            e.Handled = true;
            if (e.KeyChar == 27 | e.KeyChar == 8)
            {
                this.textBox_weight.Text = "";
            }
        }

        private void textBox_height_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textBox_height.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            e.Handled = true;
            if (e.KeyChar == 27 | e.KeyChar == 8)
            {
                this.textBox_height.Text = "";
            }
        }

        private void textBox_age_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                return;
            }
            if (e.KeyChar == ',')
            {
                e.Handled = true;
            }
            e.Handled = true;
            if (e.KeyChar == 27 | e.KeyChar == 8)
            {
                this.textBox_age.Text = "";
            }
        }

        //контекстное меню
        private void сброситьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox_weight.Text = " ";
            this.textBox_height.Text = " ";
            this.textBox_age.Text = " ";
            this.textBox_result.Text = " ";
        }

        private void оформлениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void информацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Приложения для фитоняшек \n    PokaSotka Inc. 2019 год", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //активация кнопки при условие что все поля заполнены

        int count = 0; //счётчик полей
        private void textBox_weight_TextChanged(object sender, EventArgs e)
        {
            if (textBox_weight.Text.Length > 0)
            {
                count++;
                if (count == 5)
                {
                    button1.Enabled = true;
                }
            }
        }

        private void textBox_height_TextChanged(object sender, EventArgs e)
        {
            if (textBox_height.Text.Length > 0)
            {
                count++;
                if (count == 5)
                {
                    button1.Enabled = true;
                }
            }
        }

        private void textBox_age_TextChanged(object sender, EventArgs e)
        {
            if (textBox_age.Text.Length > 0) 
            {
                count++;
                if (count == 5)
                {
                    button1.Enabled = true;
                }
            }
        }
    }
}
    

