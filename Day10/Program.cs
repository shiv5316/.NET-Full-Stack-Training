<<<<<<< HEAD
<<<<<<< HEAD
﻿using System;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;
class Program
{
    public static void Main()
    {
        /*
        string sent="abc123";
        string sent="123_123";
        string sent="abc";
        string pattern=@"\d";
        bool result=Regex.IsMatch(sent,pattern);
        Console.WriteLine(result);
        
        string sent="Amount:5000"; 
        string pattern=@"\d+"; ## It will return 5000(digit)
        string pattern=@"\d*";   ## It will return empty string
        Match m=Regex.Match(sent,pattern);
        Console.WriteLine(m.value);

        */

        //string sent="10A20B30C";
        //string sent="10 20 30";
        //string pattern=@"\d+";
        //string pattern=@"\D";

        //string pattern=@"\w";
        //string pattern=@"\W";

        //string sent="10A20B30C!@_";
        //string sent="10 20 30 !@_";
        //string sent="10A20B30C!@_abc";
        //string sent="10A20B30C!@_abc _   ";

        //string pattern=@"\s";
        //string pattern=@"\S";


        //string sent="10A20B30C!@_abc _0!_file.txt \t";
        //string pattern=@"\.txt";
        // string sent="10A20B30C!@_abc _0! C:\abc\file.txt \t";
        // string pattern=@"\\";


        // string sent="?10A20B30C!@_abc _0! C:\abc\file.txt?";
        // string pattern=@"\?";


        //string sent="Hello?10A20B30C!@_abc _0!\t,C:\abc\file.txt?Hello";
        //string pattern=@"Hello$";
        //string pattern=@"^Hello";

        // MatchCollection matches=Regex.Matches(sent,pattern);
        // foreach (Match m in matches)
        // {
        //     Console.Write(m.Value + " ");
        // }

        // Match m = Regex.Match("Date: 2025-12-29", @"(\d{4})-(\d{2})-(\d{2})");
        // Console.WriteLine(m.Value);      

        // string sent="Amount:5000"; 
        // string pattern = @"Amount:(?<value>\d+)";

        // Match m=Regex.Match(sent,pattern);
        // Console.WriteLine(m.Value);
// ##########################################################################################################################
        // string pattern= @"(?<year>\d{4})-(?<month>\d{2})-(?<date>\d{2})";
        // string input="2005-02-15";
        //Match m=Regex.Match(input,pattern);
        // Console.WriteLine(m.Groups["year"].Value);
        // Console.WriteLine(m.Groups["month"].Value);
        // Console.WriteLine(m.Groups["date"].Value);

// ############################################################################################################################
        // MatchCollection matches=Regex.Matches(input,pattern);
        // foreach (Match m in matches)
        // {
            // Console.WriteLine(m.Groups["year"].Value);
            // Console.WriteLine(m.Groups["month"].Value);
            // Console.WriteLine(m.Groups["date"].Value);
        //     Console.WriteLine(m.Groups[0].Value);
        //     Console.WriteLine(m.Groups[1].Value);
        //     Console.WriteLine(m.Groups[2].Value);
        //     Console.WriteLine(m.Groups[3].Value);
        // }
        


        string input="shivansh.12216777@lpu.in";
        string pattern=@"\b[\w.-]+@[\w-]+\.\w{2,}\b";
        if (Regex.IsMatch(input, pattern))
        {
            Console.WriteLine("Valid Email");
        }
    }
}
=======
﻿using System;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;
class Program
{
    public static void Main()
    {
        /*
        string sent="abc123";
        string sent="123_123";
        string sent="abc";
        string pattern=@"\d";
        bool result=Regex.IsMatch(sent,pattern);
        Console.WriteLine(result);
        
        string sent="Amount:5000"; 
        string pattern=@"\d+"; ## It will return 5000(digit)
        string pattern=@"\d*";   ## It will return empty string
        Match m=Regex.Match(sent,pattern);
        Console.WriteLine(m.value);

        */

        //string sent="10A20B30C";
        //string sent="10 20 30";
        //string pattern=@"\d+";
        //string pattern=@"\D";

        //string pattern=@"\w";
        //string pattern=@"\W";

        //string sent="10A20B30C!@_";
        //string sent="10 20 30 !@_";
        //string sent="10A20B30C!@_abc";
        //string sent="10A20B30C!@_abc _   ";

        //string pattern=@"\s";
        //string pattern=@"\S";


        //string sent="10A20B30C!@_abc _0!_file.txt \t";
        //string pattern=@"\.txt";
        // string sent="10A20B30C!@_abc _0! C:\abc\file.txt \t";
        // string pattern=@"\\";


        // string sent="?10A20B30C!@_abc _0! C:\abc\file.txt?";
        // string pattern=@"\?";


        //string sent="Hello?10A20B30C!@_abc _0!\t,C:\abc\file.txt?Hello";
        //string pattern=@"Hello$";
        //string pattern=@"^Hello";

        // MatchCollection matches=Regex.Matches(sent,pattern);
        // foreach (Match m in matches)
        // {
        //     Console.Write(m.Value + " ");
        // }

        // Match m = Regex.Match("Date: 2025-12-29", @"(\d{4})-(\d{2})-(\d{2})");
        // Console.WriteLine(m.Value);      

        // string sent="Amount:5000"; 
        // string pattern = @"Amount:(?<value>\d+)";

        // Match m=Regex.Match(sent,pattern);
        // Console.WriteLine(m.Value);
// ##########################################################################################################################
        // string pattern= @"(?<year>\d{4})-(?<month>\d{2})-(?<date>\d{2})";
        // string input="2005-02-15";
        //Match m=Regex.Match(input,pattern);
        // Console.WriteLine(m.Groups["year"].Value);
        // Console.WriteLine(m.Groups["month"].Value);
        // Console.WriteLine(m.Groups["date"].Value);

// ############################################################################################################################
        // MatchCollection matches=Regex.Matches(input,pattern);
        // foreach (Match m in matches)
        // {
            // Console.WriteLine(m.Groups["year"].Value);
            // Console.WriteLine(m.Groups["month"].Value);
            // Console.WriteLine(m.Groups["date"].Value);
        //     Console.WriteLine(m.Groups[0].Value);
        //     Console.WriteLine(m.Groups[1].Value);
        //     Console.WriteLine(m.Groups[2].Value);
        //     Console.WriteLine(m.Groups[3].Value);
        // }
        


        string input="shivansh.12216777@lpu.in";
        string pattern=@"\b[\w.-]+@[\w-]+\.\w{2,}\b";
        if (Regex.IsMatch(input, pattern))
        {
            Console.WriteLine("Valid Email");
        }
    }
}
>>>>>>> c45fc69d5fbdbfb4fff8724ca36ffc9b5e9691a5
=======
﻿using System;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;
class Program
{
    public static void Main()
    {
        /*
        string sent="abc123";
        string sent="123_123";
        string sent="abc";
        string pattern=@"\d";
        bool result=Regex.IsMatch(sent,pattern);
        Console.WriteLine(result);
        
        string sent="Amount:5000"; 
        string pattern=@"\d+"; ## It will return 5000(digit)
        string pattern=@"\d*";   ## It will return empty string
        Match m=Regex.Match(sent,pattern);
        Console.WriteLine(m.value);

        */

        //string sent="10A20B30C";
        //string sent="10 20 30";
        //string pattern=@"\d+";
        //string pattern=@"\D";

        //string pattern=@"\w";
        //string pattern=@"\W";

        //string sent="10A20B30C!@_";
        //string sent="10 20 30 !@_";
        //string sent="10A20B30C!@_abc";
        //string sent="10A20B30C!@_abc _   ";

        //string pattern=@"\s";
        //string pattern=@"\S";


        //string sent="10A20B30C!@_abc _0!_file.txt \t";
        //string pattern=@"\.txt";
        // string sent="10A20B30C!@_abc _0! C:\abc\file.txt \t";
        // string pattern=@"\\";


        // string sent="?10A20B30C!@_abc _0! C:\abc\file.txt?";
        // string pattern=@"\?";


        //string sent="Hello?10A20B30C!@_abc _0!\t,C:\abc\file.txt?Hello";
        //string pattern=@"Hello$";
        //string pattern=@"^Hello";

        // MatchCollection matches=Regex.Matches(sent,pattern);
        // foreach (Match m in matches)
        // {
        //     Console.Write(m.Value + " ");
        // }

        // Match m = Regex.Match("Date: 2025-12-29", @"(\d{4})-(\d{2})-(\d{2})");
        // Console.WriteLine(m.Value);      

        // string sent="Amount:5000"; 
        // string pattern = @"Amount:(?<value>\d+)";

        // Match m=Regex.Match(sent,pattern);
        // Console.WriteLine(m.Value);
// ##########################################################################################################################
        // string pattern= @"(?<year>\d{4})-(?<month>\d{2})-(?<date>\d{2})";
        // string input="2005-02-15";
        //Match m=Regex.Match(input,pattern);
        // Console.WriteLine(m.Groups["year"].Value);
        // Console.WriteLine(m.Groups["month"].Value);
        // Console.WriteLine(m.Groups["date"].Value);

// ############################################################################################################################
        // MatchCollection matches=Regex.Matches(input,pattern);
        // foreach (Match m in matches)
        // {
            // Console.WriteLine(m.Groups["year"].Value);
            // Console.WriteLine(m.Groups["month"].Value);
            // Console.WriteLine(m.Groups["date"].Value);
        //     Console.WriteLine(m.Groups[0].Value);
        //     Console.WriteLine(m.Groups[1].Value);
        //     Console.WriteLine(m.Groups[2].Value);
        //     Console.WriteLine(m.Groups[3].Value);
        // }
        


        string input="shivansh.12216777@lpu.in";
        string pattern=@"\b[\w.-]+@[\w-]+\.\w{2,}\b";
        if (Regex.IsMatch(input, pattern))
        {
            Console.WriteLine("Valid Email");
        }
    }
}
>>>>>>> c45fc69d5fbdbfb4fff8724ca36ffc9b5e9691a5
