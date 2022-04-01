namespace SOLID.Liskov_Substitution;

internal class FruitColors
{
    public abstract class Fruit
    {
        public abstract string GetColor();
    }

    public class Banana : Fruit
    {
        public override string GetColor()
        {
            return "Yellow";
        }
    }

    public class Strawberry : Fruit
    {
        public override string GetColor()
        {
            return "Red";
        }
    }

    public class Orange : Fruit
    {
        public override string GetColor()
        {
            return "Orange";
        }
    }
}
