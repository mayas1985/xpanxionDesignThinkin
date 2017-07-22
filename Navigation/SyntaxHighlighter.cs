using System;
using System.Linq;

namespace Navigation
{
    public class SyntaxHighlighter
    {
        private string  HighlighterText{get;set;}

        public SyntaxHighlighter(string highlighterText )
        {
            this.HighlighterText = highlighterText;
        }
        public string Process(string toSearch, string inputString){
            if( inputString == null) return null;
            
            var keywordToSearch = toSearch.Split(' ');
            foreach (var keyword in keywordToSearch)
            {
               inputString =  inputString.Replace(keyword, $"{HighlighterText}{keyword}{HighlighterText}");
            }
            return inputString;
        }
    }
}