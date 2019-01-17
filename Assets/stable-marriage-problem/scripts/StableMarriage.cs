using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StableMarriage : MonoBehaviour
{
    void Start() {
        var persons = TestCases.TestCase01();
        this.RunAlgorithm(persons);
        this.PrintAnswer(persons);
    }
    
    void PrintAnswer(Person[] persons) {

    }

    void RunAlgorithm(Person[] persons) {
        
    }

}
