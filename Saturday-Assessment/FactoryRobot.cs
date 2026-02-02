// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Text.RegularExpressions;
// using System.IO;
// using System.Text.Json;

// namespace MiniSocialMedia
// {
//     // ===================== INTERFACE =====================
//     public interface IPostable
//     {
//         void AddPost(string content);
//         IReadOnlyList<Post> GetPosts();
//     }

//     // ===================== CUSTOM EXCEPTION =====================
//     public class SocialException : Exception
//     {
//         public SocialException(string message) : base(message) { }
//         public SocialException(string message, Exception inner) : base(message, inner) { }
//     }

//     // ===================== GENERIC REPOSITORY =====================
//     public class Repository<T> where T : class
//     {
//         private readonly List<T> _items = new();

//         public void Add(T item) => _items.Add(item);
//         public IReadOnlyList<T> GetAll() => _items.AsReadOnly();
//         public T? Find(Predicate<T> match) => _items.Find(match);
//     }

//     // ===================== POST =====================
//     public class Post
//     {
//         public User Author { get; }
//         public string Content { get; }
//         public DateTime CreatedAt { get; }

//         public Post(User author, string content)
//         {
//             Author = author ?? throw new ArgumentNullException(nameof(author));
//             Content = content;
//             CreatedAt = DateTime.UtcNow;
//         }

//         public override string ToString()
//         {
//             var sb = new StringBuilder();
//             sb.AppendLine($"{Author} • {CreatedAt:MMM dd HH:mm}");
//             sb.AppendLine(Content);

//             var hashtags = Regex.Matches(Content, @"#[A-Za-z]+");
//             if (hashtags.Count > 0)
//             {
//                 sb.Append("Tags: ");
//                 sb.AppendJoin(", ", hashtags.Cast<Match>().Select(m => m.Value));
//             }

//             return sb.ToString().TrimEnd();
//         }
//     }

//     // ===================== USER =====================
//     public class User : IPostable, IComparable<User>
//     {
//         public string Username { get; init; }
//         public string Email { get; init; }

//         private readonly List<Post> _posts = new();
//         private readonly HashSet<string> _following = new(StringComparer.OrdinalIgnoreCase);

//         public event Action<Post>? OnNewPost;

//         public User(string username, string email)
//         {
//             if (string.IsNullOrWhiteSpace(username))
//                 throw new ArgumentException("Invalid username");

//             if (!Regex.IsMatch(email ?? "", @"^[^@]+@[^@]+\.[^@]+$"))
//                 throw new SocialException("Invalid email format");

//             Username = username.Trim();
//             Email = email.Trim().ToLower();
//         }

//         public void Follow(string username)
//         {
//             if (string.Equals(username, Username, StringComparison.OrdinalIgnoreCase))
//                 throw new SocialException("Cannot follow yourself");

//             _following.Add(username);
//         }

//         public void AddPost(string content)
//         {
//             if (string.IsNullOrWhiteSpace(content))
//                 throw new ArgumentException("Post content cannot be empty");

//             if (content.Length > 280)
//                 throw new SocialException("Post too long (max 280 characters)");

//             var post = new Post(this, content.Trim());
//             _posts.Add(post);
//             OnNewPost?.Invoke(post);
//         }

//         public IReadOnlyList<Post> GetPosts() => _posts.AsReadOnly();

//         public int CompareTo(User? other)
//         {
//             if (other == null) return 1;
//             return string.Compare(Username, other.Username, StringComparison.OrdinalIgnoreCase);
//         }

//         public override string ToString() => "@" + Username;

//         public string GetDisplayName() => $"User: {Username} <{Email}>";
//     }

//     // ===================== EXTENSIONS =====================
//     public static class SocialUtils
//     {
//         public static string FormatTimeAgo(this DateTime dt)
//         {
//             var diff = DateTime.UtcNow - dt;

//             if (diff.TotalSeconds < 60) return "just now";
//             if (diff.TotalMinutes < 60) return $"{(int)diff.TotalMinutes} min ago";
//             if (diff.TotalHours < 24) return $"{(int)diff.TotalHours} h ago";

//             return dt.ToString("MMM dd");
//         }
//     }

//     // ===================== PROGRAM =====================
//     class Program
//     {
//         static Repository<User> _users = new();
//         static User? _currentUser = null;
//         static readonly string _dataFile = "social-data.json";

//         static void Main()
//         {
//             Console.Title = "MiniSocialMedia";
//             LoadData();

//             while (true)
//             {
//                 try
//                 {
//                     if (_currentUser == null)
//                         ShowLoginMenu();
//                     else
//                         ShowMainMenu();
//                 }
//                 catch (SocialException ex)
//                 {
//                     WriteColor("Error: " + ex.Message, ConsoleColor.Red);
//                 }
//                 catch (Exception ex)
//                 {
//                     WriteColor("Unexpected error!", ConsoleColor.Red);
//                     LogError(ex);
//                 }

//                 Console.WriteLine("\nPress any key...");
//                 Console.ReadKey();
//                 Console.Clear();
//             }
//         }

//         static void ShowLoginMenu()
//         {
//             Console.WriteLine("1. Register\n2. Login\n3. Exit");
//             var ch = Console.ReadLine();

//             if (ch == "1") Register();
//             else if (ch == "2") Login();
//             else if (ch == "3")
//             {
//                 SaveData();
//                 Environment.Exit(0);
//             }
//         }

//         static void Register()
//         {
//             Console.Write("Username: ");
//             var u = Console.ReadLine();

