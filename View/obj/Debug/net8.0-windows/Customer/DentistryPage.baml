   M S B A M L   `   `   `  ����?  ;View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:View.CustomerView.Customer  5   	   !    View.Customer.DentistryPage   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:View.Customer     5   	     � Title$  DentistryPage��5   	   $	��450��6   $	��800��6,   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $$��Clinic And Service Information��6   $��24(�5      $
��Bold"�5      $��10q�5      $��Center=�5      ���#007ACC5      �� 5   
   -   5         ��Name$ 
clinicList��5      $��0��6'   $��149,10,-1,10q�5      ���#F0F0F0���#CCCCCC$��1q�5      $��1��6#    J� RenderTransformOrigin$ 0.5,0.5&�60   z�5      V� 5      .~�5      �� �� 5        �� AngleY$ 0.141Q�6$   �� 5!      T� 5"       T� Y$ 0.825Q�6)   5#       �� View 5%      �� 5&      .P�5'      ��  �� Width$	 130��6%   $��Clinic Name��61    �� DisplayMemberBinding 6F   �� *Name+�� 5(      $	 300��6%   $��Adress��61    6A   �� *	Address+�� 5)      $	 100��6%   $��Phone��61    6@   �� *Phone+�� 5*      $	 120��6%   $��Manager��61    6B   �� *Manager.User.Name+5+      5-      �� 50   
   -   5        $ serviceList��52      $��1��50      $��	0,10,0,10q�51      ���#E0F0FF���#CCCCCC$��1q�55      $
��Left=�6#   $	��137��6>    56      �� 57      .P�58      �� $	 130��6%   $��Service��61    6B   �� *Name+59      5;      �� 5<   
   -   5        	 ��Name$
	 back��5<      $
��Back��6   $
��Left=�6.   $��29,0,0,0q�6I   $��Center=�6[   $��32��6v   $��84��6�   ���	#FF1D4A4F$��Tahoma)�6�   $
��Bold"�6�   $��14(�6�   ���	#FFEEE3E36�   5>      5?      