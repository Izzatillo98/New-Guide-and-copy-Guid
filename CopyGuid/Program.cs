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
                Console.WriteLine(DateTimeOffset.Now);

                TextCopy.ClipboardService.SetText($"{stringfieldGuid},{DateTimeOffset.Now.ToString()}");
                Console.WriteLine("Copied!");

                Console.WriteLine("do you want random Guid? (+ or press anyting to exit)");
                userInput = Console.ReadLine();
            }
            while (userInput == "+");

           

            
        }
    }
}