//             Console.Write("Email: ");
//             var e = Console.ReadLine();

//             if (_users.Find(x => x.Username.Equals(u, StringComparison.OrdinalIgnoreCase)) != null)
//                 throw new SocialException("Username already exists");

//             _users.Add(new User(u!, e!));
//             Console.WriteLine("Registered successfully!");
//         }

//         static void Login()
//         {
//             Console.Write("Username: ");
//             var u = Console.ReadLine();

//             var user = _users.Find(x => x.Username.Equals(u, StringComparison.OrdinalIgnoreCase));
//             if (user == null)
//                 throw new SocialException("User not found");

//             _currentUser = user;
//             _currentUser.OnNewPost += p =>
//                 WriteColor($"[Notification] {p.Author} posted a new post!", ConsoleColor.Yellow);

//             Console.WriteLine("Login successful!");
//         }

//         static void ShowMainMenu()
//         {
//             Console.WriteLine($"Logged in as {_currentUser}");
//             Console.WriteLine("1. Post\n2. View my posts\n3. List users\n4. Logout");

//             var ch = Console.ReadLine();

//             if (ch == "1") PostMessage();
//             else if (ch == "2") ShowPosts(_currentUser!.GetPosts());
//             else if (ch == "3") ListUsers();
//             else if (ch == "4") _currentUser = null;
//         }

//         static void PostMessage()
//         {
//             Console.Write("Post: ");
//             var text = Console.ReadLine();
//             if (!string.IsNullOrWhiteSpace(text))
//                 _currentUser!.AddPost(text);
//         }

//         static void ShowPosts(IEnumerable<Post> posts)
//         {
//             if (!posts.Any())
//             {
//                 Console.WriteLine("No posts.");
//                 return;
//             }

//             foreach (var p in posts.OrderByDescending(p => p.CreatedAt))
//             {
//                 Console.WriteLine(p);
//                 Console.WriteLine($"({p.CreatedAt.FormatTimeAgo()})");
//                 Console.WriteLine("--------------------------");
//             }
//         }

//         static void ListUsers()
//         {
//             foreach (var u in _users.GetAll().OrderBy(x => x))
//                 Console.WriteLine(u.GetDisplayName());
//         }

//         static void SaveData()
//         {
//             var json = JsonSerializer.Serialize(_users.GetAll());
//             File.WriteAllText(_dataFile, json);
//         }

//         static void LoadData()
//         {
//             if (!File.Exists(_dataFile)) return;

//             var json = File.ReadAllText(_dataFile);
//             var users = JsonSerializer.Deserialize<List<User>>(json);
//             if (users == null) return;

//             foreach (var u in users)
//                 _users.Add(u);
//         }

//         static void LogError(Exception ex)
//         {
//             File.AppendAllText("error.log", $"{DateTime.Now}\n{ex}\n------\n");
//         }

//         static void WriteColor(string msg, ConsoleColor color)
//         {
//             var old = Console.ForegroundColor;
//             Console.ForegroundColor = color;
//             Console.WriteLine(msg);
//             Console.ForegroundColor = old;
//         }
//     }
// }


//#################################### Petty Case Manager ############################################endregion

// using System;
// using System.Collections.Generic;
// using System.Linq;
// namespace PettyCaseManager
// {
//     enum TransactionStatus{Pending,Approved,Rejected}
//     enum Category{Stationery,Travel,Refreshments,Courier}
//     abstract class Transaction
//     {
        
//     }
// }

//#################################### Reflection ############################################endregion

// using System;
// using library;
// namespace library
// {
//     public interface I1
//     {
//         void m1();
//         void m2();
//     }
// }
// public class A : I1
// {
//     public void m1()
//         {
//             Console.WriteLine("Method m1 executed");
//         }
//         public void m2()
//         {
//             Console.WriteLine("Method m2 executed");
//         }
// }
// class Program
// {
//     static void Main()
//     {
//         A obj = new A();
//         obj.m1();
//         obj.m2();
//     }
// }


using System;
public class RobotSafetyException : Exception
{
    public RobotSafetyException(string message) : base(message)
    {
        
    }
}
public class RobotAuditor
{
    public double CalculateHazardRisk(double armPrecision,int workerDensity,string machineryState)
    {
        if(armPrecision<0.0 || armPrecision>1.0)
        {
            throw new RobotSafetyException("Error:  Arm precision must be 0.0-1.0");
        }
        if(workerDensity<1 || workerDensity > 20)
        {
            throw new RobotSafetyException("Error: Worker density must be 1-20");
        }

        double MachineRiskFactor;
        if (machineryState == "Worn")
            MachineRiskFactor=1.3;
        else if (machineryState=="Faulty")
            MachineRiskFactor=2.0;
        else if (machineryState=="Critical")
            MachineRiskFactor=3.0;
        else 
        throw new RobotSafetyException("Error: Unsupported machinery state");

        double hazardRisk=((1.0-armPrecision)*15.0)+(workerDensity*MachineRiskFactor);
        return hazardRisk;
    }
    public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter Arm Precision (0.0 - 1.0):");
            double armPrecision = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Worker Density (1 - 20):");
            int workerDensity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Machinery State (Worn/Faulty/Critical):");
            string machineryState = Console.ReadLine();

            RobotAuditor auditor = new RobotAuditor();

            double risk = auditor.CalculateHazardRisk(armPrecision, workerDensity, machineryState);

            Console.WriteLine("Robot Hazard Risk Score: " + risk);
        }
        catch (RobotSafetyException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
}