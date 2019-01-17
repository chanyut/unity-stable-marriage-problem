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
        // reset state...
        foreach (var m in men) {
            m.currentPrefIdx = 0;
        }

        int round = 1;
        while (true) {
            bool stillHasASingleMan = false;
            for (int i=0; i<men.Length; i++) {
                if (men[i].fiance == null) {
                    stillHasASingleMan = true;
                    break;
                }
            }
            if (!stillHasASingleMan) {
                break;
            }

            for (int i=0; i<men.Length; i++) {
                var m = men[i];
                if (m.fiance != null) {
                    continue;
                }
                for (; m.currentPrefIdx<m.preferences.Count; m.currentPrefIdx++) {
                    var w = m.preferences[m.currentPrefIdx];
                    if (w.fiance == null) {
                        m.fiance = w;
                        w.fiance = m;
                        break;
                    } else {
                        var newPerfIdx = w.preferences.IndexOf(m);
                        var oldPerfIdx = w.preferences.IndexOf(w.fiance);
                        if (newPerfIdx < oldPerfIdx) {
                            w.fiance.fiance = null;
                            m.fiance = w;
                            w.fiance = m;
                            break;
                        } else {
                            // do nothing
                        }
                    }
                }
            }

            // debug
            Debug.LogFormat("round: {0}", round++);
            foreach (var m in men) {
                m.DebugMyRelationship();
            }
            yield return null;
        }
    }

}
