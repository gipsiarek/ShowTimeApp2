   M S B A M L   `   `   `  ����O  KTimerApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=574994ec10980f1a-clr-namespace:TimerApp.ViewTimerApp.View  5      =#clr-namespace:TimerApp.Model.HelperTimerApp.Model.Helper  5      /clr-namespace:TimerApp.ModelTimerApp.Model  5	      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5
      '    !TimerApp.View.PreviewSettingsView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      X TXceed.Wpf.Toolkit, Version=3.0.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5      'localclr-namespace:TimerApp.View  5      1helpers#clr-namespace:TimerApp.Model.Helper  5      &setclr-namespace:TimerApp.Model  5	      3System&clr-namespace:System;assembly=mscorlib  5
      $	��600��5        � 	Resources  5         AlertTypeEnum S� 
MethodName S� 
ObjectType  System.Enum S� MethodParameters M� TypeName  LogoPositionEnum/   )TimerApp.Model.Helper.InvertBoolConverter  
invertBool  flashAnimation �� TargetProperty W� From	 W� To g� AutoReverse	 g� Duration
 g� RepeatBehavior �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value �� 
TargetType d� 	IsChecked �� Path �� Mode �� RelativeSource � ColumnDefinitions ��Name �� CornerRadius F�Name �� Triggers �� 
TargetName J� IsHitTestVisible �� SelectionBoxItem �� SelectionBoxItemTemplate ��Name  �� 
IsReadOnly! �� 
IsReadOnly" �� IsDropDownOpen# � AllowsTransparency$ J� SnapsToDevicePixels% � ActualWidth& �� MaxDropDownHeight' K� IsItemsHost��%c	  &	        &	 u     &	 �     &	      '�� �    '��     '�� �    '�� �    S� 5   
   $ 	GetValues��63   "  6J    5      M� 5      $ set:PreviewAlertTypeEnum��6   5      S� 5   
   $ 	GetValues��66   "  6M    5      M� 5      $! set:PreviewLogoPositionEnum��6   5        5   
   6&   �� 5   
   .��5      W� $ Opacity�6   $ 1X�6B   $ 0X�6K    . $	 0:0:0.5D�6e   $
 Forever��6x   5      �� 5   
   " ��6   .�5      ��  � ��$ 14(�6)   �� 5        � ��
 �����6+   �� 5!       � ��
 ���� 6+   5"      �� 5#   
   " ��6   .�5$      ��  � ��$ 14(�6)   �� 5%       � ��
 �����6+   5&      �� 5'   
   " ��6   .�5(      ��  � ��$ 14(�6)   �� 5)       � ��
 ���� 6+   �� 5*       � ��
 �����6+    5+      P� 5,       � {� .  . �5-      ��  � ��
 ���� 63   �� 5.       � ��
 �   �63   5/      51      �� 52   
   " ��6   .�53      ��  � �� 54      �� 55      " ��6&   .R�56      � 
������ .+�57      d� $��2��6+   |�.  
������� 58   +   �� $ IsDropDownOpen�$ TwoWay=� �� *TemplatedParent+��59   "   �� 5:   &   .R�5;   *   � 
������  5<   .   �� 5=   2   $��5* �6C   �� 5>   2   $��* �6C   .+�5@   .   �� $ Border��65   $��2��6F   $ 5��6Z   
������ 
�������$��1q�6�   F� 5B   .   $ Arrow��63   $��1��6B   
�������$��Center=�6`   $��Center=�6}   "���� 	=  	= �        � z     	6�   5C   +    5D   *   P� 5E   .    �@J�IsMouseOver . . �5F   2   �� $ Border��69    � ��
 �����6c   5G   /   P� 5H   .    �@d�	IsChecked$
 trueY�6X   . �5I   2   �� $ Border��69    � ��
 �����6c   5J   /   5L   '   5N      �� 5O      $��ContentSite��6/    .  
�������#��z 6{   #��z 6�   #��z��6�   $��3q�6&  �� 5P      $ PART_EditableTextBox��6&   $y�Hidden=�6D   
�������#! z  5Q   &   
������ 6P   � 5R      $��Popup��6$   $��Bottom=�61   #��z" 6D   # . |�.  $��Slide=�6�   .��5S   "   � $��DropDown��6(   $ . #��z% 6S   #��z& 6|   .+�5T   &   �� $ DropDownBorder��6-   
�������6E   �� 5U   &   $ . .��5V   *   �� ' . 65   5W   '   5X   #   5Y      5Z      5[      5]      5^      5_      .��5a      � ��5b   
   �� 5c      ( �� ImageSource$K( E/TimerApp;component/Image/tlo_ustawien_dodawaniaczasu_instalatora.png��6   ) � RowDefinitions) 5e   
   �� 5f      $
��auto �6   �� 5g      $��* �6   .+�5i   
   �� $��10,0,0,0q�6   $��0��6"   $:��4/TimerApp;component/Image/logo_z_napisem_na_dole.png��6/   $
��Left=�6m   $	��500��6�   $	��113��6�   �� 5j   
   $��Center=�6   $��Center=�62   $��1��6M   .+�5n      � 
