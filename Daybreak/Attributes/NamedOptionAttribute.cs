using System;

namespace Daybreak.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class NamedOptionAttribute : Attribute
    {
        public string Name { get; }

        public NamedOptionAttribute(string name)
        {
            this.Name = name;
        }
    }
}
