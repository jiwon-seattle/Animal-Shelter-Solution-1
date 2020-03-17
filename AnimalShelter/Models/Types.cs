using System.Collections.Generic;

namespace AnimalShelter.Models
{
    public class Types
    {
        public Types()
        {
            this.Animals = new HashSet<Animal>();
        }

        public int TypesId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Animal> Animals { get; set; }
    }
}