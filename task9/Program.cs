using static System.Console;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Task9();
        var dict = Task9();
        ProcessWords(dict);
        FindLongShortWords(dict);
    }
    
    static Dictionary<string, int> Task9(){
        string content = "data structures and algorithms is about data structures and algorithms. data structures is about data structures. algorithms is the about algorithms. there are good algorithms and not so good algorithms. good algorithms are good good, not so good ones are not so good.";
        var dict = new Dictionary<string, int>();
        //represent single character, type: char array
        char[] delimiterChars = {',', '.', ' '};
        string[] words = content.Split(delimiterChars);
        foreach(var wd in words){
            if(wd.Trim().Length == 0) continue;
            string w = wd.ToLower();//make all words as lower case
            if(dict.ContainsKey(w) == false)
                dict.Add(w, 1);//insert w into hashtable, assign frequency as 1.
            else
                dict[w]++;//increment the frequency
        }
        return dict;
    }    
    static void ProcessWords(Dictionary<string,int> dict)
    {
        foreach(var (k,v) in dict){
            WriteLine($"{k} {v}");
        }
        WriteLine("\r\nMost and least frequent words with frequency: ");
        //calculate and display the most words with its frequency
        int most = int.MinValue;//initialise the variable with the lowest possible value
        var mostwords = new List<string>();//used to collect the most frequent words
        foreach(var (k, v) in dict){
            if(v > most) most = v;
        }
        foreach(var (k, v) in dict){
            if(v == most) mostwords.Add(k);//add the most frequent word in the list
        }
        mostwords.ForEach(w => Write(w + " "));//print all words in one line
        WriteLine(most);

        //calculate and display the least words with its frequency
        int least = int.MaxValue;
        var leastwords = new List<string>();
        foreach(var (k, v) in dict){
            if(v < least) least = v;
        }
        foreach(var (k, v) in dict){
            if(v == least) leastwords.Add(k);
        }
        leastwords.ForEach(w => Write(w + " "));//print all words in one line
        WriteLine(least);
    }
    static void FindLongShortWords(Dictionary<string,int> dict)
    {
        //calculate and display the longest words with its frequency
        WriteLine("\r\nLongest words with frequency: ");
        int longest = int.MinValue;
        var longestwords = new Dictionary<string, int>();
        foreach(var (k, v) in dict){
            if(k.Length > longest) longest = k.Length;
        }
        foreach(var (k, v) in dict){
            if(k.Length == longest) longestwords.Add(k, v);
        }

        foreach(var var in longestwords)
        {
            WriteLine("{0} {1}", var.Key, var.Value);
        }

        // longestwords.ForEach(w => Write(w + " "));
        // WriteLine(longest);

        //calculate and display the shortest words with its frequency
        WriteLine("\r\nShortest words frequency: ");
        int shortest = int.MaxValue;
        var shortestwords = new Dictionary<string, int>();
        foreach(var (k,v) in dict){
            if(k.Length < shortest) shortest = k.Length;
        }
        foreach(var (k,v) in dict){
            if(k.Length == shortest) shortestwords.Add(k, v);
        }

        foreach(var var in shortestwords)
        {
            WriteLine("{0} {1}", var.Key, var.Value);
        }
        // shortestwords.ForEach(w => Write(w + " "));
        // WriteLine(shortest);
    }
}