   M S B A M L   `   `   `  ����F  BPersonalSV, Version=1.0.1.18, Culture=neutral, PublicKeyToken=null3clr-namespace:PersonalSV.ViewsPersonalSV.Views  5   	   4    .PersonalSV.Views.TestCovidCreateTestTermWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:PersonalSV.Views     5   	   -   5          � WindowStartupLocation$  CenterScreen=�5      $��15(�6?      createTestTermWindowTitle � Title# �   5   	   $	��600��6I   $
��1000��6V   .��5	      � $��2q�6    � ColumnDefinitions 5
   
   �� 5      $
��Auto �6   �� 5       � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      �� 5      $
��auto �6   .+�5   
   ��   GroupBoxTemplate#���  6   ��5      �� 5        Background1#���  6     BorderStyle#���  6P   ._�5      �� -   5         ��Name$ txtGroupSummaryHeader��5         createTestTermGroupHeader#���  6?    �� Padding$ 3q�6~   5      .��5      �  5      �� 5      $
��auto �6'   �� 5      $
��auto �6'   �� 5      $
��auto �6'   �� 5      $
��auto �6'    5       �� 5!      $
��Auto �6$   �� 5"      $
��Auto �6$   �� 5#      .+�5%      ��  �� Orientation$ Vertical=�6   .+�5&      ��   createTestLblTestRate#���  6    $��Center=�6[   �� 5'      $ 
Horizontal=�6!   .+�5(      �� -   5         ��Name$ txtRandomRate��5(   "   $��20��69   $��18(�6C   $��3q�6Q   
���  ��$��80��6n   $��SemiBold"�6y   $��Center=�6�   �� 5)      $�� %��6$   $��Center=�6.   $��SemiBold"�6I   5*      5+      �� 5,      $��1��6   $ Vertical=�6-   $��	10,0,10,0q�6D   .+�5-      ��   createTestTestTime#���  6    �� 5.      -   5        $ txtTestTime��5.      $��08:00��63   $��18(�6@   $��3q�6N   
����  �6Z   5/      �� 50      $��2��6   $ Vertical=�6-   .+�51      ��   createTestWorkTime#���  6    �� 52      -   5        $ txtWorkTime��52      $��08:00��63   $��18(�6@   $��3q�6N   
����  �6Z   53      �� 54      $��1��6   $��0,10,0,0q�6)     createTestTestDate#���  6;   (  "System.Windows.Controls.DatePicker  55      -   5          Name$ 
dpTestDate��55   *   $��2��6   $��Center=�6>   �� 57      $��2��6   $��1��6)   $��	10,0,10,0q�69   $��Center=�6L   $��Bottom=�6i   �� 58      -   5        	 ��Name$	 hlViewWorkerList��58       .�6Y   .�59      �� 
 � Cursor$

 Hand��6$    	 createTestViewWorkerList#��� 	 62   5:      5;      �� 5=      $��2��6   $��2��6)   $��	10,0,10,0q�69   $��Center=�6L   $��Bottom=�6i   �� 5>      -   5        $	 hlTestPlanlist��5>       .�6U   .�5?      �� $

 Hand��6$    
 createTestViewTestPlanList#��� 
 62   5@      5A      �� 5C      -	   5         ��Name$ 	btnCreate��5C      $��3��6,   $��2��6<   $��1��6M   $��5,0,0,0q�6Z     ButtonConner#���  6k   $

 Hand��6�   ��5D      � 5E       5F      �� 5G   "   $
��auto �60   �� 5H   "   $
��auto �60   .+�5J      �� $��2,0,0,0q�6(   $��1��69   $��Center=�6F     createTestBtnCreate#���  6a   5K      5M      5N      5O      � 5Q   
   $��1��6   $��0,0,0,6q�6    5R      �� 5S      �� 5T      $
��auto �6    �� 5U      $
��auto �6    .+�5W      �� -
   5        $ btnImportExcel��5W   J   $��1��6   $	��200��6"   $��Right=�6.     menuCreateNewImportExcel#���  6b   $��	10,4,10,4q�6�   $��0,0,0,10q�6�   $

 Hand��6�   
���  ��$��SemiBold"�6�   6�   �� 5X      $��2��6   $ 
Horizontal=�6&   $��Right=�6?   .+�5Y      ��   menuCreateNewInputWorkerId#���  6   $��Bottom=�6\   $��0,0,10,0q�6w   �� 5Z      -   5        $ txtWorkerId��5Z      $��20(�6/   $	��200��6>   $��3q�6M   
����  �$��0,0,10,0q�6k   6}   �� 5[      -   5        $ btnAddWorkerId��5[        menuCreateNewAdd#���  61   $��	10,4,10,4q�6j   $

 Hand��6~   
����  �$��SemiBold"�6�   6�   5\      5]      &   System.Windows.Controls.DataGrid  5_   
   -   5          Name$ dgRandomList��5_   E   $��1��6   $��2��6    $��0,2,0,0q�64      AutoGenerateColumns .   �� AlternationCount$ 2��6w      AlternatingRowBackground
 �����   CanUserAddRows .     SelectionUnit$ FullRow=�5`   .      HorizontalGridLinesBrush
 �����   VerticalGridLinesBrush
 �����   
