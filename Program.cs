class Program
{
    static void Main(string[] args)
    {
        string inputFilePath = "C:\\Users\\artem\\OneDrive\\Рабочий стол\\ляляля.docx"; // путь к вашему текстовому файлу
        string outputFilePath = "C:\\Users\\artem\\OneDrive\\Рабочий столы\\ля.txt"; // путь к файлу для вывода результатов

        try
        {
            // Чтение содержимого файла
            string text = File.ReadAllText(inputFilePath);

            // Подсчет символов
            int totalCharacters = text.Length;

            // Подсчет символов без пробелов
            int charactersWithoutSpaces = text.Count(c => !char.IsWhiteSpace(c));

            // Подсчет слов
            int wordCount = text.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;

            // Формирование результатов
            string results = $"Количество символов: {totalCharacters}\n" +
                             $"Количество символов без пробелов: {charactersWithoutSpaces}\n" +
                             $"Количество слов: {wordCount}";

            // Вывод результатов в консоль
            Console.WriteLine(results);

            // Запись результатов в файл
            File.WriteAllText(outputFilePath, results);
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("Ошибка: файл не найден.");
            Console.WriteLine(ex.Message);
        }
        catch (IOException ex)
        {
            Console.WriteLine("Ошибка при чтении файла.");
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Произошла ошибка.");
            Console.WriteLine(ex.Message);
        }
    }
}