namespace LambdaUserEngine.Servies;

public class UserFilter
{
    public List<string> FilterOperation(List<User> users, Predicate<User> predicate)
    {
        List<string> result = new List<string>();
        foreach (var user in users)
        {
            if (predicate(user))
            {
                string fullName = user.FirstName + " " + user.SecondName;
                result.Add(fullName);
            }
        }

        return result;
    }
}