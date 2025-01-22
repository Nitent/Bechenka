using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Bechenka
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Publicationn> Inf = new List<Publicationn>();
            Inf.Add(new Publicationn("Тузовский А.Ф.", "Системы управления знаниями на основе использования онтологических моделей и семантических методов."));
            Inf.Add(new Publicationn("Чудинова М.В.", "Краткось юного Я"));
            Inf.Add(new Statyaa("Викторов О.К.", "Атланты из Кемеровской области", 1997, "Интеграция распределённой и разнородной информации и данных организации."));
            Inf.Add(new Statyaa("Чудинов Н.Б.", "Новости в областях IT", 2006, "Реализация проекта: 1984 в сети"));
            Inf.Add(new Uchebnikk("Викторов О.К.", 11, "Объектно-ориентированное программирование. Учебное пособие для прикладного бакалавриата."));
            Inf.Add(new Uchebnikk("Якубов В.В.", 9, "ДеЛюмпенизация математики"));
            foreach (Publicationn Uchenie in Inf)
            {
                Uchenie.Show();
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
