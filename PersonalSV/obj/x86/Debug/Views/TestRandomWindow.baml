   M S B A M L   `   `   `  ����F  BPersonalSV, Version=1.0.1.18, Culture=neutral, PublicKeyToken=null3clr-namespace:PersonalSV.ViewsPersonalSV.Views  5   	   '    !PersonalSV.Views.TestRandomWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:PersonalSV.Views     5   	   -   5        $��15(�5   6     � WindowState$  	Maximized=�6D    � WindowStartupLocation$ CenterScreen=�5      
�������   testRandomWindowTitle � Title# �   5   	   $	��600��6E   $
��1200��6R   .��5	      � $��2q�6    � ColumnDefinitions 5
   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      �� 5      $
��auto �6   .+�5   
   �� $��0,0,0,10q�6   $��2��6#    �� CornerRadius$ 5��67   $��1,1,1,1q�6H   
�������
����·�._�5      �� -   5         ��Name$ 	lblHeader��5      
���  ��  testRandomHeader#���  5      $��SemiBold"�5      $��35(�6*   $��Center=�68    �� TextAlignment$ Center=�5      5      �� 5   
   $��1��6   $��1��6   $��0,0,2,0q�6.    �� Padding$ 	10,4,10,4q�6?     BorderStyle#���  6S   
�������$ 5��6�   $��1,1,1,1q�6�   ._�5      �  5      �� 5      $
��auto �6$   �� 5      .+�5!      �� 
�������._�5"      �  5#      �� 5$      �� 5%      .+�5'      ��   testRandomGroupTestInfo#���  6$   
����  �$��SemiBold"�6s   $��18(�6�   �� 5(      -   5        $ lblClock��5(   P   $��1��6$   $��Right=�64   $��CLOCK��6b   $��18(�6o   
����  �$��SemiBold"�6�   5)      5*      � 5+      -   5        	 �Name$	 
grTestInfo��5+      $��1��6+   $��0,5,0,0q�68    5,      �� 5-      $
��auto �6(   �� 5.      $
��auto �6(    50      �� 51      �� 52      �� 53      �� 54      .+�56      �� $��Center=�6:   ��6    �� *
TestDate+6:   �� 57      $��1��6    $��Center=�6F   ��60   �� *Term+6F   �� 58      $��2��6    $��Center=�6G   ��60   �� *Round+6G   �� 59      $��3��6    $��Center=�6M   ��60   �� *RandomRatio+6M   �� 5:      $��1��6    $ Center=�6Q   ��6-   �� *TotalRequestWorker+6Q   �� 5;      $��1��6    $��1��6-   $ Center=�6Z   ��6=   �� *CurrentScan+6Z   �� 5=      $��1��6    $��3��6-   $��Center=�6=   �� 5>      -   5        
 ��Name$
 hlViewWorkerList��5>   $   .�6]   .�5?      ��  � Cursor$
 Hand��6(      testRandomLinkButtonViewData#���  66   5@      5A      5B      5C      5D      � 5F   
   $��1��6   $	��400��6   $
��Left=�6(   $��Bottom=�6C   $��2,0,0,0q�6^    5G      �� 5H      �� 5I      .+�5K      ��   workerCheckInScanCardId#���  6   $��20(�6U   $��Center=�6c   �� 5L      -   5         ��Name$ 	txtCardId��5L   /   $��1��6   $��3q�6#   {�.  
���   �$��25(�5M   *   
����  �$��SemiBold"�6J   $��Center=�5N       �� TextAlignment$ Center=�5O      6-   5P      �� 5R   
   $��1��6    �� Orientation$ 
Horizontal=�6"   $��0,0,0,5q�6;   $y�	Collapsed=�6L   .+�5S      �� $��Requested List��6   $��Bottom=�6.   �� 5T      -   5         ��Name$ 
btnRefresh��5T      {�.  $��Refresh��6;   $��4q�6M   $��5,0,0,0q�6r   5U      �� 5V   
   -   5         ��Name$ 	brDisplay��5V      $��2��6$   $��2��61   $��2q�6E   
�������$��1,1,1,1q�6c   $ 5��6}   $ 4q�6�   ._�5W      �  5X      �� 5Y      �� 5Z      $
��auto �6$   .+�5\      (�  (� Stretch$ Uniform=�6   $��Center=�6,   $��Center=�6I   .��5]      � -	   5        $	 	grDisplay��5]       5^      �� 5_      $
��auto �6,   �� 5`      $
��auto �6,   �� 5a      $
��auto �6,   �� 5b      $
��auto �6,   �� 5c      $
��auto �6,   .+�5e      �� $��Center=�6B   ��6$   �� *EmployeeName+6B   �� 5f      $��1��6$   $��Center=�6Q   ��61   �� *DepartmentName+6Q   �� 5h      $��3��6$   $��Center=�6N   ��61   �� *RequireTest+6N   �� 5i      $��4��6$   $��Center=�6N   ��61   �� *TimeDisplay+6N   5j      5k      �� 5l      $��Bottom=�67   $��12(�6R   ��6   �� *	IdDisplay+6R   5m      5n      &   System.Windows.Controls.DataGrid  5o   
   -
   5          Name$ dgWorkerNeedToTestList��5o       $��2��6      AutoGenerateColumns .   �� AlternationCount$ 2��6\      AlternatingRowBackground
 �����$y�	Collapsed=�6�      CanUserAddRows .     SelectionUnit$ FullRow=�5p   .      HorizontalGridLinesBrush
 �����   VerticalGridLinesBrush
 �����   
IsReadOnly . $��Arial)�5q   )   $��16(�6<      FrozenColumnCount$ 3��6J      RowHeaderWidth$	 NaNQ�6`    � 	Resources 5r      *  $System.Windows.Controls.DataGridCell �� 
TargetType �� Triggers  P� Property! P� Value" �� Property# �� Value��%�   '        �� 5s      "  6    5t      P� 5u        �@ 
IsSelected! . . �5v      �� " � ��
# ����6;   �� 5w      " � ��
# �����6;   5x      5z      5{      $   ColumnHeaderStyle$ 5}      �� 5~      =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5      �� " � ��$# Center=�6C   �� 5�      " � ��$# 16(�61   �� 5�      " � ��  DataGridRowHeaderBG## �  63   �� 5�      " � ��
# �����64   �� 5�      " � ��$# 0.5,0.5,0.5,0q�68   �� 5�      " � ��$# 5q�60   5�      %   Columns% 5�      4  .System.Windows.Controls.DataGridTemplateColumn  5�        commonEmployeeCode,  &System.Windows.Controls.DataGridColumn&   Header#& �  6)   '   SortMemberPath$' EmployeeCode��6c   (   CellTemplate( 5�      �� 5�      .R�5�      �� $��3q�6F   $��Center=�6Q   $��Center=�6l   ��6(   �� *EmployeeCode+6l   5�      5�        5�        commonEmployeeID#& �  6)   $' 
EmployeeID��6a   ( 5�      �� 5�      .R�5�      �� $��3q�6D   $��Center=�6O   $��Center=�6j   ��6(   �� *
EmployeeID+6j   5�      5�        5�       	 commonEmployeeName#& � 	 6)   $' EmployeeName��6c   ( 5�      �� 5�      .R�5�      �� $��3q�6F   $��Center=�6Q   ��6(   �� *EmployeeName+6Q   5�      5�        5�       
 commonEmployeeDepartment#& � 
 6)   $' DepartmentName��6i   ( 5�      �� 5�      .R�5�      �� $��3q�6H   $��Center=�6S   ��6(   �� *DepartmentName+6S   5�      5�        5�      $& Vaccine 1st Type��6)   $' VaccineFirstType��6C   ( 5�      �� 5�      .R�5�      �� $��3q�6J   $��Center=�6U   ��6(   �� *VaccineFirstType+6U   5�      5�        5�      $& Vaccine 2nd Type��6)   $' VaccinceSecondType��6C   ( 5�      �� 5�      .R�5�      �� $��3q�6K   $��Center=�6V   ��6(   �� *VaccineSecondType+6V   5�      5�      5�      5�      5�      