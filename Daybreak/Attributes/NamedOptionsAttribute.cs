using System;

namespace Daybreak.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class NamedOptionsAttribute : Attribute
    {
        public NamedOptionsAttribute(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }
}
