using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Exercise_2
{
    public class Post
    {
        private String title;
        private String description;
        private DateTime time;
        private String vote;
        private int upVote, downVote,votes;

        public void CreatePost()
        {
            Console.WriteLine("Enter Title : ");
            title = Console.ReadLine();

            Console.WriteLine("Enter Description : ");
            description = Console.ReadLine();

            Console.WriteLine("Enter U to up-vote.. Enter D to down-vote.. ");
            vote = Console.ReadLine();

            while (vote == "u" || vote == "d")
            {
                if (vote == "u")
                {
                    upVote++;
                 
                }
                else if (vote == "d")
                {
                    downVote++;
   
                }
                vote = Console.ReadLine();
            }

            if (upVote > downVote)
            {
                votes = upVote - downVote;
            } else if (downVote > upVote)
            {
                votes = downVote - upVote;
            } 

            Console.WriteLine("Title : {0}", title);
            Console.WriteLine("Description : {0}", description);
            Console.WriteLine("Up Votes : {0}", upVote);
            Console.WriteLine("Down Votes : {0}", downVote);
            Console.WriteLine("Votes : {0}", votes);
            Console.WriteLine("Post created at : {0}", DateTime.Now.ToString());


        }



    }
}
