   M S B A M L   `   `   `  ����F  BPersonalSV, Version=1.0.1.18, Culture=neutral, PublicKeyToken=null3clr-namespace:PersonalSV.ViewsPersonalSV.Views  5   	   1    +PersonalSV.Views.ChangeEmployeeCodeWindow_1   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:PersonalSV.Views     5   	   -   5        $��14(�5       !  titleChangeEmployeeCodeWindow  � Title#  �   5   	   $	��350��6M   $	��700��6]    � SizeToContent$ WidthAndHeight=�5	   	    � 
ResizeMode$ NoResize=�6(    � WindowStartupLocation$ CenterScreen=�6>   .��5
      � $��2q�6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��10 �6   �� 5      �� 5      $��5 �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      $��4* �6   �� 5      $��5 �6   �� 5      $��3* �6   .+�5   
   �  5      �� 5      �� 5      $��2* �6#   �� 5      $��3* �6#   5      �� 5   
   -   5         ��Name$ grbWorkerInformation��5      $��2��61     GroupBoxTemplate#���  6>   ��5       �� 5!      -   5         ��Name$ brSearch��5!        Background1#���  6+     BorderStyle#���  6b   ._�5#      ��  �� Orientation$ 
Horizontal=�6!   .+�5$      ��   commonEmployee#���  6    $��Center=�6T   �� 5%      -   5        	 ��Name$	 txtEmployeeIDSearch��5%      $	��120��6;   $��5,0,0,0q�6J   $��2,0,0,0q�6[   
���   �$��15(�6�   $��Center=�6�   
 �� 	MaxLength$
 10��6�   �� 5&      -   5         ��Name$ 	btnSearch��5&      $��2��60   $
��Left=�6@   $��5,0,0,0q�6[     ButtonTemplate#���  6�   ��5'      � 5(       5)   "   �� 5*   &   �� 5+   &   .+�5-   "   �� $��16��6(   $��16��63   $��/Images/search.png��6?   �� 5.   "   $��2,0,0,0q�6,   $��1��6=   $��Center=�6M   5/      51      52      53      .��55      �  56      �� 57      $
��auto �6$   �� 58      $��5 �6$   �� 59      $
��auto �6$   �� 5:      $��5 �6$   �� 5;      $
��auto �6$   �� 5<      $��5 �6$   �� 5=      $
��auto �6$   �� 5>      $��5 �6$   �� 5?      $
��auto �6$   �� 5@      $��5 �6$   �� 5A      $
��auto �6$   �� 5B      $��5 �6$    5D      �� 5E      $��2* �6'   �� 5F      $��3* �6'   .+�5H      ��   commonEmployeeName#���  6   $��Center=�6T   �� 5I      $��Center=�6:   $��1��6U   $
��Bold"�6e   ��6   �� *EmployeeName+6e   �� 5J        commonEmployeeCode#���  6   $��Center=�6T   $��2��6o   �� 5K      -   5         ��Name$ txtEmployeeCode��5K      $��Center=�6S   $��2��6n   $��1��6{   $
��Bold"�6�   ��65   �� *EmployeeCode+6�   �� 5L        commonEmployeeID#���  6   $��Center=�6R   $��4��6m   �� 5M      -   5        $ txtEmployeeID��5M      $��Center=�6O   $��4��6j   $��1��6w   $
��Bold"�6�   ��63   �� *
EmployeeID+6�   �� 5N       	 commonEmployeeDepartment#��� 	 6   $��Center=�6Z   $��6��6u   �� 5O      $��Center=�6<   $��6��6W   $��1��6d   $
��Bold"�6t   ��6   �� *DepartmentName+6t   �� 5Q       
 commonEmployeePosition#��� 
 6   $��8��6X   $��Center=�6e   �� 5R      $��Center=�6:   $��8��6U   $��1��6b   $
��Bold"�6r   ��6   �� *PositionName+6r   �� 5T        commonEmployeeJoinDate#���  6   $��10��6X   $��Center=�6f   �� 5U      $��10��6O   $��1��6]   $��Center=�6m   $
��Bold"�6�   ��6   �� *
JoinDate+ �� StringFormat$ 
MM/dd/yyyy��6�   5V      5W      �� 5X   
   $��2��6   $��2��6    #���  60   ��5Y      �� 5Z      #���  6T   #���  6�   ��6   ��  �� ElementName$ brSearch�� �� Path$ ActualHeight�._�5[      ��  ! commonGroupBoxCardInformation#���  6    $��Center=�6c   $��	10,0,10,0q�6~   5\      .��5^      �  5_      �� 5`      $��* �6$   �� 5a      $
��auto �6$   �� 5b      $
��auto �6$   �� 5c      $��* �6$    5e      �� 5f      $��* �6'   �� 5g      $
��auto �6'   �� 5h      $��* �6'   .+�5j      �� $ Vertical=�6   $��2��64   $��Center=�6H   .+�5k      	� -   5         	�Name$ radChangeCard��5k   "    ) %changeEmployeeCodeWindowRadChangeCard#���  69     RadioBlueStyle#���  6�    	� 	GroupName$ DoiThe��6�    d� 	IsChecked$
 TrueY�6�   $��Center=�6�   6  	� 5l      -	   5        $ 	radResign��5l   "    % !changeEmployeeCodeWindowRadResign#���  65   #���  6   $��0,5,0,0q�6�   $ DoiThe��6�   $��Center=�6�   6�   5m      �� 5n       , (changeEmployeeCodeWindowTxtNewCardNumber#���  6   $��1��6j   $��1��6w   $��0,0,0,5q�6�   �� 5o      -
   5        $	 txtNewEmployeeCode��5o      $	��150��66   $��2��6E   $��2,0,0,0q�6R   $��1��6d   
���   �
����  �$��20(�6�   $
 10��6�   5p      5q      � 5r   
   $��4��6   $��2��6    5s      �� 5t      $
��auto �6#   �� 5u      $
��auto �6#   �� 5v      �� 5w      �� 5x      �� 5y      .+�5{      �� -   5        $ btnSave��5{   %   $��5��6   #���  66   {�.  ��5|      � 5}       5~      �� 5      �� 5�      .+�5�      �� $��16��6    $��16��6+   $��/Images/filesave.png��67   �� 5�      $��2,0,0,0q�6$   $��1��65   $��Center=�6E     commonButtonSave#���  6`   5�      5�      5�      5�      5�      