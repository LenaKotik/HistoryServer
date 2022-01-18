using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HistoryServer.Models
{
    public class Question
    {
        public Question() { }
        public Question(string que, string[] anws, int v)
        {
            this.question = que;
            this.anwsers = anws;
            this.correct = this.anwsers[0];
            this.value = v;
        }
        public string question;
        public string[] anwsers = new string[4];
        public string correct;
        public int value;
        public int num = 0;
    }
    public static class Questions
    {
        static List<Question> _questions = new List<Question>
        {
        new Question("Какой высший орган власти создала Екатерина I\nв помощь себе для управления государством?",new string[4]{"Верховный Тайный совет","Отряд Меншикова","Тайная Канцелярия","Святейший Синод" }, 2),
        new Question("Кто сменил Петра II на Русском престоле?",new string[4]{"Анна Иоановна","Иван Грозный","Петр III","Ярополк" }, 1),
        new Question("Укажите годы правления Екатерины I",new string[4]{"1725-1727","1724-1725","1727-1730","1725-1726" }, 2),
        new Question("Кто изначально стал регентом при Иване VI?", new string[4]{"Бирон","Меншиков","Анна Иоановна","Ломоносов" }, 3),
        new Question("Кто из правителей создал Академию наук?", new string[4]{"Екатерина I","Петр I","Екатерина II","Елизавета Петровна"}, 2),
        new Question("Что является одной из многих предпосылок для\nначала дворцовых переворотов?", new string[4]{"Указ о престолонаследии","Смерть Алексея Михайловича","Русско-Шведская война","Табель о рангах(1722)" }, 3),
        new Question("Почему русский народ не был в восторге от\nвосшествия на престол Петра III?", new string[4]{"Он не был патриотом своей страны","Он был женат на своей сестре","Он был слабоумным","Екатерина I была лучше по их мнению" }, 1),
        new Question("Укажите верную дату участия России в\nСемилетней войне.",new string[4]{"1757-1762","1757-1764","1756-1761","1761-1762" }, 3),
        new Question("Востановите цепочку правителей в эпоху\nдворцовых переворотов \"ЕкатеринаI -> ... -> Анна Иоановна\n-> ИванVI -> ... -> ПетрIII\"", new string[4]{"ПетрII,Елизавета Петровна","ЕкатеринаII,Миних","Бирон,ПетрII","ПетрII,Бирон"}, 5),
        new Question("При каком правителе Россия вышла из\nСемилетней войны?",new string[4]{"ПетрIII","ИванVI","Елизавета Петровна","ИванIV"}, 2),// 24 max
        }; // quiz data initialization
        public static void Shuffle()
        {
            Random r = new Random(DateTime.Now.Second);
            _questions = _questions.OrderBy(_ => r.Next()).ToList();
            foreach (Question q in _questions)
            {
                q.anwsers = q.anwsers.OrderBy(_ => r.Next()).ToArray();
            }
        }
        public static int Score // should normaly return 24
        {
            get
            {
                int sum = 0;
                foreach (Question q in _questions)
                {
                    sum += q.value;
                }
                return sum;
            }
        }
        public static int Size => _questions.Count;
        public static Question At(int i)
        {
            if (i >= _questions.Count || i < 0)
                throw new ArgumentOutOfRangeException("i", "Get gud lol");
            return _questions[i];
        }
    }
}
