
public class Application {

	private string Id {get; set;}
	private string WindowName {get; set;}
	private string WindowTitle {get; set;}
	//private int SW = WinUser.SW_SHOWMAXIMIZED;


	public int getSW() {

		return 1;//SW;
	}

	public void SW_SHOWMAXIMIZED() {

		//SW = WinUser.SW_SHOWMAXIMIZED;
	}


	public void SW_MAXIMIZE() {

		//SW = WinUser.SW_MAXIMIZE;
	}

	/**
	 *
	 * Minimize the application
	 *
	 */
	public void SW_MINIMIZE() {

		//SW = WinUser.SW_MINIMIZE;
	}

	/**
	 *
	 * Show the application minimized
	 *
	 */
	public void SW_SHOWMINIMIZED() {

		//SW = WinUser.SW_SHOWMINIMIZED;
	}

	/**
	 *
	 * Force the application to minimize
	 *
	 */
	public void SW_FORCEMINIMIZE() {

		//SW = WinUser.SW_FORCEMINIMIZE;
	}

	/**
	 *
	 * Restore the application to previous size
	 *
	 */
	public void SW_RESTORE() {

		//SW = WinUser.SW_RESTORE;
	}

	/**
	 *
	 * Set the application to normal size
	 *
	 */
	public void SW_NORMAL() {

		//SW = WinUser.SW_NORMAL;
	}

	/**
	 *
	 * Show the application in normal size
	 *
	 */
	public void SW_SHOWNORMAL() {

		//SW = WinUser.SW_SHOWNORMAL;
	}
}