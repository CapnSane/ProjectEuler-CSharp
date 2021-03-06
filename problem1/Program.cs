// Problem 1

// If we list all the natural numbers below 10 that are multiples of 3 or 5,
// we get 3, 5, 6 and 9. The sum of these multiples is 23.

// Find the sum of all the multiples of 3 or 5 below 1000.

static int Multiples(int range)
{
    int[] list = new int [] {};
    var tempList = list.ToList();
    for (var i = 0; i < range; i++)
    {
      if(i%3==0 || i%5==0)
      {
        tempList.Add(i);
      }
    }
    int sum = tempList.Sum();
    return sum;
}

Console.WriteLine(Multiples(1000));