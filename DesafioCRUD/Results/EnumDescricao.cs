namespace DesafioCRUD.Results
{
    public class EnumDescricao<T> where T : Enum
    {
        public T Value { get; }
        public string Description { get; }

        public EnumDescricao(T value, string description)
        {
            Value = value;
            Description = description;
        }

        public override string ToString()
            => Description;

    }
}
