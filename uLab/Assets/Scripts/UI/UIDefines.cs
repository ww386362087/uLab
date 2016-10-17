

using System.Collections;
using System.Collections.Generic;


namespace Locke.ui
{

	public enum ShowMode
	{
		Normal = 0,
		Fixed,
		Popup,
		Alone,
	}

	public enum OpenAction
	{
		DoNothing,
		HideOthers,
	}

	public enum CloseAction
	{
		Traceback,
		DoNotTraceback,
	}

	public class WindowInfo
	{
		public string prefabPath;
		public string windowName;
		public ShowMode showMode = ShowMode.Normal;
		public OpenAction openAct = OpenAction.DoNothing;
		public CloseAction closeAct = CloseAction.Traceback;

		public WindowInfo(string path, ShowMode showMode, OpenAction openAct, CloseAction closeAct)
		{
			this.prefabPath = path;
			this.windowName = path.Substring(path.LastIndexOf('/') + 1);
			this.showMode = showMode;
			this.openAct = openAct;
			this.closeAct = closeAct;
		}

	}


	public abstract class IContext
	{
		public WindowInfo winInfo;
		public IWindow windowScript;

		public List<WindowInfo> hiddenWindows = new List<WindowInfo>();

	}

}