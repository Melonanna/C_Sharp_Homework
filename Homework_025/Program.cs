// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет 
//построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2

int [,,]array = new int [2,2,2];
int [] nums =new int [90];

for (int i=0; i<90;i++)
  nums [i] = i+10;

for (int i = 0; i < array.GetLength(0);i++)
  {
   for (int j = 0; j < array.GetLength(1);j++)
     {
     for (int l = 0; l < array.GetLength(2);l++)
       {
     int temp = new Random().Next(90);
     while (nums[temp] == 0) 
        temp = new Random().Next(90);
      array[i,j,l] = nums[temp];
      nums[temp]=0;
     }
  }
}
for (int i=0; i<array.GetLength(0);i++)
  {
   for (int j=0; j<array.GetLength(1);j++)
     {
      for (int l=0; l < array.GetLength(2);l++)
  Console.Write($"{array[i,j,l]},({i},{j},{l}) "); 
  Console.WriteLine();
  }  
  }

