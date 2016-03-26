// ***********************************************************************
// Assembly         : XLabs.Forms
// Author           : XLabs Team
// Created          : 12-27-2015
// 
// Last Modified By : XLabs Team
// Last Modified On : 01-04-2016
// ***********************************************************************
// <copyright file="CheckBox.cs" company="XLabs Team">
//     Copyright (c) XLabs Team. All rights reserved.
// </copyright>
// <summary>
//       This project is licensed under the Apache 2.0 license
//       https://github.com/XLabs/Xamarin-Forms-Labs/blob/master/LICENSE
//       
//       XLabs is a open source project that aims to provide a powerfull and cross 
//       platform set of controls tailored to work with Xamarin Forms.
// </summary>
// ***********************************************************************
// 

using System;
using Xamarin.Forms;

namespace MultiPokeListView.Controls
    {
        /// <summary>
        /// The check box.
        /// </summary>
        public class CheckBox : View
        {
            /// <summary>
            /// The checked state property.
            /// </summary>
            public static readonly BindableProperty CheckedProperty =
                BindableProperty.Create ("Checked", 
                    typeof(bool), 
                    typeof(CheckBox), 
                    false, BindingMode.TwoWay,propertyChanged: OnCheckedPropertyChanged);

            /// <summary>
            /// The checked state property.
            /// </summary>
            public static readonly BindableProperty EnabledProperty =
                BindableProperty.Create("Enabled",
                    typeof(bool),
                    typeof(CheckBox),
                    false, BindingMode.TwoWay, propertyChanged: OnEnabledPropertyChanged);
		

            /// <summary>
            /// Gets or sets a value indicating whether the control is checked.
            /// </summary>
            /// <value>The checked state.</value>
            public bool Checked
            {
                get { return (bool)GetValue(CheckedProperty); }
                set
                {
                    if(this.Checked != value) {
                        this.SetValue(CheckedProperty, value);
                        //this.CheckedChanged.Invoke(this, new EventArgs<bool>(value));
                    }
                }
            }

            /// <summary>
            /// Gets or sets a value indicating whether the control is checked.
            /// </summary>
            /// <value>The checked state.</value>
            public bool Enabled
            {
                get { return (bool)GetValue(EnabledProperty); }
                set
                {
                    if (this.Enabled != value)
                    {
                        this.SetValue(EnabledProperty, value);
                        //this.CheckedChanged.Invoke(this, new EventArgs<bool>(value));
                    }
                }
            }

            /// <summary>
            /// Called when [checked property changed].
            /// </summary>
            /// <param name="bindable">The bindable.</param>
            /// <param name="oldvalue">if set to <c>true</c> [oldvalue].</param>
            /// <param name="newvalue">if set to <c>true</c> [newvalue].</param>
            private static void OnCheckedPropertyChanged(BindableObject bindable, object oldvalue, object newvalue)
            {
                var checkBox = (CheckBox)bindable;
                checkBox.Checked = (bool)newvalue;
            }

            /// <summary>
            /// Called when [enabled property changed].
            /// </summary>
            /// <param name="bindable">The bindable.</param>
            /// <param name="oldvalue">if set to <c>true</c> [oldvalue].</param>
            /// <param name="newvalue">if set to <c>true</c> [newvalue].</param>
            private static void OnEnabledPropertyChanged(BindableObject bindable, object oldvalue, object newvalue)
            {
                var checkBox = (CheckBox)bindable;
                checkBox.Enabled = (bool)newvalue;
            }
        }
    }