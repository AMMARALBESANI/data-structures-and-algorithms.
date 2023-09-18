namespace RepeatedWord
{
	public class Program
	{
		public static string repeated(string word)
		{
			word = word.ToLower();
			char[] delimiters = { ' ', ',', '.', '!', '?', ';', ':', '(', ')' };
			string[] arrWords = word.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
			HashSet<string> seenWords = new HashSet<string>();
			HashSet<string> repeatedWords = new HashSet<string>();

			foreach (string w in arrWords)
			{
				if (!seenWords.Add(w)) 
				{
					repeatedWords.Add(w);
				}
			}

			if (repeatedWords.Count > 0)
			{
				return repeatedWords.First();
			}

			return "No repetition";
		}


		static void Main(string[] args)
		{
			string text = "Once upon a time, there was a brave princess who";
			string result = repeated(text);
			Console.WriteLine($"\n The repeated word is: {result} ");
			Console.ReadKey();
		}

	}
}