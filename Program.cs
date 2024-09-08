#region Task1


Console.Write("Bir ədəd daxil edin: ");
string input = Console.ReadLine();

if (IsPalindrome(input))
{
    Console.WriteLine($"{input} palindrom ededdir.");
}
else
{
    Console.WriteLine($"{input} palindrom eded deyil.");
}
    

    static bool IsPalindrome(string number)
{
    int length = number.Length;

    for (int i = 0; i < length / 2; i++)
    {
        if (number[i] != number[length - i - 1])
        {
            return false;
        }
    }

    return true;
}

#endregion

#region task2
int[] array = { 10, 20, 4, 5, 20, 30, 30 };


int[] sortedDistinctArray = array.Distinct().OrderByDescending(x => x).ToArray();

if (sortedDistinctArray.Length < 2)
{
    Console.WriteLine("İkinci ən böyük eded mövcud deyil.");
}
else
{
 
    int secondLargest = sortedDistinctArray[1];
    Console.WriteLine("İkinci ən böyük ədəd: " + secondLargest);
}


#endregion






#region task3

int n = 7;  
Console.WriteLine($"{n}-ci Fibonacci ədədi: {FibonacciRecursive(n)}");
    

    static int FibonacciRecursive(int n)
{
    if (n <= 0)
        return 0;
    if (n == 1)
        return 1;

    return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
}



#endregion







