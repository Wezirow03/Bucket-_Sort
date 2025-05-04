using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

class BucketSortTest
{
    public static void Main(string[] args)
    {
        
        GenerateTestData();

        MeasurePerformance();
    }

   
    public static void GenerateTestData()
    {
      int[] sizes = { 10, 100, 1000, 10000, 100000 };  
        int setsPerSize = 50; 

        foreach (int size in sizes)
        {
            for (int i = 0; i < setsPerSize; i++)
            {
                double[] array = GenerateRandomArray(size);  
                string filename = $"test_data/data_{size}_{i}.txt";
                SaveArrayToFile(array, filename);  
            }
        }
    }

    public static void MeasurePerformance()
    {
        string[] files = Directory.GetFiles("test_data");

        Console.WriteLine("Size  | Time(ms)| Iterations ");
        Console.WriteLine("-----------------------------------------");

        foreach (string file in files)
        {
            double[] array = ReadArrayFromFile(file);  

           
            var stopwatch = System.Diagnostics.Stopwatch.StartNew();
            long iterations = BucketSortWithIterations((double[])array.Clone(), 10); 
            stopwatch.Stop();

            double time = stopwatch.Elapsed.TotalMilliseconds; 
            Console.WriteLine($"{array.Length,-10} | {time,-9:F2} | {iterations}");
        }
    }

   
    public static long BucketSortWithIterations(double[] array, int bucketCount)
    {
        long iterationCount = 0;

        if (array.Length == 0) return iterationCount;

        double min = array[0];
        double max = array[0];

       
        for (int i = 1; i < array.Length; i++)
        {
            iterationCount++;  
            if (array[i] < min) min = array[i];
            else if (array[i] > max) max = array[i];
        }

      
        List<List<double>> buckets = new List<List<double>>();
        for (int i = 0; i < bucketCount; i++)
        {
            buckets.Add(new List<double>());
            iterationCount++;  
        }

        double range = max - min;

       
        foreach (double value in array)
        {
            int index = (int)((value - min) / range * (bucketCount - 1));
            buckets[index].Add(value);
            iterationCount++; 
        }

        int currentIndex = 0;
        
        foreach (var bucket in buckets)
        {
            bucket.Sort();
            iterationCount += (long)(bucket.Count * Math.Log(bucket.Count + 1)); 

            foreach (double value in bucket)
            {
                array[currentIndex] = value;
                currentIndex++;
                iterationCount++;  
            }
        }

        return iterationCount;  
    }

   
    public static double[] GenerateRandomArray(int size)
    {
        double[] array = new double[size];
        Random rand = new Random();

        for (int i = 0; i < size; i++)
        {
            array[i] = rand.NextDouble() * 1000;  
        }

        return array;
    }

    public static void SaveArrayToFile(double[] array, string filename)
    {
        File.WriteAllLines(filename, Array.ConvertAll(array, x => x.ToString()));  
    }
    public static double[] ReadArrayFromFile(string filename)
    {
        string[] lines = File.ReadAllLines(filename);
        double[] array = new double[lines.Length];

        for (int i = 0; i < lines.Length; i++)
        {
            array[i] = double.Parse(lines[i]); 
        }

        return array;
    }
}
