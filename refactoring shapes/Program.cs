
        abstract class Calculate
        {
            public abstract double CalculateArea();

        }
        class Rectangle : Calculate
        {
            public double Length { get; set; }
            public double Width { get; set; }

            public override double CalculateArea()
            {
                return Length * Width;
            }
        }

        class Circle : Calculate
        {
            public double Radius { get; set; }

            public override double CalculateArea()
            {
                return Math.PI * Radius * Radius;
            }
        }

        class Triangle : Calculate
        {
            public double Base { get; set; }
            public double Height { get; set; }

            public override double CalculateArea()
            {
                return 0.5 * Base * Height;
            }

        }


    }
    }


