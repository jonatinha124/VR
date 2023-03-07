using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Counter : MonoBehaviour
{
    public int counter;
    public TMP_Text counter_text;
    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
    }

   public void Increment()
    {
        counter += 1;
        counter_text.text = "Enemies" + counter; 
        Debug.Log("Counter: " + counter);
    }
}
