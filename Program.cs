namespace ConsoleApp5_PreRelease;

class Program
{
    static void Main()
    {
        Console.WriteLine("выберите операцию {1,2,3,4}");
        Console.WriteLine("1 это +\n2 это -\n3 это *\n4 это /");
        string Operand = Console.ReadLine();
        bool yspex = int.TryParse(Operand, out int ZNAK);
        if (yspex == true)
        {
            
            switch (ZNAK)
            {
                case 1:
                    Console.WriteLine($"Вы ввели значение: {ZNAK} - это операция [+]");
                    break;
                case 2:
                    Console.WriteLine($"Вы ввели значение: {ZNAK} - это операция [-]");
                    break;
                case 3:
                    Console.WriteLine($"Вы ввели значение: {ZNAK} - это операция [*]");
                    break;
                case 4:
                    Console.WriteLine($"Вы ввели значение: {ZNAK} — это операция [/]");
                    break;
                default:
                    Console.WriteLine("ПОЧЕМУ ВЫ НЕ ВВЕЛИ ЧИСЛО ОТ 1 ДО 4 ЭТО ЧТО НАСТОЛЬКО СЛОЖНО?!?");
                    Main();
                    break;


            }
            
            

        }
        else {
            Console.WriteLine("ВЫ ДОПУСТИЛИ ПОТЕРЮ ЧИСЛА! ЕГО СТОИМОСТЬ БУДЕТ ВЫЧТЕНА ИЗ ВАШЕГО ЖАЛОВАНИЯ! И ВЫ БУДЕТЕ РАБОТАТЬ 510 ЛЕТ НА УРАНОВЫХ ШАХТАХ! ПОТОМУ ЧТО ИМЕННО СТОЛЬКО ЛЕТ ВАМ ПОНАДОБИТСЯ ЧТОБЫ ОПЛАТИТЬ СТОИМОСТЬ ПОТЕРЯННОГО ЧИСЛА!!!!");
            Main();
        }
        Console.WriteLine("введите 2 числа  разделённые пробелом  \nнапример вот так: {2 2}");
        string tswoStroca = Console.ReadLine();
        string[] stroshaka = tswoStroca.Split(' ');
        if (stroshaka.Length == 2 && int.TryParse(stroshaka[0], out int number1) && int.TryParse(stroshaka[1], out int number2))
        {
            switch (ZNAK)
            {
                case 1:
                    Console.WriteLine($"Ответ: {number1 + number2}");
                    break;
                case 2:
                    Console.WriteLine($"Ответ: {number1 - number2}");
                    break;
                case 3:
                    Console.WriteLine($"Ответ: {number1 * number2}");
                    break;
                case 4:
                    Console.WriteLine($"Ответ: {number1 / number2}");
                    break;
                default:
                    Console.WriteLine("упс, неверно }:]");
                    break;


            }
        }
        else
        {
            Console.WriteLine("Неккоректный ввод. Вы silly cat. Попробуйте ещё раз");
        }

        
    }
}
