using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCases
{
    public static Person[] TestCase01() {
        var p1 = new Person("p1");
        var p2 = new Person("p2");
        var p3 = new Person("p3");
        var p4 = new Person("p4");
        var p5 = new Person("p5");

        p1.preferences = new List<Person>() { p5, p3, p4, p2 };
        p2.preferences = new List<Person>() { p4, p3, p1, p5 };
        p3.preferences = new List<Person>() { p1, p5, p2, p4 };
        p4.preferences = new List<Person>() { p5, p1, p2, p3 };
        p5.preferences = new List<Person>() { p2, p4, p1, p3 };
        
        return new Person[] { p1, p2, p3, p4, p5 };
    }

}
