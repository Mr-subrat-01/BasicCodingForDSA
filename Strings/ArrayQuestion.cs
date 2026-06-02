namespace BasicCodingForDSA
{
    public class ArrayQuestion
    {
        int[] arr = [11, 23, 45, 21, 11, 20, 23, 7, 8, 22, 11, 56, 8, 20];
        public void FindMinAndMaxInArray()
        {
            // var arr = new int[] { 10, 23, 45, 21, 56, 8 };
            int min = arr[0], max = arr[arr.Length - 1];
            foreach (int num in arr)
            {
                if (num < min) min = num;
                if (num > max) max = num;
            }

            Console.WriteLine($"Maximum Element:{max} | Minimum Element:{min}");
        }
        public void ReverseAnArray()
        {
            // var arr = new int[] { 10, 23, 45, 21, 56, 8 };
            Console.WriteLine("Orginal Array:");
            foreach (int num in arr)
            {
                Console.Write($"{num}, ");
            }
            Console.WriteLine("\n==============");
            // we use two pointer to Reverse
            int left = 0, right = arr.Length - 1;
            while (left < right)
            {
                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
                left++;
                right--;
            }
            Console.WriteLine("Reverse Array:");
            foreach (int num in arr)
            {
                Console.Write($"{num}, ");
            }
            Console.WriteLine();
        }

        public void ContainsDuplicate()
        {
            var seen = new HashSet<int>();
            foreach(int n in arr)
            {
                if (!seen.Add(n))
                {
                    Console.WriteLine("Has Duplicate : "+n); 
                    return;
                } 
            }
            Console.WriteLine("No Duplicate found");
        }
        public void FindAllDuplicate()
        {
            var mappedData = new Dictionary<int, int>();
            var result = new List<int>();
            foreach (int n in arr)
            {
                mappedData[n] = mappedData.GetValueOrDefault(n, 0) + 1;
                if (mappedData[n] == 2) result.Add(n);
            }

            Console.WriteLine("Duplicate Numbers:");
            foreach (int num in result)
            {
                Console.WriteLine(num);
            }

        }
    }
}