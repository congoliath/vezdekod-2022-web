namespace Vezdekod.Models;

public class UserProfile
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Learned { get; set; }
    public string WantToLearn { get; set; }
    public bool IsMentor { get; set; }
    public bool NeedMentor { get; set; }
    public string About { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
}