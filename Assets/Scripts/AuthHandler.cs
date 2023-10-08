using UnityEngine;
using UnityEngine.UI;
using FirebaseWebGL.Scripts.FirebaseBridge;
using TMPro;

namespace FirebaseWebGL.Auth
{
    public class AuthHandler : MonoBehaviour
    {
        public TMP_InputField emailInput;
        public TMP_InputField passwordInput;

        public TMP_Text statusText;

        private void Start()
        {
            if (Application.platform != RuntimePlatform.WebGLPlayer)
            {
                DisplayError("Webgl �÷����� �ƴϸ� Javascript ����� �νĵ��� �ʽ��ϴ�.");
                return;
            }
        }

        private void DisplayError(string errortext)
        {
            statusText.text = errortext;
        }

        private void DisPlayInfo(string Infotext)
        {
            statusText.text = Infotext;
        }


        public void CreateUserWithEmailAndPassword() =>
            FirebaseAuth.CreateUserWithEmailAndPassword(emailInput.text, passwordInput.text, gameObject.name, "DisPlayInfo", "DisplayError");

    }

}