������ $��Stretch=�6,   $��Stretch=�6J   $	��5,0q�6f   * � UseLayoutRounding* .  5o      �� 5p      $��* �6'   �� 5q      $��* �6'   ) 5s      �� 5t      $
��auto �6$   �� 5u      $
��auto �6$   �� 5v      $
��auto �6$   .+�5x      �� $��
Kolor Tła��6   $	��5,5q�6-   #  Xceed.Wpf.Toolkit.ColorPicker  5y      $��0��6#   $��1��60   !+   AvailableColorsSortingMode$+ HueSaturationBrightness=�5z      $	��5,5q�6T   ,   SelectedColor, 5y   @   �� *$"Ds.Settings.PreviewBackgroundColor+5z   T   �� 5|      $��1��6   $��0��6%   $��Kolor czasu��65   $	��5,5q�6K     5}      $��1��6$   $��1��61   $	��5,5q�6y   , 6A   �� *Ds.Settings.PreviewTextColor+6y   �� 5      $��2��6   $��0��6%   $��Kolor wiadomości��65   $	��5,5q�6P     5�      $��2��6$   $��1��61   $	��5,5q�6|   , 6A   �� *!Ds.Settings.PreviewMessageColor+6|   5�      �� 5�      $��0,5,0,10q�6   � 5�      
������ $��Stretch=�6,   $��Stretch=�6J   $	��5,5q�6f   * .  5�      �� 5�      $��* �6'   �� 5�      $��* �6'   ) 5�      �� 5�      $
��auto �6$   �� 5�      $
��auto �6$   �� 5�      $
��auto �6$   �� 5�      $
��auto �6$   �� 5�      $
��auto �6$   .+�5�      �� $��0��6   $��0��6&   $��Wczytaj tło��66   $	��5,5q�6L   ]� 5�      $��0��6   $��1��6)   .+�5�      �� $	��5,5q�6I   $	��110��6V   $��
BACKGROUND��5�      ��5�      �� $ GetBgImageFileCmd���5�   /   �� *BgFile+�� 5�      $��	Wyczyść��6H   $	��5,5q�6Z   $��CLR_BG��5�      ��5�      �� $ GetBgImageFileCmd�5�      5�      �� 5�      $��1��6   $��0��6%   $��Wczytaj logo��65   $	��5,5q�6L   ]� 5�      $��1��6   $��1��6)   .+�5�      �� $	��5,5q�6I   $	��110��6V   $
��LOGO��5�      ��5�      �� $ GetBgImageFileCmd���5�   -   �� *
LogoFile+�� 5�      $��	Wyczyść��6H   $	��5,5q�6Z   $��CLR_LOGO��5�      ��5�      �� $ GetBgImageFileCmd�5�      5�      �� 5�      $��2��6   $��0��6%   $��Miejsce logo��65   $	��5,5q�6L   �� 5�      $��2��6   $��1��6(   $	��5,5q�5�   Q   ��5�   8   �� - �� Source#- [ . �� SelectedItem. 5�      �� $% Ds.Settings.PreviewLogoPosition�6Q   �� 5�      $��3��6   $��0��6%   $��Wysokość logo [%]��65   $	��5,5q�6Q   �� 5�      $��3��6   $��1��6'   $	��100��6_   $	��5,5q�6n   ��67   �� *Ds.Settings.LogoHeight+6n   �� 5�      $��4��6   $��0��6%   $��Szerokość logo [%]��65   $	��5,5q�6R   �� 5�      $��4��6   $��1��6'   $	��100��6^   $	��5,5q�6m   ��67   �� *Ds.Settings.LogoWidth+6m   5�      �� 5�      $��0,5,0,10q�6   � 5�      
������ $��Stretch=�6,   $��Stretch=�6J   $	��5,5q�6f    5�      �� 5�      $��* �6'   �� 5�      $��* �6'   ) 5�      �� 5�      $
��auto �6$   �� 5�      $
��auto �6$   �� 5�      $
��auto �6$   �� 5�      $
��auto �6$   �� 5�      $
��auto �6$   �� 5�      $
��auto �6$   .+�5�      �� $��0��6   $��0��6%   $��Rozmiar czasu [1-10]��65   $	��5,5q�6T   �� 5�      $��0��6   $��1��6'   $	��100��6h   $	��5,5q�6w   ��67   �� *!Ds.Settings.PreviewTimeFontSize+6w   �� 5�      $��1��6   $��0��6%   $��Rozmiar tekstu [1-10]��65   $	��5,5q�6U   �� 5�      $��1��6   $��1��6'   $	��100��6k   $	��5,5q�6z   ��67   �� *$"Ds.Settings.PreviewMessageFontSize+6z   �� 5�      $��2��6   $��0��6%   $��Rodzaj alarmu��65   $	��5,5q�6M   �� 5�      $��2��6   $��1��6(   $	��5,5q�5�   N   
������ ��5�   8   �� #- [  . 5�      �� $" Ds.Settings.PreviewAlertType�5�      �� 5�      $��3��6   $��0��6%   $"��Czas uruchomienia alarmu [s]��65   $	��5,5q�6\   �� 5�      $��3��6   $��1��6'   $	��100��6e   $	��5,5q�6t   ��67   �� *Ds.Settings.PreviewAlertTime+6t   �� 5�      $��4��6   $��0��6&   $��Obrazek alertu��66   $	��5,5q�6O   ]� 5�      $��4��6   $��1��6)   .+�5�      �� $	��5,5q�6I   $	��120��6V   $��ALERT��5�      ��5�      �� $ GetBgImageFileCmd���5�   *   �� *	AlertFile+�� 5�      $��	Wyczyść��6H   $��	CLR_ALERT��5�      $	��5,5q�6.   ��5�      �� $ GetBgImageFileCmd�5�   .   5�      �� 5�      $��5��6   $��0��6"   $��Zapisz��62   $	��5,5q�6j   ��6C   �� *PreviewSettingsCmd+��5�      �� *NewBt+�� 5�      $��5��6   $��1��6"   $��Anuluj��62   $	��5,5q�6j   $��CANCEL��5�      ��5�   C   �� *PreviewSettingsCmd+5�      5�      5�      5�      5�      