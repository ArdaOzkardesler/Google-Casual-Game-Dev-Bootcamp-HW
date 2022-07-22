using UnityEngine;
using UnityEngine.Events;
 
public class CameraRotation : MonoBehaviour
{
   public float maxIdleTime = 3f;
   Vector3 lastMousePos = Vector3.zero;
   float counter = 0f;
   [SerializeField] Transform sun;
   [SerializeField] float rotationSpeed;
 
   void Update()
   {
      Vector3 mousePosition = Input.mousePosition;
      if ( lastMousePos==mousePosition)
      {
         counter += Time.deltaTime;
         counter = Mathf.Min( maxIdleTime, counter) ;
      }
      else
      {
         lastMousePos = mousePosition;
         counter = 0f;
         
      }
      if ( counter == maxIdleTime )
      {
            transform.RotateAround(sun.position,Vector3.up,rotationSpeed*Time.deltaTime);
      }
   }
}
