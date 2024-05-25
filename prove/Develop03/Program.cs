    class Program
    {
        static void Main(string[] args)
        {
            string originalText = "Hello this is a simple test to blank out words randomly.";
            List<string> words = originalText.Split(' ').ToList();
            List<bool> visible = new List<bool>(words.Select(_ => true)); // Track visibility of each word.

            Random random = new Random();

            Console.WriteLine(originalText); // Display the initial text.

            while (visible.Any(v => v)) // Run until all words are blanked out.
            {
                Console.ReadLine(); // Wait for the user to press a key.

                int indexToHide;
                do
                {
                    indexToHide = random.Next(words.Count); // Select a random word to hide.
                }
                while (!visible[indexToHide]); // Ensure the selected word is currently visible.

                visible[indexToHide] = false; // Set the word to be invisible.

                for (int i = 0; i < words.Count; i++)
                {
                    
                    if (visible[i])
                    {
                        Console.Write(words[i] + " "); // Display visible words.
                    }
                    else
                    {
                        Console.Write(new string('_', words[i].Length) + " "); // Display underscores for hidden words.
                    }
                }

                Console.WriteLine(); // Move to the next line.
            }

            Console.WriteLine("\nAll words have been blanked out. Press any key to exit.");
            Console.ReadLine();
        }
    }
