   M S B A M L   `   `   `  ����  
PersonalSV+    %PersonalSV.Views.LeavWithSalaryWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          � WindowStartupLocation$  CenterScreen=�5   @   $��13(�6e      titleOverTimeLimitWindow � Title# �   5   	   $	��500��6H   $	��780��6X   .��5      � $��2q�6    � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��5 �6   �� 5	      $��* �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��5 �6   �� 5      �� 5      $
��auto �6   .+�5   
   ��   GroupBoxTemplate#���  6   ��5      �� 5        Background1#���  6     BorderStyle#���  6P   ._�5      ��  % !commonGroupBoxEmployeeInformation#���  6    5      .��5      �  5      �� 5      $��* �6$   �� 5      $
��auto �6$   �� 5      $
��auto �6$   �� 5      $��* �6$    5      �� 5      �� 5       $��10 �6'   �� 5!      .+�5#      �� $��1��6     commonEmployee#���  6)   $��0,10,0,0q�6]   �� 5$      -   5         ��Name$ txtEmployeeSearch��5$   '   $��2��6   
���   �$��15(�6�   $��Center=�6�   6�   �� 5%      -   5         ��Name$ 	btnSearch��5%   7   $��2��6   $��2��6&     ButtonTemplate#���  6J   ��5&      � 5'       5(      �� 5)   "   �� 5*   "   .+�5,      �� $��16��6$   $��16��6/   $��/Images/search.png��6;   �� 5-      $��2,0,0,0q�6(   $��1��69   $��Center=�6I     commonButtonSearch#���  6d   5.      50      51      52      �� 54   
   $��2��6   #���  6#   ��55      �� 56      #���  6   #���  6P   ._�57      ��  % !commonGroupBoxOverTimeInformation#���  6    58      .��5:      � -   5         �Name$ gridOTInfor��5:       5;      �� 5<      �� 5=      $��5 �6'   �� 5>      �� 5?      $��5 �6'   �� 5@       5B      �� 5C      $
��auto �6$   �� 5D      $
��auto �6$   �� 5E      $
��auto �6$   �� 5F      $
��auto �6$   .+�5H      ��  	 commonDatePickerFrom#��� 	 6   $��Bottom=�6V   (  "System.Windows.Controls.DatePicker  5I      -   5          Name$ 
dpDateFrom��5I   *   $��1��6   $��1��6>   �� 5K      $��2��6     
 commonDatePickerTimeOutLimit#��� 
 6)   $��0,5,0,0q�6k   �� 5L      $��3��6   
���   �$��3��6Y    �� 	MaxLength$ 4��6f   $��Center=�6�   ��6;   �� *TimeOutLimit+��6t   �� 	 �� ElementName$	 
dpDateFrom��
 �� Path$
 ActualHeight�6�   �� 5N      $��2��6     commonDatePickerTo#���  6,   $��0,5,0,0q�6d     5O      -   5        $ dpDateTo��5O   :   $��1��6   $��2��6*   $��2��6L   �� 5T      $��2��6   $��2��6)     commonDatePickerOverTime#���  69   $��0,5,0,0q�6w   �� 5U      -   5        $��3��5U      $��2��6'   
���   �$��4��6e   $��Center=�6�   ��6K   �� *
OverTime+��6r   �� $	 
dpDateFrom��$
 ActualHeight�6�   5W      5X      R� 5Z   
   -   5         R�Name$ treeDepartments��5Z      $��2��6,   
������ 5[      &   System.Windows.Controls.DataGrid  5]   
   -	   5          Name$ dgEmployeePerDepartment��5]   0   $��2��6   $��2��6#      AutoGenerateColumns .   �� AlternationCount$ 2��6m      AlternatingRowBackground
 �����   CanUserAddRows .     SelectionUnit$ FullRow=�5^   .      HorizontalGridLinesBrush
 �����   VerticalGridLinesBrush
 �����   RowHeaderWidth$	 NaNQ�6�      
IsReadOnly . $��Times New Roman)�5_   )   $��14(�6F   $��5��6�    � ContextMenu 5`      �� 5a      .@�5b      m� -
   5         m�Name$ miRemove��5b        commonMenuItemRemove#���  61   5c      5d       � 	Resources 5f      *  $System.Windows.Controls.DataGridCell �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value��%�   '        �� 5g      "  6    5h      P� 5i       �@ 
IsSelected . . �5j      ��  � ��
 ��iA�6;   �� 5k       � ��
 �����6;   5l      5n      5o         ColumnHeaderStyle 5p      �� 5q      =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5r      ��  � ��$ Center=�6C   �� 5s       � ��$ 15(�61   �� 5t       � ��  DataGridRowHeaderBG# �  63   �� 5u       � ��
 �����64   �� 5v       � ��$ 0.5,0.5,0.5,0q�68   �� 5w       � ��$ 5q�60   5x          Columns  5z      0  *System.Windows.Controls.DataGridTextColumn  5{        commonEmployeeCode,  &System.Windows.Controls.DataGridColumn!   Header#! �  6F   1  +System.Windows.Controls.DataGridBoundColumn"   Binding" 6%   �� *EmployeeCode+6F     5|        commonEmployeeID#! �  6D   " 6%   �� *
EmployeeID+6D     5}        commonEmployeeName#! �  6F   " 6%   �� *EmployeeName+6F     5~        commonEmployeeDepartment#! �  6H   " 6%   �� *DepartmentName+6H   5�      � 5�   
   $��3��6   $��4��6   $��0,5,0,0q�6,    5�      �� 5�      $��2* �6#   �� 5�      �� 5�      $��10 �6#   �� 5�      .+�5�      �� -   5        # ��Name$# txtTotal��5�      $	��Top=�6*   
����  �$��Italic$�6T   �� 5�      -   5        $ 	btnDelete��5�      $��8��6(   $��1��65   #���  6E   ��5�      � 5�       5�      �� 5�      �� 5�      .+�5�      �� $��16��6    $��16��6+   $��/Images/edit_remove.png��67   �� 5�      $��2,0,0,0q�6$   $��1��65   $��Center=�6E     commonButtonDelete#���  6`   5�      5�      �� 5�      -   5        $ btnSave��5�      $��8��6&   $��3��63   #���  6C   ��5�      � 5�       5�      �� 5�      �� 5�      .+�5�      �� $��16��6    $��16��6+   $��/Images/filesave.png��67   �� 5�      $��2,0,0,0q�6$   $��1��65   $��Center=�6E     commonButtonSave#���  6`   5�      5�      5�      5�      5�      