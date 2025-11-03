# November 3

## Dialogruta

En dialogruta, engelska dialog box, är ett litet fönster i ett grafiskt användargränssnitt innehållande frågor, inställningar eller information som användaren måste besvara, bekräfta eller aktivt avbryta/stänga. En dialogruta kan exempelvis innehålla ett felmeddelande.

Vi har kollat på några vanliga inbyggda dialogrutor:

- [\<MessageBox\>](https://wpf-tutorial.com/dialogs/the-messagebox/)
- [\<OpenFileDialog\>](https://wpf-tutorial.com/dialogs/the-openfiledialog/)
- [\<SaveFileDialog\>](https://wpf-tutorial.com/dialogs/the-savefiledialog/)
- \<PrintDialog\>

Vi har även kollat på hur man kan bygga sina egna [custom dialogrutor](https://wpf-tutorial.com/dialogs/creating-a-custom-input-dialog/).

**Code-along:**  
[L047_Dialogs_and_Windows](https://github.com/everyloop/NEU25G-Csharp/tree/master/Code-alongs/L047_Dialogs_and_Windows)

## Converters (värdeomvandlare)

En converter i WPF används för att översätta data mellan ViewModel och View vid data binding.

**Med andra ord:**  
- ViewModel ger ett värde (t.ex. en bool).  
- UI:t behöver något annat (t.ex. Visibility).
- Convertern gör översättningen däremellan.

### Varför behövs converters?

I WPF kan du binda direkt till egenskaper, t.ex.:

```xml
<TextBlock Text="{Binding Name}" />
```

Men ibland passar inte datatyperna:

|ViewModel-egenskap | UI-egenskap |	Problem |
|-------------------|-------------|---------|
|bool IsVisible | Visibility | Kan inte binda bool → Visibility direkt |
|DateTime BirthDate | Text | Vill visa formaterad text |
|double Progress | Width | Behöver konvertera till pixelvärde |
|enum Status | Color | Behöver mappa status → färg |

### IValueConverter

En converter implementerar interfacet IValueConverter och har två metoder:

```cs
public interface IValueConverter
{
    object Convert(object value, Type targetType, object parameter, CultureInfo culture);
    object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);
}
```

### Exempel på hur man gör en egen converter: 
DateTime → formaterad text
```cs
public class DateToShortStringConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        => value is DateTime d ? d.ToString("yyyy-MM-dd") : "";
    
    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        => DateTime.TryParse(value?.ToString(), out var d) ? d : DateTime.MinValue;
}
```

**Användning i XAML:**
1) Lägg till den som resource:
```xml
   <Window.Resources>
        <local:DateToShortStringConverter x:Key="DateToShortStringConverter" />
    </Window.Resources>
```
2) Använd i binding:
```xml
<TextBox Text="{Binding BirthDate, 
                Converter={StaticResource DateToShortStringConverter}, 
                Mode=TwoWay, 
                UpdateSourceTrigger=PropertyChanged}" />
```

**Code-along:**  
[L048_Converters](https://github.com/everyloop/NEU25G-Csharp/tree/master/Code-alongs/L048_Converters)
