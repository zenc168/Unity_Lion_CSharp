using UnityEngine;    //using Unity API

// class is to define a object
// : MonoBehaviour can be used by Unity Object 
public class Class1 : MonoBehaviour
{
    // 1) When define class, case mattters
    // 2) {} () [] '' "" < > comes in pair 

    // event: at specified timestamp, method to be executed number of times
    // start(): execute once when started, initial setting
    
    
    [Header("Car number #1#")]
    public Car car1;

    [Header("Car number #2#")]
    public Car car2;

    private void Start()
    {
        print("Hello Zen");

        //retrieve
        print("Car1's cc number is "+car1.cc);
        print("Car2's brand is "+car2.brand);
        //set
        car1.cc = 999;
        car1.weight = 999f;
        car1.brand = "Aston Martin";
        car1.brake = true;
        

    }
}
