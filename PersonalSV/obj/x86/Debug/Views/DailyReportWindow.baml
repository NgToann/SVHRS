   M S B A M L   `   `   `  ����  
PersonalSV(    "PersonalSV.Views.DailyReportWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5        $��13(�5   K     � WindowStartupLocation$  CenterScreen=�5   W    !  titleWorkingDailyReportWindow � Title# �   5   	   $	��450��6M   $
��1000��6]    � WindowState$ 	Maximized=�6m   .��5      � $��2q�6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      �� 5	      $
��auto �6    � ColumnDefinitions 5   
   �� 5      $��7* �6   �� 5      $��3* �6   .+�5   
   ��   GroupBoxTemplate#���  6   ��5      �� 5        Background1#���  6     BorderStyle#���  6P   ._�5      ��   commonGroupBoxFilter#���  6    5      .��5      �  5      �� 5      $
��auto �6$   �� 5      $
��auto �6$   �� 5      $
��auto �6$   �� 5      $
��auto �6$   �� 5      $
��auto �6$   �� 5      $
��auto �6$    5      �� 5      $��2* �6'   �� 5       $��* �6'   �� 5!      $
��Auto �6'   �� 5"      $
��Auto �6'   .+�5$      � $��2��6    5%      �� 5&      �� 5'      �� 5(      $
��auto �6+   .+�5*      	� -   5         	�Name$ radAttendance��5*   "     commonRadioButtonAttendance#���  69     RadioBlueStyle#���  6}    	� 	GroupName$ Filter��6�   $��Center=�6�   6�   	� 5+      -   5        $ 	radAbsent��5+   C   $��1��6"   $��0,5,0,5q�62     commonRadioButtonAbsent#���  6V   #���  6�   $ Filter��6�   $��Center=�6�   6�   	� 5,      -   5        $ radAll��5,   2   $��2��6"     commonRadioAll#���  6B   #���  6y   $ Filter��6�   $��Center=�6�    d� 	IsChecked$
 TrueY�6�   6�   5-      � 5/      $��1��6   $��2��6$    50      �� 51      �� 52      $��5 �6+   �� 53      .+�55      �� -   5         ��Name$ 
cboSection��55      	 �� DisplayMemberPath$	 DepartmentName��63   $��Center=�6�   �� 56      -   5        $ cboDepartment��56      $��2��66   $	 DepartmentFullName��6F   $��Center=�6�   57      � 5:      $��3��6    5;      �� 5<      $
��auto �6+   �� 5=      .+�5?      �� -   5        
 ��Name$
 tblEmployee��5?        	 commonEmployee#��� 	 65   $��Center=�6i   �� 5@      -   5         ��Name$ txtEmployeeSearch��5@      $��1��69   $��5,0,0,0q�6I   
���   �$��1,1,1,1q�6n   $��Center=�6�   $��2,0,0,0q�6�   $
��Bold"�6�   6  5A      � 5C      $��3��6   $��1��6$   $��2��64   $��5,0,0,0q�6H    5D      �� 5E      �� 5F      $
��Auto �6+   �� 5G      .+�5J      �� -	   5        $ txtTimeInFrom��5J   ]   
���   � �� 	MaxLength$ 4��6�   $��Center=�6�   ��6   ��  �� ElementName$ dpFilterDate�� �� Path$ ActualHeight�6�   �� 5K       
 commonDatePickerTimeIn#��� 
 6`   $��5,0,5,0q�6�   $��1��6�   $��Center=�6�   $��Center=�6�   ��6    �� $ tblTitleTimeOut��$ ActualWidth�6�   �� 5L      -
   5        $ txtTimeInTo��5L   .   $��2��6   
���   �$ 4��6W   $��Center=�6e   5M      � 5O      $��4��6   $��1��6$   $��2��64   $��5,5,0,0q�6H    5P      �� 5Q      �� 5R      $
��Auto �6+   �� 5S      .+�5V      �� -   5        $ txtTimeOutFrom��5V      
���   �$ 4��6J   $��Center=�6X   �� 5W      -   5        $
 tblTitleTimeOut��5W       $��58��69     commonDatePickerTimeOut#���  6G   $��5,0,5,0q�6�   $��1��6�   $��Center=�6�   $��Center=�6�   �� 5Y      -   5        $ txtTimeOutTo��5Y   .   $��2��6   
