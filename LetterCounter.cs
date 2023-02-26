using System.Text;

namespace LetterCounter
{
    public static class Counter
    {
        public static string Count(string filepath)
        {
            if(!File.Exists(filepath)) { 
                return "Файл не найден по пути "+ filepath;
            }
            var dict = new Dictionary<char, int>();
            var stream = new StreamReader(filepath);
            var line = stream.ReadLine();
            while(line != null){
                for(int i = 0; i < line.Length; i++)
                {
                    var symbol = line[i];
                    if ((int)symbol < 1072 || (int)symbol > 1104) continue;
                    if (dict.ContainsKey(symbol))
                    {
                        dict[symbol]++;
                    }
                    else
                    {
                        dict.Add(symbol, 1);
                    }
                }
                line = stream.ReadLine();
            }
            var result = new StringBuilder();
            var sum = 0;
            foreach(var symbol in dict.Keys)
            {
                result.Append($"{symbol}: {dict[symbol]} \n");
                sum += dict[symbol];
            }
            result.Append($"Всего символов: {sum}");
            return result.ToString();
        }
    }
}
