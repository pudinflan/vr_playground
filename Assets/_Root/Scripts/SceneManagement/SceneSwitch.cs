using UnityEngine;
using UnityEngine.SceneManagement;

namespace Carnival.SceneManagement
{
	public class SceneSwitch : MonoBehaviour
	{
		[SerializeField] private string _sceneToLoad;

		public void Button_LoadScene() => SceneManager.LoadScene(_sceneToLoad);
	}
}
