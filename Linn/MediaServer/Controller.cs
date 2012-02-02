
using System;


namespace Linn.MediaServer
{
	public interface IView
	{
		void SetUri(string aUri);
		void Show();
		bool IsVisible();
	}

	
	public class Controller
	{
		public Controller(IView aView)
		{
			iView = aView;
		}

		public void OpenConfigurationClicked()
		{
			if (!iView.IsVisible())
			{
				iView.SetUri("http://www.google.com");
			}
			iView.Show();
		}

		private IView iView;
	}
}


