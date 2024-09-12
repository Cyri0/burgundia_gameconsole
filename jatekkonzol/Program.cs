namespace jatekkonzol
{
    internal class Program
    {
        static void HangmanStatusPrint(string status) {
            for(int poz = 0; poz < status.Length; poz++)
            {
                Console.Write(status[poz] + " ");
            }
            Console.WriteLine();
        }

        static void Hangman() {
            string[] words = ["HANGMAN", "PIXEL", "MECHWART"];

            Random rnd = new Random();
            int randomSzam = rnd.Next(words.Length);
            string word = words[randomSzam];

            string status = "";
            // Feltöltjük a status-t megfelelő mennyiségű _-al
            for(int i = 0; i < word.Length; i++)
            {
                status += "_";
            }

            while (word != status)
            {
                HangmanStatusPrint(status);
                Console.Write("Tipp: ");
                char key = Console.ReadKey().KeyChar;
                Console.WriteLine();

                string newStatus = "";

                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == key)
                    {
                        newStatus += word[i];
                    }
                    else
                    {
                        newStatus += status[i];
                    }
                }
                status = newStatus;
            }
            Console.WriteLine("Gratulálok, a szó a " + word + " volt!");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Hangman();
        }
    }
}
