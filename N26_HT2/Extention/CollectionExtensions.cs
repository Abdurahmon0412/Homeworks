namespace N26_HT2.Extention;

public static class CollectionExtensions
{

    public static ICollection<Skills> Update(this ICollection<Skills> firstcollection,
        ICollection<Skills> secondcollection)
    {
        var list = firstcollection.ToList();
        
        var addedItems = secondcollection
            .ExceptBy(firstcollection.Select(firstItem => firstItem.Id), item => item.Id);
        
        var removedItems = firstcollection
            .ExceptBy(secondcollection.Select(firstItem => firstItem.Id), item => item.Id);

        var intersectKeys = firstcollection.Select(item => item.Id)
            .Intersect(secondcollection.Select(item => item.Id));

        foreach (var item in addedItems)
            list.Add(item);

        foreach (var item in removedItems)
            list.Remove(item);
        
        foreach (var key in intersectKeys)
        {
            var firstItem = list.First(a => a.Id == key);
            var secondItem =  secondcollection.First(a => a.Id == key);

            firstItem.Name = secondItem.Name;
            firstItem.Level = secondItem.Level;
        }
        return list;
    }
}