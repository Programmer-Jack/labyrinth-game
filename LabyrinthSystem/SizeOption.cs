using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabyrinthSystem
{
    internal struct SizeOption : ISelectableOption
    {
        public string Name { get; init; }

        public int size;
        
        public SizeOption(string name, int size)
        {
            this.Name = name;
            this.size = size;
        }

        public static readonly SizeOption[] SizeOptions =
        {
            new("Grave", 2),
            new("Small", 3),
            new("Moderate", 4),
            new("Large", 5),
            new("Huge", 6),
            new("Vast", 7),
            new("Vaulted Tomb", 8)
        };
    }
}
