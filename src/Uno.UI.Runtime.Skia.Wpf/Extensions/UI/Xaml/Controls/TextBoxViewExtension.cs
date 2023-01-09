﻿#nullable enable

using Uno.UI.Runtime.Skia.UI.Xaml.Controls;
using Uno.UI.Xaml.Controls.Extensions;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Uno.UI.Runtime.Skia.WPF.Extensions.UI.Xaml.Controls;

internal class TextBoxViewExtension : OverlayTextBoxViewExtension
{
	public TextBoxViewExtension(TextBoxView owner) :
		base(owner, WpfTextBoxView.Create)
	{
	}

	public override bool IsOverlayLayerInitialized(XamlRoot xamlRoot) =>
		WpfTextBoxView.GetOverlayLayer(xamlRoot) is not null;
}
