   M S B A M L   `   `   `  ����  
PersonalSV+    %PersonalSV.Views.EditRecordTimeWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5        $��13(�5   @    !  titleCheckingRecordTimeDetail  � Title#  �   5   	   $	��400��6M   $	��500��6Z    � WindowStartupLocation$ CenterScreen=�6f   .��5      � -   5         �Name$ gridEmployeeInfor��5      $��2q�6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5	      $
��auto �6   �� 5
      $
��auto �6   �� 5      $
��auto �6   �� 5      �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      $��2* �6   �� 5      $��3* �6   .+�5   
   ��   commonEmployeeCode#���  6   $��Center=�6L   �� 5   
   -   5         ��Name$ txtEmployeeCode��5   "   $��1��6   $��Center=�6�   ��6;   �� *EmployeeCode+��6Y   ��  �� ElementName$ txtRecordTimeAdd�� �� Path$ ActualHeight�6�   �� 5   
   $��1��6     commonEmployeeID#���  6!   $��Center=�6W   �� 5   
   $��1��6   $��1��6   $��0,5,0,0q�6K   $��Center=�6�   ��6/   �� *
EmployeeID+��6\   �� $ txtRecordTimeAdd��$ ActualHeight�6�   �� 5   
   $��2��6     commonEmployeeName#���  6!   $��Center=�6Y   �� 5   
   -   5        $ txtEmployeeName��5   /   $��2��6   $��1��6   $��0,5,0,0q�6f   $��Center=�6�   ��6H   �� *EmployeeName+��6w   �� $ txtRecordTimeAdd��$ ActualHeight�6�   �� 5   
   $��3��6     commonEmployeeDepartment#���  6!   $��0,5,0,0q�6`   $��Center=�6q   �� 5   
   -   5        $ txtDepartmentName��5   /   $��3��6   $��1��6   $��0,5,0,0q�6j   $��Center=�6�   ��6J   �� *DepartmentName+��6{   �� $ txtRecordTimeAdd��$ ActualHeight�6�   �� 5    
   $��4��6   $��2��6    $��0,10,0,0q�64     GroupBoxTemplate#���  6F   ��5!      �� 5"        Background1#���  6     BorderStyle#���  6P   ._�5#      ��   commonGroupBoxAddRecordTime#���  6    5$      .��5&      �  5'      �� 5(      �� 5)      $��5 �6'   �� 5*       5,      �� 5-      �� 5.      .+�50      ��  	 
commonTime#��� 	 6   �� 51      -   5        $ txtRecordTimeAdd��51      $��1��64   $��Center=�6�    �� 	MaxLength$ 4��6�   
���   �$��1��6�   �� 52      -   5        	 ��Name$	 
btnAddTime��52   6   $��2��6   $��1��6)    
 ButtonTemplate#��� 
 6J   {�.  $��2��6�   ��53      � 54       55      �� 56   "   �� 57   "   .+�59      �� $��16��6$   $��16��6/   $��/Images/edit_add.png��6;   �� 5:      $��2,0,0,0q�6(   $��1��69   $��Center=�6I     commonButtonAdd#���  6d   5;      5=      5>      5?      � 5A   
   $��5��6   $��2��6   $��0,5,0,0q�60   .+�5B      &   System.Windows.Controls.DataGrid  -   5        
  Name$
 dgRecordTime��5B         AutoGenerateColumns .   �� AlternationCount$ 2��6I      AlternatingRowBackground
 �����   CanUserAddRows .     SelectionUnit$ FullRow=�5C   .      HorizontalGridLinesBrush
 �����   VerticalGridLinesBrush
 �����$��Times New Roman)�5D      $��14(�64      RowHeaderWidth$	 NaNQ�6B    � 	Resources 5E      *  $System.Windows.Controls.DataGridCell �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value��%�   '        �� 5F      "  6    5G      P� 5H       �@ 
IsSelected . . �5I   "   ��  � ��
 ��iA�6?   �� 5J   "    � ��
 �����6?   5K      5M      5N         ColumnHeaderStyle 5O      �� 5P      =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5Q      ��  � ��$ Center=�6G   �� 5R       � ��$ 15(�65   �� 5S       � ��  DataGridRowHeaderBG# �  67   �� 5T       � ��
 �����68   �� 5U       � ��$ 0.5,0.5,0.5,0q�6<   �� 5V       � ��$ 5q�64   5W       � ContextMenu 5Y      �� 5Z      .@�5[      m� -	   5         m�Name$ miRemove��5[   #     commonMenuItemRemove#���  65   5\      5]         Columns 5_      4  .System.Windows.Controls.DataGridTemplateColumn  5`      ,  &System.Windows.Controls.DataGridColumn   Header# �  6-      
IsReadOnly .     CellTemplate  5a      �� 5b      .R�5c   "   �� $��3q�6H   $��Center=�6S   $��Center=�6n   ��6,   �� *
EmployeeID+6n   5d      5f        5g      !   MinWidth$	! 100Q�6-    & "recordTimeDetailDataGridHeaderDate# �  6<    .   5h      �� 5i      .R�5j   "   �� $��3q�6a   $��Center=�6l   $��Center=�6�   ��6,   �� *
SourceDate+" �� StringFormat$" 
dd/MM/yyyy��6�   5k      5m        5n      $! 70Q�6-    & "recordTimeDetailDataGridHeaderTime# �  6;    .    5o      �� 5p      .R�5q   "   �� $��3q�6L   $��Center=�6W   $��Center=�6r   ��6,   �� *SourceTimeView+6r   5r      5t        5u      $! 70Q�6-    ( $recordTimeDetailDataGridHeaderCardNo# �  6;    .   5v      �� 5w      .R�5x   "   �� $��3q�6D   $��Center=�6O   $��Center=�6j   ��6,   �� *CardNo+6j   5y      5{      5}      5~      � 5   
   $��6��6   $��2��6    5�      �� 5�      �� 5�      �� 5�      .+�5�      �� -
   5        $	 btnSave��5�   2   $��2��6   $��1��6%   #��� 
 6C   $��0,5,0,0q�6�   {�.  $��3��6�   ��5�      � 5�       5�      �� 5�      �� 5�      .+�5�      �� $��16��6    $��16��6+   $��/Images/filesave.png��67   �� 5�      $��2,0,0,0q�6$   $��1��65   $��Center=�6E     commonButtonSave#���  6`   5�      5�      5�      5�      5�      