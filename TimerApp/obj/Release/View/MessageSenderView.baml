   M S B A M L   `   `   `  ���� O  KTimerApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=574994ec10980f1a-clr-namespace:TimerApp.ViewTimerApp.View  %    TimerApp.View.MessageSenderView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     -localclr-namespace:TimerApp.View       J� Opacity$	  0.8Q�.��� $��0q�$��Stretch=�$��Stretch=� � RowDefinitions �� $
��auto ��� $��* �.+�� $��0��.+�]� $��Stretch=�����  �� ImageSource$4 ./TimerApp;component/Image/pasek_wiadomosc1.png��.+��� $��WIADOMOŚĆ��$
��Left=�$��15,0,0,0q�
�������$��18(��� $��Right=�
������ 
�������$��Right=�$��0,2,10,2q�$��1q�
�������$	��120��$��18(�$�� ������ *SendMessageCmd+.��]� $��Stretch=�$��Stretch=�$	��100��.+��� $1��+/TimerApp;component/Image/ikona_wyczysc.png��$��Right=��� $��	Wyczyść��$��Right=��� $��Right=�
������ 
�������$��Right=�$��0,2,10,2q�$��1q�
�������$	��120��$��18(����� *SendMessageCmd+���� *	Message+.��]� $��Stretch=�$��Stretch=�$	��100��.+��� $0��*/TimerApp;component/Image/ikona_wyslij.png��$��Right=��� $��Wyślij��$��Right=�� $��1��.+��� $��Stretch=�$��Stretch=� �� TextWrapping$
 Wrap=� �� AcceptsReturn . $��30(����� *	Message+ �� UpdateSourceTrigger$ PropertyChanged=�.��.��.��.��.��