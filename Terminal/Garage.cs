using System.Collections;
namespace Terminal;
internal class Garage
{
    private Car[] _array = new Car[4];
    public Garage()
    {
        _array[0] = new Car("A", 20);
        _array[1] = new Car("B", 40);
        _array[2] = new Car("C", 60);
        _array[3] = new Car("D", 80);
    }
    public IEnumerator GetEnumerator()
    {
        return _array.GetEnumerator();
    }
}