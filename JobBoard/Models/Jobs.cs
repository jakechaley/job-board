using System.Collections.Generic;

namespace JobBoard.Models
{
  public class Job
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public string ContactName { get; set; }
    public string ContactEmail { get; set; }
    public string ContactPhoneNumber { get; set; }
    private static List<Job> _jobList = new List<Job> {};
    public Job(string title, string description, string contactName, string contactEmail, string contactPhoneNumber)
    {
      Title = title;
      Description = description;
      ContactName = contactName;
      ContactEmail = contactEmail;
      ContactPhoneNumber = contactPhoneNumber;
      _jobList.Add(this);
    }
    public static List<Job> GetAll()
    {
      return _jobList;
    }
  }
}