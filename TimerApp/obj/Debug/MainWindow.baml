   M S B A M L   `   `   `  ����O  KTimerApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=574994ec10980f1a#clr-namespace:TimerAppTimerApp  5   	   7 clr-namespace:TimerApp.ViewModelTimerApp.ViewModel  5   	   -clr-namespace:TimerApp.ViewTimerApp.View  5	   	       TimerApp.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:TimerApp     5   	   /vm clr-namespace:TimerApp.ViewModel     5   	   -viewsclr-namespace:TimerApp.View     5	   	     � Title$  Show Time App��5       � WindowState$ 	Maximized=�5
   	    � WindowStartupLocation$ CenterOwner=�6!    � 	Resources 5       �� DataType*   $TimerApp.ViewModel.PlayListViewModel    TimerApp.View.PlayListView)   #TimerApp.ViewModel.PreviewViewModel   TimerApp.View.PreviewView/   )TimerApp.ViewModel.MessageSenderViewModel%   TimerApp.View.MessageSenderView.   (TimerApp.ViewModel.AddBaseTimerViewModel$   TimerApp.View.AddBaseTimerView1	   +TimerApp.ViewModel.PreviewSettingsViewModel'
   !TimerApp.View.PreviewSettingsView   bg !� Visual��%  (��       5      *, +)(�� 2     5      *, +)(�� d     5      *, +)(�� �     5      *, +)(�� �     5      *,	 +)&	  �     �� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      �� 5   
   " 	 6   .R�5      
  5      !� 5   
    5      � 5      .+�5      �� $
��Fill=�6   $*��$Image/tlo_glownego_okna_programu.png��6+   5       5"      5$      .��5&      � #��[  6    � RowDefinitions 5'   
   �� 5(      $
��auto �6   �� 5)      $��* �6   .+�5+   
   �� $��	10,10,0,0q�6   $��0��6#   $%��Image/logo_z_napisem_z_boku.png��60   $
��Left=�6Y   $	��200��6t   $��50��6�   � 5-   
   $��1��6   $��
10,0,10,45q�6    � ColumnDefinitions 5.      �� 5/      $
��0.6* �6#   �� 50      $
��0.4* �6#    52      �� 53      $
��0.6* �6    �� 54      $
��0.4* �6    .+�56      � $��2��6   $��0��6%   .+�57      �� $��Stretch=�6!   $��Stretch=�6?   $��10q�6[    � UseLayoutRounding . 	 J� SnapsToDevicePixels	 . ��59      �� 
 �� Path$
 PlayListCtr� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� J� Effect 5:      3  -System.Windows.Media.Effects.DropShadowEffect  5;         ShadowDepth$ 4Q�6+      	Direction$	 330Q�6;      Color$ Black��6K      Opacity$	 0.5Q�6Y      
BlurRadius$ 8Q�6g   5=      5>      � 5@      $��1��6   $��0��6#   $��10q�60    5A      �� 5B      $
��auto �6$   �� 5C      $��* �6$   .+�5E      ]� $��Stretch=�6   $��0��6;   ��5F      �� 5H       �� ImageSource$ Image/pasek_podglad1.png��6%   .+�5J      �� $��PODGLĄD��6    
�������$��15,0,0,0q�6B   $��18(�6T   �� 5K      $��Right=�6   
������ 
�������$��Right=�6e   $��0,2,10,2q�5L      $��1q�6+   
�������$	��150��6S   $��18(�6`   ��5M      �� *PreviewSettingsViewCmd+.��5N      ]� $��Stretch=�6$   $��Stretch=�6B   $	��110��6^   .+�5O      �� $4��./TimerApp;component/Image/ikona_ustawienia.png��6$   �� 5P      $��
Ustawienia��6(   $��Right=�6:   5Q      5R      5S      �� 5T      $��Stretch=�6!   $��Stretch=�6?   $��0q�6[    . 	 . $��1��5U   U   ��5V   !   �� $
 TimerVm�$ TwoWay=�$ PropertyChanged=� 5W        5X      $ 4Q�6+   $	 330Q�6;   $ Black��6K   $	 0.5Q�6Y   $ 8Q�6g   5Z      5\      � 5]      $��1��6   $��1��6#   .+�5^      �� $��Stretch=�6!   $��Stretch=�6?   $��10q�6[    . 	 . ��5`      �� $
 MessageSenderCtr�$ TwoWay=�$ PropertyChanged=� 5a        5b      $ 4Q�6+   $	 330Q�6;   $ Black��6K   $	 0.5Q�6Y   $ 8Q�6g   5d      5e      5h      �� 5i   
   $��1��6   $��16(�6!   
���   �$��Center=�6B   $��Bottom=�6_   $��0,0,0,10q�6z   �� 5j      -   5        $��http://www.newsystems.pl?�5j      .�6k   www.newsystems.pl5l      5m      5n      5o      