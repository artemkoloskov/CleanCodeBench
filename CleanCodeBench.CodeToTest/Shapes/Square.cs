namespace CleanCodeBench.CodeToTest.Shapes
{
    public class Square : Shape
    {
        private readonly float _side;

        public float Side => _side;

        public Square(float side)
        {
            _side = side;
        }

        public override float Area()
        {
            return _side * _side;
        }

        public override int CornerCount()
        {
            return 4;
        }

        public override int WierdProp()
        {
            return 20;
        }
    }
}