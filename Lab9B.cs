using System;

class Program {
  public static void Main (string[] args) {
    int[] numbers = new int[11];
            Console.WriteLine("Please enter 11 numbers:");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Integer {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("What is the target number: ");
            int target = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }

            Console.Write("The sorted set is: ");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            int low = 0, high = numbers.Length - 1;
            bool found = false;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                Console.WriteLine($"Low is {low}, High is {high}, Mid is {mid}, Searching");

                if (numbers[mid] == target)
                {
                    found = true;
                    break;
                }
                else if (numbers[mid] < target)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            Console.WriteLine(found ? "The target is in the set." : "The target is not in the set.");
        }
    }