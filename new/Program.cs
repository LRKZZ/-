namespace new1
{
    public class Program
    {
        public static void Main(string[] args)
          {
            Console.WriteLine("Введите количество элементов массива: ");
            int kolvo = Convert.ToInt32(Console.ReadLine());
            MyArray<string> stringArray = new MyArray<string>(kolvo);
            MyArray<int> intArray = new MyArray<int>(kolvo);
            Console.Clear();
            do
            {
                Console.WriteLine("1. Создать массив string");
                Console.WriteLine("2. Создать массив int");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("1. Добавить элемент");
                            Console.WriteLine("2. Удалить первый элемент");
                            Console.WriteLine("3. Вывести элемент по индексу");
                            Console.WriteLine("4. Вывести массив");
                            choice = Convert.ToInt32(Console.ReadLine());
                            switch (choice)
                            {
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine("Введите, сколько элементов вы хотите добавить. Размер массива сейчас: " + kolvo);
                                    int count = Convert.ToInt32(Console.ReadLine());
                                    for (int i = 0; i < count; i++)
                                    {
                                        stringArray.AddElement(Console.ReadLine(), i);
                                    }
                                    Console.WriteLine("Операция выполнена. Нажмите любую кнопку, чтобы продолжить");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 2:
                                    Console.Clear();
                                    Console.WriteLine("Введите индекс элемента, который хотите удалить: ");
                                    int index = Convert.ToInt32(Console.ReadLine());
                                    stringArray.RemoveElement(index);
                                    Console.WriteLine("Операция выполнена. Нажмите любую кнопку, чтобы продолжить");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 3:
                                    Console.Clear();
                                    Console.WriteLine("Введите индекс элемента, который хотите получить (начиная с 0): ");
                                    index = Convert.ToInt32(Console.ReadLine());
                                    if (stringArray.GetElement(index) == null)
                                    {
                                        Console.WriteLine("Элемента с таким индексом нет");
                                    }
                                    else
                                    {
                                        Console.WriteLine(stringArray.GetElement(index));
                                    }
                                    Console.WriteLine("Операция выполнена. Нажмите любую кнопку, чтобы продолжить");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 4:
                                    Console.Clear();
                                    for (int i = 0; i < stringArray.GetLength(); i++)
                                    {
                                        Console.WriteLine(stringArray.GetElement(i));
                                    }
                                    Console.WriteLine("Операция выполнена. Нажмите любую кнопку, чтобы продолжить");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;

                            }
                        } while (true);
                        break;
                    case 2:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("1. Добавить элемент");
                            Console.WriteLine("2. Удалить первый элемент");
                            Console.WriteLine("3. Вывести элемент по индексу");
                            Console.WriteLine("4. Вывести массив");
                            choice = Convert.ToInt32(Console.ReadLine());
                            switch (choice)
                            {
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine("Введите, сколько элементов вы хотите добавить. Размер массива сейчас: " + kolvo);
                                    int count = Convert.ToInt32(Console.ReadLine());
                                    for (int i = 0; i < count; i++)
                                    {
                                        intArray.AddElement(Convert.ToInt32(Console.ReadLine()), i);
                                    }
                                    Console.WriteLine("Операция выполнена. Нажмите любую кнопку, чтобы продолжить");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 2:
                                    Console.Clear();
                                    Console.WriteLine("Введите индекс элемента, который хотите удалить: ");
                                    int index = Convert.ToInt32(Console.ReadLine());
                                    intArray.RemoveElement(index);
                                    Console.WriteLine("Операция выполнена. Нажмите любую кнопку, чтобы продолжить");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 3:
                                    Console.Clear();
                                    Console.WriteLine("Введите индекс элемента, который хотите получить (начиная с 0): ");
                                    index = Convert.ToInt32(Console.ReadLine());
                                    if (intArray.GetElement(index) == null)
                                    {
                                        Console.WriteLine("Элемента с таким индексом нет");
                                    }
                                    else
                                    {
                                        Console.WriteLine(intArray.GetElement(index));
                                    }
                                    Console.WriteLine("Операция выполнена. Нажмите любую кнопку, чтобы продолжить");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 4:
                                    Console.Clear();
                                    for (int i = 0; i < intArray.GetLength(); i++)
                                    {
                                        Console.WriteLine(intArray.GetElement(i));
                                    }
                                    Console.WriteLine("Операция выполнена. Нажмите любую кнопку, чтобы продолжить");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;

                            }
                        } while (true);

                }
            } while (true);
          }
    }
    
}


