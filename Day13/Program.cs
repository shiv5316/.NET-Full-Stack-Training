<<<<<<< HEAD
﻿// using System;
// class Program
// {
//     static void Main()
//     {
//         string path=@"D:\CSharpTraining\Day13\data1.txt";
//         //File.WriteAllText(path, "File I/O Example in C#");
//         //File.WriteAllText(path, "helooo");
//         //Console.WriteLine("Data written to file.");

//         string content = File.ReadAllText("data1.txt");

//         Console.WriteLine("File Content:");
//         Console.WriteLine(content);

//     }
// }

/*
using System;
class Program
{
    static void Main()
    {
        using (StreamWriter writer=new StreamWriter("log.txt"))
        {
            writer.WriteLine("Application Started");
            writer.WriteLine("Processing data");
            writer.WriteLine("Application Ended");
        }
        using (StreamReader reader=new StreamReader("log.txt"))
        {
            string line;
            while((line=reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}
*/

// using System;
// using System.Data.Common;
// class User
// {
//     public int Id;
//     public string Name;
// }
// class Program
// {
//     static void Main()
//     {
        // User user=new User{Id=1,Name="Shivansh"};
        // using(StreamWriter writer=new StreamWriter("user.txt"))
        // {
        //     writer.WriteLine(user.Id);
        //     writer.WriteLine(user.Name);

        //     user.Id = 2;
		//     user.Name = "Anand";

        //     writer.WriteLine(user.Id);
        //     writer.WriteLine(user.Name);
        // }
        // Console.WriteLine("User data saved");
        // User user = new User();
        // using (StreamReader reader = new StreamReader("user.txt"))
        // {
        //     user.Id = int.Parse(reader.ReadLine());
        //     user.Name = reader.ReadLine();
        // }

        // Console.WriteLine($"User Loaded: {user.Id}, {user.Name}");

//         User user = new User { Id = 2, Name = "Bob" };
//         using (BinaryWriter writer = new BinaryWriter(File.Open("user.bin", FileMode.Create)))
//         {
//             writer.Write(user.Id);
//             writer.Write(user.Name);
//         }
//         Console.WriteLine("Binary user data saved.");
//     }
// }



//############################# How FileInfo Is Implemented  ####################################

// using System;
// using System.IO;
// class Program
// {
//     static void Main()
//     {
//         FileInfo file=new FileInfo("sample.txt");
//         if (!file.Exists)
//         {
//             using(StreamWriter writer = file.CreateText())
//             {
//                 writer.WriteLine("Hello FileInfo class");
//             }
//         }
//         Console.WriteLine("File Name: "+file.Name);
//         Console.WriteLine("File Size: "+file.Length+" bytes");
//         Console.WriteLine("Created On: " + file.CreationTime);

//     }
// }


//############################# How the Directory Class Is Implemented ####################################

// using System;
// using System.IO;
// class Program
// {
//     static void Main()
//     {
//         Directory.CreateDirectory("Logs");
//         if (Directory.Exists("Logs"))
//         {
//             Console.WriteLine("Logs directory created successfully..");
//         }

//     }
// }

/*

//############################### How DirectoryInfo Is Implemented ################################################

using System;
using System.IO;
class Program
{
    static void Main()
    {
        DirectoryInfo dir=new DirectoryInfo("Logs");
        if (!dir.Exists)
        {
            dir.Create();
        }
        Console.WriteLine("Directory Name: "+dir.Name);
        Console.WriteLine("Created On: " + dir.CreationTime);
        Console.WriteLine("Full Path: " + dir.FullName);
    }
}


//############################### Serialization Example  ################################################

using System;
using System.IO;
using System.Text.Json;
class User
{
    public int Id{get; set;}
    public string Name{get; set;}
}
class Program
{
    static void Main()
    {
        User user=new User{ Id = 1, Name = "Shivansh" };
        string json = JsonSerializer.Serialize(user);
        File.WriteAllText("user.json", json);
        Console.WriteLine("User serialized successfully.");
    }
}


//############################### Deserialization Code ###############################################

using System;
using System.IO;
using System.Text.Json;
class User
{
    public int Id{get; set;}
    public string Name{get; set;}
}

class Program
{
    static void Main()
    {
        string json = File.ReadAllText("user.json");

        User user = JsonSerializer.Deserialize<User>(json);

        Console.WriteLine($"User Loaded: {user.Id}, {user.Name}");
        
    }
}


//############################### XML Serialization  ###############################################
using System;
using System.IO;
using System.Xml.Serialization;
[Serializable]
public class User
{
    public int Id;
    public string Name;
}
class Program
{
    static void Main()
    {
        User user = new User { Id = 1, Name = "Alice" };
        XmlSerializer serializer = new XmlSerializer(typeof(User));
        using (FileStream fs = new FileStream("user.xml", FileMode.Create))
        {
            serializer.Serialize(fs, user);
        }

        Console.WriteLine("XML Serialized");
    }
}
*/

//############################### Json Serialization  ###############################################

using System;
using System.Runtime.CompilerServices;
class Program
{
    static void Main()
    {
        Program1.calculate();
    }
}

