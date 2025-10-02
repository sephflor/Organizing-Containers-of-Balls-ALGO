using System;
using System.Collections.Generic;
using System.Linq;

class Result
{
    public static string organizingContainers(List<List<int>> container)
    {
        int n = container.Count;
        long[] containerCapacity = new long[n]; 
        long[] ballTypeCount = new long[n];     
        
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                containerCapacity[i] += container[i][j];
                ballTypeCount[j] += container[i][j];
            }
        }
        
        
        Array.Sort(containerCapacity);
        Array.Sort(ballTypeCount);
        
        
        for (int i = 0; i < n; i++)
        {
            if (containerCapacity[i] != ballTypeCount[i])
                return "Impossible";
        }
        
        return "Possible";
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int q = Convert.ToInt32(Console.ReadLine().Trim());
        
        for (int qItr = 0; qItr < q; qItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            
            List<List<int>> container = new List<List<int>>();
            
            for (int i = 0; i < n; i++)
            {
                container.Add(Console.ReadLine().TrimEnd().Split(' ')
                    .Select(containerTemp => Convert.ToInt32(containerTemp))
                    .ToList());
            }
            
            string result = Result.organizingContainers(container);
            Console.WriteLine(result);
        }
    }
}
