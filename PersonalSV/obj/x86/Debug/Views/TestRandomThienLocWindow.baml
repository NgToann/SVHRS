   M S B A M L   `   `   `  ����F  BPersonalSV, Version=1.0.1.18, Culture=neutral, PublicKeyToken=null3clr-namespace:PersonalSV.ViewsPersonalSV.Views  5   	   /    )PersonalSV.Views.TestRandomThienLocWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:PersonalSV.Views     5   	   -   5          � WindowState$  	Maximized=�5      $��15(�62   $	��900��6@    � WindowStartupLocation$ CenterScreen=�5   	   
�������   tlTestRandomWindowTitle � Title# �   5	   	   $	��600��6G   $
��1200��6T   .��5
      � $��2q�6    � ColumnDefinitions 5   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      �� 5      $
��auto �6   .+�5   
   �� $��0,0,0,10q�6   $��2��6#    �� CornerRadius$ 5��67   $��1,1,1,1q�6H   
�������
����·�._�5      �� -   5         ��Name$ 	lblHeader��5      
���  ��  testRandomHeader#���  5      $��SemiBold"�5      $��35(�6*   $��Center=�68    �� TextAlignment$ Center=�5      5      �� 5   
   $��1��6   $��1��6   $��0,0,2,0q�6.    �� Padding$ 	10,4,10,4q�6?     BorderStyle#���  6S   
�������$ 5��6�   $��1,1,1,1q�6�   ._�5      �  5      �� 5      $
��auto �6$   �� 5       .+�5"      �� 
�������._�5#      �  5$      �� 5%      �� 5&      .+�5(      ��   testRandomGroupTestInfo#���  6$   
����  �$��SemiBold"�6s   $��18(�6�   �� 5)      -   5        $ lblClock��5)   P   $��1��6$   $��Right=�64   $��CLOCK��6b   $��18(�6o   
����  �$��SemiBold"�6�   5*      5+      � 5,      -   5        	 �Name$	 
grTestInfo��5,      $��1��6+   $��0,5,0,0q�68    5-      �� 5.      $
��auto �6(   �� 5/      $
��auto �6(    51      �� 52      �� 53      �� 54      .+�56      �� $��17(�6:   
����  �$��SemiBold"�6^   ��6    �� *
TestDate+6^   �� 57      $��1��6    $��17(�6M   
����  �$��SemiBold"�6q   ��60   �� *RandomRatio+6q   �� 58      $��2��6    $��17(�6T   
����  �$��SemiBold"�6x   ��60   �� *TotalRequestWorker+6x   �� 59      $��1��6    $��2��6-   $��2��6=   $��17(�6q   
��� � �$��SemiBold"�6�   ��6R   �� *CurrentTimeIn+6�   5:      5;      5<      � 5>   
   $��1��6   $	��400��6   $
��Left=�6(   $��Bottom=�6C   $��2,0,0,0q�6^    5?      �� 5@      �� 5A      .+�5C      ��   workerCheckInScanCardId#���  6   $��20(�6U   $��Center=�6c   �� 5D      -   5        
 ��Name$
 	txtCardId��5D   /   $��1��6   $��3q�6#   {�.  
���   �$��25(�5E   *   
����  �$��SemiBold"�6J   $��Center=�5F       �� TextAlignment$ Center=�5G      6-   5H      �� 5J   
   -   5         ��Name$ 	brDisplay��5J      $��2��6$   $��2��61   $��2q�6E   
�������$��1,1,1,1q�6c   $ 5��6}   $ 4q�6�   ._�5K      �  5L      �� 5M      �� 5N      $
��auto �6$   .+�5P      (�  (� Stretch$ Uniform=�6   $��Center=�6,   $��Center=�6I   .��5Q      �  5R      �� 5S      $
��auto �6,   �� 5T      $
��auto �6,   �� 5U      $
��auto �6,   �� 5V      $
��auto �6,   .+�5X      �� $��Center=�6B   ��6$   �� *EmployeeName+6B   �� 5Y      $��1��6$   $��Center=�6Q   ��61   �� *DepartmentName+6Q   �� 5Z      $��2��6$   $��Center=�6I   ��61   �� *TimeIn+6I   �� 5[      $��3��6$   $��Center=�6J   ��61   �� *	Message+6J   5\      5]      �� 5^      $��Bottom=�67   $��12(�6R   ��6   �� *	IdDisplay+6R   5_      5`      5a      5b      