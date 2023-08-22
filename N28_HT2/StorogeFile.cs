using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N28_HT2
{
    public class StorogeFile:ICloneable
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Size { get; set; }
        public StorogeFile()
        {
            
        }
        public StorogeFile(string name, string description, int size)
        {
            Id = Guid.NewGuid();
            Name = name;
            Description = description;
            Size = size;
        }

        public object Clone()
        {
            return new StorogeFile(this.Name,this.Description,this.Size);
        }
        public override string ToString()
        {
            return $"{Name} {Description} {Size}";
        }
    }
}
