   M S B A M L   `   `   `  ����  
PersonalSV)    #PersonalSV.Views.EmployeeListWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5        $��13(�5   @     � WindowState$  	Maximized=�6N      titleChangeEmployeeList � Title# �   5   	   $	��500��6G   $	��800��6W    � WindowStartupLocation$ CenterScreen=�6}   .��5      � $��2q�6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      .+�5
   
   �  � ColumnDefinitions 5      �� 5      $��2* �6#   �� 5      $��5* �6#   �� 5      $
��auto �6#   .+�5      �� $��5q�6   
���������5      �� 5       �� Padding$ 4q�6     Background1#���  6)   
�������._�5      ��   commonGroupBoxFilter#���  6$   5      .��5      �  5      �� 5      �� 5      �� 5       5      �� 5      �� 5      �� 5      .+�5!      � $��3��6    5"      �� 5#      $��2* �6/   �� 5$      $��* �6/   .+�5&      �� -   5         ��Name$ txtEmployeeSearch��5&   "   
���   �$��15(�6   $��Center=�6�   6�   �� 5'      -   5         ��Name$ 	btnSearch��5'   T   $��5,0,0,0q�6!   $��2��62   $��3��6B     commonButtonSearch#���  6g     ButtonTemplate#���  6�   6�   5(      �� 5)      -   5         ��Name$ 
cboSection��5)   Q   $��1��6   $��2��6,   $��0,5,0,0q�6@   	 �� DisplayMemberPath$	 DepartmentName��6e   $��Center=�6�   �� 5*      -   5        $ cboDepartment��5*   Q   $��2��6   $��2��6,   $��0,5,0,0q�6@   $	 DepartmentFullName��6h   $��Center=�6�   5,      5-      �� 5/      $��4��6     commonEmployeeList#���  6,   $��30(�6d   $
��Bold"�6r   $��Center=�6�   $��Bottom=�6�   �� 50      -   5        $ 	btnAddNew��50   [   $	��100��6   $��30��6$   $��Bottom=�60   $��3��6K     commonButtonAddNew#���  6n   #���  6�   6�   51      &   System.Windows.Controls.DataGrid  52   
   -   5        
  Name$
 
dgEmployee��52   1   $��1��6   $��0,5,0,0q�6       AutoGenerateColumns .   �� AlternationCount$ 2��6a      CanUserAddRows .     SelectionUnit$ FullRow=�53   .      HorizontalGridLinesBrush
 �����   VerticalGridLinesBrush
 �����   RowHeaderWidth$ 35Q�6�      
IsReadOnly . $��Times New Roman)�54   )   $��14(�6F      FrozenColumnCount$ 4��6T      ColumnHeaderStyle 55      �� 56       �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�57      ��  �� Property � �� �� Value$ Center=�6C   �� 58       � ��$ 15(�61   �� 59       � ��
 �����63   �� 5:       � ��
 �����64   �� 5;       � ��$ 0.5,0.5,0.5,0q�68   �� 5<       � ��$ 5q�60   5=         	CellStyle 5?      �� 5@      *  $System.Windows.Controls.DataGridCell"  6    �� Triggers 5A      P� 5B       P� Property �@ 
IsSelected P� Value . . �5C      ��  � ��
 ��  �6;   �� 5D       � ��
 �����6;   �� 5E       � ��$ 0,0,0,0q�6@   5F      5H         RowStyle 5J      �� 5K      )  #System.Windows.Controls.DataGridRow"  6    5L      P� 5M       �@ 
IsSelected . . �5N      ��  � ��$
 Bold"�6;   5O      5Q         Columns 5S      4  .System.Windows.Controls.DataGridTemplateColumn  5T        commonEmployeeCode,  &System.Windows.Controls.DataGridColumn   Header# �  6)      CellTemplate 5U      �� 5V      .R�5W      �� $��3q�6F   $��Center=�6Q   $��Center=�6l   ��6(   �� *EmployeeCode+6l   5X      5Z        5[        commonEmployeeID# �  6)    5\      �� 5]      .R�5^      �� $��3q�6D   $��Center=�6O   $��Center=�6j   ��6(   �� *
EmployeeID+6j   5_      5a        5b       	 commonEmployee# � 	 6)    5c      �� 5d      .R�5e      �� $��3q�6F   $��Center=�6Q   ��6(   �� *EmployeeName+6Q   5f      5h        5i       
 commonEmployeeGender# � 
 6)    5j      �� 5k      .R�5l      �� $��3q�6@   $��Center=�6K   $��Center=�6f   ��6(   �� *Gender+6f   5m      5o        5p        commonEmployeeDepartment# �  6)    5q      �� 5r      .R�5s      �� $��3q�6H   $��Center=�6S   ��6(   �� *DepartmentName+6S   5t      5v        5w        commonEmployeePosition# �  6)    5x      �� 5y      .R�5z      �� $��3q�6F   $��Center=�6Q   ��6(   �� *PositionName+6Q   5{      5}        5~        commonEmployeeJoinDate# �  6)    5      �� 5�      .R�5�      �� $��3q�6[   $��Center=�6f   ��6(   �� *
JoinDate+  �� StringFormat$  
dd/MM/yyyy��6f   5�      5�        5�        commonEmployeeNationID# �  6)    5�      �� 5�      .R�5�      �� $��3q�6B   $��Center=�6M   ��6(   �� *
NationID+6M   5�      5�        5�        commonEmployeeAddress# �  6)    5�      �� 5�      .R�5�      �� $��3q�6A   $��Center=�6L   ��6(   �� *	Address+6L   5�      5�        5�        commonEmployeePhoneNumber# �  6)    5�      �� 5�      .R�5�      �� $��3q�6E   $��Center=�6P   ��6(   �� *PhoneNumber+6P   5�      5�        5�        commonEmployeeRemark# �  6)    5�      �� 5�      .R�5�      �� $��3q�6@   $��Center=�6K   ��6(   �� *Remark+6K   5�      5�      5�      5�      5�      