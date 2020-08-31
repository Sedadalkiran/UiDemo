using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UIElements;

public class UIManager : MonoBehaviour
{
    public RectTransform top, right;
 
  
    public void MovePanel()
    {
        
        right.DOAnchorPos(new Vector2(50, 0), 0.5f);

       
    }
}
