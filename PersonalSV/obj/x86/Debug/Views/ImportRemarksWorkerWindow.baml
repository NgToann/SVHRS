   M S B A M L   `   `   `  ����F  BPersonalSV, Version=1.0.1.18, Culture=neutral, PublicKeyToken=null3clr-namespace:PersonalSV.ViewsPersonalSV.Views  5   	   0    *PersonalSV.Views.ImportRemarksWorkerWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:PersonalSV.Views     5   	     � WindowStartupLocation$  CenterScreen=�5         titleImportRemarksWorker � Title# �   5   	   $	��450��6H   $	��800��6U   .��5	      � $��2q�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $��* �6   .+�5   
   � $��0,0,0,5q�6   .+�5      �� -   5         ��Name$ btnOpenExcelFile��5   c   $	��150��6   $��30��6!   $
��Left=�6-   $��Bottom=�6H   $��Open Excel File��6}     ButtonTemplate#���  6�   6�   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgWorkerRemarks��5       $��1��6      AutoGenerateColumns .     
IsReadOnly .    SelectionUnit$ FullRow=�6g   	   AlternatingRowBackground
	 �����
 �� AlternationCount$
 2��5   6   $��14(�6K      RowHeaderWidth$	 NaNQ�6Y      HorizontalGridLinesBrush
 �����   VerticalGridLinesBrush
 ����� � 	Resources 5      *  $System.Windows.Controls.DataGridCell �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value��%�   '        �� 5      "  6    5      P� 5       �@ 
IsSelected . . �5      ��  � ��
 ��iA�6;   �� 5       � ��
 �����6;   5      5!      5"         Columns 5#      0  *System.Windows.Controls.DataGridTextColumn  5$      ,  &System.Windows.Controls.DataGridColumn   Header$
 Date��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 64   �� *Date+ �� StringFormat$ 
dd/MM/yyyy��  5%      $ WorkerId��6%    68   �� *
EmployeeID+  5&      $ Remarks��6%    67   �� *	Remarks+5(      � 5*   
   $��2��6   $��0,2,0,0q�6   $��3��6-    5+      �� 5,      $��* �6#   �� 5-      $
��auto �6#   .+�5/      ��  �� Orientation$ 
Horizontal=�6   $��Bottom=�62   .+�50      � -   5         �Name$ 	prgStatus��50      $	��120��61   $��18��6=   �� 51      -   5         ��Name$ 	txtStatus��51      $��10,0,0,0q�6/   $��Center=�6A   
����  �$��Italic$�6n   52      �� 54      -   5        $ 	btnImport��54   %   $��1��6   $��
  Import  ��68   #���  6M   {�.  6�   55      56      57      