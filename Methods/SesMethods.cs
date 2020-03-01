using Amazon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using aws_postman.Entities;
using Amazon.SimpleEmail;
using Amazon.SimpleEmail.Model;

namespace SesMethods
{
  public class MySesMethods
  {
    public async Task<Object> Postman(string source, string destination, string subject, string body)
    {
      Console.WriteLine("Sending Email...");
      using (var client = new AmazonSimpleEmailServiceClient(Amazon.RegionEndpoint.USEast1))
      {
        var sendRequest = new SendEmailRequest
        {
          Source = source.ToString(),
          Destination = new Destination { ToAddresses = { destination } },
          Message = new Message
          {
            Subject = new Content(subject.ToString()),
            Body = new Body
            {
              Html = new Content(body.ToString())
            }
          }
        };

        try
        {
          var response = client.SendEmailAsync(sendRequest).Result;
          Console.WriteLine("Email sent! Message ID = {0}", response.MessageId);
          return new { response = response.MessageId };
        }
        catch (Exception ex)
        {
          Console.WriteLine("Send failed with exception: {0}", ex.Message);
          return new { error = ex.Message };
        }
      }

    }

  }
}