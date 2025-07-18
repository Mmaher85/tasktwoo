namespace tasktwoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("P - Print numbers");
                Console.WriteLine("A - Add a number");
                Console.WriteLine("M - Display mean of the numbers");
                Console.WriteLine("S - Display the smallest number");
                Console.WriteLine("L - Display the largest number");
                Console.WriteLine("F - Find a number (extension)");
                Console.WriteLine("C - Clear the list (extension)");
                Console.WriteLine("Q - Quit");
                Console.Write("Enter your choice: ");

                string input = Console.ReadLine().ToUpper();

                switch (input)
                {
                    case "P":
                        if (numbers.Count == 0)
                        {
                            Console.WriteLine("[] - the list is empty");
                        }
                        else
                        {
                            Console.Write("[ ");
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                Console.Write(numbers[i] + " ");
                            }
                            Console.WriteLine("]");
                        }
                        break;

                    case "A":
                        Console.Write("Enter a number to add: ");
                        string numInput = Console.ReadLine();
                        int num;
                        if (int.TryParse(numInput, out num))
                        {
                            numbers.Add(num);
                            Console.WriteLine($"{num} added.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid number.");
                        }
                        break;

                    case "M":
                        if (numbers.Count == 0)
                        {
                            Console.WriteLine("Unable to calculate the mean - no data");
                        }
                        else
                        {
                            int sum = 0;
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                sum += numbers[i];
                            }
                            double mean = (double)sum / numbers.Count;
                            Console.WriteLine($"Mean is: {mean}");
                        }
                        break;

                    case "S":
                        if (numbers.Count == 0)
                        {
                            Console.WriteLine("Unable to determine the smallest number - list is empty");
                        }
                        else
                        {
                            int smallest = numbers[0];
                            for (int i = 1; i < numbers.Count; i++)
                            {
                                if (numbers[i] < smallest)
                                    smallest = numbers[i];
                            }
                            Console.WriteLine($"The smallest number is {smallest}");
                        }
                        break;

                    case "L":
                        if (numbers.Count == 0)
                        {
                            Console.WriteLine("Unable to determine the largest number - list is empty");
                        }
                        else
                        {
                            int largest = numbers[0];
                            for (int i = 1; i < numbers.Count; i++)
                            {
                                if (numbers[i] > largest)
                                    largest = numbers[i];
                            }
                            Console.WriteLine($"The largest number is {largest}");
                        }
                        break;

                    case "F":
                        Console.Write("Enter a number to search for: ");
                        string searchInput = Console.ReadLine();
                        int searchNum;
                        if (int.TryParse(searchInput, out searchNum))
                        {
                            int foundIndex = -1;
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] == searchNum)
                                {
                                    foundIndex = i;
                                    break;
                                }
                            }

                            if (foundIndex != -1)
                                Console.WriteLine($"{searchNum} found at index {foundIndex}");
                            else
                                Console.WriteLine($"{searchNum} not found in the list.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid number.");
                        }
                        break;

                    case "C":
                        numbers.Clear();
                        Console.WriteLine("List cleared.");
                        break;

                    case "Q":
                        Console.WriteLine("Goodbye");
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Unknown selection, please try again.");
                        break;
                }
            }
        }
    }
}
