   M S B A M L   `   `   `  ����p  lSystem.Windows.Controls.DataVisualization.Toolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=null�rclr-namespace:System.Windows.Controls.DataVisualization;assembly=System.Windows.Controls.DataVisualization.Toolkit)System.Windows.Controls.DataVisualization  5   	   �{clr-namespace:System.Windows.Controls.DataVisualization.Charting;assembly=System.Windows.Controls.DataVisualization.Toolkit2System.Windows.Controls.DataVisualization.Charting  5   	   U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 5   	   F BPersonalSV, Version=1.0.1.18, Culture=neutral, PublicKeyToken=null3clr-namespace:PersonalSV.ViewsPersonalSV.Views 5	   	   *   $PersonalSV.Views.EmployeeChartWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   �dvtrclr-namespace:System.Windows.Controls.DataVisualization;assembly=System.Windows.Controls.DataVisualization.Toolkit     5   	   �dvc{clr-namespace:System.Windows.Controls.DataVisualization.Charting;assembly=System.Windows.Controls.DataVisualization.Toolkit     5   	   Dlvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   0localclr-namespace:PersonalSV.Views     5	   	   -   5          � WindowStartupLocation$  CenterScreen=�5   	    � WindowState$ 	Maximized=�6.      titleEmployeeChartWindow � Title# �   5   	   $	��450��6H   $	��800��6U   .��5      �� $��2q�6   $
��Auto=�6   $
��Auto=�6C   .��5   
   � 
������� � RowDefinitions 5      �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6     � ColumnDefinitions 5      �� 5      $
��auto �6#   �� 5      $��* �6#   .+�5        LiveCharts.Wpf.PieChart  -   5          Name$ pieChart��5       � Cursor$
 Hand��6-   $
��Left=�5      &   LiveCharts.Wpf.Charts.Base.Chart   LegendLocation$ Right=�5      $	��500��5      $	��350��6%      	Hoverable . 	   DataTooltip	 6C   Z� 5      #  LiveCharts.Wpf.CartesianChart  5!      -   5        
  Name$
 chartEmpBySection��5!   .   $��1��6!   $
��Left=�5"   !    . $
 Hand��5#   2   $	��325��5$   !   $
 None=�6.   5%      �� 5'      -   5         ��Name$ txtTitleChart��5+      $��2��5'      
���  ��$
��Bold"�5)      $��Italic$�5*      $��Center=�5,      5-      5/      50      51      