﻿using Windows.UI.Xaml;

namespace Uno.UI.Xaml.Controls.Extensions;

internal interface IOverlayTextBoxViewExtension
{
	bool IsOverlayLayerInitialized(XamlRoot xamlRoot);

	void StartEntry();

	void EndEntry();

	void UpdateNativeView();

	void InvalidateLayout();

	void UpdateSize();

	void UpdatePosition();

	void SetText(string text);

	void SetIsPassword(bool isPassword);

	void Select(int start, int length);

	int GetSelectionStart();

	int GetSelectionLength();

	void UpdateProperties();
}