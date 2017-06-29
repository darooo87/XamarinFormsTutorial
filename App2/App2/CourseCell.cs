using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App2
{
    public class CourseCell : ViewCell
    {
        public CourseCell()
        {
            var titleLabel = new Label()
            {
                Font = Font.SystemFontOfSize(NamedSize.Medium),

            };
            titleLabel.SetBinding(Label.TextProperty, new Binding("Name"));

            var AuthorLabel = new Label()
            {
                Font = Font.SystemFontOfSize(NamedSize.Micro),
                XAlign = TextAlignment.End,
                HorizontalOptions = LayoutOptions.FillAndExpand,
            };
            AuthorLabel.SetBinding(Label.TextProperty, new Binding("Title"));

            View = new StackLayout()
            {
                Children = { titleLabel, AuthorLabel },
                Orientation = StackOrientation.Horizontal
            };


        }
    }
}
