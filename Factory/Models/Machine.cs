using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Machine
  {
    public int MachineId { get; set; }
    [Required(ErrorMessage = "You must enter a machine type to create an instance of machine.")]
    public string Type { get; set; }
    public List <EngineerMachine> JoinEntities { get; set; }
  }
}