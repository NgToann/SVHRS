   M S B A M L   `   `   `  ����F  BPersonalSV, Version=1.0.1.18, Culture=neutral, PublicKeyToken=null3clr-namespace:PersonalSV.ViewsPersonalSV.Views  5   	   3    -PersonalSV.Views.TestCovidCovidTestPlanWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:PersonalSV.Views     5   	   -   5        $��15(�5   1     � WindowStartupLocation$  CenterScreen=�6?      CovidTestPlanWindowTitle � Title# �   5   	   $	��600��6H   $	��800��6U   .��5	      � $��2q�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      �� 5      $
��Auto �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      ��   CovidTestPlanSelectDate#���  6   $��0,0,10,0q�6U   $��Center=�6g   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ 
dpTestDate��5      $��Center=�6-   �� 5      -   5         ��Name$ 	btnFilter��5      $��Filter��6(   $��20,0,0,0q�69   $��	15,4,15,4q�6K   6_   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgRandomList��5   E   $��1��6   $��2��6    $��0,2,0,0q�64      AutoGenerateColumns .   �� AlternationCount$ 2��6w   	   AlternatingRowBackground
	 �����
   CanUserAddRows
 .     SelectionUnit$ FullRow=�5   .      HorizontalGridLinesBrush
 �����   VerticalGridLinesBrush
 �����   
IsReadOnly . $��Arial)�5   )   $��15(�6<      FrozenColumnCount$ 3��6J      RowHeaderWidth$	 NaNQ�6`    � 	Resources 5      *  $System.Windows.Controls.DataGridCell �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value��%�   '        �� 5      "  6    5      P� 5       �@ 
IsSelected . . �5      ��  � ��
 ����6;   �� 5       � ��
 �����6;   5      5      5          ColumnHeaderStyle 5"      �� 5#      =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5$      ��  � ��$ Center=�6C   �� 5%       � ��$ 16(�61   �� 5&       � ��  DataGridRowHeaderBG# �  63   �� 5'       � ��
 �����64   �� 5(       � ��$ 0.5,0.5,0.5,0q�68   �� 5)       � ��$ 5q�60   5*         Columns 5,      4  .System.Windows.Controls.DataGridTemplateColumn  5-        commonEmployeeCode,  &System.Windows.Controls.DataGridColumn   Header# �  6)      SortMemberPath$ EmployeeCode��6c      ClipboardContentBinding 6�   �� *EmployeeCode+   CellTemplate 5.      �� 5/      .R�50      �� $��3q�6F   $��Center=�6Q   $��Center=�6l   ��6(   �� *EmployeeCode+6l   51      53        54        commonEmployeeID# �  6)   $ 
EmployeeID��6a    6}   �� *
EmployeeID+ 55      �� 56      .R�57      �� $��3q�6D   $��Center=�6O   $��Center=�6j   ��6(   �� *
EmployeeID+6j   58      5:        5;        commonEmployeeName# �  6)   $ EmployeeName��6c    5<      �� 5=      .R�5>      �� $��3q�6F   $��Center=�6Q   ��6(   �� *EmployeeName+6Q   5?      5A        5B        commonEmployeeDepartment# �  6)   $ DepartmentName��6i    6�   �� *DepartmentName+ 5C      �� 5D      .R�5E      �� $��3q�6H   $��Center=�6S   ��6(   �� *DepartmentName+6S   5F      5H        5I        createTestTestDate# �  6)   $ TestDate��6c    6}   �� *
TestDate+ 5J      �� 5K      .R�5L      �� $��3q�6[   $��Center=�6f   ��6(   �� *
TestDate+ �� StringFormat$ 
dd/MM/yyyy��6f   5M      5O      5Q      �� 5R   
   -   5        $ btnExportExcel��5R      $	��150��6)   $��0,2,0,0q�65   $��Right=�6F   $��2��6b   $��2��6o     ButtonTemplate#���  6    � Cursor$
 Hand��6�   ��5S      � 5T       5U      �� 5V      $
��auto �6(   �� 5W      $
��auto �6(   .+�5Y      �� $��2,0,0,0q�6    $��1��61   $��Center=�6>    	 reportExportExcel#��� 	 6Y   5Z      5\      5]      5^      