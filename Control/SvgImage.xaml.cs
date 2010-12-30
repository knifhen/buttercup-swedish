using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Buttercup.Control.Common;

namespace Buttercup.Control
{
    public partial class SvgImage
    {
        public static readonly DependencyProperty SourceProperty = DependencyProperty.Register(
            "Source",
            typeof (string),
            typeof (SvgImage),
            null);

        public SvgImage()
        {
            InitializeComponent();
            Loaded += OnLoaded;
            MouseLeftButtonUp += OnClick;
        }

        public string Source
        {
            get { return (string) GetValue(SourceProperty); }
            set { base.SetValue(SourceProperty, value); }
        }

        public void OnClick(object o, RoutedEventArgs e)
        {
            Logger.Log("SvgImage was clicked!");
        }

        public void OnLoaded(object o, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Source)) return;

            if (Source.EndsWith(".svg"))
            {
                var source = new Uri("http://www-qa.blissonline.se/proxy/svg?url=" + Source, UriKind.Absolute);
                Logger.Log("Svg url: " + "http://www-qa.blissonline.se/proxy/svg?url=" + Source);
                Image.SetValue(Image.SourceProperty, new BitmapImage(source));
            }
            else
            {
                var source = new Uri(Source, UriKind.RelativeOrAbsolute);
                Image.SetValue(Image.SourceProperty, new BitmapImage(source));
            }
        }
    }
}