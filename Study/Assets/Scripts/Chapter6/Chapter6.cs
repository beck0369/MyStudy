using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter6 : MonoBehaviour
{
    //public static int Plus(int a, int b)
    //{
    //    Debug.Log($"Input : {a}, {b}");

    //    int result = a + b;
    //    return result;
    //}


    //private void Start()
    //{
    //    int a, b;

    //    a = 3;
    //    b = 4;
    //    Debug.Log($"Input : {a}, {b}");   3, 4
    //    int x = a + b;

    //    a = 5;
    //    b = 6;
    //    Debug.Log($"Input : {a}, {b}");   5, 6
    //    int y = a + b;

    //    a = 7;
    //    b = 8;
    //    Debug.Log($"Input : {a}, {b}");   7, 8
    //    int z = a + b;

    //    Debug.Log(x + y + z); 33
    //}


    //public static int Plus(int a, int b)
    //{
    //    Debug.Log($"Input : {a}, {b}");

    //    int result = a + b;
    //    return result;
    //}

    //int result1 = Chapter6.Plus(3, 4);
    //int result2 = Chapter6.Plus(5, 6);
    //int result3 = Chapter6.Plus(7, 8);


    //private void Start()
    //{
    //    int result = Plus(3, 4);
    //    Debug.Log(result);    7

    //    result = Minus(5, 2);
    //    Debug.Log(result);    3
    //}

    //public int Plus(int a, int b)
    //{
    //    return a + b;
    //}

    //public int Minus(int a, int b)
    //{
    //    return a - b;
    //}


    //void PrintProfile(string name, string phone)
    //{
    //    if(name == "")
    //    {
    //        Debug.Log("이름을 입력해주세요.");
    //        return;
    //    }
    //    Debug.Log($"Name : {name}, Phone : {phone}");
    //}

    //private void Start()
    //{
    //    PrintProfile("백다영", "456-1230");
    //    PrintProfile("", "123-4567");
    //}   Name : 백다영, Phone : 456-1230  이름을 입력해주세요


    //private void Start()
    //{
    //    Debug.Log(Plus(1, 2));        Calling int Plus(int, int)...  3
    //    Debug.Log(Plus(1, 2, 3));     Calling int Plus(int, int, int)...  6
    //    Debug.Log(Plus(1.0f, 2.4f));  Calling int Plus(float, float)...  3.4
    //    Debug.Log(Plus(1, 2.4f));     Calling int Plus(int, float)...  3.4
    //}

    //public int Plus(int a, int b)
    //{
    //    Debug.Log("Calling int Plus(int, int)...");
    //    return a + b;
    //}

    //public int Plus(int a, int b, int c)
    //{
    //    Debug.Log("Calling int Plus(int, int, int)...");
    //    return a + b + c;
    //}

    //public float Plus(float a, float b)
    //{
    //    Debug.Log("Calling int Plus(float, float)...");
    //    return a + b;
    //}

    //public float Plus(int a, float b)
    //{
    //    Debug.Log("Calling int Plus(int, float)...");
    //    return a + b;
    //}


    //int Sum(params int[] args)
    //{
    //    int sum = 0;
    //    for (int i = 0; i < args.Length; i++)
    //    {
    //        sum += args[i];
    //    }
    //    return sum;
    //}


    //static void PrintProfile(string name, string phone)
    //{
    //    Debug.Log($"{phone}, {name}");    010-123-1234  백다영
    //}

    //private void Start()
    //{
    //    PrintProfile("백다영", "010-123-1234");
    //}


    //static void PrintProfile(string name, string phone)
    //{
    //    Debug.Log($"{name}, {phone}");    백다영, 010-123-1234
    //}

    //private void Start()
    //{
    //    PrintProfile(phone: "010-123-1234", name: "백다영");
    //}


    //void MyMethod1(int a = 0)
    //{
    //    Debug.Log($"{0}, a");
    //}

    //void MyMethod2(int a, int b = 0)
    //{
    //    Debug.Log($"{0}, {1}, a, b");
    //}

    //void MyMethod3(int a, int b, int c = 10, int d = 20)
    //{
    //    Debug.Log("{0}, {1}, {2}, {3}" + (a, b, c, d));
    //}


    //public void SomeMethod()
    //{
    //    int count = 0;
    //    SomeLocalFunction(1, 2);
    //    SomeLocalFunction(3, 4);

    //    void SomeLocalFunction(int a, int b)
    //    {
    //        Debug.Log($"count : {++count}");
    //    }
    //}
}
