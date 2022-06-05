using session_4;
public class Shape
{
    //public int side1 { get; set; }
    //public int side2 { get; set; }  
    //public int side3 { get; set; }
    //public int side4 { get; set; }

    /* if we need to sides we can use the above members*/
    public virtual void Draw() {//base class property
        {
            Console.WriteLine("Base class Drawing");
        }
         

    }
    static void Main(string[] args)
    {
        var _shapes = new List<Shape>();
        _shapes.Add(new Circle());
        _shapes.Add(new Triangle());
        _shapes.Add(new Rectangle());

        foreach(var shape in _shapes)//traversing each object in the list _shapes of type Shape
        {
            shape.Draw();
        }
    }
    

}