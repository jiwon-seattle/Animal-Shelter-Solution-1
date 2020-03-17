using System;

namespace AnimalShelter.Models
{
  public class Animal
  {
    public int Id { get; set; }
    public int TypesId { get; set; }
    public virtual Types Types { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public DateTime Date { get; set; }
    public string Breed { get; set; }
  }
}