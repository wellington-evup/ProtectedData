namespace ProtectedData.Core
{
    public interface IValidable<T>
    {
        void Validate(T value);
    }
}
