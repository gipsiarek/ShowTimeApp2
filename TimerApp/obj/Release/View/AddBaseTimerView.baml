   M S B A M L   `   `   `  ���� O  KTimerApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=574994ec10980f1a-clr-namespace:TimerApp.ViewTimerApp.View  $    TimerApp.View.AddBaseTimerView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     -localclr-namespace:TimerApp.View     $	��500��$	��400��.��� ����   �� ImageSource$K  E/TimerApp;component/Image/tlo_ustawien_dodawaniaczasu_instalatora.png�� � RowDefinitions �� $
��auto ��� $��* �.+��� $��	10,10,0,0q�$��0��$:��4/TimerApp;component/Image/logo_z_napisem_na_dole.png��$
��Left=�$	��200��$	��113��� $��1��$��Center=�$��Center=�$	��5,5q� � 	Resources  �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value��%J  '��       '�� S     '�� �     �� " ��.���  � ��$ 16(���  � ��
 �������  � ��
 ���� �� " ��.���  � ��$ 16(���  � ��
 ������� " ��.���  � ��$ 16(���  � ��
 ���� ��  � ��
 ����� P�  � {� .  . ���  � ��
 ���� ��  � ��
 �   �	 � ColumnDefinitions	 �� $��* ��� $��* � �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto �.+��� $��0��$��0��$��Nazwa���� $��0��$��1��$	��150��$	��5,5q����� *
NewBt.Name+�� $��1��$��0��$��Czas [h:m:s]��]� $��1��$��1��$
��Left=�$	��5,5q�.+��� -   
 ��Name$
 Hours��$��48������  �� Path$ DurationHours��� $��:���� -   $
 Minutes��$��50������ $ DurationMinutes��� $��:���� -   $
 Seconds��$��48������ $ DurationSeconds��� $��2��$��0��$��Uwagi���� $��2��$��1��$	��100��$	��5,5q����� *NewBt.Comments+�� $��3��$��0��$��Odliczanie do 0��$��Center=��� $��0q�$��3��$��1��$��0q�$��45��$��45��$��Center=�$��Center=����� *DownToZeroCmd+���� " ��.���  � �� ��  �� 
TargetType" ��.R��� #��z��
������ $��0q�._��� #��z��#��z��#��z�� J� SnapsToDevicePixels# z ��.  ��  �� Binding �� $ NewBt.IsTimerDescending� �� Value True.a���  � �� �� $3  -/TimerApp;component/Image/zielony_znaczek.png�� j� Stretch$ Uniform=���  �� *NewBt.IsTimerDescending+	 False.a���  � �� �� $1  +/TimerApp;component/Image/pusty_znaczek.png��$ Uniform=��� $��4��$��0��$��Czy uruchamiać alarm��$��Center=��� $��0q�$��4��$��1��$��0q�$��45��$��45��$��Center=�$��Center=����� *FireAlertCmd+���� *NewBt.ShouldFireAlert+���� " ��.���  � �� �� " ��.R��� #��z��
������ $��0q�._��� #��z��#��z��#��z��# z ��.  ��  �� $ NewBt.ShouldAlertFire� True.a���  � �� �� $3  -/TimerApp;component/Image/zielony_znaczek.png��$ Uniform=���  �� *NewBt.ShouldAlertFire+	 False.a���  � �� �� $1  +/TimerApp;component/Image/pusty_znaczek.png��$ Uniform=��� $��5��$��0��$��Zapisz��$	��5,5q����� *AddNewPlayListItemCmd+���� *NewBt+�� $��5��$��1��$��Anuluj��$��CANCEL��$	��5,5q����� *AddNewPlayListItemCmd+