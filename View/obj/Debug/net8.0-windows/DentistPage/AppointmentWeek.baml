   M S B A M L   `   `   `  ����?  ;View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:View.DentistPageView.DentistPage  5   	   &     View.DentistPage.AppointmentWeek   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:View.DentistPage     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ AppointmentWeek��5	   	   $	��800��6!   $
��1200��6.    � 	Resources 5
         AppointmentTemplate �� StringFormat��%�   &	        �� 5   
   .R�5      �� .+�5      �� ��6   �� *TimeSlot.Time+$ 	{0:HH:mm}���� 5      ��6   �� *Customer.User.Name+�� 5      ��6   �� *Service.Name+5      5      5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   ���#007ACC �� Padding$ 10q�63   $��52��6@   $	��Top=�6L   ._�5      ]� $
��True��6   .+�5      �� -   5         ��Name$
 Back��5      $
��Back��6'   $��84��66   $��32��6A   ���	#FF1D4A4F$��Tahoma)�6d   $
��Bold"�6x   $��14(�6�   ���	#FFEEE3E3$
��Left=�6�   $	��5,0q�6�   �� 5      -   5        $ History��5      $��History��6*   $��84��6<   $��32��6G   $��Tahoma)�6S   $��10(�6g   
���   �$��Right=�6�   $	��5,0q�6�   
���������6�   Z� �� 5       $��Dentist Appointments��6   $��24(�68   $
��Bold"�6F   
�������$��Center=�6k   $��Center=�6�   $	��Top=�6�   5!      5"      �� 5%   
   $��1��6    �� Orientation$ 
Horizontal=�6"   $��Center=�6;   .+�5&      �� $��Select Date: ��6   $��Center=�6-   $��5q�6H   (  "System.Windows.Controls.DatePicker  5'      -   5        $��
DatePicker��5'      6+   5(      � 5+   
   $��2��6   $��
0,10,0,621q�6    � ColumnDefinitions 5,      �� 5-      $��* �6#   �� 5.      $��* �6#   �� 5/      $��* �6#   �� 50      $��* �6#   �� 51      $��* �6#   �� 52      $��* �6#   �� 53      $��* �6#   .+�56      �� $��0��6[   $��Center=�6k   $��Center=�6�   $
��Bold"�6�   $��	0,10,0,10q�6�   ��6   �� *
MondayDate+$ Monday, {0:MM/dd/yyyy}��6�   �� 57      $��1��6]   $��Center=�6m   $��Center=�6�   $
��Bold"�6�   $��	0,10,0,10q�6�   ��6   �� *TuesdayDate+$ Tuesday, {0:MM/dd/yyyy}��6�   �� 58      $��2��6a   $��Center=�6q   $��Center=�6�   $
��Bold"�6�   $��	0,10,0,10q�6�   ��6   �� *WednesdayDate+$ Wednesday, {0:MM/dd/yyyy}��6�   �� 59      $��3��6_   $��Center=�6o   $��Center=�6�   $
��Bold"�6�   $��	0,10,0,10q�6�   ��6   �� *ThursdayDate+$ Thursday, {0:MM/dd/yyyy}��6�   �� 5:      $��4��6[   $��Center=�6k   $��Center=�6�   $
��Bold"�6�   $��	0,10,0,10q�6�   ��6   �� *
FridayDate+$ Friday, {0:MM/dd/yyyy}��6�   �� 5;      $��5��6_   $��Center=�6o   $��Center=�6�   $
��Bold"�6�   $��	0,10,0,10q�6�   ��6   �� *SaturdayDate+$ Saturday, {0:MM/dd/yyyy}��6�   �� 5<      $��6��6[   $��Center=�6k   $��Center=�6�   $
��Bold"�6�   $��	0,10,0,10q�6�   ��6   �� *
SundayDate+$ Sunday, {0:MM/dd/yyyy}��6�   5=      � 5@   
   $��2��6   $��0,68,0,0q�6    5A      �� 5B      $��* �6#   �� 5C      $��* �6#   �� 5D      $��* �6#   �� 5E      $��* �6#   �� 5F      $��* �6#   �� 5G      $��* �6#   �� 5H      $��* �6#   .+�5K      �� #��[  6A   $��0��6u   ��6   �� *MondayAppointments+6u   �� 5L      #��[  6B   $��1��6v   ��6   �� *TuesdayAppointments+6v   �� 5M      #��[  6D   $��2��6x   ��6   �� *WednesdayAppointments+6x   �� 5N      #��[  6C   $��3��6w   ��6   �� *ThursdayAppointments+6w   �� 5O      #��[  6A   $��4��6u   ��6   �� *FridayAppointments+6u   �� 5P      #��[  6C   $��5��6w   ��6   �� *SaturdayAppointments+6w   �� 5Q      #��[  6A   $��6��6u   ��6   �� *SundayAppointments+6u   5R      5S      5T      