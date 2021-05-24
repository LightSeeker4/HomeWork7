using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1.Doubler
{
    static class Program
    {
        //Алексей Сазонов
        //а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
        //б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок. 
        //Игрок должен получить это число за минимальное количество ходов.
        //в) *Добавить кнопку «Отменить», которая отменяет последние ходы. Используйте обобщенный класс Stack.
        //Вся логика игры должна быть реализована в классе с удвоителем.

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
