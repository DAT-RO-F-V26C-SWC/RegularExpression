using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressionApp
{
    internal class AWorker
    {
        private String Text =
            "Two swindlers arrive at the capital city of an emperor " +
            "who spends lavishly on clothing at\r\nthe expense of state matters. " +
            "Posing as weavers, they offer to supply him with magnificent\r\nclothes " +
            "that are invisible to those who are stupid or incompetent. " +
            "The emperor hires them,\r\nand they set up looms and go to work. " +
            "A succession of officials, and then the emperor himself,\r\nvisit them to check their progress. " +
            "Each sees that the looms are empty but pretends otherwise\r\nto avoid being thought a fool. " +
            "Finally, the weavers report that the emperor's suit is finished." +
            "\r\nThey mime dressing him and he sets off in a procession before the whole city. " +
            "The townsfolk\r\nuncomfortably go along with the pretense, not wanting to appear inept or stupid, " +
            "until a child\r\nblurts out that the emperor is wearing nothing at all. " +
            "The people then realize that everyone\r\nhas been fooled. Although startled, " +
            "the emperor continues the procession, walking more\r\nproudly than ever.";

        public AWorker()
        {
        }

        public void Start()
        {
            // 3.1 find indexes of e/Emperor
            Console.WriteLine("Find indexes of emperor (lower or upper case e)");
            String pattern1 = "(e|E)mperor"; // [eE]mperor

            MatchCollection matches = Regex.Matches(Text, pattern1);
            foreach (Match m in matches)
            {
                Console.WriteLine("har index: " + m.Index);
            }
            Console.WriteLine();


            // 3.2 Change the ‘emperor’ to ‘teacher’
            Console.WriteLine("Change the ‘emperor’ to ‘teacher’");
            String pattern2a = "emperor";
            String pattern2b = "Emperor";

            String ReplacedText = Regex.Replace(Text, pattern2a, "teacher");
            ReplacedText = Regex.Replace(ReplacedText, pattern2b, "Teacher");

            Console.WriteLine(ReplacedText);
            Console.WriteLine();

            // 3.3 Capture sentences 
            Console.WriteLine("Find all sentences");
            String pattern3 = @"([a-zA-Z,' \r\n]+\.)";

            MatchCollection matches3 = Regex.Matches(Text, pattern3);
            foreach (Match m in matches3)
            {
                Console.WriteLine();
                Console.WriteLine("New sentence");
                String NiceText = Regex.Replace(m.Captures[0].Value, @"^ ", "");
                NiceText = Regex.Replace(NiceText, @"\r\n", " ");
                Console.WriteLine(NiceText);
            }

        }
    }
}
