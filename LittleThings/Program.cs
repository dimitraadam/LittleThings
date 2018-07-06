using System;

namespace LittleThings
{
    class Program
    {
        static void Main(string[] args)
        {
            //test Palindrome class
            Palindrome p = new Palindrome();

            Console.WriteLine(p.IsPalindrome("Deleveled"));
            Console.WriteLine(p.IsPalindrome("Anna"));
            Console.WriteLine(p.IsPalindrome("Dimitra"));
            Console.WriteLine(p.IsPalindrome("apva"));

            //------------------------------------------------------
            //test Folders class
            string xml =
                           "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                           "<folder name=\"c\">" +
                               "<folder name=\"program files\">" +
                                   "<folder name=\"uninstall information\" />" +
                               "</folder>" +
                               "<folder name=\"users\" />" +
                           "</folder>";

            foreach (string name in Folders.FolderNames(xml, 'u'))
                Console.WriteLine(name);


            string xml2 =
                           "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                           "<folder name=\"portal\">" +
                               "<folder name=\"something borrow\">" +
                                   "<folder name=\"pineapple incident\" />" +
                               "</folder>" +
                               "<folder name=\"users\" />" +
                           "</folder>";

            foreach (string name in Folders.FolderNames(xml2, 'p'))
                Console.WriteLine(name);

            //------------------------------------------------------
            //test User interface classes
            UserInterface.TextInput txtInput = new UserInterface.TextInput();
            txtInput.Add('1');
            txtInput.Add('a');
            txtInput.Add('0');
            Console.WriteLine("txtInput: " + txtInput.GetValue());

            UserInterface.NumericInput numInput = new UserInterface.NumericInput();
            numInput.Add('1');
            numInput.Add('a');
            numInput.Add('0');
            Console.WriteLine("numInput: " + numInput.GetValue());

            Console.WriteLine(UserInterface.GoatLatinConverter.ToGoatLatin("I speak Goat Latin Dimitra Antigoni Lida Aris Eleni"));

            Console.ReadLine();



        }



    }



}
