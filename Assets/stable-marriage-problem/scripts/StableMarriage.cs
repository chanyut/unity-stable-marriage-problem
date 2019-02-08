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

    IEnumerator RunAlgorithm(Person[] men, Person[] women)
    {
        //Person p;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    for (int l = 0; l < 3; l++)
                    {
                        if (men[j].preferences[i].name == women[k].name && women[k].preferences[l].name == men[j].name)
                        {
                            if (men[j].fiance == null)
                            {
                                if (women[k].fiance != null)
                                {
                                    if(women[k].preferences.IndexOf(women[k].preferences[l]) < women[k].preferences.IndexOf(women[k].fiance))
                                    {
                                        foreach (var x in men)
                                        {                                    
                                            if( x.fiance == women[k])
                                            {
                                                x.fiance = null;
                                            }
                                        }
                                    
                                        men[j].fiance = women[k];
                                        women[k].fiance = men[j];
                                    }
                                }
                                else 
                                {
                                    men[j].fiance = women[k];
                                    women[k].fiance = men[j];
                                   // men.IndexOf(women[k].preferences[j])
                                }
                            }
                        }
                    }
                   
                }
            }

        }
        yield return null;
    }
    // if (men[i].preferences[j].name == women[k].name /*&& women[j].preferences[j].name == men[i].name*/)
    //   men[i].fiance = women[k];               
    /*
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
