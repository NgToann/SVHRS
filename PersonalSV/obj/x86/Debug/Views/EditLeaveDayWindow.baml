   M S B A M L   `   `   `  ����  
PersonalSV)    #PersonalSV.Views.EditLeaveDayWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5        $��13(�5   U       titleAddUpdateLeaveDayWindow  � Title#  �   5   	   $	��450��6L   $	��600��6Y    � WindowStartupLocation$ CenterScreen=�6e   .��5      � $��2q�6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   �� 5	      $
��auto �6   .+�5   
   �� -   5         ��Name$ gridLeaveDay��5        GroupBoxTemplate#���  6)   ��5      �� 5        Background1#���  6     BorderStyle#���  6P   ._�5      ��  % !commonGroupBoxLeaveDayInformation#���  6    5      .��5      �  � ColumnDefinitions 5      �� 5      �� 5      $��5 �6'   �� 5       5      �� 5      $
��auto �6$   �� 5      $
��auto �6$   �� 5      $
��auto �6$   �� 5      $
��auto �6$   �� 5      $
��auto �6$   �� 5      $
��auto �6$   .+�5       ��   commonDatePickerDateBegin#���  6   $��Bottom=�6[   (  "System.Windows.Controls.DatePicker  5!      -   5          Name$ 
dpDateFrom��5!   *   $��1��6   $��Center=�6a      SelectedDate 6>   �� *	BeginDate+6a   �� 5"      $��2��6     commonDatePickerDateEnd#���  6,   $��0,5,0,0q�6i     5#      -   5        $ dpDateTo��5#   ;   $��2��6   $��1��6-   $��Center=�6�    6M   �� *	EndDate+6�   � 5%      $��2��6   $��3��6$    5&      �� 5'      �� 5(      $��5 �6+   �� 5)      �� 5*      $��5 �6+   �� 5+       5-      �� 5.      $
��auto �6(   �� 5/      $
��auto �6(   .+�51      �� $��0,5,0,0q�6      leaveDayTotalDay#���  61   �� 52      -   5         ��Name$ txtTotalDay��52      $��1��63   
���   �$��Center=�6�   ��6@   ��  �� ElementName$ 
dpDateFrom��	 �� Path$	 ActualHeight���6�   �� *
TotalDay+6  �� 53      $��2��6    $��0,5,0,0q�60     leaveDayRemark#���  6A   �� 54      -   5        $ 	txtRemark��54      $��2��61   $��1��6A   
���   �$��Center=�6b   ��6�   �� *Remark+�� 56      $��4��6    $��0,5,0,0q�60   $��RandomNo��6A   �� 57      $��4��6   $��1��6.   
���  ��$��SemiBold"�6L   
���   �$��Center=�6v   {�.  ��6�   �� *
RandomNo+58      � 5:      $��3��6   $��3��6$   $��0,10,0,0q�68    5;      �� 5<      �� 5=      $��5 �6+   �� 5>      �� 5?      $��5 �6+   �� 5@      .+�5B      	� -   5        
 	�Name$
 radPaidLeave��5B   "    	 commonRadioPaid#��� 	 68    
 RadioBlueStyle#��� 
 6p    	� 	GroupName$ 	PaidLeave��6�   $��Center=�6�   $��Center=�6�    d� 	IsChecked 6�   �� *IsPaid+	� 5D      -   5        $
 radNotPaidLeave��5D   2   $��2��6"     commonRadioNotPaid#���  6K     RadioRedStyle#���  6�   $ 	PaidLeave��6�   $��Center=�6�   $��Center=�6�    6  �� *	IsNotPaid+�� 5F      -	   5         ��Name$ btnAdd��5F   -   $��4��6     ButtonTemplate#���  6=   ��5G      � 5H       5I   "   �� 5J   &   �� 5K   &   .+�5M   "   �� $��16��6(   $��16��63   $��/Images/edit_add.png��6?   �� 5N   "   $��2,0,0,0q�6,   $��1��6=   $��Center=�6M     commonButtonAdd#���  6h   5O      5Q      5R      5T      5U      &   System.Windows.Controls.DataGrid  5W   
   -
   5          Name$ 
dgLeaveDay��5W   1   $��1��6   $��0,5,0,0q�6       AutoGenerateColumns .   �� AlternationCount$ 2��6a      AlternatingRowBackground
 �����   CanUserAddRows .     SelectionUnit$ FullRow=�5X   .      HorizontalGridLinesBrush
 �����   VerticalGridLinesBrush
 �����   
IsReadOnly . $��Times New Roman)�5Y   )   $��14(�6F      FrozenColumnCount$ 3��6T      RowHeaderWidth$	 NaNQ�6j    � 	Resources 5Z      *  $System.Windows.Controls.DataGridCell �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value��%�   '        �� 5[      "  6    5\      P� 5]       �@ 
IsSelected . . �5^      ��  � ��
 ��iA�6;   �� 5_       � ��
 �����6;   5`      5b      5c          ColumnHeaderStyle  5d      �� 5e      =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5f      ��  � ��$ Center=�6C   �� 5g       � ��$ 15(�61   �� 5h       � ��  DataGridRowHeaderBG# �  63   �� 5i       � ��
 �����64   �� 5j       � ��$ 0.5,0.5,0.5,0q�68   �� 5k       � ��$ 5q�60   5l      !   Columns! 5n      4  .System.Windows.Controls.DataGridTemplateColumn  5o      ,  &System.Windows.Controls.DataGridColumn"   Header$" RandomNo��6)   #   SortMemberPath$# RandomNo��6;   $   CellTemplate$ 5p      �� 5q      .R�5r      �� $��3q�6B   $��Center=�6M   $��Center=�6h   ��6(   �� *
