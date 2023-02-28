using UnityEngine;
using Unity;
using UnityEngine.EventSystems;
public class TouchObject : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    Vector2 downPos;
    Vector2 upPos;

    public GameObject Player;
    public void OnPointerDown(PointerEventData eventData)
    {
        downPos = eventData.position;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        upPos = eventData.position;
        Vector2 swipePos = (downPos - upPos).normalized;
        Debug.Log($"위치가 나오는 가 : {swipePos}");
        if (swipePos.x > 0.7f && swipePos.y < 0.7f && swipePos.y > -0.7f)
        {
            Player.GetComponent<PlayerMove>().moveLeft();
        }
        else if (swipePos.x < -0.7f && swipePos.y < 0.7f && swipePos.y > -0.7f)
        {
            Player.GetComponent<PlayerMove>().moveRight();
        }
        else if (swipePos.y < -0.7f && swipePos.x < 0.7f && swipePos.x > -0.7f)
        {
            Player.GetComponent<PlayerMove>().moveUp();
        }
        else if (swipePos.y > 0.7f && swipePos.x < 0.7f && swipePos.x > -0.7f)
        {
            Player.GetComponent<PlayerMove>().moveDown();
        }
    }
}