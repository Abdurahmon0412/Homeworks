
using N18_1;

var management = new OrderManagementService();
management.Add(50);
management.Add(159);
management.Add(250);
management.Add(592);

Console.WriteLine($"Sum{management.Sum()}");
Console.WriteLine($"Sum{management.Sum()}");
Console.WriteLine($"Min{management.Min()}");
Console.WriteLine($"Min{management.Min()}");
Console.WriteLine($"Max{management.Max()}");
Console.WriteLine($"Max{management.Max()}");


management.Add(750);
management.Add(85);
management.Add(85);
management.Add(330);

Console.WriteLine($"Sum{management.Sum()}");
Console.WriteLine($"Sum{management.Sum()}");
Console.WriteLine($"Min{management.Min()}");
Console.WriteLine($"Min{management.Min()}");
Console.WriteLine($"Max{management.Max()}");
Console.WriteLine($"Max{management.Max()}");





