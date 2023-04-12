namespace CleanCodeBench.CodeToTest
{
    public abstract class OneFileShape
    {
        public abstract float Area();
        public abstract int CornerCount();
        public abstract int WierdProp();
    }

    public class OneFileTriangle : OneFileShape
    {
        private readonly float _height;
        private readonly float _width;

        public float Height => _height;
        public float Width => _width;

        public OneFileTriangle(float width, float height)
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

    public class OneFileSquare : OneFileShape
    {
        private readonly float _side;

        public float Side => _side;

        public OneFileSquare(float side)
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

    public class OneFileRectangle : OneFileShape
    {
        private readonly float _height;
        private readonly float _width;

        public float Height => _height;
        public float Width => _width;

        public OneFileRectangle(float width, float height)
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

    public class OneFileCircle : OneFileShape
    {
        private readonly float _radius;

        public float Radius => _radius;

        public OneFileCircle(float radius)
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
