   M S B A M L   `   `   `  ����F  BPersonalSV, Version=1.0.1.18, Culture=neutral, PublicKeyToken=null3clr-namespace:PersonalSV.ViewsPersonalSV.Views  5   	   0    *PersonalSV.Views.WorkerCheckInReportWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:PersonalSV.Views     5   	   -   5        $��14(�5        � WindowStartupLocation$  CenterScreen=�6(    � WindowState$ 	Maximized=�6M      reportCheckInOutWindowTitle � Title# �   5   	   $	��450��6K   $	��800��6X   .��5	      � $��2q�6    � RowDefinitions 5
   
   �� 5      $
��auto �6   �� 5      �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      .+�5   
   ��   GroupBoxTemplate#���  6   ��5      �� 5        Background1#���  6     BorderStyle#���  6P   ._�5      �� -   5         ��Name$ txtGroupSummaryHeader��5         reportCheckInOutOption#���  6?   5      .��5      �  5      �� 5      �� 5      �� 5      �� 5       5       �� 5!      �� 5"      .+�5$      �� -   5         ��Name$ txtFindWhat��5$      $��20(�6/   $��3q�6=   $��Center=�6I   $	��240��6�   �� 5%      $��1��6    �� Orientation$ 
Horizontal=�6*   .+�5&      ��   commonDatePickerDate#���  6    $��Bottom=�6Z   (  "System.Windows.Controls.DatePicker  5'      -   5          Name$ dpFilterDate��5'   !   $��5,5,0,0q�67   $��Center=�6H   $	��150��6j   5(      �� 5*      -   5        	 ��Name$	 stkRadio��5*      $ 
Horizontal=�6/   $��2��6H   $��0,5,0,0q�6U   $y�	Collapsed=�6f   .+�5+      	� $��1��6"   $��Center=�6.   	� 5,      $��1��6"   $��Center=�6.   $��5,0,0,0q�6P   5-      �� 5.      $ 
Horizontal=�6   $��3��66   $��0,5,0,0q�6C   $y�	Collapsed=�6T   .+�5/      �� $��TimeIn >��6    $��Center=�60   
���  ��6K   �� 50      -   5        $ 	txtTimeIn��50      $��60��61   $��18(�6<   $��4,0,0,0q�6J   $��2q�6[   
����  �6�   �� 51      $��	TimeOut >��6    $��Center=�61   $��10,0,0,0q�6L   
���  ��6^   �� 52      -   5        $ 
txtTimeOut��52      $��60��62   $��18(�6=   $��4,0,0,0q�6K   $��2q�6\   
����  �6�   53      �� 54      -   5        
 ��Name$
 
btnPreview��54      $��5,0,0,0q�6-     ButtonTemplate#���  6>   $��3��6v   $��5��6�   {�.  ��55      � 56       57      �� 58   "   $
��auto �60   �� 59   "   $
��auto �60   .+�5;      �� $��16��6$   $��16��6/   $��/Images/update.png��6;   �� 5<      $��2,0,0,0q�6(   $��1��69   $��Center=�6F     commonButtonPreview#���  6a   5=      5?      5@      5A      �� 5B   
   $��1��6   $��2��6   $��0,5,0,0q�62   ._�5C      &   System.Windows.Controls.DataGrid  -	   5          Name$ dgReport��5C         AutoGenerateColumns .   �� AlternationCount$ 2��6E      AlternatingRowBackground
 �����   ClipboardCopyMode$ IncludeHeader=�6      CanUserAddRows .     SelectionUnit$ FullRow=�5D   .      HorizontalGridLinesBrush
 �����   VerticalGridLinesBrush
 �����$��15(�6�      
IsReadOnly .    FrozenColumnCount$ 3��5E   )   $��Cabri)�6?      RowHeaderWidth$	 NaNQ�6R    � 	Resources 5F      *  $System.Windows.Controls.DataGridCell �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value��%�   '        �� 5G      "  6    5H      P� 5I       �@ 
IsSelected . . �5J   "   ��  � ��
 ����6?   �� 5K   "    � ��
 �����6?   5L      5N      5O         ColumnHeaderStyle 5P      �� 5Q      =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5R      ��  � ��$ Center=�6G   �� 5S       � ��$ 15(�65   �� 5T       � ��  DataGridRowHeaderBG# �  67   �� 5U       � ��
 �����68   �� 5V       � ��$ 0.5,0.5,0.5,0q�6<   �� 5W       � ��$ 5q�64   5X         Columns 5Z      4  .System.Windows.Controls.DataGridTemplateColumn  5[       	 commonEmployeeCode,  &System.Windows.Controls.DataGridColumn    Header#  � 	 6-   !   SortMemberPath$! EmployeeCode��6g   "   ClipboardContentBinding" 6�   �� *EmployeeCode+#   CellTemplate# 5\      �� 5]      .R�5^   "   �� $��3q�6J   $��Center=�6U   $��Center=�6p   ��6,   �� *EmployeeCode+6p   5_      5a        5b       
 commonEmployeeID#  � 
 6-   $! 
EmployeeID��6e   " 6�   �� *
EmployeeID+# 5c      �� 5d      .R�5e   "   �� $��3q�6H   $��Center=�6S   $��Center=�6n   ��6,   �� *
EmployeeID+6n   5f      5h        5i        commonEmployeeName#  �  6-   $! EmployeeName��6g   " 6�   �� *EmployeeName+# 5j      �� 5k      .R�5l   "   �� $��3q�6J   $��Center=�6U   ��6,   �� *EmployeeName+6U   5m      5o        5p        commonEmployeeDepartment#  �  6-   $! DepartmentName��6m   " 6�   �� *DepartmentName+# 5q      �� 5r      .R�5s   "   �� $��3q�6L   $��Center=�6W   ��6,   �� *DepartmentName+6W   5t      5v        5w        commonEmployeeDate#  �  6-   $! TestDate��6g   " 6�   �� *
TestDate+# 5x      �� 5y      .R�5z   "   �� $��3q�6_   $��Center=�6j   ��6,   �� *
TestDate+$ �� StringFormat$$ 
dd/MM/yyyy��6j   5{      5}        5~        reportGridTimeIn#  �  6-   $! TimeIn��6e   " 6}   �� *TimeIn+# 5      �� 5�      .R�5�   "   �� $��3q�6D   $��Center=�6O   $��Center=�6l   ��6,   �� *TimeIn+6l   5�      5�        5�        reportGridTimeOut#  �  6-   $! TimeOut��6f   " 6   �� *	TimeOut+# 5�      �� 5�      .R�5�   "   �� $��3q�6E   $��Center=�6P   $��Center=�6m   ��6,   �� *	TimeOut+6m   5�      5�        5�        reportGridStatus#  �  6-   $! 
TestStatus��6e   " 6�   �� *
TestStatus+# 5�      �� 5�      .R�5�   "   �� $��3q�6H   $��Center=�6S   $��Center=�6p   ��6,   �� *
TestStatus+6p   5�      5�        5�      $  Remarks��6-   $! Remarks��6>   " 6W   �� *	Remarks+# 5�      �� 5�      .R�5�   "   �� $��3q�6E   $��Center=�6P   $��Center=�6m   ��6,   �� *	Remarks+6m   5�      5�      5�      5�      �� 5�   
   -
   5        $ lblTotalWorker��5�   !   $��2��6   
����  �$��SemiBold"�6K   $y�	Collapsed=�6a   �� 5�   
   -   5        $
 btnExportExcel��5�      $	��150��6)   $��0,2,0,0q�65   $��Right=�6F   $��2��6b   $��2��6o   #���  6   % � Cursor$
% Hand��6�   ��5�      � 5�       5�      �� 5�      $
��auto �6(   �� 5�      $
��auto �6(   .+�5�      �� $��2,0,0,0q�6    $��1��61   $��Center=�6>     reportExportExcel#���  6Y   5�      5�      5�      5�      