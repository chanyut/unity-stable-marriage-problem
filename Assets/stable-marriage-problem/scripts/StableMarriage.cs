using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StableMarriage : MonoBehaviour
{
    IEnumerator Start() {
        var t = TestCases.TestCase01();
        yield return this.RunAlgorithm(t.Item1, t.Item2);
        this.PrintAnswer(t.Item1);
    }
    
    void PrintAnswer(Person[] persons) {
        Debug.Log("answer...");
        for (int i=0; i<persons.Length; i++) {
            persons[i].DebugMyRelationship();
        }
    }

    IEnumerator RunAlgorithm(Person[] men, Person[] women) {
        yield return null;
    }

}
