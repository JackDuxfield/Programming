   M S B A M L   `   `   `  ����B  >Lab1WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:Lab1WPFLab1WPF  5   	       Lab1WPF.MainWindow   5   	   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Lab1WPF     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��1��6   $��0��6   .��6.   Random Numbers6@   �� 5   
   -   5         ��Name$ RandomNumbers��5   /   $��2��6   $��0��6   6/   �� 5   
   $��1��6   $��1��6   .��6.   Sorted Numbers6@   �� 5   
   -   5        $ SortedNumbers��5   /   $��2��6   $��1��6   6/   �� 5   
   -   5         ��Name$ sortNumbers��5   .   $��0��6   $��0��6   $��5q�6c   .��6n   Sort Numbers5      5      5       