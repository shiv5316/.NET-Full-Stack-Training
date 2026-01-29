using System.Collections.Generic;

namespace MiniSocialMedia
{
    public static class UserExtensions
    {
        public static IEnumerable<string> GetFollowingNames(this User user)
        {
            return user
                .GetType()
                .GetField("_following",
                    System.Reflection.BindingFlags.NonPublic |
                    System.Reflection.BindingFlags.Instance)!
                .GetValue(user) as IEnumerable<string>
                ?? new List<string>();
        }
    }
}
