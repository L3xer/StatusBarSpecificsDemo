using Xamarin.Forms;
using FormsElement = Xamarin.Forms.Page;


namespace StatusBarSpecificsDemo.PlatformConfiguration.Android
{
    public static class StatusBarColor
    {
        const string EffectName = "MyCompany.StatusBarColorEffect";

        public static readonly BindableProperty ColorProperty =
            BindableProperty.CreateAttached("Color",
                                            typeof(Color),
                                            typeof(StatusBarColor),
                                            Color.Transparent,
                                            propertyChanged: OnColorPropertyChanged);

        public static Color GetColor(BindableObject element)
        {
            return (Color)element.GetValue(ColorProperty);
        }

        public static void SetColor(BindableObject element, Color color)
        {
            element.SetValue(ColorProperty, color);
        }

        static void OnColorPropertyChanged(BindableObject element, object oldValue, object newValue)
        {
            var newColor = (Color)newValue;
            var oldColor = (Color)oldValue;

            if (newColor == oldColor)
                return;

            AttachEffect(element as FormsElement);
        }

        static void AttachEffect(FormsElement element)
        {
            element.Effects.Clear();

            IElementController controller = element;
            if (controller == null || controller.EffectIsAttached(EffectName)) {
                return;
            }
            element.Effects.Add(Effect.Resolve(EffectName));
        }

        public static IPlatformElementConfiguration<Xamarin.Forms.PlatformConfiguration.Android, FormsElement> SetStatusBarColor(this IPlatformElementConfiguration<Xamarin.Forms.PlatformConfiguration.Android, FormsElement> config, Color color)
        {
            SetColor(config.Element, color);
            return config;
        }

        public class StatusBarColorEffect : RoutingEffect
        {
            public StatusBarColorEffect() : base(EffectName)
            {
            }
        }
    }
}
