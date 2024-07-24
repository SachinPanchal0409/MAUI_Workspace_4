using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIProject.Views
{
    public class ExtendedCollectionView : CollectionView
    {

        public static readonly BindableProperty NameProperty =
            BindableProperty.Create(nameof(Name), typeof(string), typeof(ExtendedCollectionView), default(string), BindingMode.TwoWay);

        public static readonly BindableProperty TitleProperty =
            BindableProperty.Create(nameof(Title), typeof(string), typeof(ExtendedCollectionView), default(string), BindingMode.TwoWay);

        public static readonly BindableProperty CountProperty =
           BindableProperty.Create(nameof(Count), typeof(int), typeof(ExtendedCollectionView), default(int), BindingMode.TwoWay);

        public static readonly BindableProperty MemberCountProperty =
          BindableProperty.Create(nameof(MemberCount), typeof(int), typeof(ExtendedCollectionView), default(int), BindingMode.TwoWay);

        public static readonly BindableProperty IsVisibleMemberCountProperty =
         BindableProperty.Create(nameof(IsVisibleMemberCount), typeof(bool), typeof(ExtendedCollectionView), default(bool), BindingMode.TwoWay);

        public static readonly BindableProperty IsVisibleTitleProperty =
         BindableProperty.Create(nameof(IsVisibleTitle), typeof(bool), typeof(ExtendedCollectionView), default(bool), BindingMode.TwoWay);
        public static readonly BindableProperty ImageSourceProperty =
       BindableProperty.Create(nameof(ImageSource), typeof(ImageSource), typeof(ExtendedCollectionView));

        public ImageSource ImageSource
        {
            get { return GetValue(ImageSourceProperty) as ImageSource; }
            set { SetValue(ImageSourceProperty, value); }
        }
        public string Name
        {
            get => (string)GetValue(NameProperty);
            set => SetValue(NameProperty, value);
        }

        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        public int Count
        {
            get => (int)GetValue(CountProperty);
            set => SetValue(CountProperty, value);
        }
        public int MemberCount
        {
            get => (int)GetValue(MemberCountProperty);
            set => SetValue(MemberCountProperty, value);
        }

        public bool IsVisibleMemberCount
        {
            get => (bool)GetValue(IsVisibleMemberCountProperty);
            set => SetValue(IsVisibleMemberCountProperty, value);
        }

        public bool IsVisibleTitle
        {
            get => (bool)GetValue(IsVisibleTitleProperty);
            set => SetValue(IsVisibleTitleProperty, value);
        }

    }
    
    
    

}
