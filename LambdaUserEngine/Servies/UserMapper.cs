namespace LambdaUserEngine.Servies;

public class UserMapper
{
    public List<LenghtResult> MapOperation<LenghtResult>(List<User> users, Func<User, LenghtResult> mapper)
    {
        List<LenghtResult> result = new List<LenghtResult>();
        foreach (var user in users)
        {
            
            result.Add(mapper(user));
        }
        return result;
    }

}
