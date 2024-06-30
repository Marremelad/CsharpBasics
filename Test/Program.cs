int[] array = new int[1];
array[0] = 1;
int[] bar = array;
bar[0] = 2;

Console.WriteLine(array[0]);
Console.WriteLine(bar[0]);
