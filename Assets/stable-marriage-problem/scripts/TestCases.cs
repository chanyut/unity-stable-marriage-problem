using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCases
{
    public static Tuple<Person[], Person[]> TestCase01() {
        var m1 = new Person("m1");
        var m2 = new Person("m2");
        var m3 = new Person("m3");
        var w1 = new Person("w1");
        var w2 = new Person("w2");
        var w3 = new Person("w3");
        
        m1.preferences = new List<Person>() { w2, w1, w3 };
        m2.preferences = new List<Person>() { w2, w3, w1 };
        m3.preferences = new List<Person>() { w2, w3, w1 };

        w1.preferences = new List<Person>() { m3, m2, m1 };
        w2.preferences = new List<Person>() { m1, m2, m3 };
        w3.preferences = new List<Person>() { m1, m3, m2 };
        
        return new Tuple<Person[], Person[]>(
            new Person[] { m1, m2, m3 },
            new Person[] { w1, w2, w3 }
        );
    }

}
