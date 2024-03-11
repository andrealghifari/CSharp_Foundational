// int[,] multiArray = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
int[,] multiArray = { {1,2,3}, {4,5,6}, {7,8,9} };
for (int i = 0; i < multiArray.GetLength(0); i++) //
{
    for (int j = 0; j < multiArray.GetLength(1); j++)
    {
        Console.Write(multiArray[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
//
// Jagged Array
int[][] jaggedArray = [ [1,2,3], [4,5,6,7], [8,9,10] ];
// int[][] jaggedArray = new int[][]
// {
//     new int[] { 1, 2, 3 },
//     new int[] { 4, 5, 6, 7, 8 },
//     new int[] { 9, 10 }
// };

for(int i=0; i < jaggedArray.Length; i++){
    for(int j=0; j<jaggedArray[i].Length; j++){
        Console.Write(jaggedArray[i][j] + " ");
    }
    Console.WriteLine();
}
