   M S B A M L   `   `   `  ���� O  KTimerApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=574994ec10980f1a-clr-namespace:TimerApp.ViewTimerApp.View      TimerApp.View.Login   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -localclr-namespace:TimerApp.View       � WindowStyle$  
ToolWindow=�
������ $��0q� � Title$ Login��$	��300��$	��500��.��� ����  �� ImageSource$K E/TimerApp;component/Image/tlo_ustawien_dodawaniaczasu_instalatora.png�� � RowDefinitions �� $
��auto ��� $��* �.+��� $��	10,10,0,0q�$��0��$:��4/TimerApp;component/Image/logo_z_napisem_na_dole.png��$
��Left=�$	��200��$	��100��� $��1��$��Center=�$��Center=�$	��5,5q� � 	Resources  �� 
TargetType �� Property �� Value �� Triggers	 P� Property
 P� Value��%�  'G�       '�� S     '�� �     '�� �     �� " G�.���  � ��$ 16(���  � ��
 �������  � ��
 ���� �� " ��.���  � ��$ 16(���  � ��
 �������  � ��
 ���� �� " ��.���  � ��$ 16(���  � ��
 ������� " ��.���  � ��$ 16(���  � ��
 ���� ��  � ��
 ����� P� 	 � {�
 .  . ���  � ��
 ���� ��  � ��
 �   � � ColumnDefinitions �� $��* ��� $��* � �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto �.+��� $��0��$��0��$��Adres Hosta���� -    ��Name$ txbHost��$��0��$��1��$	��150��$	��5,5q��� $��1��$��0��$��Użytkownik���� -   $ txbName��$��1��$��1��$	��150��$	��5,5q��� $��2��$��0��$��Hasło��G� -    G�Name$ txbPassword��$��2��$��1��$	��150��$	��5,5q��� -    ��Name$ BtnSave��$��5��$��0��$��Zapisz��$	��5,5q��� -   $ 	BtnCancel��$��5��$��1��$��Anuluj��$	��5,5q