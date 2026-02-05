namespace SabirMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
			#region practice
			//string word = "salam sagol";
			//Console.WriteLine(word.Remove(4));
			//Console.WriteLine(word.Substring(0,4));
			//Console.WriteLine(word.Trim());
			//Console.WriteLine(word.IndexOf(' '));
			//string[] words = word.Split(' ');
			//Console.WriteLine(string.Concat(words));
			//Console.WriteLine(word.Replace('',' '));
			#endregion

			#region task1
			//int[] numbers= [ 1, 2, -3, 4, -5, 6, -7 ];
			//MusbeteCevir(ref numbers);
			//foreach (int number in numbers)
			//	Console.Write(number+" ");
			#endregion

			#region task2
			//string word = Console.ReadLine();
			//int count = int.Parse(Console.ReadLine());
			//Repeat(word,count);
			#endregion

			#region task3
			//string str = Console.ReadLine();
			//TekrarlariSil(str);
			#endregion

			#region task4
			//string word = "salam sagol asdjn,asda.";
			//string[] words = word.Split(' ','.',',');
			//Print(words);
			#endregion

			#region task5
			//string word = "salam sagol";
			//Console.WriteLine(word.Remove(4));
			//Console.WriteLine(word.Substring(0,4));
			#endregion
		}
		public static void Print(string[] arr)
		{
			foreach (string a in arr)
				Console.WriteLine(a);
		}
		public static int[] MusbeteCevir(ref int[] nums)
        {
			int[] newArray = new int[nums.Length];
			for (int i = 0; i<nums.Length; i++)
			{
				if (nums[i] < 0) nums[i] *= -1;
			}
            return nums;
        }
		public static void Repeat(string word, int count)
		{
			for(int i = 0; i<count; i++)
			{
				Console.Write(word);
			}
		}
		public static string TekrarlariSil(string word)
		{

			return word;
		}





    }
}
