﻿//библиотеки
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//что я добавил
using System.IO;

namespace Cclearpro
{

    public partial class main : Form
    {

        //переменные

        //формы

        login f1;// 1 форма то есть авторизация

        //для таймеров

        //Time

        int c;//секунды
        int z;//минуты
        int x;//Часы

        public main()
        {
            InitializeComponent();
        }

        //кнопочки
        private void btcloses_Click(object sender, EventArgs e)//для закрытия
        {
            if (Data.closeself == true)
            {
                DialogResult wat = MessageBox.Show("Вы уверены закрыть программу?", "Cclearpro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (wat == DialogResult.Yes)
                {
                    Application.Exit();
                    if (Data.nameform == false)//Странно надо проверить
                    {
                        f1 = new login();
                        f1.Close();
                    }
                }
                else if (wat == DialogResult.No)
                {
                    //Можно что-то сделать.
                    //Например пасхалку :)
                }
            }
            else if (Data.closeself == false)
            {
                Application.Exit();
            }
        }

        private void btminis_Click(object sender, EventArgs e)//чтобы скрыть
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Анимации

        //для закрытия
        private void btcloses_MouseEnter(object sender, EventArgs e)
        {
            if (Data.amin == true)
            {
                btcloses.BackColor = Color.Red;
            }
            else if (Data.amin == false)
            {

            }
        }

        private void btcloses_MouseLeave(object sender, EventArgs e)
        {
            if (Data.amin == true)
            {
                btcloses.BackColor = Color.Gray;
            }
            else if (Data.amin == false)
            {

            }
        }

        //для скрытия формы

        private void btminis_MouseEnter(object sender, EventArgs e)
        {
            if (Data.amin == true)
            {
                btminis.BackColor = Color.Red;
            }
            else if (Data.amin == false)
            {

            }
        }

        private void btminis_MouseLeave(object sender, EventArgs e)
        {
            if (Data.amin == true)
            {
                btminis.BackColor = Color.Gray;
            }
            else if (Data.amin == false)
            {

            }
        }

        //При загруски формы
        private void main_Load(object sender, EventArgs e)
        {
            if (Data.name == "")
            {
                MessageBox.Show("Error: Нет имени", "Cclearpro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                f1 = new login();
                f1.Show();
                this.Close();
            }
            else if (Data.name != "")
            {
                label1.Text = label1.Text + Data.name;
                radioButton2.Checked = true; // Да мне было лень менять настройки)))
            }
        }

        //таймеры

        //чтобы понять сколько времени работает программа

        private void time_Tick(object sender, EventArgs e)
        {

            //время

            c++;
            if (c == 60)
            {
                z++;
                c = 0;
            }
            if (z == 60)
            {
                x++;
                z = 0;
            }
            label4.Text = "Время работы программы: ";
            label4.Text = Convert.ToString(label4.Text + c + ":" + z + ":" + x);

            //инфо

            if (Data.closeself == false)
            {
                if (Data.i == true)
                {
                    label5.Text = "";
                    Data.i = false;
                }
            }
            else if (Data.closeself == true)
            {
                if (Data.i == false)
                {
                    label5.Show();
                    label5.Text = Data.info;
                    Data.i = true;
                }
            }
        }


        //какой-то мусоро
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        //Очистка мусора

        //Для очистки
        private void Clear_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (checkTemp.Checked == true)
                {
                    cleartemp();
                }
                MessageBox.Show("Завершено!", "Cclearpro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (radioButton2.Checked == true)
            {
                try
                {
                    System.Diagnostics.Process.Start("C:\\Windows\\System32\\cleanmgr.exe");
                }
                catch { MessageBox.Show("Error: Нет файла под пути C: Windows System32 cleanmgr.exe или другая проблема", "Clearpro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        //void-ы

        //для очистки

        //temp

        public static void cleartemp()
        {
            try
            {
                //пока нет)
            }
            catch { MessageBox.Show("Error: clear temp", "Cclearpro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        //загрузки

        //пока нет

        //Мусорная корзина

        //пока нет

        //Для проверки нажата ли наш радио?

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                checkTemp.Enabled = true;
                checkcor.Enabled = true;
                checkdonl.Enabled = true;
            }
            else
            {
                checkTemp.Enabled = false;
                checkcor.Enabled = false;
                checkdonl.Enabled = false;
            }
            if (radioButton1.Checked == true)
            {
                checkTemp.Enabled = true;
                checkcor.Enabled = true;
                checkdonl.Enabled = true;
            }
            else
            {
                checkTemp.Enabled = false;
            }
            if (radioButton1.Checked == true)
            {
                checkTemp.Enabled = true;
                checkcor.Enabled = true;
                checkdonl.Enabled = true;
            }
            else
            {
                checkTemp.Enabled = false;
                checkcor.Enabled = false;
                checkdonl.Enabled = false;
            }
        }

        //настройки

        //Когда закрывается прога

        private void checkcloseself_CheckedChanged(object sender, EventArgs e)
        {
            if (checkcloseself.Checked == true)
            {
                Data.closeself = true;
            }
            else if (checkcloseself.Checked == false)
            {
                Data.closeself = false;
            }
        }

        //информация

        private void checkcloseself_MouseEnter(object sender, EventArgs e)
        {
            if (Data.infoself == true)
            {
                label5.Text = Data.info;//Исправляет баг
                label5.Text = label5.Text + "Это чтобы показывалось подвержедение чтобы закрыть прогу";
            }
        }

        private void checkcloseself_MouseLeave(object sender, EventArgs e)
        {
            if (Data.infoself == true)
                label5.Text = Data.info;
        }

        //Анимация

        private void checkamin_CheckedChanged(object sender, EventArgs e)
        {
            if (checkamin.Checked == true)
            {
                Data.amin = true;
            }
            else if (checkamin.Checked == false)
            {
                Data.amin = false;
            }
        }

        //Информация

        private void checkamin_MouseEnter(object sender, EventArgs e)
        {
            if (Data.infoself == true)
            {
                label5.Text = Data.info;//Исправляет баг
                label5.Text = label5.Text + "Это чтобы показывалось анимацию кнопок";
            }
        }

        private void checkamin_MouseLeave(object sender, EventArgs e)
        {
            if (Data.infoself == true)
                label5.Text = Data.info;
        }

        //текст которое показывает ваше имя

        //Информация

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            if (Data.infoself == true)
            {
                label5.Text = Data.info;//Исправляет баг
                label5.Text = label5.Text + "Это чтобы показывалось ваше имя";
            }
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            if (Data.infoself == true)
                label5.Text = Data.info;
        }


        //чтобы инфу показывала

        private void checkinfoleft_CheckedChanged(object sender, EventArgs e)
        {
            if (checkinfoleft.Checked == true)
            {
                Data.infoself = true;
            }
            else if (checkinfoleft.Checked == false)
            {
                Data.closeself = false;
            }
        }
    }
}
