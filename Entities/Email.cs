using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace aws_postman.Entities
{
  public class Email
  {
    public int Id { get; set; }
    [Required]
    [EmailAddress]
    public string email { get; set; }

  }
}