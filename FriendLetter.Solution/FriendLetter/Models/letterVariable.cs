namespace FriendLetter.Models
{
  public class LetterVariable
  {
    //////allowing the Sender and Receipt to be set
    public string Recipient { get; set; }
    public string Sender { get; set; }
    public string Location { get; set; }
    public string Items { get; set;}
  }
}