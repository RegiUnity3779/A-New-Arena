using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{

    public Sprite sprite;
    public MiniMapIcon mapIcon;

    // Start is called before the first frame update
    void Start()
    {
        mapIcon.UpdateMiniMapIcon(sprite);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
