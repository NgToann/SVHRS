   M S B A M L   `   `   `  ����  
PersonalSV.    (PersonalSV.Views.ExecuteDataSalaryWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5        $��13(�5   @     � 
ResizeMode$  CanMinimize=�6N       titleExecuteDataSalaryWindow � Title# �   5   	   $	��580��6L    � SizeToContent$ Height=�6X    � WindowStartupLocation$ CenterScreen=�6o   .��5      � $��2q�6   .+�5   
   ��   GroupBoxTemplate#���  6   ��5      �� 5        Background1#���  6     BorderStyle#���  6P   ._�5	      ��   commonGroupBoxOption#���  6    5
      .��5      �  � RowDefinitions 5      �� 5      $
��auto �6$   �� 5      $
��auto �6$   �� 5      $
��auto �6$   �� 5      $
��auto �6$   �� 5      $��* �6$    � ColumnDefinitions 5      �� 5      �� 5      $��20 �6'   �� 5      .+�5      ��   commonDatePickerFrom#���  6   $��Bottom=�6V   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ dpFrom��5   *   $��1��6   6*   �� 5      $��1��6   $��1��6*   $��->��6:   $��Center=�6D   $��Center=�6_   �� 5      $��2��6     commonDatePickerTo#���  6,   $��Bottom=�6d     5      -   5        $
 dpTo��5   ;   $��1��6   $��2��6+   6;   � 5!      $��2��6   $��3��6$   $��0,10,0,0q�68    5"      �� 5#      $
��auto �6(   �� 5$      $��5 �6(   �� 5%      $
��auto �6(   �� 5&      $��5 �6(   �� 5'      $
��auto �6(   �� 5(      $��7 �6(   �� 5)      $
��auto �6(    5+      �� 5,      $��* �6+   �� 5-      $��5 �6+   �� 5.      $��2* �6+   .+�50      	� -   5         	�Name$ radExecutePerSection��50   "    & "commonRadioButtonExecutePerSection#���  6@     RadioBlueStyle#���  6�   $��Center=�6�    	� 	GroupName$ ExecuteMode��6�   	 d� 	IsChecked$
	 TrueY�6�   6  �� 51      -   5        
 ��Name$
 
cboSection��51   /   $��2��6    �� DisplayMemberPath$ DepartmentFullName��6|   $��Center=�6  ��6C   ��  �� ElementName$ dpFrom�� �� Path$ ActualHeight�{�6�   �� *	IsChecked+$ radExecutePerSection��6  	� 53      -   5        $ radExcuteByDeparment��53   /   $��2��6"    )	 %commonRadioButtonExecutePerDepartment#��� 	 6M   #���  6�   $��Center=�6�   $ ExecuteMode��6�   6  �� 54      -   5        $
 cboDepartment��54   u   $��2��6   $��2��6,   $��Center=�6�   ��6<   �� $ dpFrom��$ ActualHeight�{�6�   �� *	IsChecked+$ radExcuteByDeparment��6�   	� 56      -   5        $ radExcuteByEmployee��56   /   $��4��6"    '
 #commonRadioButtonExecutePerEmployee#��� 
 6L   #���  6�   $��Center=�6�   $ ExecuteMode��6�   6   �� 57      -	   5         ��Name$ txtEmployeeID��57   t   $��4��6   $��2��6+   $��15(�6�   
���   �$��Center=�6�   ��6;   �� $ dpFrom��$ ActualHeight�{�6�   �� *	IsChecked+$ radExcuteByEmployee��6�   	� 59      -
   5        $ radExcuteAll��59   /   $��6��6"     commonRadioButtonExecuteAll#���  6E   #���  6�   $��Center=�6�   $ ExecuteMode��6�   6�   5:      � 5<      $��3��6   $��3��6$   $��0,10,0,5q�68    5=      �� 5>      $��* �6+   �� 5?      $��2* �6+   �� 5@      $��* �6+   .+�5B      �� -   5         ��Name$ 
btnExecute��5B   -   $��1��6   $��38��6A     ButtonTemplate#���  6M   {�.  ��5C      � 5D       5E   "   �� 5F   &   �� 5G   &   .+�5I   "   �� $��16��6(   $��16��63   $��/Images/arrow_switch.png��6?   �� 5J   "   $��2,0,0,0q�6,   $��1��6=     commonButtonExecute#���  6M   5K      5M      5N      � 5P      $��4��6   $��3��6$    5Q      �� 5R      $
��auto �6(   �� 5S      $
��auto �6(   .+�5U      � -   5         �Name$ prgProcessing��5U   "   $��18��69   �� 5V      -   5         ��Name$ txtProcessing��5V       $��Center=�67   $��Center=�6T   $��Italic$�6o   
����  �$��11(�6�   �� 5W      -   5        $ 	txtStatus��5W   -   $��1��6    $��Center=�6@   $��Center=�6]   
����  �$��Italic$�6�   $
��Wrap=�6�   5X      5Y      5Z      5[      5\      