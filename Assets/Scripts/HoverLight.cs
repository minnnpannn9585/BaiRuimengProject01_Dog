using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverLight : MonoBehaviour
{
    
    public Sprite hoverSprite;  // 每个物体可独立设置
    
    private SpriteRenderer spriteRenderer;
    private Sprite originalSprite;  // 保存自身原始图片
    private bool isHovering = false;  // 是否正被射线击中

    void Awake()
    {
        // 获取自身的SpriteRenderer组件（必须有）
        spriteRenderer = GetComponent<SpriteRenderer>();
        // 记录原始图片
        originalSprite = spriteRenderer.sprite;
    }

    // 射线击中时调用：切换到悬停图片
    public void OnHoverEnter()
    {
        if (DialogueManager.Instance.inDialogue)
        {
            return;
        }
        if (!isHovering && hoverSprite != null)
        {
            spriteRenderer.sprite = hoverSprite;
            isHovering = true;
        }
    }

    // 射线离开时调用：恢复原始图片
    public void OnHoverExit()
    {
        if (DialogueManager.Instance.inDialogue)
        {
            return;
        }
        if (isHovering)
        {
            spriteRenderer.sprite = originalSprite;
            isHovering = false;
        }
    }
}
