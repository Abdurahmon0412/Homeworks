using N28_HT2;


var ListA = new ClonableList<StorogeFile>
{
    new StorogeFile("file1", "bu 1 description", 72),
    new StorogeFile("file2", "bu 2 description", 2),
    new StorogeFile("file3", "bu 3 description", 24),
};

var clonedList = (ClonableList<StorogeFile>)ListA.Clone();

ListA.First().Name = "djals";

ListA.ForEach(Console.WriteLine);
Console.WriteLine();
clonedList.ForEach(Console.WriteLine);