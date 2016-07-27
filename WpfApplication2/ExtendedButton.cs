﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfApplication2
{
    public class ExtendedButton : Button
    {
        public static string DefaultText { get; set; }

        static ExtendedButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ExtendedButton),
                new FrameworkPropertyMetadata(typeof(ExtendedButton)));
        }

        public ExtendedButton()
        {
            Text = DefaultText;
        }

        #region Dependency Properties
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Text.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(ExtendedButton), new PropertyMetadata(null));


        public Brush EnabledForegroundBrush
        {
            get { return (Brush)GetValue(EnabledForegroundBrushProperty); }
            set { SetValue(EnabledForegroundBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for EnabledForegroundBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty EnabledForegroundBrushProperty =
            DependencyProperty.Register("EnabledForegroundBrush", typeof(Brush), typeof(ExtendedButton), new PropertyMetadata(Brushes.Black));


        public Brush DisabledForegroundBrush
        {
            get { return (Brush)GetValue(DisabledForegroundBrushProperty); }
            set { SetValue(DisabledForegroundBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DisabledForegroundBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DisabledForegroundBrushProperty =
            DependencyProperty.Register("DisabledForegroundBrush", typeof(Brush), typeof(ExtendedButton), new PropertyMetadata(Brushes.Gray));


        public Brush EnabledBackgroundBrush
        {
            get { return (Brush)GetValue(EnabledBackgroundBrushProperty); }
            set { SetValue(EnabledBackgroundBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for EnabledBackgroundBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty EnabledBackgroundBrushProperty =
            DependencyProperty.Register("EnabledBackgroundBrush", typeof(Brush), typeof(ExtendedButton), new PropertyMetadata(Brushes.Blue));


        public Brush DisabledBackgroundBrush
        {
            get { return (Brush)GetValue(DisabledBackgroundBrushProperty); }
            set { SetValue(DisabledBackgroundBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DisabledBackgroundBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DisabledBackgroundBrushProperty =
            DependencyProperty.Register("DisabledBackgroundBrush", typeof(Brush), typeof(ExtendedButton), new PropertyMetadata(Brushes.Purple));

        public bool State
        {
            get { return (bool)GetValue(StateProperty); }
            set { SetValue(StateProperty, value); }
        }

        // Using a DependencyProperty as the backing store for State.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty StateProperty =
            DependencyProperty.Register("State", typeof(bool), typeof(ExtendedButton), new PropertyMetadata(true));


        #endregion


    }
}
