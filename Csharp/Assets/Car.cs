using UnityEngine;

// "//" to elaborate, only seen here
// "///" to summary, can be seen at other classes
// coding is class
// In Unity is object
/// <summary>
/// to define car object
/// </summary>

public class Car : MonoBehaviour
{
    // field :  to store data
    // cc -2000- int
    // weight-100.9- float 
    // brand-bmw- string
    // brake-y/n- bool
    // only 'public' will show in Inspector in Unity 
    // default is 'private'
    // how to define
    // initial value int, float 0, string "", bool false
    //Range is for number types only [Range(min, max)]
    /// <summary>
    /// Car's cc number summary
    /// </summary>
    [Header("Car's cc number"), Range(500, 5000)]
    public int cc = 2000;
    
    /// <summary>
    /// Car's weight summary
    /// </summary>
    [Header("Car weight")]
    [Tooltip("This is car's weight"), Range(50, 350)]
    public float weight = 100.9f;

    /// <summary>
    /// Car's brand summmary
    /// </summary>
    [Header("Car's brand name")]
    [Tooltip("This is car's brand")]
    public string brand = "BMW";

    /// <summary>
    /// Car's brake summmary boolean
    /// </summary>
    [Header("brake on/off"), Tooltip("Do you have hand brake on")]
    public bool brake = false;

}
