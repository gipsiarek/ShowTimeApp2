   M S B A M L   `   `   `  ����O  KTimerApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=574994ec10980f1a-clr-namespace:TimerApp.ViewTimerApp.View  5   	       TimerApp.View.Login   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:TimerApp.View     5   	     � WindowStyle$  
ToolWindow=�5      
������ $��0q�5   #    � Title$ Login��5	   	   $	��300��6   $	��500��6$   .��5
      � ��5   
   �� 5       �� ImageSource$K E/TimerApp;component/Image/tlo_ustawien_dodawaniaczasu_instalatora.png��6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��	10,10,0,0q�6   $��0��6#   $:��4/TimerApp;component/Image/logo_z_napisem_na_dole.png��60   $
��Left=�6n   $	��200��6�   $	��100��6�   � 5   
   $��1��6   $��Center=�6   $��Center=�68   $	��5,5q�6U    � 	Resources 5       �� 
TargetType �� Property �� Value �� Triggers	 P� Property
 P� Value��%�  'G�       '�� �     '�� (    '�� �    �� 5      " G�6   .�5      ��  � ��$ 16(�61   �� 5       � ��
 �����63   �� 5       � ��
 ���� 63   5      �� 5      " ��6   .�5      ��  � ��$ 16(�61   �� 5       � ��
 �����63   �� 5       � ��
 ���� 63   5      �� 5       " ��6   .�5!      ��  � ��$ 16(�61   �� 5"       � ��
 �����63   5#      �� 5$      " ��6   .�5%      ��  � ��$ 16(�61   �� 5&       � ��
 ���� 63   �� 5'       � ��
 �����63    5(      P� 5)      	 � {�
 .  . �5*      ��  � ��
 ���� 6;   �� 5+       � ��
 �   �6;   5,      5.      5/       � ColumnDefinitions 50      �� 51      $��* �6#   �� 52      $��* �6#    54      �� 55      $
��auto �6    �� 56      $
��auto �6    �� 57      $
��auto �6    �� 58      $
��auto �6    �� 59      $
��auto �6    �� 5:      $
��auto �6    .+�5<      �� $��0��6   $��0��6!   $��Adres Hosta��61   �� 5=      -   5         ��Name$ txbHost��5=      $��0��6'   $��1��64   $	��150��6D   $	��5,5q�6S   �� 5?      $��1��6   $��0��6!   $��Użytkownik��61   �� 5@      -   5        $ txbName��5@      $��1��6'   $��1��64   $	��150��6E   $	��5,5q�6T   �� 5B      $��2��6   $��0��6!   $��Hasło��61   G� 5C      -   5         G�Name$ txbPassword��5C      $��2��6/   $��1��6<   $	��150��6L   $	��5,5q�6[   �� 5F      -   5         ��Name$ BtnSave��5F      $��5��6&   $��0��63   $��Zapisz��6C   $	��5,5q�6j   �� 5G      -   5        $ 	BtnCancel��5G      $��5��6(   $��1��65   $��Anuluj��6E   $	��5,5q�6n   5H      5I      5J      