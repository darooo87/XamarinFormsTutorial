﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class relativepage : ContentPage
	{
		public relativepage ()
		{
			InitializeComponent ();

            var layout = new RelativeLayout();
            Content = layout;

            var aquabox = new BoxView { Color = Color.Aqua };

            layout.Children.Add(aquabox,
                widthConstraint: Constraint.RelativeToParent(parent => parent.Width),
                heightConstraint: Constraint.RelativeToParent(parent => parent.Height * 0.3));

            var silverBox = new BoxView { Color = Color.Silver };

            layout.Children.Add(silverBox,
                yConstraint: Constraint.RelativeToView(aquabox, (RelativeLayout, element) => element.Height + 20));
		}
	}
}