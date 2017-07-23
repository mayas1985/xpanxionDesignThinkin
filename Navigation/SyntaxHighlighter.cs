using System;
using System.Linq;
using System.Collections.Generic;
namespace Navigation
{
    public class SyntaxHighlighter
    {
        
        private  Dictionary<string,Meta> KeywordAndHighlighter {get;set;}

        public SyntaxHighlighter(string toSearch)
        {
            this.KeywordAndHighlighter = new Dictionary<string, Meta>();
            var keywordToSearch = toSearch.Split(' ');
            foreach (var keywords in keywordToSearch)
            {
                var meta =new Meta{ Highlight = "[blue]", Case = StringCase.Default};
                string keySearch = keywords;

                if( keywords.Contains(":")){
                    var keyword = keywords.Split(':');
                    
                    meta.Highlight = "[" + keyword[1] + "]";
                    if(keyword[3]=="bold"){
                    meta.FontStyle = "[" + keyword[3] + "]";
                    }
                    meta.Case = keyword[2] == "capital"? StringCase.Capital: StringCase.Lower ;
                    keySearch = keyword[0];
                }
                this.KeywordAndHighlighter.Add(keySearch, meta);
            }
        }


        public string Process(string inputString){
            if( inputString == null) return null;
            
            foreach (var dict in this.KeywordAndHighlighter)
            {
                 Meta meta = dict.Value;
                 var toReplace = dict.Key;
                    
                  if(meta.Case == StringCase.Capital )
                      toReplace=  dict.Key.ToUpper();
            
                    if(meta.Case == StringCase.Lower ) 
                    toReplace= dict.Key.ToLower();
        
                
               inputString =  inputString.Replace(dict.Key, $"{meta.Highlight}{meta.FontStyle}{toReplace}{meta.FontStyle}{meta.Highlight}");
            }
            return inputString;
        }
    }
}