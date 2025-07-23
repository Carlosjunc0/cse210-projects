using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<Video> videoList = new List<Video>();

        // Video 1
        Video video1 = new Video();
        video1.Title = "Skilly, the new skin care routine";
        video1.Author = "Sohara Pharmaceuticals";
        video1.Length = 600;
        video1.AddComment(new Comment("Harvey", "I've been using this for a week and I can already see the difference."));
        video1.AddComment(new Comment("Ann", "This is the best skin care routine I have ever tried."));
        video1.AddComment(new Comment("Peter", "I love the natural ingredients in this product."));

        videoList.Add(video1);

        // Video 2
        Video video2 = new Video();
        video2.Title = "Doken, the new soap bar for sensitive skin";
        video2.Author = "Sohara Pharmaceuticals";
        video2.Length = 900;
        video2.AddComment(new Comment("Karen", "This soap is amazing! My skin feels so soft."));
        video2.AddComment(new Comment("Kelly", "I love it!"));
        video2.AddComment(new Comment("Jeremiah", "Great for sensitive skin."));

        videoList.Add(video2);

        // Video 3
        Video video3 = new Video();
        video3.Title = "Duki, the new body lotion for dry skin";
        video3.Author = "Sohara Pharmaceuticals";
        video3.Length = 720;
        video3.AddComment(new Comment("Lucy", "Smells great and hydrates well."));
        video3.AddComment(new Comment("Katy", "Really moisturizing."));
        video3.AddComment(new Comment("Sophia", "I use it every day after showering."));

        videoList.Add(video3);

        foreach (Video v in videoList)
        {
            Console.WriteLine("Title: " + v.Title);
            Console.WriteLine("Author: " + v.Author);
            Console.WriteLine("Length: " + v.Length + " seconds");
            Console.WriteLine("Number of comments: " + v.GetNumberOfComments());

            Console.WriteLine("Comments:");
            foreach (Comment c in v.Comments)
            {
                Console.WriteLine("- " + c.Name + ": " + c.Text);
            }

            Console.WriteLine();
        }
    }
}
