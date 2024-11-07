using System;

namespace lab_5
{
    public class Bread : ICloneable
    {
        public string Name { get; set; }
        public string FlourType { get; set; }
        public bool HasSeeds { get; set; }
        public bool IsGlutenFree { get; set; }

        public Bread(string name, string flourType, bool hasSeeds, bool isGlutenFree)
        {
            Name = name;
            FlourType = flourType;
            HasSeeds = hasSeeds;
            IsGlutenFree = isGlutenFree;
        }

        // Реалізація клонування
        public object Clone()
        {
            return new Bread(this.Name, this.FlourType, this.HasSeeds, this.IsGlutenFree);
        }

        public override string ToString()
        {
            return $"{Name} (Flour: {FlourType}, Seeds: {HasSeeds}, Gluten-free: {IsGlutenFree})";
        }
    }
}
