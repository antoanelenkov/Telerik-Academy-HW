using System;

/*•	Write a program that parses an URL address given in the format:
 * [protocol]://[server]/[resource] and extracts from it the [protocol],
 * [server] and [resource] elements.*/

class ParseURL
{
    static void Main()
    {
        string url = "http://telerikacademy.com/Courses/Courses/Details/212";
        int protocolLength = url.IndexOf(":");
        int serverLength = url.IndexOf("/", protocolLength + 3) - protocolLength - 3;
        int resoourceStartIndex = url.IndexOf("/", protocolLength + 3);

        string protocol = url.Substring(0, protocolLength);
        string server = url.Substring(protocolLength + 3, serverLength);
        string resource = url.Substring(resoourceStartIndex);

        Console.WriteLine("The whole adress is:");
        Console.WriteLine(url);
        Console.WriteLine("Result:");
        Console.WriteLine("[protocol] = {0}", protocol);
        Console.WriteLine("[server] = {0}", server);
        Console.WriteLine("[resource] = {0}", resource);

        //Second way of solving the problem
        //Uri urlTwo = new Uri(url);
        //string protocol = urlTwo.Scheme;
        //string server = urlTwo.Host;
        //string resource = urlTwo.AbsolutePath;
        //Console.WriteLine("[protocol] = {0}", protocol);
        //Console.WriteLine("[server] = {0}", server);
        //Console.WriteLine("[resource] = {0}", resource);
    }
}
