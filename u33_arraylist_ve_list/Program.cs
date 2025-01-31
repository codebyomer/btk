using System.Collections;

ArrayList arrayList = ["İzmir", 35, 3.14, true];
arrayList.Add("BTK");
arrayList.Insert(2,-1);
foreach(var i in arrayList)
{
    Console.WriteLine($"{i}, ");
}
Console.WriteLine();

List<int> liste = [5,6,2,8,9,7,7];
liste.Remove(liste.Count - 1);
liste.Add(3);
liste.AddRange([1, 8, 4]);
liste.Insert(0, 11);
