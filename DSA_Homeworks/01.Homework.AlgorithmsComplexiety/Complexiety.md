# Algorithms complexity Homework
Task 1. What is the expected running time of the following C# code? Explain why.
Assume the array's size is n.

```cs
  long Compute(int[] arr)
  {
      long count = 0;
      for (int i=0; i<arr.Length; i++)
      {
          int start = 0, end = arr.Length-1;
          while (start < end)
              if (arr[start] < arr[end])
                  { start++; count++; }
              else 
                  end--;
      }
      return count;
  }
  ```

The complexiety is O(n^2), beacause there is a for loop with n iterattions in a for loop with n iterations.

Task 2. What is the expected running time of the following C# code?
Explain why.
Assume the input matrix has size of n * m.

```cs
  long CalcCount(int[,] matrix)
  {
      long count = 0;
      for (int row=0; row<matrix.GetLength(0); row++)
          if (matrix[row, 0] % 2 == 0)
              for (int col=0; col<matrix.GetLength(1); col++)
                  if (matrix[row,col] > 0)
                      count++;
      return count;
  }
  ```

The complexity is O(n*m)/2, so lets say it is O(n*m) because of the one loop in the other one


Task 3. What is the expected running time of the following C# code?
Explain why.
Assume the input matrix has size of n * m.

```cs
  long CalcSum(int[,] matrix, int row)
  {
      long sum = 0;
      for (int col = 0; col < matrix.GetLength(0); col++) 
          sum += matrix[row, col];
      if (row + 1 < matrix.GetLength(1)) 
          sum += CalcSum(matrix, row + 1);
      return sum;
  }
  
  Console.WriteLine(CalcSum(matrix, 0));
```

The complexity is O(n*m) becuase every time the recursive call perform go trough the loop with n iterations. This calls are of count "m".
