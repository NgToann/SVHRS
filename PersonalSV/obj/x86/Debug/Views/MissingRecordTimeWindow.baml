   M S B A M L   `   `   `  ����F  BPersonalSV, Version=1.0.1.18, Culture=neutral, PublicKeyToken=null3clr-namespace:PersonalSV.ViewsPersonalSV.Views  5   	   .    (PersonalSV.Views.MissingRecordTimeWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:PersonalSV.Views     5   	   -   5        $��13(�5   6     � WindowStartupLocation$  CenterScreen=�5         titleMissingRecordTime � Title# �   5   	   $	��500��6F   $	��800��6S   .��5	      � $��2q�6    � RowDefinitions 5
   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �  � ColumnDefinitions 5      �� 5      $
��auto �6#   �� 5      $
��auto �6#   .+�5      ��   GroupBoxTemplate#���  6   ��5      �� 5        Background1#���  6     BorderStyle#���  6T   ._�5      ��  & "commonGroupBoxSearchingInformation#���  6$   5      .��5      �  5      �� 5      $
��auto �6(   �� 5      $
��auto �6(   �� 5      $
��auto �6(   �� 5      $
��auto �6(    5       �� 5!      $
��auto �6+   �� 5"      $��10 �6+   �� 5#      $
��auto �6+   �� 5$      $��10 �6+   �� 5%      $
��auto �6+   �� 5&      $��10 �6+   �� 5'      $
��auto �6+   .+�5)      ��   commonDatePickerFrom#���  6    �� 5*        commonDatePickerTo#���  6    $��2��6X   (  "System.Windows.Controls.DatePicker  5+      -   5          Name$ dpFrom��5+   !   $��1��61   $��0,2,0,0q�6>     5,      -   5        $
 dpTo��5,   !   $��1��6/   $��2��6<   $��0,2,0,0q�6L   �� 5.      $��4��6      commonEmployee#���  60   �� 5/      -   5         ��Name$ txtEmployeeIDSearch��5/   \   $��1��6   $��4��6+   $	��120��6;   $��3,0,0,0q�6J   
���   �$��15(�6�   $��Center=�6�   6�   � 51      $��6��6   $��1��6+   $��3��68    52      �� 53      �� 54      .+�56      �� -   5         ��Name$ 	btnSearch��56   !     ButtonTemplate#���  64    � Cursor$
 Hand��6�   ��57      � 58   "    59   &   �� 5:   *   �� 5;   *   .+�5=   &   �� $��16��6,   $��16��67   $��/Images/search.png��6C   �� 5>   &   $��2,0,0,0q�60   $��1��6A   $��Center=�6Q    	 commonButtonSearch#��� 	 6l   5?   #   5A      5B      �� 5C      $��3��6    $��10��6-   $��0,5,0,0q�6B   $
��Bold"�6S   
���  ��$��Italic$�6v    
 missingRecordRemarks#��� 
 6�   5D      5E      5F      &   System.Windows.Controls.DataGrid  5G   
   -   5          Name$ dgMissingRecord��5G   1   $��1��6   $��0,5,0,0q�6    	   AutoGenerateColumns	 .  
   CanUserSortColumns
 .    ClipboardCopyMode$ IncludeHeader=�6�      CanUserAddRows .     SelectionUnit$ FullRow=�5H   .      HorizontalGridLinesBrush
 �����   VerticalGridLinesBrush
 �����   RowHeaderWidth$	 NaNQ�6�      
IsReadOnly . $��Times New Roman)�5I   )   $��14(�6F      FrozenColumnCount$ 2��6T      	CellStyle 5J      �� 5K       �� 
TargetType*  $System.Windows.Controls.DataGridCell"  6    �� Triggers 5L      P� 5M       P� Property �@ 
IsSelected P� Value . . �5N      ��  �� Property � �� �� Value
 �   �6;   �� 5O       � ��
 ��� �6;   �� 5P       � ��$ Semibold"�6;   �� 5Q       � ��$ 0,0,0,0q�6@   5R      5T         ColumnHeaderStyle 5V      �� 5W      =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5X      ��  � ��$ Center=�6C   �� 5Y       � ��$ 15(�61   �� 5Z       � ��  DataGridRowHeaderBG# �  63   �� 5[       � ��
 �����64   �� 5\       � ��$ 0.5,0.5,0.5,0q�68   �� 5]       � ��$ 5q�60   5^         Columns 5`      4  .System.Windows.Controls.DataGridTemplateColumn  5a        missingRecordTimeCardId,  &System.Windows.Controls.DataGridColumn   Header# �  6)      SortMemberPath$ CardId��6h      ClipboardContentBinding 6�   �� *CardId+   CellTemplate 5b      �� 5c      .R�5d      �� $��3q�6@   $��Center=�6K   $��Center=�6f   ��6(   �� *CardId+6f   5e      5g        5h        missingRecordTimeWorkerId# �  6)   $ WorkerId��6j    6�   �� *
WorkerId+ 5i      �� 5j      .R�5k      �� $��3q�6B   $��Center=�6M   $��Center=�6h   ��6(   �� *
WorkerId+6h   5l      5n        5o        missingRecordTimeWorkerName# �  6)   $
 Name��6l    6�   �� *Name+ 5p      �� 5q      .R�5r      �� $��3q�6>   $��Center=�6I   ��6(   �� *Name+6I   5s      5u        5v        missingRecordTimeJoinDate# �  6)   $ JoinDate��6j    6�   �� *
JoinDate+ 5w      �� 5x      .R�5y      �� $��3q�6[   $��Center=�6f   ��6(   �� *
JoinDate+  �� StringFormat$  
dd/MM/yyyy��6f   5z      5|        5}        missingRecordTimeDepartment# �  6)   $ 
Department��6l    6�   �� *
Department+ 5~      �� 5      .R�5�      �� $��3q�6D   $��Center=�6O   ��6(   �� *
Department+6O   5�      5�        5�        missingRecordTimeDate# �  6)   $
 Date��6f    6|   �� *Date+ 5�      �� 5�      .R�5�      �� $��3q�6W   $��Center=�6b   ��6(   �� *Date+$  
dd/MM/yyyy��6b   5�      5�        5�        missingRecordTimeNoOfScan# �  6)   $ NoOfScan��6j    6�   �� *
NoOfScan+ 5�      �� 5�      .R�5�      �� $��3q�6B   $��Center=�6M   $��Center=�6h   ��6(   �� *
NoOfScan+6h   5�      5�        5�        missingRecordTimeRecordTime# �  6)   $ 
RecordTime��6l    6�   �� *
RecordTime+ 5�      �� 5�      .R�5�      �� $��3q�6D   $��Center=�6O   $��Center=�6j   ��6(   �� *
RecordTime+6j   5�      5�      5�      5�      5�      