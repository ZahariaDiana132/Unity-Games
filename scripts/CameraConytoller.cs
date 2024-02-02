using UnityEngine;

public class CameraConytoller : MonoBehaviour
{
   [SerializeField] private Transform lilDude;
   float cameraFar = -10f;
    private void Update()
    {
        transform.position = new Vector3(lilDude.position.x,lilDude.position.y - 0.1f,cameraFar);
    }
}
