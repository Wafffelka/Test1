﻿int array = new int[] {1, 5, 10, 20, 30, 40, 99, 4, 90, 3};
int count = 0;
      for (int i = 0; i < array.Lenght; i = i + 1)
      {
        if (array[i] == 10)
        {
          count++;
          if (array[i] == 90)
          {
            break;
          }
        }
      }
Console.WriteLine(count);