using UnityEngine;
using System.Collections;

public class InputField : MonoBehaviour
{

    TouchScreenKeyboard keyboard;
    public  string keyboardText = "Input any";
    public string keyname;
    public string title;

    
    private void Awake()
    {
        if (PlayerPrefs.GetString(keyname) != "")
            keyboardText = PlayerPrefs.GetString(keyname);

        gameObject.GetComponent<TextMesh>().text = keyboardText;        
    }

    void OnSelect()
    {
        if (keyboard == null)
            keyboard = new TouchScreenKeyboard(keyboardText, TouchScreenKeyboardType.Default, false, false, false, false, title);
        else
        {
            keyboard.text = gameObject.GetComponent<TextMesh>().text;
            keyboard.active = true;

        }
    }
    void Update()
    {
        
        if (keyboard != null && keyboard.active == false)
        {
            if (keyboard.done == true)
            {
                
                keyboardText = keyboard.text;
                keyboard = null;
           
            }
        }
        gameObject.GetComponent<TextMesh>().text = keyboardText;
    }
    private void OnDestroy()
    {
        string s = gameObject.GetComponent<TextMesh>().text;
        Debug.Log("save[" + keyname + "]=" + s);
        PlayerPrefs.SetString(keyname, s);
    }
}