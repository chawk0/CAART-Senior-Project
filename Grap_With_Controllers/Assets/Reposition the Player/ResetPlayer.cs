using UnityEngine;

public class ResetPlayer : MonoBehaviour
{
    [SerializeField] Transform resetTransform;
    [SerializeField] GameObject player;
    [SerializeField] Camera playerHead;



    public void ResetPosition()
    {
        var rotationAngleY = resetTransform.rotation.eulerAngles.y - playerHead.transform.rotation.eulerAngles.y;

        player.transform.Rotate(0, -rotationAngleY, 0);

        var ditanceDiff = resetTransform.position - playerHead.transform.position;

        player.transform.position += ditanceDiff;
    }
}
