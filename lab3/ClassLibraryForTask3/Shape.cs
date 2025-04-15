namespace ClassLibraryForTask3
{
    public abstract class Shape
    {
        protected readonly Renderer _renderer;

        public Shape(Renderer renderer)
        {
            _renderer = renderer;
        }

        public abstract void Draw();
    }
}
