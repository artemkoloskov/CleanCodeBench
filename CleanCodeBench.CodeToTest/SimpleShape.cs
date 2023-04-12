namespace CleanCodeBench.CodeToTest
{
    public class SimpleShape
    {
        private readonly float[] _coeffs = new float[] { 0.5f, 1.0f, 1.0f, 3.14f };
        private readonly int[] _corners = new int[] { 3, 4, 4, 0 };
        private readonly int[] _anotherWierdProp = new int[] { 10, 20, 40, 50 };

        public readonly float Width;
        public readonly float Height;
        public readonly ShapeTypes ShapeType;

        public SimpleShape(float width, float height, ShapeTypes shapeType)
        {
            Width = width;
            Height = height;
            ShapeType = shapeType;
        }

        public float Area()
        {
            return _coeffs[(int)ShapeType] * Width * Height;
        }

        public int CornerCount()
        {
            return _corners[(int)ShapeType];
        }

        public int WierdProp()
        {
            return _anotherWierdProp[(int)ShapeType];
        }
    }

    public enum ShapeTypes
    {
        Triangle = 0,
        Sqare,
        Rectangle,
        Circle
    }
}
