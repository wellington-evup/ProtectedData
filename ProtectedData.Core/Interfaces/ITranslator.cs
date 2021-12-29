namespace ProtectedData.Core
{
    public interface ITranslator<X, Y>
    {
        Y Translate(X value);
        X Translate(Y value);
    }
}
