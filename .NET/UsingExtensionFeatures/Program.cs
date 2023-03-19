namespace StringExtensionFeatures
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Extension Features");

            var wordToFind = "coding";
            int index = "Hello my friend I love coding very much".FindWordIndex(wordToFind);
            Console.WriteLine($"I found the word: {wordToFind} at index: {index}");

            var secondWordToFind = "very";
            int secondIndex = "Hello my friend I love coding very much".FindWordIndex(secondWordToFind);
            Console.WriteLine($"I found the word: {secondWordToFind} at index: {secondIndex}");


            XRRig picoXRRig = new XRRig("room", 0);
            Console.WriteLine($"What's my PICO space: {picoXRRig.FindXRRigSpace()}");

            XRRig questProXRRig = new XRRig("stationary", 5);
            Console.WriteLine($"What's my Meta Quest pro space: {questProXRRig.FindXRRigSpace()}");
        }
    }
}