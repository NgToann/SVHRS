   M S B A M L   `   `   `  ����F  BPersonalSV, Version=1.0.1.18, Culture=neutral, PublicKeyToken=null3clr-namespace:PersonalSV.ViewsPersonalSV.Views  5   	   7    1PersonalSV.Views.TestRandomViewEmployeeListWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:PersonalSV.Views     5   	   -   5        $��15(�5   6   
�������  � WindowStartupLocation$  CenterScreen=�5   I      testRequestListWindowTitle � Title# �   5   	   $	��600��6J   $	��900��6W   .��5	      � $��2q�6    � RowDefinitions 5
   
   �� 5      $
��auto �6   �� 5      .+�5   
   �� $��0,0,0,10q�6   $��2��6#    �� CornerRadius$ 5��67   $��1,1,1,1q�6H   
�������._�5      �� -   5         ��Name$ tblTitle��5      
���   �  createTestViewWorkerList#���  5      $��SemiBold"�5      $��35(�6*   $��Center=�68    �� TextAlignment$ Center=�5      5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgEmployeeList��5   E   $��1��6   $��2��6    $��0,2,0,0q�64      AutoGenerateColumns .   �� AlternationCount$ 2��6y   	   AlternatingRowBackground
	 �����
   CanUserAddRows
 .     SelectionUnit$ FullRow=�5   .      HorizontalGridLinesBrush
 �����   VerticalGridLinesBrush
 �����   
IsReadOnly . $��Arial)�5   )   $��15(�6<      FrozenColumnCount$ 3��6J      RowHeaderWidth$	 NaNQ�6`    � 	Resources 5      *  $System.Windows.Controls.DataGridCell �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value��%�   '        �� 5      "  6    5      P� 5       �@ 
IsSelected . . �5      ��  � ��
 ����6;   �� 5       � ��
 �����6;   5      5      5          ColumnHeaderStyle 5"      �� 5#      =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5$      ��  � ��$ Center=�6C   �� 5%       � ��$ 16(�61   �� 5&       � ��  DataGridRowHeaderBG# �  63   �� 5'       � ��
 �����64   �� 5(       � ��$ 0.5,0.5,0.5,0q�68   �� 5)       � ��$ 5q�60   5*         Columns 5,      4  .System.Windows.Controls.DataGridTemplateColumn  5-        commonEmployeeCode,  &System.Windows.Controls.DataGridColumn   Header# �  6)      SortMemberPath$ EmployeeCode��6c      ClipboardContentBinding 6�   �� *EmployeeCode+   CellTemplate 5.      �� 5/      .R�50      �� $��3q�6F   $��Center=�6Q   $��Center=�6l   ��6(   �� *EmployeeCode+6l   51      53        54        commonEmployeeID# �  6)   $ 
EmployeeID��6a    6}   �� *
EmployeeID+ 55      �� 56      .R�57      �� $��3q�6D   $��Center=�6O   $��Center=�6j   ��6(   �� *
EmployeeID+6j   58      5:        5;        commonEmployeeName# �  6)   $ EmployeeName��6c    5<      �� 5=      .R�5>      �� $��3q�6F   $��Center=�6Q   ��6(   �� *EmployeeName+6Q   5?      5A        5B        commonEmployeeDepartment# �  6)   $ DepartmentName��6i    6�   �� *DepartmentName+ 5C      �� 5D      .R�5E      �� $��3q�6H   $��Center=�6S   ��6(   �� *DepartmentName+6S   5F      5H      5J      5K      5L      