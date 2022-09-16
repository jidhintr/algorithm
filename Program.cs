System.Console.WriteLine("Sub array ");
var initialArray = new int[] { 3, 4, 1, 1, 6 };
var key = 7;
var result = FindSubArraySumMatchKey(initialArray, key);
System.Console.WriteLine(result);

var len = LongestDistinctSubString("araaraci", 2);
System.Console.WriteLine($"Distinct string length is {len}");

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


static int LongestDistinctSubString(string data, int key)
{   //araaci
    var result = 0;
    var max = 0;
    var index = 0;
    for (int i = 0; i <= data.Length - 1; i++)
    {
        var rightIndex = data[i];
        max++; // use dict or hashmap to get count 
        while (max > key)
        {
            var leftChar = data[index];
            index++;
            max--; // same use dict here - logic same as above func()
        }
    result = i -  index + 1;
    }
    
    return result;

}