=======
﻿// using System;
// class Program
// {
//     static void Main()
//     {
//         string path=@"D:\CSharpTraining\Day13\data1.txt";
//         //File.WriteAllText(path, "File I/O Example in C#");
//         //File.WriteAllText(path, "helooo");
//         //Console.WriteLine("Data written to file.");

//         string content = File.ReadAllText("data1.txt");

//         Console.WriteLine("File Content:");
//         Console.WriteLine(content);

//     }
// }

/*
using System;
class Program
{
    static void Main()
    {
        using (StreamWriter writer=new StreamWriter("log.txt"))
        {
            writer.WriteLine("Application Started");
            writer.WriteLine("Processing data");
            writer.WriteLine("Application Ended");
        }
        using (StreamReader reader=new StreamReader("log.txt"))
        {
            string line;
            while((line=reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}
*/

// using System;
// using System.Data.Common;
// class User
// {
//     public int Id;
//     public string Name;
// }
// class Program
// {
//     static void Main()
//     {
        // User user=new User{Id=1,Name="Shivansh"};
        // using(StreamWriter writer=new StreamWriter("user.txt"))
        // {
        //     writer.WriteLine(user.Id);
        //     writer.WriteLine(user.Name);

        //     user.Id = 2;
		//     user.Name = "Anand";

        //     writer.WriteLine(user.Id);
        //     writer.WriteLine(user.Name);
        // }
        // Console.WriteLine("User data saved");
        // User user = new User();
        // using (StreamReader reader = new StreamReader("user.txt"))
        // {
        //     user.Id = int.Parse(reader.ReadLine());
        //     user.Name = reader.ReadLine();
        // }

        // Console.WriteLine($"User Loaded: {user.Id}, {user.Name}");

//         User user = new User { Id = 2, Name = "Bob" };
//         using (BinaryWriter writer = new BinaryWriter(File.Open("user.bin", FileMode.Create)))
//         {
//             writer.Write(user.Id);
//             writer.Write(user.Name);
//         }
//         Console.WriteLine("Binary user data saved.");
//     }
// }



//############################# How FileInfo Is Implemented  ####################################

// using System;
// using System.IO;
// class Program
// {
//     static void Main()
//     {
//         FileInfo file=new FileInfo("sample.txt");
//         if (!file.Exists)
//         {
//             using(StreamWriter writer = file.CreateText())
//             {
//                 writer.WriteLine("Hello FileInfo class");
//             }
//         }
//         Console.WriteLine("File Name: "+file.Name);
//         Console.WriteLine("File Size: "+file.Length+" bytes");
//         Console.WriteLine("Created On: " + file.CreationTime);

//     }
// }


//############################# How the Directory Class Is Implemented ####################################

// using System;
// using System.IO;
// class Program
// {
//     static void Main()
//     {
//         Directory.CreateDirectory("Logs");
//         if (Directory.Exists("Logs"))
//         {
//             Console.WriteLine("Logs directory created successfully..");
//         }

//     }
// }

/*

//############################### How DirectoryInfo Is Implemented ################################################

using System;
using System.IO;
class Program
{
    static void Main()
    {
        DirectoryInfo dir=new DirectoryInfo("Logs");
        if (!dir.Exists)
        {
            dir.Create();
        }
        Console.WriteLine("Directory Name: "+dir.Name);
        Console.WriteLine("Created On: " + dir.CreationTime);
        Console.WriteLine("Full Path: " + dir.FullName);
    }
}


//############################### Serialization Example  ################################################

using System;
using System.IO;
using System.Text.Json;
class User
{
    public int Id{get; set;}
    public string Name{get; set;}
}
class Program
{
    static void Main()
    {
        User user=new User{ Id = 1, Name = "Shivansh" };
        string json = JsonSerializer.Serialize(user);
        File.WriteAllText("user.json", json);
        Console.WriteLine("User serialized successfully.");
    }
}


//############################### Deserialization Code ###############################################

using System;
using System.IO;
using System.Text.Json;
class User
{
    public int Id{get; set;}
    public string Name{get; set;}
}

class Program
{
    static void Main()
    {
        string json = File.ReadAllText("user.json");

        User user = JsonSerializer.Deserialize<User>(json);

        Console.WriteLine($"User Loaded: {user.Id}, {user.Name}");
        
    }
}


//############################### XML Serialization  ###############################################
using System;
using System.IO;
using System.Xml.Serialization;
[Serializable]
public class User
{
    public int Id;
    public string Name;
}
class Program
{
    static void Main()
    {
        User user = new User { Id = 1, Name = "Alice" };
        XmlSerializer serializer = new XmlSerializer(typeof(User));
        using (FileStream fs = new FileStream("user.xml", FileMode.Create))
        {
            serializer.Serialize(fs, user);
        }

        Console.WriteLine("XML Serialized");
    }
}
*/

//############################### Json Serialization  ###############################################

using System;
using System.Runtime.CompilerServices;
class Program
{
    static void Main()
    {
        Program1.calculate();
    }
}

>>>>>>> c45fc69d5fbdbfb4fff8724ca36ffc9b5e9691a5
