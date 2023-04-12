namespace CleanCodeBench.CodeToTest.Shapes
{
    public class Circle : Shape
    {
        private readonly float _radius;

        public float Radius => _radius;

        public Circle(float radius)
        {
            _radius = radius;
        }

        public override float Area()
        {
            return 3.14f * _radius * _radius;
        }

        public override int CornerCount()
        {
            return 0;
        }

        public override int WierdProp()
        {
            return 50;
        }
    }
}