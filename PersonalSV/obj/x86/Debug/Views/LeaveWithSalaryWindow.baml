   M S B A M L   `   `   `  ����F  BPersonalSV, Version=1.0.1.18, Culture=neutral, PublicKeyToken=null3clr-namespace:PersonalSV.ViewsPersonalSV.Views  5   	   ,    &PersonalSV.Views.LeaveWithSalaryWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:PersonalSV.Views     5   	   -   5          � WindowStartupLocation$  CenterScreen=�5   6   $��13(�6[      titleLeaveWithSalaryWindow � Title# �   5   	   $	��500��6J   $	��780��6Z   .��5      � $��2q�6    � ColumnDefinitions 5	   
   �� 5
      $
��auto �6   �� 5      $��5 �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��5 �6   �� 5      �� 5      $��2* �6   �� 5      $
��auto �6   .+�5   
   ��   GroupBoxTemplate#���  6   $��5��6M   ��5      �� 5        Background1#���  6     BorderStyle#���  6P   ._�5      ��   commonGroupBoxLine#���  6    5      .��5      �  5      �� 5      �� 5      $��5 �6$   �� 5      $
��Auto �6$   .+�5!      R� -   5         R�Name$ treeDepartments��5!      
������ 5"      � 5#      $��2��6    5$      �� 5%      $
��auto �6(   �� 5&       5(      �� 5)      �� 5*      $��5 �6+   �� 5+      $
��Auto �6+   .+�5-      ��   commonEmployee#���  6    �� 5.      -   5         ��Name$ txtEmployeeSearch��5.   +   $��1��6   
���   �$��18(�6�   $��3,2,2,2q�6�   $��SemiBold"�6�   $��Center=�6�   6�   �� 5/      -   5         ��Name$ 	btnSearch��5/   :   $��1��6   $��2��6*     ButtonTemplate#���  6M   ��50      �� 51      $��1��6$   $��16��64   $��16��6?   $��/Images/edit_add.png��6K   53      54      55      56      �� 57   
   $��2��6   #���  6#   ��58      �� 59      #���  6   #���  6P   ._�5:      ��  , (commonGroupBoxLeaveWithSalaryInformation#���  6    5;      .��5=      � -   5         �Name$ gridOTInfor��5=       5>      �� 5?      �� 5@      $��5 �6'   �� 5B      �� 5C      $��5 �6'   �� 5D       5F      �� 5G      $
��auto �6$   �� 5H      $
��auto �6$   �� 5I      $
��auto �6$   �� 5J      $
��auto �6$   �� 5K      $
��auto �6$   �� 5L      $
��auto �6$   .+�5O      ��   commonDatePickerFrom#���  6   $��Bottom=�6V   (  "System.Windows.Controls.DatePicker  5P      -   5          Name$ 
dpDateFrom��5P   *   $��1��6   $��1��6>   $��0.5,0.5,0.5,0.5q�6K   �� 5R      $��2��6    	 commonDatePickerTo#��� 	 6,   $��0,5,0,0q�6d     5S      -   5        $ dpDateTo��5S   :   $��1��6   $��2��6*   $��2��6L   $��0.5,0.5,0.5,0.5q�6Y   � 5T      $��2��6   $��0,5,0,0q�6$    5U      �� 5V      �� 5W      .+�5Y      	� -   5        	 	�Name$	 	radNormal��5Y   "   
 	� 	GroupName$
 Reason��65   $��Normal��6H   $��Center=�6Y    d� 	IsChecked$
 TrueY�6{   6�   	� 5Z      -	   5        $	 
radSpecial��5Z   2   $��1��6"   $
 Reason��6F   $��Special��6Y   $��Center=�6k   6�   5[      �� 5\      -
   5         ��Name$ 	stkNormal��5\      $��3��60    �� Orientation$ Vertical=�6=   $y�Visible=�6T   .+�5]      �� $��Reason��6    $	��Top=�6.   $��0,5,0,0q�6F   �� 5^      -   5         ��Name$ 	cboReason��5^      $��Center=�62   5_      5`      �� 5b      -   5        $ 
stkSpecial��5b      $��3��61   $ Vertical=�6>   $y�	Collapsed=�6U   .+�5c      ��  
 commonTextBlockSalaryRate#��� 
 6    $��0,5,0,0q�6_   
���  ��$��SemiBold"�6�   $��Italic$�6�   �� 5d      -   5        $ txtSalaryRate��5d      $��4��65   
���   �$	��100��6V    �� 	MaxLength$ 3��6a   $��3��6o   $��3q�6|   $��Center=�6�   ��6�   ��  �� ElementName$ 
dpDateFrom�� �� Path$ ActualHeight�6�   5e      �� 5f      $��2��6   $��2��6)   $��Remark��69   $��Bottom=�6G   $��Italic$�6b   
����  �6u   �� 5g      -   5        $ 
txtRemarks��5g   K   $��3��6   $��2��6'   $��3��67   $��50��6_    �� TextWrapping$
 Wrap=�6n   $��3q�6�   �� 5i      -   5        $ btnAddReason��5i   f   $��4��6   $��0,5,0,0q�6&   
