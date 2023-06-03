namespace Jordnaer.Shared.UserSearch;

public class ChildDto
{
    public required string FirstName { get; set; }
    public string? LastName { get; set; }
    public Gender? Gender { get; set; }
    public DateTime? DateOfBirth { get; set; }
}