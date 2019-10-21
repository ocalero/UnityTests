using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript
{

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    static void someFunction() {
        Debug.Log("Some Function");

    }
}
