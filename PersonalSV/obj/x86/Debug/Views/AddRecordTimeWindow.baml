   M S B A M L   `   `   `  ����  
PersonalSV*    $PersonalSV.Views.AddRecordTimeWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5        $��13(�5   @      titleAddRecordTimeWindow  � Title#  �   5   	   $	��330��6H   $	��500��6U    � WindowStartupLocation$ CenterScreen=�6a   .��5      � -   5         �Name$ gridEmployeeInfor��5      $��2q�6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5	      $
��auto �6   �� 5
      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   ��   commonEmployeeID#���  6   $��Center=�6J   �� 5   
   -   5         ��Name$ txtEmployeeIDSearch��5      $��1��6/   $��0,2,0,0q�6Y   
���   �$��15(�6~   $��Center=�6�   
 � Tag 6<   �� *EmployeeCode+6�   �� 5   
   -   5         ��Name$ 	btnSearch��5      $��1��6<   $��Search��6L   $��0��6]   �� 5   
   $��2��6     commonEmployeeName#���  6!   $��Center=�6Y   $��0,10,0,0q�6t   �� 5   
   $��3��6   $��0,2,0,0q�6=   
���   �
����  ���6   �� *EmployeeName+6b   �� 5   
   $��4��6     commonDatePickerDate#���  6!   $��Center=�6[   $��0,20,0,0q�6v   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ 	dpDateAdd��5      $��5��6(   $��0,2,0,0q�6V   	   SelectedDate	 65   �� *	DateAdd+6g   �� 5    
   $��6��6     commonDatePickerTime#���  6!   $��Center=�6[   $��0,20,0,0q�6v   �� 5!   
   -   5        $��7��5!      $��0,2,0,0q�68   
���   �
 �� 	MaxLength$
 4��6�   ��6   �� *	TimeAdd+6�   �� 5#   
   -   5        $ btnAdd��5#      $��9��6     ButtonTemplate#���  6.   {�.  ��5$      � 5%       5&      �� 5'      �� 5(      .+�5*      �� $��16��6   $��16��6'   $��/Images/mini-append.png��63   �� 5+      $��5,0,0,0q�6    $��1��61   $��Center=�6A     commonButtonAdd#���  6\   5,      5.      � 50   
   $��1��6   $��1��6   $��9��6,   $��2��6=   .+�51      &   System.Windows.Controls.DataGrid  -   5          Name$ dgRecordTime��51         AutoGenerateColumns .   �� AlternationCount$ 2��6I      AlternatingRowBackground
 �����$��5,2,0,0q�6�      CanUserAddRows .     SelectionUnit$ CellOrRowHeader=�52   .      HorizontalGridLinesBrush
 �����   VerticalGridLinesBrush
 �����   
IsReadOnly . $��Times New Roman)�53   )   $��14(�6F    � 	Resources 54      *  $System.Windows.Controls.DataGridCell �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value��%�   '        �� 55      "  6    56      P� 57       �@ 
IsSelected . . �58   "   ��  � ��
 ��iA�6?   �� 59   "    � ��
 �����6?   5:      5<      5=         ColumnHeaderStyle 5>      �� 5?      =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5@      ��  � ��$ Center=�6G   �� 5A       � ��$ 15(�65   �� 5B       � ��  DataGridRowHeaderBG# �  67   �� 5C       � ��
 �����68   �� 5D       � ��$ 0.5,0.5,0.5,0q�6<   �� 5E       � ��$ 5q�64   5F         Columns 5H      0  *System.Windows.Controls.DataGridTextColumn  5I      ,  &System.Windows.Controls.DataGridColumn   MinWidth$	 100Q�6)    & "recordTimeDetailDataGridHeaderDate   Header# �  6p   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   �� *
SourceDate+  �� StringFormat$  
dd/MM/yyyy��6p     5J      $ 70Q�6)    &	 "recordTimeDetailDataGridHeaderTime# � 	 6Z    67   �� *SourceTimeView+6Z     5K       (
 $recordTimeDetailDataGridHeaderCardNo# � 
 6D    6)   �� *CardNo+6D   5M      5N      5O      5P      