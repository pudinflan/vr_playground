using UnityEngine;
using UnityEngine.SceneManagement;

namespace Carnival.SceneManagement
{
	public class SceneReset : MonoBehaviour
	{
		public void ResetScene() => SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
