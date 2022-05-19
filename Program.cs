using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            double attitudUsdToRub = 65.33;
            double attitudRubToUsd = 70.12;

            double attitudEurToRub = 73.12;
            double attitudRubToEur = 78.23;

            double attitudUsdToEur = 0.97;
            double attitudEurToUSD = 1.1;

            double usd = rand.Next(10,101);
            double rub = rand.Next(100,1001);
            double eur = rand.Next(8,91);
            string userInput;
            double moneyExchange;

            Console.WriteLine($"Приветствуем Вас в нашем конвертере валют. \n" +
                $"На вашем счете в данный момент {usd} долларов, {rub} рублей, {eur} евро.\n"+
                $"Для начала обмена введите \"Да\"\n" +
                $"Для выхода введите \"Выход\"");
            userInput = Console.ReadLine();
            while (userInput == "Да")
            {
                Console.WriteLine("Какой вид обмена Вас интересует? \n" +
                    "1 - Рубли на Доллары, 2 - Рубли на Евро\n" +
                    "3 - Доллары на Рубли, 4 - Доллары на Евро\n" +
                    "5 - Евро на Рубли, 6 - Евро на доллары.");
                userInput = Console.ReadLine();
                Console.Clear();

                if (userInput == "1")
                {
                    Console.WriteLine("Какую сумму Вы желаете обменять?");
                    moneyExchange = Convert.ToDouble(Console.ReadLine());

                    rub -= moneyExchange;
                    usd += moneyExchange / attitudRubToUsd;
                    Console.WriteLine($"После обмена Вам доступно в данный момент:\n" +
                        $" {usd} долларов, {rub} рублей, {eur} евро.");
                }
                if (userInput == "2")
                {
                    Console.WriteLine("Какую сумму Вы желаете обменять?");
                    moneyExchange = Convert.ToDouble(Console.ReadLine());

                    rub -= moneyExchange;
                    eur += moneyExchange / attitudRubToEur;
                    Console.WriteLine($"После обмена Вам доступно в данный момент:\n" +
                        $" {usd} долларов, {rub} рублей, {eur} евро.");
                }
                if (userInput == "3")
                {
                    Console.WriteLine("Какую сумму Вы желаете обменять?");
                    moneyExchange = Convert.ToDouble(Console.ReadLine());

                    usd -= moneyExchange;
                    rub += moneyExchange * attitudUsdToRub;
                    Console.WriteLine($"После обмена Вам доступно в данный момент:\n" +
                        $" {usd} долларов, {rub} рублей, {eur} евро.");
                }
                if (userInput == "4")
                {
                    Console.WriteLine("Какую сумму Вы желаете обменять?");
                    moneyExchange = Convert.ToDouble(Console.ReadLine());

                    usd -= moneyExchange;
                    eur += moneyExchange / attitudUsdToEur;
                    Console.WriteLine($"После обмена Вам доступно в данный момент:\n" +
                        $" {usd} долларов, {rub} рублей, {eur} евро.");
                }
                if (userInput == "5")
                {
                    Console.WriteLine("Какую сумму Вы желаете обменять?");
                    moneyExchange = Convert.ToDouble(Console.ReadLine());

                    eur -= moneyExchange;
                    rub += moneyExchange * attitudEurToRub;
                    Console.WriteLine($"После обмена Вам доступно в данный момент:\n" +
                        $" {usd} долларов, {rub} рублей, {eur} евро.");
                }
                if (userInput == "6")
                {
                    Console.WriteLine("Какую сумму Вы желаете обменять?");
                    moneyExchange = Convert.ToDouble(Console.ReadLine());

                    eur -= moneyExchange;
                    usd += moneyExchange * attitudEurToUSD;
                    Console.WriteLine($"После обмена Вам доступно в данный момент:\n" +
                        $" {usd} долларов, {rub} рублей, {eur} евро.");
                }
                Console.WriteLine("Если хотите продолжить введите \"Да\" \n" +
                    "Для выхода введите \"Выход \"");
                userInput = Console.ReadLine();
            }
                if (userInput == "Выход")
                {
                    Console.WriteLine("Всего хорошего!");
                }
            
                
            }
        }
    }
