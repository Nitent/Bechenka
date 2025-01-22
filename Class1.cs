using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Bechenka
{
    class Publicationn
    {
        public string AFtor { get; set; }
        public string TEXAS { get; set; }
        public Publicationn() { }
        public Publicationn(string Aftor, string texa)
        {
            AFtor = Aftor;
            TEXAS = texa;
        }
        public virtual void Show()
        {
            Console.WriteLine($"Публикация: Автор = {AFtor}, содержание = {TEXAS}");
        }
    }
    class Statyaa : Publicationn
    {
        public string Shournal;
        public int God_vupuska;
        public Statyaa() { }
        public Statyaa(string Aftor, string shournal, int god_vupuska, string texa) : base(Aftor, texa)
        {
            Shournal = shournal;
            God_vupuska = god_vupuska;
        }
        public override void Show()
        {
            Console.WriteLine($"Статья: Автор - {AFtor}, журнал - {Shournal}, год выпуска - {God_vupuska}, содержание - {TEXAS}");
        }
    }
    class Uchebnikk : Publicationn
    {
        public int Clas;
        public Uchebnikk() { }
        public Uchebnikk(string Aftor, int clas, string texa) : base(Aftor, texa)
        {
            Clas = clas;
        }
        public override void Show()
        {
            Console.WriteLine($"Учебник: Автор - {AFtor}, класс - {Clas}, содержание - {TEXAS}");
        }
    }
}
