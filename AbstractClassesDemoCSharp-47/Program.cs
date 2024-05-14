using AbstractClassesDemoCSharp_47;

var beagle = new Dog();

beagle.Move();
beagle.Breathe();

var circleOne = new Circle(25);

Console.WriteLine($"Area of cicle with a radius of {circleOne.Radius} is {circleOne.CalculateArea()}");


