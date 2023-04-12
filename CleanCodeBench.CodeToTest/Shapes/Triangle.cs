namespace CleanCodeBench.CodeToTest.Shapes
{
    public class Triangle : Shape
    {
        private readonly float _height;
        private readonly float _width;

        public float Height => _height;
        public float Width => _width;

        public Triangle(float width, float height)
        {
            _height = height;
            _width = width;
        }

        public override float Area()
        {
            return 0.5f * _height * _width;
        }

        public override int CornerCount()
        {
            return 3;
        }

        public override int WierdProp()
        {
            return 10;
        }
    }
}