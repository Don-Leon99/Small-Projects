// Abstrakta klasser, arv, virtual, override:
using Former;

Shape circle = new Circle(3);
Shape rectangle = new Rectangle(4, 5);
Shape triangle = new Triangle(6, 2);

circle.Describe();
rectangle.Describe();
triangle.Describe();

Shape shape = new Shape();