System.Console.WriteLine("Sub array ");
var initialArray = new int[] { 3, 4, 1, 1, 6 };
var key = 7;
var result = FindSubArraySumMatchKey(initialArray, key);
System.Console.WriteLine(result);


static int FindSubArraySumMatchKey(int[] array, int key)
{
    var sum = 0;
    var min = 0;
    var startIndex = 0;
    for (var i = 0; i <= array.Length - 1; i++)
    {
        sum += array[i];
        while (sum >= key)
        {
            min = i + 1 - startIndex;
            sum -= array[startIndex];
            startIndex++;
        }
    }
    return min;
}
