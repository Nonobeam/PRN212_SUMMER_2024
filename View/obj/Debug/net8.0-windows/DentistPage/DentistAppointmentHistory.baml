   M S B A M L   `   `   `  ����?  ;View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:View.DentistPageView.DentistPage  5   	   0    *View.DentistPage.DentistAppointmentHistory   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:View.DentistPage     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ DentistAppointmentHistory��5	   	   $	��800��6+   $
��1200��68   .��5
      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   ���#007ACC �� Padding$ 10q�63   $��52��6@   $	��Top=�6L   ._�5      ]� $
��True��6   .+�5      �� -   5         ��Name$
 Back��5      $
��Back��6'   $��84��66   $��32��6A   ���	#FF1D4A4F$��Tahoma)�6d   $
��Bold"�6x   $��14(�6�   ���	#FFEEE3E3$
��Left=�6�   $	��5,0q�6�   �� 5      -   5        $ Appointment��5      $��Appointment��6.   $��84��6D   $��32��6O   $��Tahoma)�6[   $��10(�6o   ���	#FFEEE3E3$��Right=�6�   $	��5,0q�6�   ��6�   Z� ��6�   Z� �� 5      $��History Appointments��6   $��24(�68   $
��Bold"�6F   
�������$��Center=�6k   $��Center=�6�   $	��Top=�6�   5      5      � 5   
   $��1��6   $��10q�6    � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $��* �6#   �� 5      $
��Auto �6#   �� 5       $��* �6#   �� 5!      $
��Auto �6#   .+�5$      �� $��Search by Date:��6   $��Center=�6/   ���#007ACC$��0,0,10,0q�6_   �� 5%      -   5         ��Name$ 
searchDate��5%      $��1��6*   $��Center=�6:   �� 5'      $��2��6   $��Search by Name:��6(   $��Center=�6?   ���#007ACC$
��10,0q�6o   �� 5(      -   5        $ 
searchName��5(      $��3��6*   $��Center=�6:   �� 5*      -   5        $��SearchButton��5*      $��4��6)   $��Search��69   $��	10,0,10,0q�6J   $
��10,5q�6]   ���#007ACC
�������6�   5+      �� 5.   
   -   5         ��Name$ AccountTable��5.      $��2��6)   $	��588��6Z   $	��Top=�6g   $��0,10,0,0q�6   ��66   �� *Appointment+ �� View 5/      �� 50      .P�51      �� 	 �� Width$		 130��6%   $
��Date��61   
 �� DisplayMemberBinding
 6?   �� *Date+�� 52      $		 200��6%   $��TimeSlot��62   
 6D   �� *
TimeSlot+�� 53      $		 200��6%   $��Customer��61   
 6C   �� *
Customer+�� 54      $		 200��6%   $��Dentist��61   
 6B   �� *	Dentist+�� 55      $		 150��6%   $��Service��61   
 6B   �� *	Service+�� 56      $		 250��6%   $��Clinic��61   
 6A   �� *Clinic+57      59      5:      5;      