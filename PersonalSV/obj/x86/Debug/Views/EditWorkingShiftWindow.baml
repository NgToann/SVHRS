   M S B A M L   `   `   `  ����F  BPersonalSV, Version=1.0.1.18, Culture=neutral, PublicKeyToken=null3clr-namespace:PersonalSV.ViewsPersonalSV.Views  5   	   -    'PersonalSV.Views.EditWorkingShiftWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:PersonalSV.Views     5   	   -   5          � WindowStartupLocation$  CenterScreen=�5      $��13(�6?      titleWorkingShiftWindow � Title# �   5   	   $	��400��6G   $	��600��6T   .��5	      � $��2q�6    � RowDefinitions 5
   
   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   ��   GroupBoxTemplate#���  6   ��5      �� 5        Background1#���  6     BorderStyle#���  6P   ._�5      ��  �� Padding$ 	10,0,10,0q�6     # commonGroupBoxWorkingShiftInfor#���  64   5      .��5      �  5      �� 5      $
��auto �6$   �� 5      $
��auto �6$   �� 5      $
��auto �6$   �� 5      $
��auto �6$    � ColumnDefinitions 5      �� 5      �� 5      $��10 �6'   �� 5      .+�5!      ��   commonDatePickerFrom#���  6   �� 5"        commonDatePickerTo#���  6   $��2��6T   (  "System.Windows.Controls.DatePicker  5#      -   5          Name$ dpFrom��5#      $��1��6-   $��0,2,0,0q�6:   $��Center=�6K     5$      -   5        $
 dpTo��5$      $��1��6+   $��2��68   $��0,2,0,0q�6H   $��Center=�6Y   �� 5&      $��2��6     commonSelectWorkingShiftNo#���  6)   $��0,10,0,0q�6i   �� 5'      -   5         ��Name$ cboWorkingShiftNo��5'   ]   $��26��6    �� DisplayMemberPath$ WorkingShiftFullName��6'   $��3��6P   $��Center=�6x   6�   5(      5)      &   System.Windows.Controls.DataGrid  57  
   -   5          Name$ dgShiftNoTemp��57  1   $��1��6   $��0,5,0,0q�6    	   AutoGenerateColumns	 .  
 �� AlternationCount$
 2��6d      AlternatingRowBackground
 �����   CanUserAddRows .     SelectionUnit$ FullRow=�58  .      HorizontalGridLinesBrush
 �����   VerticalGridLinesBrush
 �����$��Times New Roman)�59     $��14(�64      FrozenColumnCount$ 3��6B      RowHeaderWidth$	 NaNQ�6X    � 	Resources 5:     *  $System.Windows.Controls.DataGridCell �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value��%�   '        �� 5;     "  6    5<     P� 5=      �@ 
IsSelected . . �5>     ��  � ��
 ��iA�6;   �� 5?      � ��
 �����6;   5@     5B     5C        ColumnHeaderStyle 5D     �� 5E     =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5F     ��  � ��$ Center=�6C   �� 5G      � ��$ 15(�61   �� 5H      � ��  DataGridRowHeaderBG# �  63   �� 5I      � ��
 �����64   �� 5J      � ��$ 0.5,0.5,0.5,0q�68   �� 5K      � ��$ 5q�60   5L      � ContextMenu 5N     �� 5O     .@�5P     m� -   5         m�Name$ miRemove��5P      	 commonMenuItemRemove#��� 	 6-   5Q     5R        Columns 5T     0  *System.Windows.Controls.DataGridTextColumn  5U      
 commonEmployeeCode,  &System.Windows.Controls.DataGridColumn   Header# � 
 6F      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *EmployeeCode+6�     5V       commonDatePickerDate# �  6\    .  6%   �� *	ShiftDate+  �� StringFormat$  
dd/MM/yyyy��6�     5W       commonWorkingShiftNo# �  6C    .   6%   �� *	ShiftCode+!   	CellStyle! 5X     �� 5Y     "  6    .�5Z     ��  � �� 6;   �� *ShiftBackground+�� 5[      � ��
 �   �6;   5\     5^     5`     � 5b  
   $��2��6    5c     �� 5d     �� 5e     �� 5f     �� 5g     .+�5i     �� -   5        " ��Name$" btnSave��5i  %   $��3��6     ButtonTemplate#���  66   $��0,5,0,0q�6�   {�.  ��5j     � 5k      5l     �� 5m     �� 5n     .+�5p     �� $��16��6    $��16��6+   $��/Images/filesave.png��67   �� 5q     $��2,0,0,0q�6$   $��1��65   $��Center=�6E     commonButtonSave#���  6`   5r     5t     5u     5v     5w     