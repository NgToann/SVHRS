   M S B A M L   `   `   `  ����F  BPersonalSV, Version=1.0.1.18, Culture=neutral, PublicKeyToken=null3clr-namespace:PersonalSV.ViewsPersonalSV.Views  5   	   +    %PersonalSV.Views.WorkerCheckOutWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:PersonalSV.Views     5   	   -   5        
�������$��14(�5   2     � WindowStartupLocation$  CenterScreen=�6@      workerCheckOutWindowTitle � Title# �   5   	   $	��500��6I   $
��1200��6V    � WindowState$ 	Maximized=�6c   .��5	      � $��2q�6    � RowDefinitions 5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��2��6   $��0,0,0,15q�6&    �� CornerRadius$ 5��68   $��1,1,1,1q�6I   
�������
�����_�._�5      �� -   5         ��Name$ tblTitle��5        workerCheckOutTitle#���  5      
����  �$��SemiBold"�5      $��35(�6*   $��Center=�68    �� TextAlignment$ Center=�5      5      � 5   
   $��1��6   $	��400��6   $	��400��6(   $��2,0,0,0q�67   $��Bottom=�6H   $
��Left=�6c    5      �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $��* �6    �� 5       $
��auto �6    .+�5"      ��   workerCheckInScanCardId#���  6   $ Center=�6U   $��20(�6l   �� 5#      -   5         ��Name$ 	txtCardId��5#   @   $��1��6   $��3q�6#   $��0,4,0,0q�6/   {�.  
���   �$��25(�5$   *   
����  �$��SemiBold"�6J   $��Center=�5%      	 �� TextAlignment$	 Center=�5&      6-   �� 5(      $��4��6   
 �� Padding$
 5q�6"   $��0,0,0,5q�6.   $��1,1,1,1q�6?   
�������$ 5��6l   $y�	Collapsed=�6}   ._�5)      �� -   5        $ lblTotal��5)      $ Center=�6.   $��Center=�6E   
����  �$��20(�6r   5*      5+      �� 5,   
   $��1��6   $��1��6   $��0,0,2,0q�6.   $
 	15,4,15,4q�6?     BorderStyle#���  6S   
�������$ 5��6�   $��1,1,1,1q�6�   ._�5-      �  5.      �� 5/      $
��auto �6$   �� 50      .+�52      �� 
�������$y�	Collapsed=�6,   ._�53      �  54      �� 55      �� 56      .+�58      ��   workerCheckInStatistics#���  6$   
����  �$��SemiBold"�6s   $��18(�6�   �� 59      -   5        $ lblClock��59   P   $��1��6$   $��Right=�64   $��CLOCK��6b   $��18(�6o   
����  �$��SemiBold"�6�   5:      5;      � 5<      -   5         �Name$ grStatistics��5<      $��1��6-   $��0,5,0,0q�6:    5=      �� 5>      $
��auto �6(   �� 5?      $
��auto �6(    5A      �� 5B      �� 5C      �� 5D      .+�5F      �� $��18(�6:   $��SemiBold"�6H   
����  ���6    �� *
TestDate+6^   �� 5G      $��1��6    $��18(�6I   $��SemiBold"�6W   
����  ���60   �� *	CheckIn+6m   �� 5H      $��2��6    $��18(�6J   $��SemiBold"�6X   
��� � ���60   �� *
CheckOut+6n   5I      5J      5K      �� 5L   
   -   5         ��Name$ 	brDisplay��5L      $��2��6$   $��2��61   $��2q�6E   
�������$��1,1,1,1q�6c   $ 5��6}   $
 4q�6�   ._�5M      (�  (� Stretch$ Uniform=�6   $��Center=�6(   $��Center=�6E   .��5N      � -   5        $ 	grDisplay��5N       5O      �� 5P      $
��auto �6(   �� 5Q      $
��auto �6(   �� 5R      $
��auto �6(   �� 5S      $
��auto �6(   .+�5U      �� $��Center=�6>   $��SemiBold"�6[   ��6    �� *EmployeeName+��6q   �� *
Foreground+�� 5V      $��1��6    $��Center=�6I   $��SemiBold"�6f   ��6-   �� *
EmployeeID+��6|   �� *
Foreground+�� 5W      $��2��6    $��Center=�6M   $��SemiBold"�6j   ��6-   �� *DepartmentName+��6�   �� *
Foreground+�� 5X      $��4��6    $��Center=�6I   $��SemiBold"�6f   ��6-   �� *
RecordTime+��6|   �� *
Foreground+5Y      5Z      5[      5\      5]      