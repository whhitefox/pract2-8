   M S B A M L   `   `   `  ����T  PПрактическая8, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Практическая8Практическая8  5      ,    &Практическая8.CalendarPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:Практическая8     5        N� Title$  CalendarPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      $��6* �6    � ColumnDefinitions 5   
   �� 5      �� 5      $��4* �6   �� 5      $
��0.5* �6   �� 5      .+�5   
   �� -   5         ��Name$ 
PrevButton��5      $��0��6%   $��0��62   $��<��6B   6Q   �� 5   
   -   5         ��Name$ 
MonthLabel��5      $��0��6$   $��1��61   $��Center=�6A   $��Center=�6^   $��24(�6y   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ MonthSelect��5      $��2��6*   $��Center=�6:   $��30��6�   �� 5   
   -   5        $ 
NextButton��5      $��0��6%   $��3��62   $��>��6B   6Q   �� 5   
   -   5         ��Name$ DaysList��5      $��1��6$   $��4��61   $��Disabled=�6E   ��5      �� 5      .R�5      � 5       5"      5&      5'      