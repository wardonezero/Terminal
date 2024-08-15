using Terminal;
using static System.Console;
//1
WriteLine("****How the animals sounds****");
//Tiger tiger = new Tiger();
//tiger.Sound();
//Dog dog = new Dog();
//dog.Sound();
//Monkey monkey = new Monkey();
//monkey.Sound();
//2
//ISound animal = new Tiger();
//animal.Sound();
//animal = new Dog();
//animal.Sound();
//animal = new Monkey();
//animal.Sound();
//3
//List<ISound> animls =
//[
//    new Dog(),
//    new Monkey(),
//    new Tiger(),
//];
//foreach (ISound animal in animls)
//{
//    animal.Sound();
//}
//4
ISound animal = GetAnimal();
//animal.Sound();
//animal = GetAnimal();
//animal.Sound();
//animal = GetAnimal();
//animal.Sound();
//animal = GetAnimal();
//5
MakeSound(animal);
animal = GetAnimal();
MakeSound(animal);
animal = GetAnimal();
MakeSound(animal);
//6
static ISound GetAnimal()
{
    ISound animal;
    Random random = new();
    int temp = random.Next(0, 3);
    return temp switch
    {
        0 => animal = new Tiger(),
        1 => animal = new Dog(),
        2 => animal = new Monkey(),
        _ => throw new Exception("No animal"),
    };
}
static void MakeSound(ISound animal)
{
    animal.Sound();
}