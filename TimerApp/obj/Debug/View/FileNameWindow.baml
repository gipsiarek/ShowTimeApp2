   M S B A M L   `   `   `  ����O  KTimerApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=574994ec10980f1a-clr-namespace:TimerApp.ViewTimerApp.View  5   	   "    TimerApp.View.FileNameWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:TimerApp.View     5   	     � WindowStyle$  
ToolWindow=�5      
������ $��0q�5   #    � Title$ Nazwa pliku do wgrania��5	   	   $	��300��6(   $	��400��65   .��5
      � ��5   
   �� 5       �� ImageSource$K E/TimerApp;component/Image/tlo_ustawien_dodawaniaczasu_instalatora.png��6   .+�5   
   � $��1��6   $��Center=�6   $��Center=�68   $	��5,5q�6U    � 	Resources 5       �� 
TargetType �� Property �� Value �� Triggers P� Property	 P� Value��%�  'G�       '�� �     '�� (    '�� �    �� 5      " G�6   .�5      ��  � ��$ 16(�61   �� 5       � ��
 �����63   �� 5       � ��
 ���� 63   5      �� 5      " ��6   .�5      ��  � ��$ 16(�61   �� 5       � ��
 �����63   �� 5       � ��
 ���� 63   5      �� 5      " ��6   .�5      ��  � ��$ 16(�61   �� 5       � ��
 �����63   5      �� 5      " ��6   .�5       ��  � ��$ 16(�61   �� 5!       � ��
 ���� 63   �� 5"       � ��
 �����63    5#      P� 5$       � {�	 .  . �5%      ��  � ��
 ���� 6;   �� 5&       � ��
 �   �6;   5'      5)      5*      
 � ColumnDefinitions
 5+      �� 5,      $��* �6#   �� 5-      $��* �6#    � RowDefinitions 5/      �� 50      $
��auto �6    �� 51      $
��auto �6    �� 52      $
��auto �6    �� 53      $
��auto �6    �� 54      $
��auto �6    �� 55      $
��auto �6    .+�57      �� $��0��6   $��0��6!   $��Nazwa pliku��61   �� 58      -   5         ��Name$ txbConfigName��58      $��0��6-   $��1��6:   $	��150��6J   $	��5,5q�6Y    � ToolTip$9 3Podaj nazwę pliku która zapisze się na serwerze.��6f   �� 5:      -   5         ��Name$ BtnSave��5:      $��5��6&   $��0��63   $��Zapisz��6C   $	��5,5q�6j   �� 5;      -   5        $ 	BtnCancel��5;      $��5��6(   $��1��65   $��Anuluj��6E   $	��5,5q�6n   5<      5?      5@      