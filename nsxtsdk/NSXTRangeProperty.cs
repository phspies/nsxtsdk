using System;
using System.Collections.Generic;
using System.Text;

namespace nsxtsdk.Models
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class NSXTRangeProperty : Attribute
    {
        private string descriptionValue { get; set; }
        private long rangeValue { get; set; }
        public NSXTRangeProperty(long Range, string Description)
        {
            this.descriptionValue = Description;
            this.rangeValue = Range;
        }

        public NSXTRangeProperty(string Description)
        {
            this.descriptionValue = Description;
        }

        public virtual string Description
        {
            get
            {
                return this.descriptionValue;
            }
        }

        public virtual long Range
        {
            get
            {
                return this.rangeValue;
            }
        }
    }
}
