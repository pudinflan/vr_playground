using UnityEngine;
using UnityEngine.SceneManagement;

namespace Carnival.SceneManagement
{
	public class SceneReset : MonoBehaviour
	{
		public void BigRedButton_ResetScene() => SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
