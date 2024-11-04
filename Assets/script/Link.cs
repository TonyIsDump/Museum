using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Link : MonoBehaviour
{
    public void OpenWebsite(string url = "https://www.polyu.edu.hk/en/")
    {
    	Application.OpenURL(url);
    }
}
