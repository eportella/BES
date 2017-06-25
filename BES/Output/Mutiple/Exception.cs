namespace BES.Output.Mutiple
{
    public class Exception : System.InvalidOperationException
    {
        public Exception() : base("There can not be more than one output column with result") { }
    }
}
