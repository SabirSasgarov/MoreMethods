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
			//Console.WriteLine(TekrarlariSil(str));
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
			//char[] numbers = {'1','2','3','4','5','6','7','8','9','0'};
			//CheckString(str,numbers);
			#endregion

			#region task8
			//string str = Console.ReadLine();
			//string[] words = str.Split();
			//ToPascal(words);
			#endregion

			#region task9
			//string[] fullNames={"Sabir Asgarov","Aqsin Khalilov","Farid Cavadov"};
			//foreach(string name in FullToOnlyNames(fullNames))
			//	Console.WriteLine(name);
			#endregion
		}

		//9
		private static string[] FullToOnlyNames(string[] fullNames)
		{
			string[] name = new string[fullNames.Length];
			for (int i=0;i<fullNames.Length;i++)
				name[i] = fullNames[i].Split()[0];
			return name;
		}
		//7
		private static void CheckString(string str, char[] numbers)
		{
			bool contain = false;
			int count = default;
			foreach (char s in str)
			{
				if(contain = numbers.Contains(s))
					break;	
			}
			if(contain)
				Console.WriteLine("Reqem var");
			else
				Console.WriteLine("Herflerden ibaretdir");
		}
		//8
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
		//6
		public static void GetDomain(string mail)
		{
			Console.WriteLine(mail.Substring(mail.IndexOf('@')+1));
		}
		//4
		public static void Print(string[] arr)
		{
			foreach (string a in arr)
				Console.WriteLine(a);
		}
		//1
		public static int[] MusbeteCevir(ref int[] nums)
        {
			int[] newArray = new int[nums.Length];
			for (int i = 0; i<nums.Length; i++)
			{
				if (nums[i] < 0) nums[i] *= -1;
			}
            return nums;
        }
		//2
		public static void Repeat(string word, int count)
		{
			for(int i = 0; i<count; i++)
			{
				Console.Write(word);
			}
		}
		//3
		public static string TekrarlariSil(string str)
		{
			string newStr = string.Empty;
			for(int i = 0; i < str.Length; i++)
			{
				int count = 0;
				for(int j = 0; j < str.Length; j++)
				{
					if (str[i] == str[j])
						count++;
				}
				if (count < 2 && str[i]!=' ')
					newStr += str[i];
			}
			return newStr;
		}

	}
}
