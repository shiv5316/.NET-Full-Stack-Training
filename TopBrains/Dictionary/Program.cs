using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Dictionary<int,int> salaryDict=new Dictionary<int, int>()
        {
            {1,20000},{4,40000},{5,15000}
        };
        int[] ids={1,4,5};
        int totalSalary=0;
        foreach(int id in ids)
        {
            if (salaryDict.ContainsKey(id))
            {
                totalSalary+=salaryDict[id];
            }
        }
        Console.WriteLine(totalSalary);
    }
}
