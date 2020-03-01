using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections;

namespace aws_postman.Entities
{
  public class Listdestination
  {
    public int Id { get; set; }
    [Required]
    public string name { get; set; }
    public List<Email> destination { get; set; }
    public string query { get; set; }
    public string description { get; set; }
  }
}