internal class Program
{
    static void Main(string[] args)
    {
        Console.InputEncoding = System.Text.Encoding.Unicode;
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.WriteLine("Напишіть свій текст:");
        string str = Console.ReadLine();
        int flag = 0;
        int start = 0, end = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == ';')
            {
                if (flag == 3)
                {
                    end = i;
                    Console.WriteLine("\nID: ");
                    Console.Write(str.Substring(start, end - start));
                    break;
                }
                flag++;
                if (flag == 3)
                {
                    start = i + 1;
                }
            }
        }
        Console.ReadKey();
    }
}