using System.Collections.Generic;

namespace DoctorsOffice.Models
{
  public class Specialty
  {

    public int SpecialtyId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int DoctorId { get; set; }

    public virtual Doctor Doctor {get; set; } //making a new property that gives us access to the doctors 

  }
}