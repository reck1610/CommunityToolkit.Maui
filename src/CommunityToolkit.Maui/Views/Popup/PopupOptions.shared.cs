using Microsoft.Maui.Controls.Shapes;

namespace CommunityToolkit.Maui;

/// <summary>
/// Popup options.
/// </summary>
public partial class PopupOptions : BindableObject, IPopupOptions
{
	/// <summary>
	///  Backing BindableProperty for the <see cref="CanBeDismissedByTappingOutsideOfPopup"/> property.
	/// </summary>
	public static readonly BindableProperty CanBeDismissedByTappingOutsideOfPopupProperty = BindableProperty.Create(nameof(CanBeDismissedByTappingOutsideOfPopup), typeof(bool), typeof(PopupOptions), Options.DefaultPopupOptionsSettings.CanBeDismissedByTappingOutsideOfPopup);

	/// <summary>
	///  Backing BindableProperty for the <see cref="CanBeDismissedByBackButtonPressed"/> property.
	/// </summary>
	public static readonly BindableProperty CanBeDismissedByBackButtonPressedProperty = BindableProperty.Create(nameof(CanBeDismissedByBackButtonPressed), typeof(bool), typeof(PopupOptions), Options.DefaultPopupOptionsSettings.CanBeDismissedByBackButtonPressed);

	/// <summary>
	///  Backing BindableProperty for the <see cref="OnTappingOutsideOfPopup"/> property.
	/// </summary>
	public static readonly BindableProperty OnTappingOutsideOfPopupProperty = BindableProperty.Create(nameof(OnTappingOutsideOfPopup), typeof(Action), typeof(PopupOptions), Options.DefaultPopupOptionsSettings.OnTappingOutsideOfPopup);

	/// <summary>
	///  Backing BindableProperty for the <see cref="OnBackButtonPressed"/> property.
	/// </summary>
	public static readonly BindableProperty OnBackButtonPressedProperty = BindableProperty.Create(nameof(OnBackButtonPressed), typeof(Action), typeof(PopupOptions), Options.DefaultPopupOptionsSettings.OnBackButtonPressed);

	/// <summary>
	///  Backing BindableProperty for the <see cref="OnDismiss"/> property.
	/// </summary>
	public static readonly BindableProperty OnDismissProperty = BindableProperty.Create(nameof(OnDismiss), typeof(Action), typeof(PopupOptions), Options.DefaultPopupOptionsSettings.OnDismiss);

	/// <summary>
	///  Backing BindableProperty for the <see cref="PageOverlayColor"/> property.
	/// </summary>
	public static readonly BindableProperty PageOverlayColorProperty = BindableProperty.Create(nameof(PageOverlayColor), typeof(Color), typeof(PopupOptions), Options.DefaultPopupOptionsSettings.PageOverlayColor);

	/// <summary>
	///  Backing BindableProperty for the <see cref="Shape"/> property.
	/// </summary>
	public static readonly BindableProperty ShapeProperty = BindableProperty.Create(nameof(Shape), typeof(Shape), typeof(PopupOptions), Options.DefaultPopupOptionsSettings.Shape);

	/// <summary>
	///  Backing BindableProperty for the <see cref="Shadow"/> property.
	/// </summary>
	public static readonly BindableProperty ShadowProperty = BindableProperty.Create(nameof(Shadow), typeof(Shadow), typeof(PopupOptions), Options.DefaultPopupOptionsSettings.Shadow);

	/// <summary>
	/// An empty instance of <see cref="IPopupOptions"/> containing default values.
	/// </summary>
	public static IPopupOptions Empty { get; } = new PopupOptions();

	/// <inheritdoc/>
	/// <remarks>
	/// When true and the user taps outside the popup, it will dismiss.
	/// </remarks>
	public bool CanBeDismissedByTappingOutsideOfPopup
	{
		get => (bool)GetValue(CanBeDismissedByTappingOutsideOfPopupProperty);
		set => SetValue(CanBeDismissedByTappingOutsideOfPopupProperty, value);
	}

	/// <inheritdoc/>
	/// <remarks>
	/// On Android - when false the hardware back button is disabled.
	/// </remarks>
	public bool CanBeDismissedByBackButtonPressed
	{
		get => (bool)GetValue(CanBeDismissedByBackButtonPressedProperty);
		set => SetValue(CanBeDismissedByBackButtonPressedProperty, value);
	}

	/// <inheritdoc/>
	public Color PageOverlayColor
	{
		get => (Color)GetValue(PageOverlayColorProperty);
		set => SetValue(PageOverlayColorProperty, value);
	}

	/// <inheritdoc/>
	public Action? OnTappingOutsideOfPopup
	{
		get => (Action?)GetValue(OnTappingOutsideOfPopupProperty);
		set => SetValue(OnTappingOutsideOfPopupProperty, value);
	}

	/// <inheritdoc/>
	public Action? OnBackButtonPressed
	{
		get => (Action?)GetValue(OnBackButtonPressedProperty);
		set => SetValue(OnBackButtonPressedProperty, value);
	}

	/// <inheritdoc/>
	public Action? OnDismiss
	{
		get => (Action?)GetValue(OnDismissProperty);
		set => SetValue(OnDismissProperty, value);
	}

	/// <inheritdoc/>
	public Shape? Shape
	{
		get => (Shape?)GetValue(ShapeProperty);
		set => SetValue(ShapeProperty, value);
	}

	/// <inheritdoc/>
	public Shadow? Shadow
	{
		get => (Shadow?)GetValue(ShadowProperty);
		set => SetValue(ShadowProperty, value);
	}
}