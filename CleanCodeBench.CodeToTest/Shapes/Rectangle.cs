namespace CleanCodeBench.CodeToTest.Shapes
{
    public class Rectangle : Shape
    {
        private readonly float _height;
        private readonly float _width;

        public float Height => _height;
        public float Width => _width;

        public Rectangle(float width, float height)
        {
            _height = height;
            _width = width;
        }

        public override float Area()
        {
            return _height * _width;
        }

        public override int CornerCount()
        {
            return 4;
        }

        public override int WierdProp()
        {
            return 40;
        }
    }
}