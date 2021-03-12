using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Task6.Classes
{

    public class ColorConfig
    {
        /* Цвета  */
        public Color ApplicationBackground;
        public Color ApplicationForeground;
        public Color TextForeground;
        public Color ListBackground;
        public Color ListForeground;
        public Color ButtonBackground;
        public Color ButtonForeground;
        public Color MenuBackground;
        public Color MenuForeground;

        //конструктор без параметров отвечающий за установку значений "по умолчанию"
        public ColorConfig()
        {
            #region Цвет формы
            ApplicationBackground = Color.FromName("Control");
            ApplicationForeground = Color.FromName("ControlText");
            #endregion

            #region Цвет списка
            ListBackground = Color.FromName("Control");
            ListForeground = Color.FromName("ControlText");
            #endregion

            #region Цвет текста
            TextForeground = Color.FromName("ControlText");
            #endregion

            #region Цвет кнопки
            ButtonBackground = Color.FromName("Control");
            ButtonForeground = Color.FromName("ControlText");
            #endregion

            #region Цвет меню
            MenuBackground = Color.FromName("Control");
            MenuForeground = Color.FromName("ControlText");
            #endregion
        }

        //Конфигурируем текстовый файл
        public string Configurate()
        {
            string json = JsonConvert.SerializeObject(this);

            return json;
        }
    }
}
