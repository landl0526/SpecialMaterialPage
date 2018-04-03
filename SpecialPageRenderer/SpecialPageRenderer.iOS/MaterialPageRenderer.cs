using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using SpecialPageRenderer;
using SpecialPageRenderer.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(MaterialPage), typeof(MaterialPageRenderer))]
namespace SpecialPageRenderer.iOS
{
    public class MaterialPageRenderer : PageRenderer
    {
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            if (Element != null)
            {
                var materialView = UIStoryboard.FromName("Main", null).InstantiateViewController("ViewController").View;

                NativeView.AddSubview(materialView);
            }
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            //If you want to dismiss the native navigation bar
            ViewController.NavigationController?.SetNavigationBarHidden(true, true);
        }
    }
    
}