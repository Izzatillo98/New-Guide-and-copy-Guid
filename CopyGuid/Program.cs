namespace CopyGuid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            string userInput;
            do
            {
                String stringfieldGuid = Guid.NewGuid().ToString();
                Console.WriteLine(stringfieldGuid);
                TextCopy.ClipboardService.SetText(stringfieldGuid);
                Console.WriteLine("Copied!");

                Console.WriteLine("do you want random Guid? (+ or press anyting to exit)");
                userInput = Console.ReadLine();
            }
            while (userInput == "+");

            do
            {
                Console.WriteLine(DateTimeOffset.Now);
                TextCopy.ClipboardService.SetText(DateTimeOffset.Now.ToString());
                Console.WriteLine("This Time");

                Console.WriteLine("Do you want UTC Now? (press + )");
                userInput = Console.ReadLine();

            }
            while (userInput == "+");

            
        }
    }
}
