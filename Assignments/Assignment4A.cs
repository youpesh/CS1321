using System;
class Assignment4A {
  
  public static void Main()
      {
          Console.Write("Enter a single character for the diamond: ");
          char diamondChar = Console.ReadKey().KeyChar;
          Console.WriteLine();

          int maxWidth;
          do
          {
              Console.Write("\nEnter the maximum width for the diamond (odd number greater than 2): ");
          }
          while (!int.TryParse(Console.ReadLine(), out maxWidth) || maxWidth < 3 || maxWidth % 2 == 0);

          // Upper half of the diamond
          for (int i = 1; i <= maxWidth; i += 2)
          {
              // Print leading spaces
              for (int j = 0; j < (maxWidth - i) / 2; j++)
              {
                  Console.Write(" ");
              }

              // Print diamond character
              for (int j = 0; j < i; j++)
              {
                  Console.Write(diamondChar);
              }

              Console.WriteLine();
          }

          // Lower half of the diamond
          for (int i = maxWidth - 2; i >= 1; i -= 2)
          {
              // Print leading spaces
              for (int j = 0; j < (maxWidth - i) / 2; j++)
              {
                  Console.Write(" ");
              }

              // Print diamond character
              for (int j = 0; j < i; j++)
              {
                  Console.Write(diamondChar);
              }

              Console.WriteLine();
          }
      }
  }


