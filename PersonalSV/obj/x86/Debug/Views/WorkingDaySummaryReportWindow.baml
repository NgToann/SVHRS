   M S B A M L   `   `   `  ����g  cMicrosoft.ReportViewer.WinForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3atSclr-namespace:Microsoft.Reporting.WinForms;assembly=Microsoft.Reportviewer.WinFormsMicrosoft.Reporting.WinForms  5   	    
PersonalSV4   .PersonalSV.Views.WorkingDaySummaryReportWindow   [rpvSclr-namespace:Microsoft.Reporting.WinForms;assembly=Microsoft.Reportviewer.WinForms  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5        $��13(�5   @     � WindowState$  	Maximized=�6e       titleWorkingDaySummaryWindow � Title# �   5   	   $	��400��6L   $	��700��6\    � WindowStartupLocation$ CenterScreen=�6k   .��5      � $��2q�6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5	      $��* �6    � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   ��   GroupBoxTemplate#���  6   ��5      �� 5        Background1#���  6     BorderStyle#���  6P   ._�5      ��  �� Padding$ 4,0,4,0q�6     & "commonGroupBoxSearchingInformation#���  62   5      .��5      �  5      �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$    5      �� 5      �� 5       $��5 �6'   �� 5!      �� 5"      $
��auto �6'   .+�5$      � $��4��6    5%      �� 5&      $
��auto �6+   �� 5'      .+�5)      �� $��0,0,5,0q�6      commonEmployee#���  61   $��Center=�6e   �� 5*      -   5         ��Name$ txtEmployeeSearch��5*   .   $��1��6   
���   �$��18(�6�   $��3,0,0,0q�6�   
����  �$��Center=�6�   6�   5+      � 5,      $��1��6   $��0,5,0,5q�6$   $��4��65    5-      �� 5.      �� 5/      $��5 �6+   �� 50      .+�52      �� -   5         ��Name$ 
cboSection��52       �� DisplayMemberPath$ DepartmentName��63   $��Center=�6�   6�   �� 53      -   5        $ cboDepartment��53   /   $��2��6   $ DepartmentFullName��6F   $��Center=�6m   54      �� 56      $��4��6     commonDatePickerFrom#���  6)   $��Bottom=�6c   (  "System.Windows.Controls.DatePicker  57      -   5        	  Name$	 
dpDateFrom��57   *   $��5��6   6*   �� 58      $��4��6   $��2��6)     commonDatePickerTo#���  69   $��0,5,0,0q�6q     59      -   5        $	 dpDateTo��59   :   $��5��6   $��2��6*   6:   �� 5:      -   5        
 ��Name$
 
btnPreview��5:   f   $��3��6   $��4��6)   $��3��66   $��5,0,0,0q�6G   $��78��6X     ButtonTemplate#���  6z   ��5;      � 5<       5=      �� 5>   "   $
��auto �60   �� 5?   "   $
��auto �60   .+�5A      �� $��16��6$   $��16��6/   $��/Images/update.png��6;   �� 5B      $��2,0,0,0q�6(   $��1��69   $��Center=�6F    	 commonButtonPreview#��� 	 6a   5C      5E      5F      5G      7  1System.Windows.Forms.Integration.WindowsFormsHost  5H   
   $��1��6   $��2��6(   $��0,2,0,0q�6<      Child. 5I      /   )Microsoft.Reporting.WinForms.ReportViewer  -   5        reportViewer��   ShowFindControls .  5I   5   5J      5K      5L      