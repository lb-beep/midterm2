using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;


namespace CS_131_Projects
{
    public class User
    {
        public string name { get; set; }
        public string comment { get; set; }
        
        
        static void Main()
        {
            User accountUser = new User();
            accountUser.name = "Luis";
            List<string> UserName = new List<string>();
            UserName.Add("Luis");
            UserName.Add("Amanda");
            UserName.Add("Rob");

            foreach(var option1 in UserName)
            {
                Console.WriteLine(option1);
            }

            User UserComment = new User();
            List<string> Comments = new List<string>();
            Comments.Add("You are the best!");
            Comments.Add("I like it here");
            Comments.Add("The weather is not good!");
            foreach(var option2 in Comments)
            {
                Console.WriteLine(option2);
            }

        }
    }


}

