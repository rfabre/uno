using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using FluentAssertions;
using Microsoft.UI.Xaml.Tests.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Windows.Media.Playback;
using Windows.Phone.Notification.Management;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Automation.Peers;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using static Private.Infrastructure.TestServices;

namespace Uno.UI.RuntimeTests.Tests.Windows_UI_Xaml_Controls
{
	[TestClass]
	[RunsOnUIThread]
	public class Given_MediaPlayerElement
	{
		[TestMethod]
		public void When_MediaPlayerElement_Not_SetSource_Property_Value()
		{
			var entity = new MediaPlayerElement();
			entity.SetMediaPlayer(new Windows.Media.Playback.MediaPlayer());
			entity.MediaPlayer.Play();
			entity.GetValue(MediaPlayerElement.SourceProperty);

			Assert.IsNull(entity.Source);
		}

		[TestMethod]
		public void When_MediaPlayerElement_SetSource_Property_Value()
		{
			var entity = new MediaPlayerElement();
			entity.AutoPlay = true;
			entity.Source = Windows.Media.Core.MediaSource.CreateFromUri(new Uri("https://test-videos.co.uk/vids/bigbuckbunny/mp4/h264/720/Big_Buck_Bunny_720_10s_5MB.mp4"));
			entity.GetValue(MediaPlayerElement.SourceProperty);
			entity.Should().NotBeNull();
		}

		[TestMethod]
		public async Task When_MediaPlayerElement_Added_In_Opening()
		{
			MediaPlayerElement entity = await StartPlayerAsync();

			entity.MediaPlayer.Play();

			var mediaTransportControls = entity.TransportControls as MediaTransportControls;
			Assert.IsNotNull(mediaTransportControls);

			var mediaPlayer = entity.MediaPlayer as Windows.Media.Playback.MediaPlayer;
			Assert.IsNotNull(mediaPlayer);
		}

		[TestMethod]
		public void When_MediaPlayerElement_Dependency_Property_Value()
		{
			var entity = new MediaPlayerElement();
			entity.AutoPlay = true;
			entity.Source = Windows.Media.Core.MediaSource.CreateFromUri(new Uri("https://test-videos.co.uk/vids/bigbuckbunny/mp4/h264/720/Big_Buck_Bunny_720_10s_5MB.mp4"));
			entity.ApplyTemplate();
			entity.SetMediaPlayer(new Windows.Media.Playback.MediaPlayer());
			entity.MediaPlayer.Play();

			entity.GetValue(MediaPlayerElement.SourceProperty);
			entity.Should().NotBeNull();
		}

		[TestMethod]
		public async Task When_MediaPlayerElement_SetIsFullWindow_Check_Fullscreen()
		{

			MediaPlayerElement entity = await StartPlayerAsync();
			try
			{

				entity.IsFullWindow = true;

				Thread.Sleep(3000);
				entity.GetValue(MediaPlayerElement.IsFullWindowProperty);
				entity.Should().NotBeNull();
			}
			finally
			{
				entity.IsFullWindow = false;
			}
		}

		[TestMethod]
		public async Task When_MediaPlayerElement_SetSource_Check_Play()
		{
			MediaPlayerElement entity = await StartPlayerAsync();

			entity.MediaPlayer.Play();

			Thread.Sleep(3000);
			Assert.IsTrue(entity.MediaPlayer.PlaybackSession.IsPlaying);
		}

		[TestMethod]
		public async Task When_MediaPlayerElement_SetSource_Check_PausePlayStop()
		{
			MediaPlayerElement entity = await StartPlayerAsync();

			entity.MediaPlayer.Play();
			Thread.Sleep(3000);
			Thread.Yield();

			Assert.AreEqual(entity.MediaPlayer.PlaybackSession.PlaybackState, MediaPlaybackState.Playing);

			// step 2: Test Stop
			entity.MediaPlayer.Stop();
			Assert.AreEqual(entity.MediaPlayer.PlaybackSession.Position, TimeSpan.Zero);

			// step 3: Test Pause
			entity.MediaPlayer.Play();
			Thread.Sleep(TimeSpan.FromSeconds(3).Milliseconds);
			entity.MediaPlayer.Pause();
			var pausePosition = entity.MediaPlayer.PlaybackSession.Position;
			Thread.Sleep(TimeSpan.FromSeconds(3).Milliseconds);
			Assert.AreEqual(entity.MediaPlayer.PlaybackSession.Position, pausePosition);
			Assert.AreEqual(entity.MediaPlayer.PlaybackSession.PlaybackState, MediaPlaybackState.Paused);

		}

		public async Task<MediaPlayerElement> StartPlayerAsync()
		{
			var entity = new MediaPlayerElement();
			entity.Source = Windows.Media.Core.MediaSource.CreateFromUri(new Uri("https://test-videos.co.uk/vids/bigbuckbunny/mp4/h264/720/Big_Buck_Bunny_720_10s_5MB.mp4"));
			entity.AutoPlay = true;

			//Load Player
			WindowHelper.WindowContent = entity;
			await WindowHelper.WaitForLoaded(entity);
			return entity;
		}
	}
}
