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

    /**
    // reference - https://en.wikipedia.org/wiki/Stable_marriage_problem
    function stableMatching {
        Initialize all m ∈ M and w ∈ W to free
        while ∃ free man m who still has a woman w to propose to {
                w = first woman on m’s list to whom m has not yet proposed
                if w is free
                    (m, w) become engaged
                else some pair (m', w) already exists
                    if w prefers m to m'
                    m' becomes free
                    (m, w) become engaged 
                    else
                    (m', w) remain engaged
            }  
    }
    */
}
