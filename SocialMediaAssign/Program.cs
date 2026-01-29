using System;

namespace MiniSocialMedia
{
    class Program
    {
        static void Main()
        {
            var shivansh = new User("Shivansh", "shivansh@Mail.COM");
            var deepak = new User("Deepak", "deepak@mail.com");

            shivansh.OnNewPost += post =>
            {
                Console.WriteLine("New post created!");
            };

            shivansh.Follow("Deepak");
            shivansh.AddPost("Learning C# is fun #dotnet #coding");

            Console.WriteLine(shivansh.GetDisplayName());
            Console.WriteLine();
            Console.WriteLine(shivansh.GetPosts()[0]);
        }
    }
}
