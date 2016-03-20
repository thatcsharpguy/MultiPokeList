using System;

using Xamarin.Forms;

namespace MultiPokeListView.Controls
{
    public class PokemonSelectableCell : ViewCell
    {
        public static readonly BindableProperty NameProperty =
            BindableProperty.Create ("Name", typeof(string), typeof(PokemonSelectableCell), "Charmander");
        
        public static readonly BindableProperty WeightProperty =
            BindableProperty.Create ("Weight", typeof(double), typeof(PokemonSelectableCell), 8.5D);
        
        public static readonly BindableProperty HeightProperty =
            BindableProperty.Create ("Height", typeof(double), typeof(PokemonSelectableCell), 0.6D);

        public string Name {
            get { return(string)GetValue (NameProperty); }
            set { SetValue (NameProperty, value); }
        }

        public double Weight {
            get { return(double)GetValue (WeightProperty); }
            set { SetValue (WeightProperty, value); }
        }

        public double Height {
            get { return(double)GetValue (HeightProperty); }
            set { SetValue (HeightProperty, value); }
        }

        Label lbName, lbWeight, lbHeight;

        public PokemonSelectableCell()
        {
            lbName = new Label{ HorizontalOptions = LayoutOptions.StartAndExpand };
            lbWeight = new Label{ HorizontalOptions = LayoutOptions.EndAndExpand };;
            lbHeight = new Label{ HorizontalOptions = LayoutOptions.EndAndExpand };;

            Grid infoLayout = new Grid
            {
                ColumnDefinitions = 
                {
                    new ColumnDefinition { Width = new GridLength(3,GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1,GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1,GridUnitType.Star) }
                },
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            infoLayout.Children.Add(lbName,0,0);
            infoLayout.Children.Add(lbWeight,1,0);
            infoLayout.Children.Add(lbHeight,2,0);

            var cellWrapper = new Grid 
            {
                Padding = 10,
                ColumnDefinitions = 
                {
                    new ColumnDefinition { Width = new GridLength(1,GridUnitType.Auto) },
                    new ColumnDefinition { Width = new GridLength(1,GridUnitType.Star) },
                }
            };

			//var cb = new CheckBox();
            //cellWrapper.Children.Add(cb, 0, 0);
			var sw = new Switch();
            sw.SetBinding(Switch.IsToggledProperty, "IsSelected");

			cellWrapper.Children.Add(sw, 0, 0);
            cellWrapper.Children.Add(infoLayout, 1, 0);

            View = cellWrapper;
        }

        protected override void OnBindingContextChanged ()
        {
            base.OnBindingContextChanged ();

            if (BindingContext != null) {
                lbName.Text = Name;
                lbWeight.Text = Weight.ToString() + " kg";
                lbHeight.Text = Height.ToString() + " m";
            }
        }
    }
}


