namespace LambdaUserEngine.Servies;

public class UserProcess
{
    public List<User> ProcessUsers(List<User> users, Func<User, User> processor)
    {
        List<User> processed = new List<User>();
        foreach (User user in users)
        {
            processed.Add(processor(user));
        }
        return processed;
    }
}