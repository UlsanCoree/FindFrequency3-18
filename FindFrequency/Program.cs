namespace FindFrequency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "사과 바나나 사과 파인애플 블루베리 바나나 사과 참외 수박 파인애플";
            string[] words = text.Split(' ');
            var wordFrequency = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (wordFrequency.ContainsKey(word))
                {
                    wordFrequency[word]++;
                }
                else
                {
                    wordFrequency[word] = 1;
                }
            }

            foreach (var pair in wordFrequency)
            {
                Console.WriteLine($"{pair.Key} : {pair.Value}");
            }
        }
    }
}

