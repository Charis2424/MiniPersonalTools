using MiniPersonalTools.Services;

namespace MiniPersonalTools
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Check if 2 string is anagram
            AnagramValidator validator = new AnagramValidator();
            Console.WriteLine("The 2 strings is anagram = ");
            Console.WriteLine(validator.IsAnagram("yolo", "oloy"));

            // Replace a string Sequence with ","
            string stringSequence = "yo\r\nlo\r\nonce\r\nlol";
            string stringReplaceWithComa = "\r\n";
            StringModifier stringModifier = new StringModifier(stringSequence,stringReplaceWithComa);

            //Check a string array or a string if is XML syntax correct
            string[] xmlStringArray = new string[]
            {
                "<xml><p> yo </p></xml>",
                "",
            };
            xmlValidator xmlValidator = new xmlValidator(xmlStringArray);
        }
    }
}