namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Thanks for the Birthday wishes", true, "Luca D'Aprano");

            ImagePost imagePost1 = new ImagePost("Check out my new shoes", "Luca D'Aprano", 
                "https://images.com/shoes", true);

            VideoPost videoPost1 = new VideoPost("Fail Video", "Luca D'Aprano", 
                "https://video.com/failvideo", true, 10);

            Console.WriteLine(post1.ToString());
            Console.WriteLine(imagePost1.ToString());
            Console.WriteLine(videoPost1.ToString());

            videoPost1.Play();
            Console.WriteLine("Press any key to stop the video!");
            Console.ReadKey();
            videoPost1.Stop();
            Console.ReadLine();
        }

        // CHALLENGE - Add a child class "VideoPost" with a property VideoURL, Length.

        // Create the required constructors to create a VideoPost
        // adjust the ToString() method accordingly
        // Create an instance of VideoPost and use the ToString method on it

        /* More advanced - Use Timer and a Callback method here (Use Google)
         * Create fields as required
         * Add member methods "Play" which should write the current duration of the video
         * and "Stop" which should stop the "Timer" and write "stopped at {0}s" onto the console
         * Play the video after creating the instance and pause it, when the user presses any key
        */
    }
}
