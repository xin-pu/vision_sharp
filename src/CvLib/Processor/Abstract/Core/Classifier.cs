namespace CVLib.Processor
{
    /// <summary>
    ///     抽象分类器
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class Classifier<T> : MatProcessor<T>
        where T : struct
    {
        protected Classifier(string name)
            : base(name)
        {
        }
    }
}