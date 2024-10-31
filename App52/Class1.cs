using Microsoft.UI.Xaml;

namespace App52;

public class Class1 {

    public static int GetMyProperty(DependencyObject obj) {
        return (int)obj.GetValue(MyPropertyProperty);
    }

    public static void SetMyProperty(DependencyObject obj, int value) {
        obj.SetValue(MyPropertyProperty, value);
    }

    public static readonly DependencyProperty MyPropertyProperty =
        DependencyProperty.RegisterAttached("MyProperty", 
            typeof(int), typeof(Class1), new PropertyMetadata(default(int)));

}
