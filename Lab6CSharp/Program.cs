Console.WriteLine("Lab 4 CSharp");
while (true)
{
    Console.WriteLine("Enter the task number:");
    string input = Console.ReadLine();
    int n;
    if (int.TryParse(input, out n))
    {
        switch (n)
        {
            case 1:

                Console.WriteLine("Створення об'єктів:");

                Test test1 = new Test("Загальний тест", 20);
                test1.Show();
                Console.WriteLine();

                Exam exam1 = new Exam("Іспит з математики", 30, "Математика");
                exam1.Show();
                Console.WriteLine();

                FinalExam finalExam1 = new FinalExam("Випускний іспит", 50, "Фізика", 95);
                finalExam1.Show();
                Console.WriteLine();

                Quiz quiz1 = new Quiz("Вікторина про країни", 10, "Географія");
                quiz1.Show();
                Console.WriteLine();

                Console.WriteLine("Завершення програми. Деструктори будуть викликані автоматично.");

                break;


            case 2:

                Product[] products = new Product[]
    {
            new Toy("Лялька", 25.50, "Іграшковий завод", "пластик", 3),
            new Book("451 градус за фарангейтом", 55.00, "Рей Бредбері", "Україна", 16),
            new SportsEquipment("Футбольний м'яч", 20.00, "Nike", 10),
    };

                Console.WriteLine("Повна інформація про товари:");
                foreach (var product in products)
                {
                    product.DisplayInfo();
                    Console.WriteLine();
                }

                string searchType = "toy"; // Тип товару, який шукаємо
                Console.WriteLine($"Пошук товарів типу \"{searchType}\":");
                foreach (var product in products)
                {
                    if (product.MatchesType(searchType))
                    {
                        product.DisplayInfo();
                        Console.WriteLine();
                    }
                }

                break;

        }
    }
}