# Bowling-Project
Write a class that reads in a list of players' bowling scores and calculates the final score (rules to follow). 
         * The score (Ex: "X 7/ 72 9/ X X X 23 6/ 7/3") must be read from a .txt file and the final score (168) must be 
         * written to the same file without disturbing the original content. 

        Example input strings:
        "X 7/ 72 9/ X X X 23 6/ 7/3" (which would result in 168 points)
        "5/ 81 X 0/ 52 70 7/ 9/ 54 90" (which would result in 128 points)
        "X X X X X X X X X XXX" (which would result in 300 points)
        Scoring rules:
        One game of bowling contains 10 frames. For each frame, a bowler gets a maximum of two attempts to knock down 10 pins. If the bowler 
        knocks down all 10 pins on the first attempt, it is called a strike. The 10th frame allows a third roll if a strike or spare is recorded.

        A strike is notated with a X. A spare is notated with the number of pins knocked down with the first ball in the frame followed by a /. 
        This can be seen in the above example. 

        A strike (knocking down all 10 pins in the first roll) is worth 10, plus the value of the bowler’s next two rolls. 
        At the very least, your score for a frame in which you toss a strike will be 10 (10 + 0 + 0). 
        If your next two shots are strikes, the frame will be worth 30 (10 + 10 + 10).

        A spare (knocking down all 10 pins in two rolls) is worth 10, plus the value of the bowler’s next roll.
        Completing a spare in the first frame and knocking down four pins with the first roll of the next frame will result in 
        the score of 14 for the first frame. The maximum score for a frame in which the bowler records a spare is 20 (spare + strike). 
        The final score is the sum of each individual frame

        static void Main()
    {

        // These examples assume a "C:\Users\Public\TestFolder" folder on your machine.
        // You can modify the path if necessary.
        

        


        // Example #2: Write one string to a text file.
        string text = "A class is the most powerful data type in C#. Like a structure, " +
                       "a class defines the data and behavior of the data type. ";
        // WriteAllText creates a file, writes the specified string to the file,
        // and then closes the file.    You do NOT need to call Flush() or Close().
        System.IO.File.WriteAllText(@"C:\Users\Public\TestFolder\WriteText.txt", text);

        // Example #3: Write only some strings in an array to a file.
        // The using statement automatically flushes AND CLOSES the stream and calls 
        // IDisposable.Dispose on the stream object.
        // NOTE: do not use FileStream for text files because it writes bytes, but StreamWriter
        // encodes the output as text.
        using (System.IO.StreamWriter file = 
            new System.IO.StreamWriter(@"C:\Users\Public\TestFolder\WriteLines2.txt"))
        {
            foreach (string line in lines)
            {
                // If the line doesn't contain the word 'Second', write the line to the file.
                if (!line.Contains("Second"))
                {
                    file.WriteLine(line);
                }
            }
        }

        // Example #4: Append new text to an existing file.
        // The using statement automatically flushes AND CLOSES the stream and calls 
        // IDisposable.Dispose on the stream object.
        using (System.IO.StreamWriter file = 
            new System.IO.StreamWriter(@"C:\Users\Public\TestFolder\WriteLines2.txt", true))
        {
            file.WriteLine("Fourth line");
        }