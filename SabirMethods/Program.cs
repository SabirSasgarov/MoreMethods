namespace SabirMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "salam sagol";

            //Console.WriteLine(word.Remove(4));
            //Console.WriteLine(word.Substring(0,4));
            //Console.WriteLine(word.Trim());
            //Console.WriteLine(word.IndexOf(' '));
            //string[] words = word.Split(' ');
            //Console.WriteLine(string.Concat(words));
            //Console.WriteLine(word.Replace('',' '));

            int[] numbers= [ 1, 2, -3, 4, -5, 6, -7 ];
            MusbeteCevir(ref numbers);



        }
        public static int[] MusbeteCevir(ref int[] nums)
        {

            return new int[nums.Length];
        }
    }
}
