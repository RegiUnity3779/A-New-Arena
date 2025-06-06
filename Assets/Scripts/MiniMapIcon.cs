using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MiniMapIcon : MonoBehaviour
{
    public Image miniMapImage;

    public void UpdateMiniMapIcon(Sprite sprite)
    {
        miniMapImage.sprite = sprite;
    }
}
