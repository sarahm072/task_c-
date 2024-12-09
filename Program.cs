using System.Xml.Linq;

class Animal
{
    private String Name;
    private String Breed;
    private int Age;
    public void setName(String N)
    {
        Name = N;
    }
    public void setBreed(String B)
    {
        Breed = B;
    }
    public void setAge(int A)
    {
        Age = A;
    }
    public String getName()
    {
        return Name;
    }
    public String getBreed()
    {
        return Breed;
    }
   public  int getAge()
    {
        return Age;
    }
    public virtual void Bark()
    {
        Console.WriteLine("Animal sound!");
    }
   
}
class Dog : Animal
{
    private String FavoriteToy;

    public void setFavoriteJoy(String Joy)
    {
        FavoriteToy= Joy;
    }
    public String getFavoriteJoy()
    {
        return FavoriteToy;
    }
    public override void Bark()
    {
        Console.WriteLine(getName()+ " says: Woof! Woof!");
    }
}

public class main
{
    public static void Main(string[] args) { 
        Animal a = new Animal();
        a.setName("cat");
        a.setBreed("Siamese");
        a.setAge(3);
        Console.WriteLine("Animal Name:" + a.getName() + " Breed: " + a.getBreed() + " Age: " + a.getAge());
        a.Bark();

        Dog d = new Dog();
        d.setName("dog");
        d.setBreed("Beagle");
        d.setAge(3);
        d.setFavoriteJoy("Ball");
        Console.WriteLine("Dogl Name:" + d.getName() + " Breed: " + d.getBreed( ) + " Age: " + d.getAge()+ " Favorite Joy: "+d.getFavoriteJoy());
        d.Bark();
    }
}