using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace MiniSocialMedia
{
    public class SocialExceptin : Exception
    {
        public SocialExceptin(string message) : base(message){ }
        public SocialException(string message, Exception inner) : base(message, inner) { }   
    }
    public interface IPostable
    {
        void AddPost(string content);
        IReadOnlyList<SendOrPostCallback> GetPosts();
    }
    public partial class User : IPostable, IComparable<User>
    {
        
    }
}