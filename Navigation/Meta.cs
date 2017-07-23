
using System;
using System.Linq;
using System.Collections.Generic;
namespace Navigation
{
    public class Meta{
        public string Highlight { get; set; }
        public StringCase Case {get;set;}
        }

        public enum StringCase{
            Capital,
            Lower,
            Default
        }
}