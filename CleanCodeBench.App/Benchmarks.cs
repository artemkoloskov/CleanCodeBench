using BenchmarkDotNet.Attributes;
using CleanCodeBench.CodeToTest;
using CleanCodeBench.CodeToTest.Shapes;

namespace CleanCodeBench.App
{
    [MemoryDiagnoser]
    public class Benchmarks
    {
        private Shape[]? _shapes;
        private OneFileShape[]? _oneFileShapes;
        private SimpleShape[]? _simpleShapes;

        [GlobalSetup]
        public void Setup()
        {
            _shapes = new Shape[4];
            _oneFileShapes = new OneFileShape[4];
            _simpleShapes = new SimpleShape[4];

            var rnd = new Random(101);

            var triangle = new Triangle((float)rnd.NextDouble(), (float)rnd.NextDouble());
            _shapes[0] = triangle;
            _oneFileShapes[0] = new OneFileTriangle(triangle.Width, triangle.Height);
            _simpleShapes[0] = new SimpleShape(triangle.Width, triangle.Height, ShapeTypes.Triangle);

            var square = new Square((float)rnd.NextDouble());
            _shapes[1] = square;
            _oneFileShapes[1] = new OneFileSquare(square.Side);
            _simpleShapes[1] = new SimpleShape(square.Side, square.Side, ShapeTypes.Sqare);

            var rectangle = new Rectangle((float)rnd.NextDouble(), (float)rnd.NextDouble());
            _shapes[2] = rectangle;
            _oneFileShapes[2] = new OneFileRectangle(rectangle.Width, rectangle.Height);
            _simpleShapes[2] = new SimpleShape(rectangle.Width, rectangle.Height, ShapeTypes.Rectangle);

            var circle = new Circle((float)rnd.NextDouble());
            _shapes[3] = circle;
            _oneFileShapes[3] = new OneFileCircle(circle.Radius);
            _simpleShapes[3] = new SimpleShape(circle.Radius, circle.Radius, ShapeTypes.Circle);
        }

        [GlobalCleanup]
        public void Cleanup()
        {
            _shapes = null;
            _oneFileShapes = null;
            _simpleShapes = null;
        }

        [Benchmark]
        public float CleanCodeShapesArea()
        {
            float areas = 0.0f;

            foreach (Shape shape in _shapes)
            {
                areas += 1.0f / (1.0f + shape.CornerCount()) * shape.Area();
            }

            return areas;
        }

        [Benchmark]
        public float CleanCodeOneFileShapesArea()
        {
            float areas = 0.0f;

            foreach (OneFileShape shape in _oneFileShapes)
            {
                areas += 1.0f / (1.0f + shape.CornerCount()) * shape.Area();
            }

            return areas;
        }

        [Benchmark]
        public float SimpleShapesArea()
        {
            float areas = 0.0f;

            foreach (SimpleShape shape in _simpleShapes)
            {
                areas += 1.0f / (1.0f + shape.CornerCount()) * shape.Area();
            }

            return areas;
        }
    }
}
