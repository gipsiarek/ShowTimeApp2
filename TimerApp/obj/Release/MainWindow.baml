   M S B A M L   `   `   `  ���� O  KTimerApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=574994ec10980f1a#clr-namespace:TimerAppTimerApp  7 clr-namespace:TimerApp.ViewModelTimerApp.ViewModel  -clr-namespace:TimerApp.ViewTimerApp.View      TimerApp.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     (localclr-namespace:TimerApp     /vm clr-namespace:TimerApp.ViewModel     -viewsclr-namespace:TimerApp.View       � Title$  Show Time App�� � WindowState$ 	Maximized=� � WindowStartupLocation$ CenterOwner=� � 	Resources  �� DataType*   $TimerApp.ViewModel.PlayListViewModel    TimerApp.View.PlayListView)   #TimerApp.ViewModel.PreviewViewModel   TimerApp.View.PreviewView/   )TimerApp.ViewModel.MessageSenderViewModel%   TimerApp.View.MessageSenderView.   (TimerApp.ViewModel.AddBaseTimerViewModel$   TimerApp.View.AddBaseTimerView1	   +TimerApp.ViewModel.PreviewSettingsViewModel'
   !TimerApp.View.PreviewSettingsView   bg !� Visual��%   (��       *, +)(��      *, +)(�� $     *, +)(�� 6     *, +)(�� H     *,	 +)&	  Z     �� "  .R�  �� "  .R�  �� "  .R�  �� "  .R�  �� " 	 .R�
  !�  � .+��� $
��Fill=�$*��$Image/tlo_glownego_okna_programu.png��.��� #��[   � RowDefinitions �� $
��auto ��� $��* �.+��� $��	10,10,0,0q�$��0��$%��Image/logo_z_napisem_z_boku.png��$
��Left=�$	��200��$��50��� $��1��$��
10,0,10,45q� � ColumnDefinitions �� $
��0.6* ��� $
��0.4* � �� $
��0.6* ��� $
��0.4* �.+�� $��2��$��0��.+��� $��Stretch=�$��Stretch=�$��10q� � UseLayoutRounding . 	 J� SnapsToDevicePixels	 . ���� 
 �� Path$
 PlayListCtr� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     ShadowDepth$ 4Q�   	Direction$	 330Q�   Color$ Black��   Opacity$	 0.5Q�   
BlurRadius$ 8Q�� $��1��$��0��$��10q� �� $
��auto ��� $��* �.+�]� $��Stretch=�$��0������  �� ImageSource$ Image/pasek_podglad1.png��.+��� $��PODGLĄD��
�������$��15,0,0,0q�$��18(��� $��Right=�
������ 
�������$��Right=�$��0,2,10,2q�$��1q�
�������$	��150��$��18(����� *PreviewSettingsViewCmd+.��]� $��Stretch=�$��Stretch=�$	��110��.+��� $4��./TimerApp;component/Image/ikona_ustawienia.png���� $��
Ustawienia��$��Right=��� $��Stretch=�$��Stretch=�$��0q� . 	 . $��1������ $
 TimerVm�$ TwoWay=�$ PropertyChanged=�   $ 4Q�$	 330Q�$ Black��$	 0.5Q�$ 8Q�� $��1��$��1��.+��� $��Stretch=�$��Stretch=�$��10q� . 	 . ���� $
 MessageSenderCtr�$ TwoWay=�$ PropertyChanged=�   $ 4Q�$	 330Q�$ Black��$	 0.5Q�$ 8Q��� $��1��$��16(�
���   �$��Center=�$��Bottom=�$��0,0,0,10q��� -   $��http://www.newsystems.pl?�.�www.newsystems.pl