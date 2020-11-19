using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent ( typeof( Button ) )]
public class SceneSwitcherButton : MonoBehaviour {

   [SerializeField] string targetScene;

   Button switchButton;

   void Awake ( ) {
      switchButton = GetComponent <Button> ( );

      switchButton.onClick.RemoveAllListeners ( );
      switchButton.onClick.AddListener ( ( ) => SceneManager.LoadScene ( targetScene ) );
   }

}
