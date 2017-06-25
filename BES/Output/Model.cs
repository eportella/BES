using BES.Alias.Name;

namespace BES.Output
{
    public class Model : Interface
    {
        public Model(Struct name)
        {
            Name = name;
        }
        public Struct Name { get; private set; }
    }
}
