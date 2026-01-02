<<<<<<< HEAD
<<<<<<< HEAD
using System;
using System.Text.RegularExpressions;
namespace LogProcessing
{
    class LogParser
    {
        private readonly string validLineRegexPattern=@"^\[(TRC|DBG|INF|WRN|ERR|FTL)\]";
        private readonly string splitLineRegexPattern = @"<\*\*\*>|<====>|<\^\*>";
        private readonly string quotedPasswordRegexPattern = "\"password\"";
        private readonly string endOfLineRegexPattern = @"end-of-line\d+";
        private readonly string weakPasswordRegexPattern = @"password\w+";   
    
    public bool IsValidLine(string text)
        {
            return Regex.IsMatch(text, validLineRegexPattern);
        }
    public string[] SplitLogLine(string text)
        {
            return Regex.IsMatch(text, splitLineRegexPattern);
        }
    public int CountQuotedPasswords(string lines)
        {
            return Regex.IsMatch(text, quotedPasswordRegexPattern);
        }
    public string RemoveEndOfLineText(string line)
        {
            return Regex.IsMatch(text, endOfLineRegexPattern);
        }
    public string[] ListLinesWithPasswords(string[] lines)
        {
            string[] result = new string[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                Match match = Regex.Match(lines[i],
                    weakPasswordRegexPattern,
                    RegexOptions.IgnoreCase);

                if (match.Success)
                    result[i] = match.Value + ": " + lines[i];
                else
                    result[i] = "--------: " + lines[i];
            }

            return result;
        }
    }

=======
using System;
using System.Text.RegularExpressions;
namespace LogProcessing
{
    class LogParser
    {
        private readonly string validLineRegexPattern=@"^\[(TRC|DBG|INF|WRN|ERR|FTL)\]";
        private readonly string splitLineRegexPattern = @"<\*\*\*>|<====>|<\^\*>";
        private readonly string quotedPasswordRegexPattern = "\"password\"";
        private readonly string endOfLineRegexPattern = @"end-of-line\d+";
        private readonly string weakPasswordRegexPattern = @"password\w+";   
    
    public bool IsValidLine(string text)
        {
            return Regex.IsMatch(text, validLineRegexPattern);
        }
    public string[] SplitLogLine(string text)
        {
            return Regex.IsMatch(text, splitLineRegexPattern);
        }
    public int CountQuotedPasswords(string lines)
        {
            return Regex.IsMatch(text, quotedPasswordRegexPattern);
        }
    public string RemoveEndOfLineText(string line)
        {
            return Regex.IsMatch(text, endOfLineRegexPattern);
        }
    public string[] ListLinesWithPasswords(string[] lines)
        {
            string[] result = new string[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                Match match = Regex.Match(lines[i],
                    weakPasswordRegexPattern,
                    RegexOptions.IgnoreCase);

                if (match.Success)
                    result[i] = match.Value + ": " + lines[i];
                else
                    result[i] = "--------: " + lines[i];
            }

            return result;
        }
    }

>>>>>>> c45fc69d5fbdbfb4fff8724ca36ffc9b5e9691a5
=======
using System;
using System.Text.RegularExpressions;
namespace LogProcessing
{
    class LogParser
    {
        private readonly string validLineRegexPattern=@"^\[(TRC|DBG|INF|WRN|ERR|FTL)\]";
        private readonly string splitLineRegexPattern = @"<\*\*\*>|<====>|<\^\*>";
        private readonly string quotedPasswordRegexPattern = "\"password\"";
        private readonly string endOfLineRegexPattern = @"end-of-line\d+";
        private readonly string weakPasswordRegexPattern = @"password\w+";   
    
    public bool IsValidLine(string text)
        {
            return Regex.IsMatch(text, validLineRegexPattern);
        }
    public string[] SplitLogLine(string text)
        {
            return Regex.IsMatch(text, splitLineRegexPattern);
        }
    public int CountQuotedPasswords(string lines)
        {
            return Regex.IsMatch(text, quotedPasswordRegexPattern);
        }
    public string RemoveEndOfLineText(string line)
        {
            return Regex.IsMatch(text, endOfLineRegexPattern);
        }
    public string[] ListLinesWithPasswords(string[] lines)
        {
            string[] result = new string[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                Match match = Regex.Match(lines[i],
                    weakPasswordRegexPattern,
                    RegexOptions.IgnoreCase);

                if (match.Success)
                    result[i] = match.Value + ": " + lines[i];
                else
                    result[i] = "--------: " + lines[i];
            }

            return result;
        }
    }

>>>>>>> c45fc69d5fbdbfb4fff8724ca36ffc9b5e9691a5
}