   M S B A M L   `   `   `  ����?  ;View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:View.ComponentView.Component  5   	   &     View.Component.ClinicInformation   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:View.Component     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ ClinicInformation��5	   	   $	��800��6#   $
��1200��60   .��5
      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   ���#007ACC �� Padding$ 10q�63   $��52��6@   $	��Top=�6L   ._�5      ]� $
��True��6   .+�5      �� -   5         ��Name$
 Back��5      $
��Back��6'   $��84��66   $��32��6A   ���	#FF1D4A4F$��Tahoma)�6d   $
��Bold"�6x   $��14(�6�   ���	#FFEEE3E3$
��Left=�6�   $	��5,0q�6�   �� 5      -   5        $ Clinic��5      $��Clinic��6)   $��84��6:   $��32��6E   $��Tahoma)�6Q   $��17(�6e   ���	#FFEEE3E3$��Right=�6�   $	��5,0q�6�   ��6�   Z� ��6�   Z� �� 5      -   5        $ ClinicDashboard��5      $��	Dashboard��62   $��95��6F   $��32��6Q   $��Tahoma)�6]   $��17(�6q   ���	#FFEEE3E3$��Right=�6�   $	��5,0q�6�   ��6�   Z� ��6�   Z� �� 5      -   5        $ Account��5      $��Account��6*   $��91��6<   $��32��6G   $��Tahoma)�6S   $��17(�6g   ���	#FFEEE3E3$��Right=�6�   $	��5,0q�6�   ��6�   Z� ��6�   Z� �� 5      $��Clinic Detail Information��6   $��24(�6=   $
��Bold"�6K   
�������$	��Top=�6p   $	��280��6�   5      5      �� 5   
   $��1��6   .+�5      �� $��Appointments Table��6   $��16(�62   $
��Bold"�6@   $��10q�6R   $
��1094��6^   �� 5      -   5         ��Name$ AppointmentsTable��5      $
��1125��6W   ��62   �� *Appointments+ �� View 5      �� 5      .P�5       ��  �� Width$	 130��6)   $
��Date��65    �� DisplayMemberBinding 6C   �� *Date+�� 5!      $	 200��6)   $��TimeSlot��66    6H   �� *
TimeSlot+�� 5"      $	 200��6)   $��Customer��65    6G   �� *
Customer+�� 5#      $	 200��6)   $��Dentist��65    6F   �� *	Dentist+�� 5$      $	 150��6)   $��Service��65    6F   �� *	Service+�� 5%      $	 250��6)   $��Clinic��65    6E   �� *Clinic+5&      5(      �� 5*      $��DentistsTable��6   $��16(�6-   $
��Bold"�6;   $��10q�6M   $
��1094��6Y   �� 5+      -   5        $ DentistsTable��5+      $
��1125��6O   ��6.   �� *
Dentists+ 5,      �� 5-      .P�5.      �� $	 600��6)   $
��Name��65    6C   �� *Name+5/      51      52      53      54      