using System;
using System.Collections.Generic;
using System.Text;

namespace nsxtsdk.Models
{
    [AttributeUsage(AttributeTargets.Property)]
    public class NSXTDefaultProperty : Attribute
    {
        private string[] defaultValue { get; set; }
        public NSXTDefaultProperty(string[] Default)
        {
            this.defaultValue = Default;
        }
        public virtual string[] Default
        {
            get
            {
                return this.defaultValue;
            }
        }
    }
}
