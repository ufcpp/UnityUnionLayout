using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using Random = System.Random;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]
    Text _text;

    void Start()
    {
        var data = SampleData.CreateData();
        //foreach (var x in data) Debug.Log(x.ToString());
        var text = string.Join("\n", data);
        Debug.Log(text);
        _text.text = text;
    }

    void Update()
    {
        
    }
}
