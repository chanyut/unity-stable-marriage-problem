using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person {
    public string name;
    public Person fiance;
    public List<Person> preferences;
    public int currentPrefIdx;

    public Person(string name) {
        this.name = name;
        this.preferences = new List<Person>();
        this.fiance = null;
        this.currentPrefIdx = 0;
    }

    public void DebugMyRelationship() {
        Debug.LogFormat("relationship: {0} - {1}", this.name, this.fiance == null? "none": this.fiance.name);
    }

}