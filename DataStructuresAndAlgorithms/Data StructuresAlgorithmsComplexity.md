#Data Structures, Algorithms and Complexity
-

###Problem 1

```C#
long Compute(int[] arr)
{
    long count = 0;
    for (int i = 0; i < arr.Length; i++)
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

Assuming `arr.Length` is n, first we go n times in the `for` loop and than for every loop inside it we go another n times in the `while` loop. So the complexity here is
![equation](http://www.sciweavers.org/upload/Tex2Img_1446391324/eqn.png).

-
###Problem 2

```C#
long CalcCount(int[,] matrix)
{
    long count = 0;
    for (int row = 0; row < matrix.GetLength(0); row++)
        if (matrix[row, 0] % 2 == 0)
            for (int col = 0; col < matrix.GetLength(1); col++)
                if (matrix[row,col] > 0)
                    count++;
    return count;
}
```

We have a matrix with size **n*m** - there are **n** rows and m columns.

With the first `for` loop we loop **n** rows.

If the first element is even we go for the second `for` loop that loops **m** columns.

So the complexity here is ![equation](http://www.sciweavers.org/upload/Tex2Img_1446391426/render.png).

-
###Problem 3

```C#
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

The `for` loop in the method `CalcSum` is called **n** times and the method calls itself recursively another **m** times, so the complexity again is ![equation](http://www.sciweavers.org/upload/Tex2Img_1446391426/render.png).
