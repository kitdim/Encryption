using static System.Console;
namespace Encryption.Process;
static class Process
{
    const int key = 1988;
    
    public static void Run()
    {
        WriteLine("Введи текст");
        var text = ReadLine().ToCharArray();

        WriteLine("\nЗашифрованное");
        for (var i = 0; i < text.Length; i++)
        {
            text[i] = (char)(text[i] ^ key);
        }
        foreach (var item in text)
            Write(item);

        WriteLine("\nРасшифрованное");
        for (var i = 0; i < text.Length; i++)
        {
            text[i] = (char)(text[i] ^ key);
        }
        foreach (var item in text)
            Write(item);
    }
}