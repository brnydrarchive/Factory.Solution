using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }
    [Required(ErrorMessage = "You must enter a name for an engineer. ")]
    [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "The name must contain only alphabetic characters.")]
    public string Name { get; set; }
    public List<EngineerMachine> JoinEntities { get; set; }
  }
}