using UnityEngine;

// 挂载到主相机上，负责发射射线检测鼠标位置
public class MouseRay2DManager : MonoBehaviour
{
    private HoverLight currentHoverObject;  // 当前被射线击中的物体

    void Update()
    {
        if (DialogueManager.Instance.inDialogue)
        {
            return;
        }
        // 从鼠标位置发射2D射线（基于主相机）
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D hit = Physics2D.GetRayIntersection(ray);

        if (hit)
        {
            // 尝试获取击中物体上的HoverSpriteSetter组件
            HoverLight target = hit.collider.GetComponent<HoverLight>();
            if (target != null)
            {
                // 如果击中了新物体，先让之前的物体恢复
                if (currentHoverObject != null && currentHoverObject != target)
                {
                    currentHoverObject.OnHoverExit();
                }
                // 通知当前物体切换到悬停图片
                currentHoverObject = target;
                currentHoverObject.OnHoverEnter();
            }
            else
            {
                // 击中了没有HoverSpriteSetter的物体，恢复之前的物体
                ExitCurrentHover();
            }
        }
        else
        {
            // 射线没有击中任何物体，恢复之前的物体
            ExitCurrentHover();
        }
    }

    // 让当前悬停的物体恢复原始图片
    private void ExitCurrentHover()
    {
        if (currentHoverObject != null)
        {
            currentHoverObject.OnHoverExit();
            currentHoverObject = null;
        }
    }
}