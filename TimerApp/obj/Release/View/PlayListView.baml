   M S B A M L   `   `   `  ���� O  KTimerApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=574994ec10980f1a-clr-namespace:TimerApp.ViewTimerApp.View  =#clr-namespace:TimerApp.Model.HelperTimerApp.Model.Helper       TimerApp.View.PlayListView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     -localclr-namespace:TimerApp.View     9	Converter#clr-namespace:TimerApp.Model.Helper       J� Opacity$	  0.9Q� � 	Resources *   $TimerApp.Model.Helper.IndexConverter   IndexConverter  selectionBg !� Visual��%k   &	        &	        !�  � .+��� $
��Fill=�$0��*/TimerApp;component/Image/zaznzaczenie.png��.��� $��0q� � RowDefinitions �� $
��auto ��� $��* �.+�]� $��0��$��Stretch=�$  1Q� J� OpacityMask �	#FF5DF03C����  �� ImageSource$7 1/TimerApp;component/Image/pasek_lista_czasow1.png��.+��� $��LISTA CZASÓW��
�������$��15,0,0,0q�$��18(�$
��Left=��� $��Right=�
�������$��Center=�$��Right=�$��0,2,10,2q�$��1q�
�������$	��120��$��18(�
������ ���� *AddNewPlayListItemViewCmd+.��]� $��Stretch=�$��Stretch=�$	��100��.+��� $��+��$
��Left=��� $��
Dodaj czas��$��Right=��� $��Right=�
�������$��Center=�$��Right=�$��0,2,10,2q�$��1q�
�������$	��120��$��28��$��18(�
������ ���� *UploadConfigCmd+.���� $��Synchronizuj��$��Center=��� $��Right=�
�������$��Center=�$��Right=�$��0,2,10,2q�$��1q�
�������$	��120��$��18(�
������ ���� *LoadConfigCmd+.���� $��Wczytaj plik��$��Center=�� $��1��$	  0.8Q�.+�&   System.Windows.Controls.DataGrid     AutoGenerateColumns .  $��0q�   CanUserAddRows .     CanUserDeleteRows .  
�������$��14(�$��Center=�$��Center=�	   CanUserSortColumns	 .  
   GridLinesVisibility$
 
Horizontal=�
������    SelectionMode$ Single=�   SelectionUnit$ FullRow=�   RowHeaderWidth$ 0Q�$��0q�����  �� Path$ Ds.TimesCollection� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedItem �� $ SelectedTime�$ TwoWay=�$ PropertyChanged=� =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value)  #System.Windows.Controls.DataGridRow �� Triggers �� Binding �� Value��%�  (��       * SystemColors.HighlightBrushKey+)(�� 6     *1/SystemColors.InactiveSelectionHighlightBrushKey+)'  l     '  �     7  �� $0 */TimerApp;component/Image/zaznzaczenie.png���� $0 */TimerApp;component/Image/zaznzaczenie.png���� "  .���  � ��
 ���� ��  � ��$ Center=��� "  .���  � ��
 ����  ��  �� *State+ Started.a���  � ��8      Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$	 Lp.��   
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding ��  �� RelativeSource �� *FindAncestor+ �� AncestorType"   �� 	Converter# [     ElementStyle �� " ��.���  � ��$ Center=���  � ��$ 5,0,0,0q�4  .System.Windows.Controls.DataGridTemplateColumn  $ Akcja�� .     CellTemplate  �� .R��� $��0q�$��0q�$��45��$��45��$��Center=�$��Center=����� $ DataContext.StartPauseCmd� �� *FindAncestor+" >����� $ SelectedItem� �� ! �� Mode$! FindAncestor=�$ DataGridL����� " ��.���  � �� �� " �� 
TargetType"" ��.R��� #��z��
������ $��0q�._��� #��z��#��z��#��z��# J� SnapsToDevicePixels## z# ��. $ �� Triggers$ P� % P� Property% �@J�IsMouseOver& P� Value& . . ���  � ��
 ��  ���  �@�Cursor$
 Hand����  �@J�Opacity$	 0.5Q� ��  �� *State+
 Paused.a���  � �� �� $( "/TimerApp;component/Image/play.png��' j� Stretch$' Uniform=���  �� *State+
 Stoped.a���  � �� �� $( "/TimerApp;component/Image/play.png��$' Uniform=���  �� *State+ Started.a���  � �� �� $) #/TimerApp;component/Image/pauza.png��$' Uniform=�  $ Nazwa�� . (   Width5	  /System.Windows.Controls.DataGridLengthConverter$( *	  �� $
 Name� �� " ��.���  � ��$ Center=���  � ��$ 5,0,0,0q�  $
 Czas�� .  �� $ DurationDisplay� �� " ��.���  � ��$ Center=���  � ��$ 5,0,0,0q�  $
 do 0�� .   �� .R��� $��0q�$��0q�$��45��$��45��$��Center=�$��Center=����� " ��.���  � {� .  ��  � �� �� "" ��.R��� #��z��
������ $��0q�._��� #��z��#��z��#��z��## z# ��.  ��  �� $ IsTimerDescending� True.a���  � �� �� $3 -/TimerApp;component/Image/zielony_znaczek.png��$' Uniform=���  �� *IsTimerDescending+	 False.a���  � �� �� $1 +/TimerApp;component/Image/pusty_znaczek.png��$' Uniform=�  $ Alarm�� .   �� .R��� $��0q�$��0q�$��45��$��45��$��Center=�$��Center=����� " ��.���  � {� .  ��  � �� �� "" ��.R��� #��z��
������ $��0q�._��� #��z��#��z��#��z��## z# ��.  ��  �� $ ShouldAlertFire� True.a���  � �� �� $3 -/TimerApp;component/Image/zielony_znaczek.png��$' Uniform=���  �� *ShouldAlertFire+	 False.a���  � �� �� $1 +/TimerApp;component/Image/pusty_znaczek.png��$' Uniform=�  $ Uwagi�� . $( *	  �� $ Comments� �� " ��.���  � ��$ Center=���  � ��$ 5,0,0,0q�    �� .R��� $��0q�$��45��$��45��
������ $��0q�$��Center=�$��Center=����� $ DataContext.StopCmd� �� *FindAncestor+" >����� $ SelectedItem� �� $! FindAncestor=�$ DataGridL����� $( "/TimerApp;component/Image/stop.png��$' Uniform=�  )   HeaderTemplate) �� .R��� $��UP��$��0q�
�������
������ $��1q�
����������� *DataContext.RowMovementCmd+ �� "  ��F� * F�Name$* Arrow��$��1��
�������$��Center=�$��Center=�"����     z � z     � $�  z 	  �� .R��� $��0q�$��45��$��45��
������ $��0q�$��Center=�$��Center=����� $ DataContext.EditRowCmd� �� *FindAncestor+" >����� $ SelectedItem� �� $! FindAncestor=�$ DataGridL����� $* $/TimerApp;component/Image/olowek.png��$' Uniform=�  ) �� .R��� $
��DOWN��$��0q�
�������
������ $��1q�
����������� *DataContext.RowMovementCmd+ �� "  ��F� $* Arrow��$��1��
�������$��Center=�$��Center=�"����        � z  z � $�     	  �� .R��� $��0q�$��45��$��45��
������ $��0q�$��Center=�$��Center=����� $ DataContext.DeleteRowCmd� �� *FindAncestor+" >����� $ SelectedItem� �� $! FindAncestor=�$ DataGridL����� $( "/TimerApp;component/Image/kosz.png��$' Uniform=