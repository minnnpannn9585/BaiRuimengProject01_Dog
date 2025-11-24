using UnityEngine;

public class Cookie : MonoBehaviour
{
    [Tooltip("2D游戏Z轴固定值（建议设为0，避免前后错位）")]
    public float fixedZ = 0f;

    private bool isFollowing = false; // 是否正在跟随鼠标
    private Vector3 mouseOffset; // 鼠标与物体中心的偏移量（关键：防止点击瞬间跳转）

    void Update()
    {

        // 1. 检测鼠标单击（左键），切换跟随状态
        if (Input.GetMouseButtonDown(0))
        {
            CheckClickToToggleFollow();
        }

        // 2. 跟随期间，每一帧同步鼠标位置（瞬间跟随）
        if (isFollowing)
        {
            SyncWithMousePosition();
        }
    }

    private void CheckClickToToggleFollow()
    {
        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPos.z = fixedZ;

        RaycastHit2D hit = Physics2D.Raycast(mouseWorldPos, Vector2.zero);

        if (hit.collider != null)
        {
            if (hit.collider.gameObject == gameObject)
            {
                isFollowing = !isFollowing;
            }
        }
    }
    
    private void SyncWithMousePosition()
    {
        // 实时更新鼠标世界坐标
        Vector3 targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        targetPos.z = fixedZ; // 固定Z轴，保持2D层级
        transform.position = targetPos;
    }
}