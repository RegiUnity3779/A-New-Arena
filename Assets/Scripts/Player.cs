using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Sprite sprite;
    public Image miniMapImage;

    // Start is called before the first frame update
    void Start()
    {
        miniMapImage.sprite = sprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
