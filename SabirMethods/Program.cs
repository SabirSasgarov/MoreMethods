using System.Diagnostics.Tracing;

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

			#region task6
			//string str = Console.ReadLine();
			//GetDomain(str);
			#endregion

			#region task7
			//string str = Console.ReadLine();
			//GetDomain(str);
			#endregion

			#region task8
			//string str = Console.ReadLine();
			//string[] words = str.Split();
			//ToPascal(words);
			#endregion

		}


		public static void ToPascal(string[] words)
		{
			int count = default;
			foreach (string word in words)
			{
				if (count == 0)
				{
					count++;
					word.ToUpper();
					Console.Write(word.ToUpper()[0]);
					Console.Write(word.Substring(1).ToLower());
				}
				else
					Console.Write(word.ToLower());
				Console.Write(" ");
			}
		}
		public static void GetDomain(string mail)
		{
			Console.WriteLine(mail.Substring(mail.IndexOf('@')+1));
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






    }
}
