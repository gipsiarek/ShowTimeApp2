   M S B A M L   `   `   `  ����O  KTimerApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=574994ec10980f1a-clr-namespace:TimerApp.ViewTimerApp.View  5      %    TimerApp.View.MessageSenderView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:TimerApp.View     5        J� Opacity$	  0.8Q�5       .��5	      � $��0q�6   $��Stretch=�6   $��Stretch=�64    � RowDefinitions 5
   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   � $��0��6   .+�5      ]� $��Stretch=�6   ��5      �� 5       �� ImageSource$4 ./TimerApp;component/Image/pasek_wiadomosc1.png��6!   .+�5      �� $��WIADOMOŚĆ��6   $
��Left=�6-   $��15,0,0,0q�6C   
�������$��18(�6h   �� 5      $��Right=�6   
������ 
�������$��Right=�6a   $��0,2,10,2q�5      $��1q�6+   
�������$	��120��6S   $��18(�6`   $�� ��5   <   ��6   �� *SendMessageCmd+.��5      ]� $��Stretch=�6    $��Stretch=�6>   $	��100��6Z   .+�5      �� $1��+/TimerApp;component/Image/ikona_wyczysc.png��6    $��Right=�6U   �� 5      $��	Wyczyść��6$   $��Right=�63   5      5      �� 5      $��Right=�6   
������ 
�������$��Right=�6a   $��0,2,10,2q�5      $��1q�6+   
�������$	��120��6S   $��18(�6`   ��5      �� *SendMessageCmd+��6<   �� *	Message+.��5       ]� $��Stretch=�6    $��Stretch=�6>   $	��100��6Z   .+�5!      �� $0��*/TimerApp;component/Image/ikona_wyslij.png��6    $��Right=�6T   �� 5"      $��Wyślij��6$   $��Right=�62   5$      5%      5&      5'      � 5(   
   $��1��6   .+�5)      �� $��Stretch=�6   $��Stretch=�62    �� TextWrapping$
 Wrap=�6P    �� AcceptsReturn . $��30(�5*   X   ��6   �� *	Message+ �� UpdateSourceTrigger$ PropertyChanged=�.��6g   .��5,      .��5-   �   .��5.   �   .��50   0   51      52      53      54      