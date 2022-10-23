using static System.Net.Mime.MediaTypeNames;

namespace DataStorageSovunja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> texts = new List<string>(); 
            Console.WriteLine("Приветствуем в приложении для хранения данных! \nРаботу выполнил Кирилл Андреев (aka Sovunja) \nДля продолжения нажмите Enter!");
            Console.ReadLine();
            char choice = '1';
            while (choice != 'q' && choice != 'Q')
            {
                Console.Clear();
                Console.WriteLine("1. Print Data \n2. Add item\n3. Remove item\nQ. Quit");
                choice = Console.ReadKey().KeyChar;
                Console.Clear();
                switch (choice)
                {
                    case '1':
                        if (texts.Count == 0)
                        {
                            Console.WriteLine("There is nothing here :(");
                            Thread.Sleep(1000);
                        }
                        else
                        {
                            foreach (string text in texts)
                            {
                                Console.WriteLine($"{texts.IndexOf(text) + 1}. {text}\n");
                            }
                            Console.WriteLine("Prees Enter to continue");
                            Console.ReadLine();
                        }
                        break;
                    case '2':
                        Console.WriteLine("Which type of data you want to add?:\n1. Message \n2. Person\n3. Car");
                        char addChoice = Console.ReadKey().KeyChar;
                        Console.Clear();
                        switch (addChoice)
                        {
                            case '1':
                                Console.WriteLine("Write your message:");
                                string text = Console.ReadLine();
                                texts.Add(new Message(text).Add());
                                break;
                            case '2':
                                Console.WriteLine("First name:");
                                string firstName = Console.ReadLine();
                                Console.WriteLine("Last name:");
                                string lastName = Console.ReadLine();
                                Console.WriteLine("Age:");
                                int age = int.Parse(Console.ReadLine());
                                texts.Add(new Person(firstName, lastName, age).Add());
                                break;
                            case '3':
                                Console.WriteLine("Brand:");
                                string brand = Console.ReadLine();
                                Console.WriteLine("Year:");
                                int year = int.Parse(Console.ReadLine());
                                texts.Add(new Car(brand, year).Add());
                                break;
                        }
                        Console.WriteLine("Your Data has been saved.");
                        Thread.Sleep(1000);
                        break;
                    case '3':
                        if (texts.Count == 0)
                        {
                            Console.WriteLine("There is no elements in the storage to delete!");
                        }
                        else
                        {
                            Console.WriteLine("Which Data you want to delete?");
                            int i = int.Parse(Console.ReadLine()) - 1;
                            if (i > texts.Count)
                            {
                                Console.WriteLine("The element with this number does not exist");
                            }
                            else
                            {
                                texts.RemoveAt(i);
                                Console.WriteLine($"Data number {i + 1} is deleted ");
                            }
                        }
                        Thread.Sleep(1000);
                        break;
                    case 'q':
                    case 'Q':
                        Console.WriteLine("Peace to you, ma dude!");
                        break;
                    default:
                        Console.WriteLine("Man, what is that, I don't understand you...");
                        Thread.Sleep(1500);
                        break;
                }
            }
        }
    }
}