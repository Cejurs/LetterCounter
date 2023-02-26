using LetterCounter;
while (true)
{
    Console.WriteLine("Введите путь до файла");
    var filepath = Console.ReadLine();
    var result = Counter.Count(filepath);
    Console.Write(result);
}
