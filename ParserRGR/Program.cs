using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AngleSharp.Html.Parser;

namespace RGRRiverParser
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

            // string baseURL = "https://ru.wikipedia.org/";
            // string startURL = "w/index.php?title=%D0%9A%D0%B0%D1%82%D0%B5%D0%B3%D0%BE%D1%80%D0%B8%D1%8F:%D0%A0%D0%B5%D0%BA%D0%B8_%D0%BF%D0%BE_%D0%B0%D0%BB%D1%84%D0%B0%D0%B2%D0%B8%D1%82%D1%83";
            // 
            // Parser.ParserWorker parserWorker = new Parser.ParserWorker(baseURL);
            // parserWorker.OnNewData += (object obj) => Console.WriteLine(obj);
            // 
            // parserWorker.Start(startURL);
        }
    }
}
