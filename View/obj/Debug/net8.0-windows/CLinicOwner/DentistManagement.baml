   M S B A M L   `   `   `  ����?  ;View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:View.CLinicOwnerView.CLinicOwner  5   	   (    "View.CLinicOwner.DentistManagement   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:View.CLinicOwner     5   	     � Title$  DentistManagement��5   	   $	��450��6#   $	��800��60   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	tbDentist��5
         AutoGenerateColumns$ False��6&   $��Center=�6B   $	��207��6_   $��	0,217,0,0q�6l   $	��Top=�6   $	��780��6�   $
��Auto=�6�   $
��Auto=�5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6H   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+6H     5      $
 Name��6%   $	 100 6L    63   �� *Name+6L     5      $ Email��6%   $	 100 6N    64   �� *Email+6N     5      $ Phone��6%   $	 100 6N    64   �� *Phone+6N     5      $ Password��6%   $	 150 6T    67   �� *
Password+6T     5      $ Status��6%   $	 100 6P    65   �� *Status+6P     5      $ 
ClinicName��6%   $	 100 6X    69   �� *
ClinicName+6X   4  .System.Windows.Controls.DataGridTemplateColumn  5      $ Actions��6)   $ * 6:      CellTemplate 5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6)   $��Center=�6B   .+�5   "   �� -   5        $
��Edit��5   )   $��5q�6d   
	 � Tag	 6Q   �� *Id+6d   5      5      5      5      �� 5   
   -   5        
 ��Name$
 btnAdd��5      $	��ADD��6!   $
��Left=�6/   $��33��6J   $��
10,162,0,0q�6V   $	��Top=�6j   $��94��6�   6�   �� 5    
   $��DENTIST MANAGEMENT��6   $��Center=�6-   $��64��6J   $��0,35,0,0q�6V   $	��Top=�6h   $	��800��6�   $��26(�6�   $
��Bold"�6�   ���	#FF1AAAC9$��Center=�6�   �� 5!   
   -   5        $

 back��5!      $
��Back��6   $
��Left=�6.   $��	20,47,0,0q�6I   $	��Top=�6\   $��31��6t   $��84��6�   ���	#FF1D4A4F$��Tahoma)�6�   $
��Bold"�6�   $��14(�6�   ���	#FFEEE3E36�   5#      5$      