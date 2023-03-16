# Unity With CSharp Course
Unity With C# course supplemental source code examples

💡 What is included in this repo? 
* Includes Unity and .NET Console projects demonstrated with [Learn XR C# Fundamentals With Unity Course](https://www.learnxr.io/c-programming-fundamentals-with-unity)

📚 Topic References:

* Single dimensional arrays:
    ```csharp
    int[] array = new int[4];
    array[0] = 1;
    array[1] = 2;
    array[2] = 3;
    array[3] = 4;

    int[] secondArray = new int[] { 2, 4, 8, 16 };
    ```
        *Visual representation of one dimensional arrays:*
        |Index| Value|
        |-----|------|
        |  0  |  2   |
        |  1  |  4   |
        |  2  |  8   |
        |  3  |  16  |

* Two dimensional arrays:


    ```csharp
    //[rows, columns]
    int[,] array = new int[3,3];
    array[0, 0] = 1;
    array[0, 1] = 5;

    int[,] secondArray = {{ 1, 2, 3}, {3, 4, 5}};
    Console.WriteLine(secondArray[0, 0]); //outputs 1
    Console.WriteLine(secondArray[1, 1]); //outputs 4
    Console.WriteLine(secondArray[1, 2]); //outputs 5
```
    *Visual representation of two dimensional arrays:*
    |     |Column 0|Column 1|Column 2|
    |-----|--------|--------|--------|
    |Row 0|1       |2       |3       |
    |Row 1|3       |4       |5       |
