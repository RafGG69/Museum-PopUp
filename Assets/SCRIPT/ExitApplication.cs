using UnityEngine;

public class ExitApplication : MonoBehaviour
{
    public void ExitApp()
    {
        // Ini akan mencoba keluar dari aplikasi pada perangkat Android.
        // Perhatikan bahwa Android mungkin tidak memungkinkan aplikasi keluar di semua situasi.
        // Ini disarankan hanya untuk penggunaan yang terbatas, seperti permainan.
#if UNITY_EDITOR
        // Di dalam Unity Editor, hentikan mode bermain.
        UnityEditor.EditorApplication.isPlaying = false;
#else
            // Di perangkat Android, coba untuk keluar dari aplikasi.
            Application.Quit();
#endif
    }
}