IsReadOnly . $��Arial)�5a   )   $��15(�6<      FrozenColumnCount$ 3��6J      RowHeaderWidth$	 NaNQ�6`    � 	Resources 5b      *  $System.Windows.Controls.DataGridCell �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value��%�   '        �� 5c      "  6    5d      P� 5e       �@ 
IsSelected . . �5f      ��  � ��
 ����6;   �� 5g       � ��
 �����6;   5h      5j      5k       � ContextMenu 5l      �� 5m      .@�5n      m� -   5         m�Name$ miRemove��5n        commonMenuItemRemove#���  61   5o      5p          ColumnHeaderStyle  5r      �� 5s      =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5t      ��  � ��$ Center=�6C   �� 5u       � ��$ 16(�61   �� 5v       � ��  DataGridRowHeaderBG# �  63   �� 5w       � ��
 �����64   �� 5x       � ��$ 0.5,0.5,0.5,0q�68   �� 5y       � ��$ 5q�60   5z      !   Columns! 5|      4  .System.Windows.Controls.DataGridTemplateColumn  5}        commonEmployeeID,  &System.Windows.Controls.DataGridColumn"   Header#" �  6)   #   SortMemberPath$# 
EmployeeID��6a   $   ClipboardContentBinding$ 6}   �� *
EmployeeID+%   CellTemplate% 5~      �� 5      .R�5�      �� $��3q�6D   $��Center=�6O   $��Center=�6j   ��6(   �� *
EmployeeID+6j   5�      5�        5�        commonEmployeeCode#" �  6)   $# EmployeeCode��6c   $ 6�   �� *EmployeeCode+% 5�      �� 5�      .R�5�      �� $��3q�6F   $��Center=�6Q   $��Center=�6l   ��6(   �� *EmployeeCode+6l   5�      5�        5�        commonEmployeeName#" �  6)   $# EmployeeName��6c   % 5�      �� 5�      .R�5�      �� $��3q�6F   $��Center=�6Q   ��6(   �� *EmployeeName+6Q   5�      5�        5�        commonEmployeeDepartment#" �  6)   $# DepartmentName��6i   $ 6�   �� *DepartmentName+% 5�      �� 5�      .R�5�      �� $��3q�6H   $��Center=�6S   ��6(   �� *DepartmentName+6S   5�      5�        5�      #" �  6)   $# TestDate��6c   $ 6}   �� *
TestDate+% 5�      �� 5�      .R�5�      �� $��3q�6[   $��Center=�6f   $��Center=�6�   ��6(   �� *
TestDate+& �� StringFormat$& 
MM/dd/yyyy��6�   5�      5�        5�      #" �  6)   $# TestTime��6c   $ 6}   �� *
TestTime+% 5�      �� 5�      .R�5�      �� $��3q�6B   $��Center=�6M   $��Center=�6h   ��6(   �� *
TestTime+6h   5�      5�        5�      #" �  6)   $# WorkTime��6c   $ 6}   �� *
WorkTime+% 5�      �� 5�      .R�5�      �� $��3q�6B   $��Center=�6M   $��Center=�6h   ��6(   �� *
WorkTime+6h   5�      5�        5�        createTestRemark#" �  6)   $# Remark��6a   $ 6y   �� *Remark+% 5�      �� 5�      .R�5�      �� $��3q�6@   $��Center=�6K   $��Center=�6f   ��6(   �� *Remark+6f   5�      5�        5�        createTestTerm#" �  6)   $
# Term��6_   '   
Visibility$' 	Collapsed=�6�   $ 6u   �� *Term+% 5�      �� 5�      .R�5�      �� $��3q�6>   $��Center=�6I   ��6(   �� *Term+6I   5�      5�        5�        createTestRound#" �  6)   $# Round��6`   $' 	Collapsed=�6�   $ 6w   �� *Round+% 5�      �� 5�      .R�5�      �� $��3q�6?   $��Center=�6J   ��6(   �� *Round+6J   5�      5�      5�      � 5�   
   $��2��6   $��2��6   $��0,2,0,0q�60    5�      �� 5�      $��* �6#   �� 5�      $
��auto �6#   �� 5�      $
��auto �6#   .+�5�      �� -   5        $ 	btnDelete��5�      $��1��6(   $��0,0,30,0q�68     ButtonTemplate#���  6J   $

 Hand��6�   ��5�      � 5�       5�      �� 5�      $
��auto �6,   �� 5�      $
��auto �6,   .+�5�      �� $ 	25,4,25,4q�6$   $��1��68   $��Center=�6E     commonButtonDelete#���  6`   
���  ��$��SemiBold"�6�   5�      5�      �� 5�      -   5        $ btnSave��5�      $��2��6&   #���  66   $

 Hand��6�   ��5�      � 5�       5�      �� 5�      $
��auto �6,   �� 5�      $
��auto �6,   .+�5�      �� $ 	25,4,25,4q�6$   $��1��68   $��Center=�6E     commonButtonSave#���  6`   5�      5�      5�      5�      5�      