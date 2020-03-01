using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections;

namespace aws_postman.Entities
{
  public class Usermessage
  {
    public int Id { get; set; }
    [Required]
    [EmailAddress]
    public string source { get; set; }
    [Required]
    public List<Email> destination { get; set; }

    public List<Email> ccdestination { get; set; }

    public List<Email> bccdestination { get; set; }
    [Required]
    public string subject { get; set; }
    [Required]
    public string body { get; set; }

  }
}