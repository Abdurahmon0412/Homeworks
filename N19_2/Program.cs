using N19_2;


int[] IntArray  = new int[] { 1,2,3,4,5,6,7,8,9};

Console.WriteLine($"Min value -  {AggregationService.Min(IntArray)}");
Console.WriteLine($"Max value -  {AggregationService.Max(IntArray)}");
Console.WriteLine($"Avrage value -  {AggregationService.Average(IntArray)}");
Console.WriteLine($"Sum  -  {AggregationService.Sum(IntArray)}");




//2 shart
var A1 = 6;
var A2 = int.MaxValue;
var A3 = -10;
var A4 = int.MinValue;

AggregationService.Decrement(ref A1);
AggregationService.Decrement(ref A2);
AggregationService.Increment(ref A3);
AggregationService.Increment(ref A4);
Console.WriteLine(A1);
Console.WriteLine(A2);
Console.WriteLine(A3);
Console.WriteLine(A4);