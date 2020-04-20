using System;

namespace ConsoleApp1
{
    class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        private DateTime DateTime { get; set; }
        private int upvote=0;
        private int downvote=0;

        public void Upvote()
        {
            upvote = upvote + 1;
        }

        public void Downvote()
        {
            downvote = downvote + 1;
        }

        public void TotalVote()
        {
            Console.WriteLine("Upvotes are:"+upvote+"Downvotes are:"+downvote);
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post();
            post.Title = "Richest Person";
            post.Description = "Person having most money in "+DateTime.Now;

            while(true)
            {
              //  int upvote = 0;
              //  int downvote = 0;
                Console.WriteLine("Enter 1 to upvote or 0 to downvote for the post to exit press -1");
                var vote =Convert.ToInt32( Console.ReadLine());
                if (vote == 1)
                {
                    post.Upvote();
                }
                else if(vote == 0)
                {
                    post.Downvote();
                }
                else
                {
                    post.TotalVote();
                    break;
                }
                    

            }

           
        }
    }
}
