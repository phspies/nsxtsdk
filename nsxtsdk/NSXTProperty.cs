using System;
using System.Collections.Generic;
using System.Text;

namespace nsxtsdk.Models
{
    [AttributeUsage(AttributeTargets.All)]
    public class NSXTProperty : Attribute
    {
        private string descriptionValue { get; set; }
        private bool isrequiredValue { get; set; }
        public NSXTProperty(bool IsRequired, string Description)
        {
            this.descriptionValue = Description;
            this.isrequiredValue = IsRequired;
        }

        public NSXTProperty(string Description)
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

        public virtual bool IsRequired
        {
            get
            {
                return this.isrequiredValue;
            }
        }
    }
}
