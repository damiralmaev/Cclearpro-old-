﻿//библиотеки
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cclearpro
{
    static class Data//Хранит себе переменные чтобы было их удобно перемещать между формами
    {

        //переменные которое сразу работают

        public static string name = "";//кто чтобы хранить имя переменной
        public static bool nameself = false;//проверить если ли имя

        //для очистки

        public static double clearmdodd = 0;//Для просмотра сколько всего очистила прога
        public static double clearmd = 0;//Для просмотра сколько очистила прога
        public static int clearerrortempt = 0;//для просмотра сколько было ошибок при очистки temp
        public static int clearerroradd = 0;//для просмотра сколько всего было ошибок
        public static int clearerrorcor = 0;//для просмотра сколько было ошибок при очистки корзины
        public static int clearerrorcoradd = 0;//для просмотра сколько всего было ошибок

        //Настройки

        public static bool closeself = true;//что выводить сообщение вы уверены что хотите это закрыть
        public static bool amin = true;//Анимация чтобы при навидение кнопки закрыть было красной
        public static bool infoself = true;//параметр показывать инфо?
        public static string colorbed = "DimGray";//цвет заднего цвета

        //Напинималки ;)

        //короче надо написать переменные в сброс

        //Информация

        public static string info = "Что это такое? ";//Исправляет баг

        //разное

        //для рандомное

        public static string namerand = "";

        //нужна перезагруска

        public static bool nameform = false;//проверяет что и как запускать!
    }
}
