   M S B A M L   `   `   `  ����  
PersonalSV/    )PersonalSV.Views.ChangeEmployeeCodeWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5        $��13(�5   @    !  titleChangeEmployeeCodeWindow  � Title#  �   5   	   $	��280��6M   $	��600��6]    � SizeToContent$ WidthAndHeight=�5   	    � 
ResizeMode$ NoResize=�6(    � WindowStartupLocation$ CenterScreen=�6>   .��5      � $��2q�6    � RowDefinitions 5   
   �� 5	      $
��auto �6   �� 5
      �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      $��4* �6   �� 5      $��3* �6   .+�5   
   � $��2��6   $��0,0,0,10q�6#    5      �� 5      �� 5      $��2* �6#   �� 5      $��3* �6#   .+�5      ��   commonEmployee#���  6   $��Center=�6L   �� 5      -   5         ��Name$ txtEmployeeIDSearch��5      $��1��63   
���   �$��15(�6�   $��Center=�6�   �� 5      -   5         ��Name$ 	btnSearch��5      $��2��6(   $	��100��68   $
��Left=�6D   $��5,0,0,0q�6_     ButtonTemplate#���  6�   ��5      � 5       5      �� 5      �� 5      .+�5       �� $��16��6    $��16��6+   $��/Images/search.png��67   �� 5!      $��2,0,0,0q�6$   $��1��65   $��Center=�6E     commonButtonSearch#���  6`   5"      5$      5%      �� 5&   
   -   5         ��Name$ grbWorkerInformation��5&      $��1��61     GroupBoxTemplate#���  6>   ��5'      �� 5(        Background1#���  6     BorderStyle#���  6P   ._�5)      ��  # commonGroupBoxWorkerInformation#���  6    5*      .��5,      �  5-      �� 5.      $
��auto �6$   �� 5/      $
��auto �6$   �� 50      $
��auto �6$   �� 51      $
��auto �6$    53      �� 54      $��2* �6'   �� 55      $��3* �6'   .+�57      ��   commonEmployeeName#���  6   $��Center=�6T   �� 58      $��Center=�6:   $��1��6U   $��14(�6e   $
��Bold"�6s   ��6   �� *EmployeeName+6s   �� 59       	 commonEmployeeCode#��� 	 6   $��Center=�6T   $��1��6o   �� 5:      -   5        	 ��Name$	 txtEmployeeCode��5:      $��Center=�6S   $��1��6n   $��1��6{   $��14(�6�   $
��Bold"�6�   $��0,5,0,0q�6�   ��65   �� *EmployeeCode+6�   �� 5;       
 commonEmployeeID#��� 
 6   $��Center=�6R   $��2��6m   �� 5<      -   5        $	 txtEmployeeID��5<      $��Center=�6O   $��2��6j   $��1��6w   $��14(�6�   $
��Bold"�6�   $��0,5,0,0q�6�   ��63   �� *
EmployeeID+6�   �� 5=        commonEmployeeDepartment#���  6   $��Center=�6Z   $��3��6u   �� 5>      $��Center=�6<   $��3��6W   $��1��6d   $��14(�6t   $
��Bold"�6�   $��0,5,0,0q�6�   ��6   �� *DepartmentName+6�   5?      5@      �� 5A   
   $��1��6   $��1��6$   $��3��64   $
��Left=�6>   $��Stretch=�6Y   $��0,10,0,0q�6u   �� 5C   
   $��1��6   $��1��6    $��3,0,0,0q�60   #���  6A   ��5D      �� 5E      #���  6   #���  6P   ._�5F      ��  ! commonGroupBoxCardInformation#���  6    5G      .��5I      �  5J      �� 5K      $��* �6$   �� 5L      $
��auto �6$   �� 5M      $
��auto �6$   �� 5N      $��* �6$    5P      �� 5Q      $��* �6'   �� 5R      $
��auto �6'   �� 5S      $��* �6'   .+�5U      ��  , (changeEmployeeCodeWindowTxtNewCardNumber#���  6   $��1��6j   $��1��6w   $��0,0,0,5q�6�   �� 5V      -   5        $ txtNewEmployeeCode��5V      $	��150��66   $��2��6E   $��1��6R   
���   �
����  �$��15(�6�   5W      5X      � 5Y   
   $��2��6   $��2��6   $��0,5,0,0q�60    5Z      �� 5[      �� 5\      �� 5]      �� 5^      .+�5`      �� -   5        $ btnSave��5`   %   $��3��6   #���  66   {�.  ��5a      � 5b       5c      �� 5d      �� 5e      .+�5g      �� $��16��6    $��16��6+   $��/Images/filesave.png��67   �� 5h      $��2,0,0,0q�6$   $��1��65   $��Center=�6E     commonButtonSave#���  6`   5i      5k      5l      5n      5o      