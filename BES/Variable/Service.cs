namespace BES.Variable
{
    public class Service
    {
        public static Interface Create(Alias.Name.Struct name) => new Model(name);
    }
}