���  ��$��15(�6H   $��4��6V   $y�Visible=�6|   $��Update Reason��6�   6�   5k      5l      &   System.Windows.Controls.DataGrid  5m   
   -   5          Name$ dgEmployeePerDepartment��5m   A   $��2��6   $��2��6#   $��2��60      AutoGenerateColumns .   �� AlternationCount$ 2��6~      AlternatingRowBackground
 �����   CanUserAddRows .     SelectionUnit$ FullRow=�5n   .      HorizontalGridLinesBrush
 �����   VerticalGridLinesBrush
 �����   RowHeaderWidth$	 NaNQ�6�      
IsReadOnly . $��Times New Roman)�5o   )   $��14(�6F   $��5��6�    � ContextMenu 5p      �� 5q      .@�5r      m� -   5         m�Name$ miRemove��5r        commonMenuItemRemove#���  61   5s      5t       � 	Resources 5v      *  $System.Windows.Controls.DataGridCell  �� 
TargetType! �� Triggers" P� Property# P� Value$ �� Property% �� Value��%�   '        �� 5w      "   6   ! 5x      P� 5y      " �@ 
IsSelected# . . �5z      �� $ � ��
% ��iA�6;   �� 5{      $ � ��
% �����6;   5|      5~      5      &   ColumnHeaderStyle& 5�      �� 5�      =  7System.Windows.Controls.Primitives.DataGridColumnHeader"   6   .�5�      �� $ � ��$% Center=�6C   �� 5�      $ � ��$% 15(�61   �� 5�      $ � ��  DataGridRowHeaderBG#% �  63   �� 5�      $ � ��
% �����64   �� 5�      $ � ��$% 0.5,0.5,0.5,0q�68   �� 5�      $ � ��$% 5q�60   5�      '   Columns' 5�      4  .System.Windows.Controls.DataGridTemplateColumn  5�        commonEmployeeCode,  &System.Windows.Controls.DataGridColumn(   Header#( �  6)   )   SortMemberPath$) EmployeeCode��6c   *   ClipboardContentBinding* 6�   �� *EmployeeCode++   CellTemplate+ 5�      �� 5�      .R�5�      �� $��3q�6F   $��Center=�6Q   $��Center=�6l   ��6(   �� *EmployeeCode+6l   5�      5�        5�        commonEmployeeID#( �  6)   $) 
EmployeeID��6a   * 6}   �� *
EmployeeID++ 5�      �� 5�      .R�5�      �� $��3q�6D   $��Center=�6O   $��Center=�6j   ��6(   �� *
EmployeeID+6j   5�      5�        5�        commonEmployeeName#( �  6)   $) EmployeeName��6c   * 6�   �� *EmployeeName++ 5�      �� 5�      .R�5�      �� $��3q�6F   $��Center=�6Q   , �� Padding$, 3,0,0,0q�6l   ��6(   �� *EmployeeName+6l   5�      5�        5�        commonEmployeeDepartment#( �  6)   $) DepartmentName��6i   * 6�   �� *DepartmentName++ 5�      �� 5�      .R�5�      �� $��3q�6H   $��Center=�6S   $, 3,0,0,0q�6n   ��6(   �� *DepartmentName+6n   5�      5�        5�      -   5        	colReason��  commonEmployeeReason#( �  5�   <   $) Reason��6x   * 6�   �� *Reason++ 5�      �� 5�      .R�5�      �� $��3q�6@   $��Center=�6K   $, 3,0,0,0q�6f   ��6(   �� *Reason+6f   5�      5�        5�      -   5        	colRemark��  commonEmployeeRemark#( �  5�   =   $) LeaveRemark��6y   * 6�   �� *LeaveRemark++ 5�      �� 5�      .R�5�      �� $��3q�6E   $��Center=�6P   $, 3,0,0,0q�6k   ��6(   �� *LeaveRemark+6k   5�      5�        5�      -   5        colDateDisplay��  commonEmployeeDate#( �  5�   B   $) FromToDisplay��6|   * 6�   �� *FromToDisplay++ 5�      �� 5�      .R�5�      �� $��3q�6G   $��Center=�6R   $, 3,0,0,0q�6m   ��6(   �� *FromToDisplay+6m   5�      5�      5�      � 5�   
   $��4��6   $��4��6   $��0,5,0,0q�6,    5�      �� 5�      $��2* �6#   �� 5�      �� 5�      $��10 �6#   �� 5�      .+�5�      �� -   5        - ��Name$- txtTotal��5�      $	��Top=�6*   
����  �$��Italic$�6T   �� 5�      -   5        $ 	btnDelete��5�      $��8��6(   $��1��65   #���  6E   ��5�      � 5�       5�      �� 5�      �� 5�      .+�5�      �� $��16��6    $��16��6+   $��/Images/edit_remove.png��67   �� 5�      $��2,0,0,0q�6$   $��1��65   $��Center=�6E     commonButtonDelete#���  6`   5�      5�      �� 5�      -   5        $ btnSave��5�      $��8��6&   $��3��63   #���  6C   ��5�      � 5�       5�      �� 5�      �� 5�      .+�5�      �� $��16��6    $��16��6+   $��/Images/filesave.png��67   �� 5�      $��2,0,0,0q�6$   $��1��65   $��Center=�6E     commonButtonSave#���  6`   5�      5�      5�      5�      5�      