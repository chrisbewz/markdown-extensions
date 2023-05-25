namespace MarkdownExtensions.Decorators
{
    public class BoldStarredDecorator : IDecorator
    {
        private string _decorator;

        public string Decorator => _decorator;

        public BoldStarredDecorator()
        {
            this._decorator = "**";
        }

        public override string ToString()
        {
            return this._decorator;
        }
    }
}