RandomNo+6h   5s      5u        5v        commonEmployeeCode#" �  6)   $# EmployeeCode��6c   $ 5w      �� 5x      .R�5y      �� $��3q�6F   $��Center=�6Q   $��Center=�6l   ��6(   �� *EmployeeCode+6l   5z      5|        5}        commonEmployeeID#" �  6)   $# 
EmployeeID��6a   $ 5~      �� 5      .R�5�      �� $��3q�6D   $��Center=�6O   $��Center=�6j   ��6(   �� *
EmployeeID+6j   5�      5�        5�        leaveDayDate#" �  6)   $# 	LeaveDate��6]   $ 5�      �� 5�      .R�5�      �� $��3q�6\   $��Center=�6g   $��Center=�6�   ��6(   �� *	LeaveDate+% �� StringFormat$% 
dd/MM/yyyy��6�   5�      5�        5�      #" �  6)   $# TotalDay��6a   $ 5�      �� 5�      .R�5�      �� $��3q�6B   $��Center=�6M   $��Center=�6h   ��6(   �� *
TotalDay+6h   5�      5�        5�      #" �  6)   $# Remark��6_   $ 5�      �� 5�      .R�5�      �� $��3q�6@   $��Center=�6K   $��Center=�6f   ��6(   �� *Remark+6f   5�      5�        5�        leaveDayPaidLeave#" �  6)   $
# Paid��6b   $ 5�      �� 5�      .R�5�      �� $��3q�6>   $��Center=�6I   $��Center=�6d   ��6(   �� *Paid+6d   5�      5�      5�      � 5�   
   $��2��6   $��0,5,0,0q�6    5�      �� 5�      �� 5�      �� 5�      �� 5�      .+�5�      �� -   5        $ 	btnDelete��5�   %   $��2��6   #���  68   ��5�      � 5�       5�      �� 5�      �� 5�      .+�5�      �� $��16��6    $��16��6+   $��/Images/edit_remove.png��67   �� 5�      $��2,0,0,0q�6$   $��1��65   $��Center=�6E     commonButtonDelete#���  6`   5�      5�      �� 5�      -   5        $ btnSave��5�   %   $��3��6   $��5,0,0,0q�66   #���  6G   ��5�      � 5�       5�      �� 5�      �� 5�      .+�5�      �� $��16��6    $��16��6+   $��/Images/filesave.png��67   �� 5�      $��2,0,0,0q�6$   $��1��65   $��Center=�6E     commonButtonSave#���  6`   5�      5�      5�      5�      5�      