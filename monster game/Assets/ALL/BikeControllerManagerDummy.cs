using UnityEngine;
using UnityEngine.UI;

namespace RGSK
{
    public class BikeControllerManagerDummy : MonoBehaviour
    {

        public Text caliculatingAce;
        public static BikeControllerManagerDummy instance;

        public bool isBikeRotate = true;
        private bool isOnce = false;

        void Start()
        {
            instance = this;

        }

        void Update()
        {


       //     if (Input.GetKeyDown(KeyCode.UpArrow) && !isOnce)
      //      {

      //          GameObject.FindGameObjectWithTag("Bike").GetComponent<Animator>().SetTrigger("Up");
      //          isOnce = true;
       //     }
            if (InputManager.instance.mobileInput.accelerate.inputValue > 0 && !isOnce)
           {
                GameObject.FindGameObjectWithTag("Bike").GetComponent<Animator>().SetTrigger("Up");
                isOnce = true;
            }

        }
    }
}