���   �$ 4��6X   $��Center=�6f   5Z      �� 5\      $��4��6    �� Orientation$ 
Horizontal=�6*   .+�5]      ��   commonDatePickerFrom#���  6    $��Bottom=�6�   ��6Z   �� $ tblEmployee��$ ActualWidth�6�   (  "System.Windows.Controls.DatePicker  5^      -   5          Name$ dpFilterDate��5^   !   $��4��67   $��5,5,0,0q�6D   $��Center=�6U   �� 5_        commonDatePickerTo#���  6    $��Bottom=�6X   $��5,0,5,0q�6s     5`      -   5        $ dpFilterDateTo��5`   !   $��4��69   $��0,5,0,0q�6F   $��Center=�6W   �� 5a      -   5         ��Name$ 	chkSunday��5a      $��10,0,0,0q�62     commonCheckboxSunday#���  6D   $��Bottom=�6�   $
 TrueY�6�   6�   5b      �� 5d      -   5         ��Name$ 
btnPreview��5d      $��5,0,0,0q�6-     ButtonTemplate#���  6>   $��3��6v   $��5��6�   ��5e      � 5f       5g      �� 5h   "   $
��auto �60   �� 5i   "   $
��auto �60   .+�5k      �� $��16��6$   $��16��6/   $��/Images/update.png��6;   �� 5l      $��2,0,0,0q�6(   $��1��69   $��Center=�6F     commonButtonPreview#���  6a   5m      5o      5p      5q      �� 5r   
   $��1��6   $��5,0,0,0q�6#   #���  64   ��5s      �� 5t      #���  6   #���  6P   ._�5u      �� -   5        $
 txtGroupSummaryHeader��5u         dailyAttendanceSummary#���  6?   5v      .��5x      �  5y      �� 5z      �� 5{      �� 5|      $
��auto �6$    5~      �� 5      �� 5�      $��5 �6'   �� 5�      �� 5�      $��5 �6'   �� 5�      �� 5�      $��5 �6'   .+�5�      ��   dailyAttendanceQuantity#���  6   $��Center=�6Y   $��18(�6t   $��Center=�6�   �� 5�      -   5        $
 txtQuantity��5�      $��1��61   $��Center=�6>   $��Center=�6Y   $��16(�6v   �� 5�      $��2��6     dailyAttendanceAttendance#���  6,   $��Center=�6k   $��18(�6�   
����  �$��Center=�6�   �� 5�      -   5        $
 txtAttendance��5�      $��2��63   $��1��6C   $��Center=�6P   $��Center=�6k   $��16(�6�   
����  �6�   �� 5�      $��4��6     dailyAttendanceAbsent#���  6,   $��Center=�6g   $��16(�6�   
���  ��$��Center=�6�   �� 5�      -   5        $
 	txtAbsent��5�      $��4��6/   $��1��6?   $��Center=�6L   $��Center=�6g   $��16(�6�   
���  ��6�   �� 5�      -   5        $��2��5�      $��6��6(    $  dailyAttendanceCheckDisplayChart#��[ 6<   $��Center=�6�    � Cursor$
 Hand��6�   $
 TrueY�6�   
����  �$��SemiBold"�6  5�      5�      � 5�   
   $��1��6   $��0,5,0,0q�6   $��2��6-    5�      �� 5�      $��4* �6#   �� 5�      $��0 �6#   �� 5�      $
��auto �6#   .+�5�      &   System.Windows.Controls.DataGrid  -   5          Name$ dgResult��5�         AutoGenerateColumns .   �� AlternationCount$ 2��6E      ClipboardCopyMode$ IncludeHeader=�6Z    $� VirtualizationMode$ Standard=�6|    $� IsVirtualizing .    SelectionUnit$ FullRow=�5�   D      CanUserAddRows .     HorizontalGridLinesBrush
 �����   VerticalGridLinesBrush
 �����   RowHeaderWidth$	 NaNQ�5�         
IsReadOnly .  $��Times New Roman)�5�   *   $��14(�6G       ColumnHeaderStyle  5�      �� 5�      ! �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"!  6   .�5�      �� " �� Property" � ��# �� Value$# Center=�6G   �� 5�      " � ��$# 15(�65   �� 5�      " � ��  DataGridRowHeaderBG## �  67   �� 5�      " � ��
# �����68   �� 5�      " � ��$# 0.5,0.5,0.5,0q�6<   �� 5�      " � ��$# 5q�64   5�      $   Columns$ 5�      4  .System.Windows.Controls.DataGridTemplateColumn  5�        commonDateSearch,  &System.Windows.Controls.DataGridColumn%   Header#% �  6-   &   SortMemberPath$& 
DateSearch��6e   '   ClipboardContentBinding' 6�   �� *
DateSearch+(   CellTemplate( 5�      �� 5�      .R�5�   "   �� $��3q�6\   $��Center=�6g   ��6,   �� *
DateSearch+) �� StringFormat$) dd/MM��6g   5�      5�        5�      #% � 	 6-   $& EmployeeName��6c   ' 6�   �� *EmployeeName+( 5�      �� 5�      .R�5�   "   �� $��3q�6J   $��Center=�6U   ��6,   �� *EmployeeName+6U   5�      5�        5�        commonEmployeeID#% �  6-   $& 
EmployeeID��6e   ' 6�   �� *
EmployeeID+( 5�      �� 5�      .R�5�   "   �� $��3q�6H   $��Center=�6S   $��Center=�6n   ��6,   �� *
EmployeeID+6n   5�      5�        5�        commonEmployeeDepartment#% �  6-   $& DepartmentName��6m   ' 6�   �� *DepartmentName+( 5�      �� 5�      .R�5�   "   �� $��3q�6L   $��Center=�6W   $��Center=�6r   ��6,   �� *DepartmentName+6r   5�      5�        5�      #% � 
 6-   $& 
TimeInView��6k   ' 6�   �� *
TimeInView+( 5�      �� 5�      .R�5�   "   �� $��3q�6H   $��Center=�6S   $��Center=�6n   ��6,   �� *
TimeInView+6n   5�      5�        5�      #% �  6-   $& TimeOutView��6l   ' 6�   �� *TimeOutView+( 5�      �� 5�      .R�5�   "   �� $��3q�6I   $��Center=�6T   $��Center=�6o   ��6,   �� *TimeOutView+6o   5�      5�        5�        commonDatePickerRemarks#% �  6-   $& Remarks��6l   ' 6�   �� *	Remarks+( 5�      �� 5�      .R�5�   "   �� $��3q�6E   $��Center=�6P   $��Center=�6k   ��6,   �� *	Remarks+6k   5�      5�        5�      -   5        	colReason��*   
Visibility$* 	Collapsed=�5�   @     commonReason#% �  6W   $& Reason��6�   ' 6�   �� *Reason+( 5�      �� 5�      .R�5�   "   �� $��3q�6i   $��Center=�6t   $��Center=�6�   ��6,   �� *Reason++ �� UpdateSourceTrigger$+ PropertyChanged=�6�   5�      5�        5�      -   5        colConfirmAbsent��  commonChbConfirmAbsent#% �  5�   G   $* 	Collapsed=�6�   ( 5�      �� 5�      .R�5�   "   �� $ chkConfirmAbsent��6+   -   5        $��Center=�5�   �   $��Center=�6�   $��Center=�6�   $
 Hand��6�   5�      5�      5�      �� 5�      -   5        , ��Name$, 
groupChart��5�      $��2,0,0,0q�6+   $��2��6<   #���  6L   $y�	Collapsed=�6�   $	��450��6�   ��5�      �� 5�      #���  6   #���  6T   ._�5�      �� -   5        $
 
chartTitle��5�   $     dailyAttendanceChart#���  68   5�      .��5�      �� $
��Auto=�6   $
��Auto=�6D   .��5�      �� -   5        - ��Name$- stkChart��5�   !   $ Vertical=�63   5�      5�      5�      5�      �� 5�   
   -   5        $
 	tblStatus��5�      $��2��6'   $��Bottom=�64   
����  �$��Italic$�6a   $��12(�6t   � 5�   
   $��2��6   $��1��6   $��0,5,0,0q�6,    5�      �� 5�      �� 5�      $
��auto �6#   .+�5�      �� -   5        $ 	btnReport��5�      $��1��6(   $��98��68   #���  6F   ��5�      � 5�       5      �� 5     �� 5     .+�5     �� $��16��6    $��16��6+   $��/Images/large_chart.png��67   �� 5     $��2,0,0,0q�6$   $��1��65   $��Center=�6E     commonButtonReport#���  6`   5     5     5	     5
     5     