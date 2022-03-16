namespace MorseCodeEN_DE_Coder
{
    class Program
    {
        static void Main(string[] args)
        {
            var morse = new Dictionary < char, string>();
            morse.Add("1", ".----");
            morse.Add("2", "..---");
            morse.Add("3", "...--");
            morse.Add("4", "....-");
            morse.Add("5", ".....");
            morse.Add("6", "-....");
            morse.Add("7", "--...");
            morse.Add("8", "---..");
            morse.Add("9", "----.");
            morse.Add("0", "-----");

            morse.Add(" ", " ");

            morse.Add("a", ".-");
            morse.Add("b", "-...");
            morse.Add("c", "-.-.");
            morse.Add("d", "-..");
            morse.Add("e", ".");
            morse.Add("f", "..-.");
            morse.Add("g", "--.");
            morse.Add("h", "....");
            morse.Add("i", "..");
            morse.Add("j", ".---");
            morse.Add("k", "-.-");
            morse.Add("l", ".-..");
            morse.Add("m", "--");
            morse.Add("n", "-.");
            morse.Add("o", "---");
            morse.Add("p", ".--.");
            morse.Add("q", "--.-");
            morse.Add("r", ".-.");
            morse.Add("s", "...");
            morse.Add("t", "-");
            morse.Add("u", "..-");
            morse.Add("v", "...-");
            morse.Add("w", ".--");
            morse.Add("x", "-..-");
            morse.Add("y", "-.--");
            morse.Add("z", "--..");

            Console.WriteLine(morse['a'])
            

        }
    }
}