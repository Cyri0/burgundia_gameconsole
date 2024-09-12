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

        static void DrawMap(char[][] map) {
            /*
             0  1  2
            [ ][ ][ ] 0
            [ ][ ][ ] 1
            [ ][ ][ ] 2

                 0       1       2
             [[0,1,2,3],[0,1,2,3],[0,1,2,3]]
            */

            Console.WriteLine(" 0  1  2");
            for (int s = 0; s < map.Length; s++) {
                for(int o = 0; o < map[s].Length; o++)
                {
                    Console.Write("[" + map[s][o] + "]");
                }
                Console.Write(" " + s);
                Console.WriteLine();
            }
        }

        static int ReadNumber(string label)
        {
            Console.Write(label);
            char numChar = Console.ReadKey().KeyChar;
            int num = int.Parse("" + numChar);
            Console.WriteLine();
            return num;
        }

        static void TicTacToe() {
            char[][] map = [
                [' ',' ',' '],
                [' ',' ',' '],
                [' ',' ',' ']
            ];

            DrawMap(map);

            int sor = ReadNumber("Sor: ");
            int oszlop = ReadNumber("Oszlop: ");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // Hangman();
            TicTacToe();

            /*
                 Ez egy
                 több soros
                 komment
                 !!!!
            */
        }
    }
}
