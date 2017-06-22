using System;

namespace BES.Alias.Name
{
    public struct Struct : IComparable<Struct>, IEquatable<Struct>
    {

        const string DEFAULT = "";
        private string _value;
        public string Value
        {
            get
            {
                if (_value == null) return DEFAULT;
                else
                    return _value;
            }
        }

        public Struct(string value)
        {
            _value = value ?? throw new NotNull.Exception(nameof(value));
        }

        public override bool Equals(object obj)
        {
            return Equals((Struct)obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public int CompareTo(Struct other) => Value.CompareTo(other.Value);

        public bool Equals(Struct other) => Value.Equals(other.Value);

        public static bool operator ==(Struct d1, Struct d2) => d1.Equals(d2);
        public static bool operator !=(Struct d1, Struct d2) => !(d1 == d2);
    }
}
