using Task_002;

var a = new Block(1, 2, 3, 4);
var b = new Block(1, 2, 3, 4);

Console.WriteLine($"Is {a.ToString()} equal to {b.ToString()}? " +
    $"The answer is : " + a.Equals(b));