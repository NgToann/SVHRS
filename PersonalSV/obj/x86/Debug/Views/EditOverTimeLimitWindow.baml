   M S B A M L   `   `   `  ����  
PersonalSV.    (PersonalSV.Views.EditOverTimeLimitWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5        $��13(�5   K     � WindowStartupLocation$  CenterScreen=�5   @      titleOverTimeLimitWindow � Title# �   5   	   $	��400��6H   $	��600��6U   .��5      � $��2q�6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   �� 5	      $
��auto �6   .+�5   
   �� $��2��6     GroupBoxTemplate#���  6#   ��5      �� 5        Background1#���  6     BorderStyle#���  6P   ._�5      ��  % !commonGroupBoxOverTimeInformation#���  6    5      .��5      � -   5         �Name$ gridOTInfor��5       � ColumnDefinitions 5      �� 5      �� 5      $��5 �6'   �� 5       5      �� 5      $
��auto �6$   �� 5      $
��auto �6$   �� 5      $
��auto �6$   �� 5      $
��auto �6$   �� 5      $
��auto �6$   .+�5      ��   commonDatePickerFrom#���  6   $��Bottom=�6V   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ 
dpDateFrom��5   *   $��1��6   $��1��6>      SelectedDate$ 
1992/11/16X�6K   �� 5!      $��2��6      commonDatePickerTimeOutLimit#���  6)   $��0,5,0,0q�6k   �� 5"      -   5         ��Name$ txtTimeOutLimit��5"      $��3��63   
���   � �� 	MaxLength$ 4��6  $��Center=�6  $��3��6=  ��6@   �� 	 �� ElementName$	 
dpDateFrom��
 �� Path$
 ActualHeight���6�   �� *TimeOutLimit+6=  �� 5$      $��2��6     commonDatePickerTo#���  6,   $��0,5,0,0q�6d     5%      -   5        $ dpDateTo��5%   :   $��1��6   $��2��6*   $ 
1992/11/16X�6L   $��2��6f   �� 5'      $��2��6   $��2��6)     commonDatePickerOverTime#���  69   $��0,5,0,0q�6w   �� 5(      -   5        $ txtOverTime��5(      $��3��6/   $��2��6<   
���   �$��Center=�6�   $��4��6�   ��6`   �� *
OverTime+6�   �� 5*      -   5         ��Name$ btnAdd��5*      $��4��6)   $��2��66    	 ButtonTemplate#��� 	 6F   $��0,5,0,0q�6~   $��5��6�   ��5+      � 5,       5-      �� 5.   "   �� 5/   "   .+�51      �� $��16��6$   $��16��6/   $��/Images/edit_add.png��6;   �� 52      $��2,0,0,0q�6(   $��1��69   $��Center=�6I    
 commonButtonAdd#��� 
 6d   53      55      56      57      � 58   
   $��1��6   $��2��6   $��0,5,0,0q�60   .+�59      &   System.Windows.Controls.DataGrid  -   5          Name$ dgOverTimeTemp��59         AutoGenerateColumns .   �� AlternationCount$ 2��6K      AlternatingRowBackground
 �����   RowHeaderWidth$	 NaNQ�6�      CanUserAddRows .     SelectionUnit$ FullRow=�5:   .      HorizontalGridLinesBrush
 �����   VerticalGridLinesBrush
 �����$��Times New Roman)�5;      $��14(�64    � 	Resources 5<      *  $System.Windows.Controls.DataGridCell �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value��%�   '        �� 5=      "  6    5>      P� 5?       �@ 
IsSelected . . �5@   "   ��  � ��
 ��iA�6?   �� 5A   "    � ��
 �����6?   5B      5D      5E         ColumnHeaderStyle 5F      �� 5G      =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5H      ��  � ��$ Center=�6G   �� 5I       � ��$ 15(�65   �� 5J       � ��  DataGridRowHeaderBG# �  67   �� 5K       � ��
 �����68   �� 5L       � ��$ 0.5,0.5,0.5,0q�6<   �� 5M       � ��$ 5q�64   5N       � ContextMenu 5P      �� 5Q      .@�5R      m� -	   5         m�Name$ miRemove��5R   #     commonMenuItemRemove#���  65   5S      5T         Columns 5V      4  .System.Windows.Controls.DataGridTemplateColumn  5W        commonEmployee,  &System.Windows.Controls.DataGridColumn    Header#  �  6-   !   
IsReadOnly! . "   CellTemplate" 5X      �� 5Y      .R�5Z   "   �� $��3q�6J   $��Center=�6U   $��Center=�6p   ��6,   �� *EmployeeCode+6p   5[      5]        5^        commonEmployeeID#  �  6-   ! . " 5_      �� 5`      .R�5a   "   �� $��3q�6H   $��Center=�6S   $��Center=�6n   ��6,   �� *
EmployeeID+6n   5b      5d        5e      #   MinWidth$	# 100Q�6-    . *checkRecordingTimeGridHeaderAttendanceDate#  �  6<   ! . " 5f      �� 5g      .R�5h   "   �� $��3q�6c   $��Center=�6n   $��Center=�6�   ��6,   �� *OverTimeDate+$ �� StringFormat$$ 
dd/MM/yyyy��6�   5i      5k        5l      $# 70Q�6-   #  �  6;   ! . " 5m      �� 5n      .R�5o   "   �� $��3q�6J   $��Center=�6U   $��Center=�6p   ��6,   �� *TimeOutLimit+6p   5p      5r        5s      #  �  6-   ! .  " 5t      �� 5u      .R�5v   "   �� $��3q�6Y   $��Center=�6d   $��Center=�6   ��6,   �� *
OverTime+$$ N2��6   5w      5y      5{      5|      � 5}   
   $��2��6    5~      �� 5      �� 5�      �� 5�      �� 5�      .+�5�      �� -
   5        $ btnSave��5�      $��3��6&   #��� 	 66   $��0,5,0,0q�6n   ��5�      � 5�       5�      �� 5�      �� 5�      .+�5�      �� $��16��6    $��16��6+   $��/Images/filesave.png��67   �� 5�      $��2,0,0,0q�6$   $��1��65   $��Center=�6E     commonButtonSave#���  6`   5�      5�      �� 5�      -   5        $ 	btnDelete��5�      $��2��6(   #��� 	 68   $��0,5,5,0q�6p   ��5�      � 5�       5�      �� 5�      �� 5�      .+�5�      �� $��16��6    $��16��6+   $��/Images/edit_remove.png��67   �� 5�      $��2,0,0,0q�6$   $��1��65   $��Center=�6E     commonButtonDelete#���  6`   5�      5�      5�      5�      5�      