   M S B A M L   `   `   `  ����  
PersonalSV,    &PersonalSV.Views.AttendanceDailyWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5        $��14(�5   K     � WindowStartupLocation$  CenterScreen=�5   @    � Title$ AttendanceDailyWindow��5   	   $	��300��6'   $	��500��67   .��5      � $��2q�6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      .+�5
   
   �  � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $
��Auto �6#   .+�5      (  "System.Windows.Controls.DatePicker  -   5          Name$ dpDateSearch��5   )   $��1��6   6?   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgAttendanceDaily��5   1   $��1��6   $��0,5,0,0q�6       AutoGenerateColumns .   �� AlternationCount$ 2��6h      AlternatingRowBackground
 �����	   CanUserAddRows	 .  
   SelectionUnit$
 FullRow=�5   .      HorizontalGridLinesBrush
 �����   VerticalGridLinesBrush
 �����   RowHeaderWidth$ 1Q�6�      
IsReadOnly . $��Times New Roman)�5   )   $��14(�6F    �� 
GroupStyle 5      (  "System.Windows.Controls.GroupStyle  5         ContainerStyle 5      �� 5       �� 
TargetType" ��6    .�5      ��  �� Property � �� �� Value 5   "   �� 5   &    �� 
TargetType" ��66   .R�5   *   9�  9� 
IsExpanded . ��5   .   �� 5   2   ��6<   �� *SectionName+.��5   .   �� 5    +   5!   '   5#      5$         Panel 5&      �� 5'      .R�5(      >  8System.Windows.Controls.Primitives.DataGridRowsPresenter  5)      5+         Columns 5-      0  *System.Windows.Controls.DataGridTextColumn  5.      -   5        
colSection��,  &System.Windows.Controls.DataGridColumn   
Visibility$ 	Collapsed=�5.   Y   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *SectionName+6r     5/         Header$ 
Department��6%      MinWidth$	 120Q�69    6H   �� *DepartmentName+6m     50      $ Total��6%   $	 100Q�64    6C   �� *Total+6_     51      $ 
Attendance��6%   $	 100Q�69    6H   �� *
Attendance+6i     52      $ Absent��6%   $	 100Q�65    6D   �� *Absent+6a   54      55      56      