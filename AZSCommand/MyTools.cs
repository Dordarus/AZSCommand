using System;
using System.IO;
using System.Linq;

namespace AZSCommand
{

    class MyTools
    {
        /// <summary>
        /// Повертає массив потчних значень Назва ПС
        /// </summary>
        public string[] FillerName()
        {
            var context = new NutshellContext();

            var query = context.Fs
                .Select(p => p.Назва_ПС).Distinct().ToArray();
            return query;
        }

        /// <summary>
        /// Створює запис у журнал по даті та часу
        /// </summary>
        /// <param name="a">Відформатована стрічка для запису у лог-файл</param>
        public void Log(string a)
        {
            var dt = DateTime.Now;
            var logs = Environment.CurrentDirectory + @"\Logs";

            if (!Directory.Exists(logs))
            {
                Directory.CreateDirectory(logs);
            }

            var sw = new StreamWriter(logs + @"\Log[" + dt.ToShortDateString() + @"].txt", true);
            sw.WriteLine($"[{dt.ToLongTimeString()}]");
            sw.WriteLine($"{a}");
            sw.Close();
        }

        /// <summary>
        /// Повертає усі дати лог-файлів
        /// </summary>
        public DateTime[] Date()
        {
            var logs = Environment.CurrentDirectory + @"\Logs";

            var dir = new DirectoryInfo(logs);

            var g = dir.GetFiles();

            return g.Select(p => p.CreationTime).ToArray();
        }

        
    }
}
