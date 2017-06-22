namespace BES.Alias.Name.NotNull
{
    public class Exception : System.ArgumentNullException
    {
        public Exception(string paramName) : base(paramName)
        {

        }
    }
}
