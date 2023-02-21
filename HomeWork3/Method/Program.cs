//Написать метод для разворота массива, не используя память под дополнительный массив
int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9};
ReverseArray(array);
// метод просто выводит массив задом наперед, но т.к. использовать цикл задом на перед
// не очень хорошо, ниже второй метод, который будет перезаписывать ячейки
// static void ReverseArray(int[] arr)
// {
//     for (int i = arr.Length - 1; i >= 0; i = i - 1)
//     {
//         Console.WriteLine(arr[i]);
//     }
// }
static void ReverseArray(int[] arr)
{
    int length = arr.Length -1;
    for (int i = 0; i < arr.Length/2; i++)
    {
        int temp = arr[i];
        arr[i] = arr[length];
        arr[length] = temp;
        length = length - 1;
    }
}
var str = string.Join(" ", array);
Console.WriteLine(str);
