   M S B A M L   `   `   `  ���� O  KTimerApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=574994ec10980f1a-clr-namespace:TimerApp.ViewTimerApp.View  =#clr-namespace:TimerApp.Model.HelperTimerApp.Model.Helper  /clr-namespace:TimerApp.ModelTimerApp.Model  O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem '    !TimerApp.View.PreviewSettingsView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     X TXceed.Wpf.Toolkit, Version=3.0.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  'localclr-namespace:TimerApp.View  1helpers#clr-namespace:TimerApp.Model.Helper  &setclr-namespace:TimerApp.Model  3System&clr-namespace:System;assembly=mscorlib  $	��600��  � 	Resources     AlertTypeEnum S� 
MethodName S� 
ObjectType  System.Enum S� MethodParameters M� TypeName  LogoPositionEnum/   )TimerApp.Model.Helper.InvertBoolConverter  
invertBool  flashAnimation �� TargetProperty W� From	 W� To g� AutoReverse	 g� Duration
 g� RepeatBehavior �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value �� 
TargetType d� 	IsChecked �� Path �� Mode �� RelativeSource � ColumnDefinitions ��Name �� CornerRadius F�Name �� Triggers �� 
TargetName J� IsHitTestVisible �� SelectionBoxItem �� SelectionBoxItemTemplate ��Name  �� 
IsReadOnly! �� 
IsReadOnly" �� IsDropDownOpen# � AllowsTransparency$ J� SnapsToDevicePixels% � ActualWidth& �� MaxDropDownHeight' K� IsItemsHost��%�  &	        &	 B     &	 �     &	 �     '�� �     '�� -    '�� h    '��     S� $ 	GetValues��"   M� $ set:PreviewAlertTypeEnum��S� $ 	GetValues��"   M� $! set:PreviewLogoPositionEnum��  �� .��W� $ Opacity�$ 1X�$ 0X� . $	 0:0:0.5D�$
 Forever���� " ��.���  � ��$ 14(���  � ��
 �������  � ��
 ���� �� " ��.���  � ��$ 14(���  � ��
 ������� " ��.���  � ��$ 14(���  � ��
 ���� ��  � ��
 ����� P�  � {� .  . ���  � ��
 ���� ��  � ��
 �   ��� " ��.���  � �� �� " ��.R�� 
������ .+�d� $��2��|�.  
������� �� $ IsDropDownOpen�$ TwoWay=� �� *TemplatedParent+���� .R�� 
������  �� $��5* ��� $��* �.+��� $ Border��$��2��$ 5��
������ 
�������$��1q�F� $ Arrow��$��1��
�������$��Center=�$��Center=�"���� 	=  	= �        � z     	 P�  �@J�IsMouseOver . . ��� $ Border�� � ��
 �����P�  �@d�	IsChecked$
 trueY�. ��� $ Border�� � ��
 ������� $��ContentSite�� .  
�������#��z #��z #��z��$��3q��� $ PART_EditableTextBox��$y�Hidden=�
�������#! z  
������ � $��Popup��$��Bottom=�#��z" # . |�.  $��Slide=�.��� $��DropDown��$ . #��z% #��z& .+��� $ DropDownBorder��
��������� $ . .���� ' . .��� ���� ( �� ImageSource$K( E/TimerApp;component/Image/tlo_ustawien_dodawaniaczasu_instalatora.png��) � RowDefinitions) �� $
��auto ��� $��* �.+��� $��10,0,0,0q�$��0��$:��4/TimerApp;component/Image/logo_z_napisem_na_dole.png��$
��Left=�$	��500��$	��113���� $��Center=�$��Center=�$��1��.+�� 
������ $��Stretch=�$��Stretch=�$	��5,0q�* � UseLayoutRounding* .  �� $��* ��� $��* �) �� $
��auto ��� $
��auto ��� $
��auto �.+��� $��
Kolor Tła��$	��5,5q�#  Xceed.Wpf.Toolkit.ColorPicker  $��0��$��1��!+   AvailableColorsSortingMode$+ HueSaturationBrightness=�$	��5,5q�,   SelectedColor, �� *$"Ds.Settings.PreviewBackgroundColor+�� $��1��$��0��$��Kolor czasu��$	��5,5q�  $��1��$��1��$	��5,5q�, �� *Ds.Settings.PreviewTextColor+�� $��2��$��0��$��Kolor wiadomości��$	��5,5q�  $��2��$��1��$	��5,5q�, �� *!Ds.Settings.PreviewMessageColor+�� $��0,5,0,10q�� 
������ $��Stretch=�$��Stretch=�$	��5,5q�* .  �� $��* ��� $��* �) �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto �.+��� $��0��$��0��$��Wczytaj tło��$	��5,5q�]� $��0��$��1��.+��� $	��5,5q�$	��110��$��
BACKGROUND������ $ GetBgImageFileCmd����� *BgFile+�� $��	Wyczyść��$	��5,5q�$��CLR_BG������ $ GetBgImageFileCmd��� $��1��$��0��$��Wczytaj logo��$	��5,5q�]� $��1��$��1��.+��� $	��5,5q�$	��110��$
��LOGO������ $ GetBgImageFileCmd����� *
LogoFile+�� $��	Wyczyść��$	��5,5q�$��CLR_LOGO������ $ GetBgImageFileCmd��� $��2��$��0��$��Miejsce logo��$	��5,5q��� $��2��$��1��$	��5,5q����� - �� Source#- [ . �� SelectedItem. �� $% Ds.Settings.PreviewLogoPosition��� $��3��$��0��$��Wysokość logo [%]��$	��5,5q��� $��3��$��1��$	��100��$	��5,5q����� *Ds.Settings.LogoHeight+�� $��4��$��0��$��Szerokość logo [%]��$	��5,5q��� $��4��$��1��$	��100��$	��5,5q����� *Ds.Settings.LogoWidth+�� $��0,5,0,10q�� 
������ $��Stretch=�$��Stretch=�$	��5,5q� �� $��* ��� $��* �) �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto �.+��� $��0��$��0��$��Rozmiar czasu [1-10]��$	��5,5q��� $��0��$��1��$	��100��$	��5,5q����� *!Ds.Settings.PreviewTimeFontSize+�� $��1��$��0��$��Rozmiar tekstu [1-10]��$	��5,5q��� $��1��$��1��$	��100��$	��5,5q����� *$"Ds.Settings.PreviewMessageFontSize+�� $��2��$��0��$��Rodzaj alarmu��$	��5,5q��� $��2��$��1��$	��5,5q�
������ ���� #- [  . �� $" Ds.Settings.PreviewAlertType��� $��3��$��0��$"��Czas uruchomienia alarmu [s]��$	��5,5q��� $��3��$��1��$	��100��$	��5,5q����� *Ds.Settings.PreviewAlertTime+�� $��4��$��0��$��Obrazek alertu��$	��5,5q�]� $��4��$��1��.+��� $	��5,5q�$	��120��$��ALERT������ $ GetBgImageFileCmd����� *	AlertFile+�� $��	Wyczyść��$��	CLR_ALERT��$	��5,5q����� $ GetBgImageFileCmd��� $��5��$��0��$��Zapisz��$	��5,5q����� *PreviewSettingsCmd+���� *NewBt+�� $��5��$��1��$��Anuluj��$	��5,5q�$��CANCEL������ *PreviewSettingsCmd+