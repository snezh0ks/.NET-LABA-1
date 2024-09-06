using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA_1
{
    class Program
    {
        
        static void TaskOne() // выводит текст в консоль в строку и с новой строки
        {
            // Console.Write - вывод текста в строку

            Console.Write("Фамилия ");
            Console.Write("Имя ");
            Console.Write("Отчество");

            // для наглядности добавим оступы между элементами

            Console.WriteLine("\n");

            // Console.WriteLine - вывод текста с новой строки

            Console.WriteLine("Фамилия");
            Console.WriteLine("Имя");
            Console.WriteLine("Отчество");
        }

        static void TaskTwo() // получает данные из консоли и выводит их обратно
        {
            // Console.ReadLine - считывает данные с консоли текущей строки

            string name, age;

            Console.Write("Имя = ");
            name = Console.ReadLine();

            Console.Write("Возраст = ");
            age = Console.ReadLine();

            // символ $ - позволяет форматировать строку и использовать в ней переменные

            Console.WriteLine($"Добро пожаловать, {name}!");
            Console.WriteLine($"Вам, {age} лет!");
        }

        static void TaskThree() // запускает интересный диалог)
        {
            int section;

            Console.WriteLine("Добро пожаловать в наш магазин Mayo World! Как к вам можно обращаться?");
            Console.Write("Имя = ");
            string name = Console.ReadLine();

            Console.WriteLine($"\n{name}, вам что нибудь подсказать? (1 - да; 2 - нет)");
            Console.Write("= ");
            
            section = int.Parse(Console.ReadLine());
            
            if (section == 1)
            {
                Console.WriteLine($"\n{name}, есть какие-нибудь предпочтения? Если нет, тогда могу посоветовать вам домашний майонез!");
                Console.WriteLine("1 - принять предложение;");
                Console.WriteLine("2 - а у меня есть выбор? (майонез который посоветовал вам продовец являеться вашим самым любимым майонезом, который вы всегда покупаете!)");
                Console.Write("= ");

                Console.ReadLine();
                Console.WriteLine("\nКласика жанра! Вы оплатили покупку и пошли домой! Дома вы сварали свои любимые пельмешки и вкусно покушали! (Хорошая концовка)");
                
                return;
            }


            Console.WriteLine("\nПеред вам стоит выбор.");
            Console.WriteLine("1 - ваш любимый майонез, который вы всегда покупаете;");
            Console.WriteLine("2 - майонез со скидкой в 99%, не просроченный!!! честно!!!");
            Console.Write("= ");

            section = int.Parse(Console.ReadLine());
            
            if (section == 1)
            {
                Console.WriteLine("\nКласика жанра! Вы оплатили покупку и пошли домой! Дома вы сварали свои любимые пельмешки и вкусно покушали! (Хорошая концовка)");
                return;
            }

            Console.WriteLine("\nВы решили довериться надписи на упаковке. Не будет же ваш любимый, замечательный майонез вас обманывать!");
            Console.WriteLine("Правда ведь? ПРАВДА ВЕДЬ?");
            Console.WriteLine("Как оказалось, майонез был просроченным и своим вкусом испортил пельмени. Вы остались голодными! (Плохая концовка)");
        }

        static void Main(string[] args)
        {
            // TaskOne();

            // TaskTwo();

            TaskThree();

            // Console.ReadKey() - ожидает ввод любой клавиши (используется для того чтобы после завершения программы не закрывалась консоль)

            Console.ReadKey();
        }
    }
}
