using UnityEngine;

public class Class2_Operator : MonoBehaviour
{

    public float a = 10;
    public float b = 3;

    public string c = "7";
    public int d = 3;

    public int e = 99;
    public int f = 9;

    public bool g = true;
    public bool h = false;

    public int key;
    public int result;

    public int hp = 100;
    // execute once at the start of program
    private void Start()
    {
        
        #region math
        // arithmetic + - * / %
        print(a + b);   //13
        print(a - b);   //7   
        print(a * b);   //30
        print(a / b);   //3.33333
        print(a % b);   //1

        // +: to concat data/string
        print("Float: " + 99.9f);
        // result is string after concat
        print(c+d);
        #endregion

        #region comp
        // math comparison: return boolean value
        // > < >= <= == !=
        print(e > f);
        print(e < f);
        print(e >= f);
        print(e <= f);
        print(e == f);
        print(e != f);
        #endregion

        #region logic
        //logic 
        //  && And 
        print("And: " + (g && h));
        // || Or
        print("Or: " + (g || h));

        print(true && true);
        print(true && false);
        print(false && true);
        print(false && false);

        print(true || true);
        print(true || false);
        print(false || true);
        print(false || false);

        //invert
        // !
        print(!true);
        print(!false);

        #endregion

        // calculate right side then assign to left side
        result = 2 + 3;
        print(result);
        key = key + 1;
        print("Key: "+key);

        //_____++(behind) +1, output first then add
        print("Key: " + key++);
        //++_____(front) +1, add then output 
        print("Key: " + ++key);

        // += -= *= /= %=
        // hp = hp + 20;
        hp += 20;
        print("Blood: " + hp);
        hp -= 50;
        print("Blood: " + hp);
    }
}
