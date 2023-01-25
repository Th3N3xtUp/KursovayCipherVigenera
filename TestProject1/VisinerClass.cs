using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class VisinerClass
    {
        public string kluch { get; set; }
        public string slovo { get; set; }
        public string alpha { get; set; }
        public VisinerClass(string klch, string slv, string s)
        {
            kluch = klch;
            slovo = slv;
            alpha = s;
        }
        public int[] funckluch(string klch, string alf, int[] a1)         //сдвиги ключа
        {
            for (int i = 0; i < klch.Length; i++)
            {
                int na4 = 0;
                while (klch[i] != alf[na4])
                {
                    na4++;
                }
                a1[i] = na4;
            }
            return a1;
         
        }
        public string[] funcshifr(string slovo, string alf, int[] a1, string[] mas)    //сдвиг по алфавиту по ключу, т.е само шифрование 
        {
            try                                      // проверка на ошибку при внесение в поле другого языка
            {
                int x = 0;
                for (int i = 0; i < slovo.Length; i++)
                {
                    int na4 = 0;
                    while (slovo[i] != alf[na4])
                    {
                        na4++;
                    }
                    if (x > a1.Length - 1)
                    {
                        x = 0;
                    }
                    int a = na4 + a1[x];
                    if (a > alf.Length - 1)
                    {
                        a = a - alf.Length;
                    }
                    if (a < 0)
                    {
                        a = a + alf.Length;
                    }
                    mas[i] = Convert.ToString(alf[a]);
                    x++;
                }
                return mas;
            }
            catch (System.IndexOutOfRangeException)
            {
                mas[0] = Convert.ToString("{ПОЖАЛУЙСТА,ПРОВЕРЬТЕ ИСПОЛЬЗУЕТЕ ЛИ ВЫ ЛАТИНСКИЙ ЯЗЫК, ВВЕДЕН ЛИ У ВАС КЛЮЧ И ВЫБРАН ЛИ КОРРЕКТНЫЙ РЕЖИМ ЗАПИСИ ВАШЕГО ТЕКСТА!}");
            }
            return mas;

        }
        public string[] funcunshifr(string slovo, string alf, int[] a1, string[] mas)      //дешифрование 
        {
            try
            {
                int x = 0;
                for (int i = 0; i < slovo.Length; i++)
                {
                    int na4 = 0;
                    while (slovo[i] != alf[na4])
                    {
                        na4++;
                    }
                    if (x > a1.Length - 1)
                    {
                        x = 0;
                    }
                    int a = na4 - a1[x];
                    if (a > alf.Length - 1)
                    {
                        a = a - alf.Length;
                    }
                    if (a < 0)
                    {
                        a = a + alf.Length;
                    }
                    mas[i] = Convert.ToString(alf[a]);
                    x++;
                }
                return mas;
            }
            catch (System.IndexOutOfRangeException)
            {
                mas[0] = Convert.ToString("{ПОЖАЛУЙСТА,ПРОВЕРЬТЕ ИСПОЛЬЗУЕТЕ ЛИ ВЫ ЛАТИНСКИЙ ЯЗЫК, ВВЕДЕН ЛИ У ВАС КЛЮЧ И ВЫБРАН ЛИ КОРРЕКТНЫЙ РЕЖИМ ЗАПИСИ ВАШЕГО ТЕКСТА!}");
            }
            return mas;
        }
    }
    public class Alfavit : VisinerClass
    {

        public Alfavit(string klch, string slv, string s) : base(klch, slv, s)
        {

        }

    }
    public class Alfavitsoznak : VisinerClass
    {
        public Alfavitsoznak(string klch, string slv, string s) : base(klch, slv, s)
        {

        }

    }
}
