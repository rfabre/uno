using System;
using Windows.Media.Core;
using Windows.UI.Xaml.Controls;
using static Private.Infrastructure.TestServices;

namespace Uno.UI.RuntimeTests.Tests.Windows_UI_Xaml_Controls
{
	[TestClass]
	[RunsOnUIThread]
	public partial class Given_MediaPlayerElement
	{
		private static readonly Uri TestVideoUrl = new Uri("https://test-videos.co.uk/vids/bigbuckbunny/mp4/h264/720/Big_Buck_Bunny_720_10s_5MB.mp4");

		[TestMethod]
		public async void When_NotAutoPlay_Source()
		{
			var sut = new MediaPlayerElement()
			{
				AutoPlay = false,
				Source = MediaSource.CreateFromUri(TestVideoUrl),
			};
			WindowHelper.WindowContent = sut;
			await WindowHelper.WaitForLoaded(sut);

			// PlaybackState should transition out of Opening state when the video is ready to play.
			await WindowHelper.WaitFor(
				condition: () => sut.MediaPlayer?.PlaybackSession?.PlaybackState == Windows.Media.Playback.MediaPlaybackState.Paused,
				timeoutMS: 5000,
				message: "Timeout waiting for the media player to enter Paused state."
			);
		}
	}
}
