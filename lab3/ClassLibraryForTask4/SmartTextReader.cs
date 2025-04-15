namespace ClassLibraryForTask4
{
    public class SmartTextReader
    {
        public char[][] ReadText(string filePath)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                char[][] result = new char[lines.Length][];

                for (int i = 0; i < lines.Length; i++)
                {
                    result[i] = lines[i].ToCharArray();
                }

                return result;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Файл не знайдено!");
                return null;
            }
        }
    }
}
