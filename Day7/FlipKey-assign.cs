// using System;
// class Assignment
// {
//     public static void calculate()
//     {
//         Console.WriteLine("Enter a word: ");
//         string input=Console.ReadLine();
//         Assignment a=new Assignment();
//         string key=a.CleanseAndInvert(input);
//         if (key == "")
//         {
//             Console.WriteLine("Invalid Input");
//         }
//         else
//         {
//             Console.WriteLine("the generated key is - "+key);
//         }
//     }
//     public string CleanseAndInvert(string input)
//     {
//         if(string.IsNullOrEmpty(input) || input.Length < 6)
//         {
//             return "";
//         }
//         foreach(char ch in input)
//         {
//             if(!char.IsLetter(ch))
//             {
//                 return "";
//             }
//         }
//     string Lower=input.ToLower();
//     string filtered="";
//     foreach(char ch in Lower)
//         {
//             int ascii=(int)ch;
//             if(ascii %2 != 0)
//             {
//                 filtered += ch;
//             }
//         }
//     char[] chars=filtered.ToCharArray();
//     Array.Reverse(chars);
//     for(int i = 0; i < chars.Length; i++)
//         {
//             if(i%2==0)
//             chars[i]=char.ToUpper(chars[i]);
//         }
//         return new string(chars);
    
//     }
// }