   M S B A M L   `   `   `  ����?  ;View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:View.CustomerView.Customer  5   	   &     View.Customer.AppointmentHistory   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:View.Customer     5   	     � Title$  AppointmentHistory��5   	   $	��450��6$   $	��800��61   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   ���#007ACC �� Padding$ 10q�63   ._�5      �� $��Appointment History��6   $��24(�63   $
��Bold"�6A   
�������$��Center=�6f   5      � 5   
   $��1��6   $��10q�6    � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $��* �6#   �� 5      $
��Auto �6#   �� 5      $��* �6#   �� 5      $
��Auto �6#   .+�5      �� $��Search by Date:��6   $��Center=�6/   ���#007ACC$��0,0,10,0q�6_   (  "System.Windows.Controls.DatePicker  5       -   5          Name$ 
searchDate��5       $��1��6-   $��Center=�6=   �� 5"      $��2��6   $��Search by Name:��6(   $��Center=�6?   ���#007ACC$
��10,0q�6o   �� 5#      -   5         ��Name$ search��5#      $��3��6&   $��Center=�66   �� 5%      -   5        $��4��5%      $��Search��6%   $��Center=�66   $
��10,0q�6Q   $
��10,5q�6_   ���#007ACC
�������6�   5&      �� 5)   
   -   5         ��Name$	 lvi��5)      $��2��6!   $��	0,10,0,10q�6.    �� View 5*      �� 5+      .P�5,      ��  �� Width$ 90��6%   $
��Date��60   	 �� DisplayMemberBinding	 6>   �� *Date+�� 5-      $	 100��6%   $
��Time��62   	 6@   �� *TimeSlot.Time+�� 5.      $	 170��6%   $��Dentist��61   	 6B   �� *Dentist.User.Name+�� 5/      $	 120��6%   $��Service��61   	 6B   �� *Service.Name+�� 50      $	 140��6%   $��Clinic��61   	 6A   �� *Clinic.Name+�� 51      $	 100��6%   $��Status��61   	 6A   �� *Status+�� 53      $ 70��6%   
 �� CellTemplate
 54      �� 55      .R�56   "   ��  �� Orientation$ 
Horizontal=�6-   .+�57   &   ��  ��Name$ delete��6-   -   5        $��Delete��57   =   $��5q�6N   ��6Y   �� 6v   58   #   59      5;      5<      ��5>      �� 5?       �� 
TargetType" ��6   .�5@      ��  �� Property � �� �� Value$ Stretch=�6C   5A      5C      �� 5D   
   -   5        $
 back��5D      $
��Back��6   $
��Left=�6.   $��29,0,0,0q�6I   $��Center=�6[   $��32��6v   $��84��6�   ���	#FF1D4A4F$��Tahoma)�6�   $
��Bold"�6�   $��14(�6�   ���	#FFEEE3E36�   5F      5G      