   M S B A M L   `   `   `  ����?  ;View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:View.CLinicOwnerView.CLinicOwner  5   	   +    %View.CLinicOwner.AppoinmentManagement   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:View.CLinicOwner     5   	     � Title$  AppoinmentManagement��5   	   $	��450��6&   $	��800��63   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ tbAppoinment��5
      $��Center=�6)   $	��190��6F   $��	0,234,0,0q�6S   $	��Top=�6f   $	��780��6~   $
��Auto=�6�   $
��Auto=�5         AutoGenerateColumns$ False��63      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6H   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+6H     5      $
 Date��6%   $ 80 6L    63   �� *Date+6L     5      $ 
TimeSlotId��6%   $ 80 6X    69   �� *
TimeSlotId+6X     5      $ CustomerName��6%   $	 100 6\    6;   �� *CustomerName+6\     5      $ DentistName��6%   $	 100 6Z    6:   �� *DentistName+6Z     5      $ 
ClinicName��6%   $	 100 6X    69   �� *
ClinicName+6X     5      $ ServiceName��6%   $	 100 6Z    6:   �� *ServiceName+6Z     5      $ Status��6%   $	 100 6P    65   �� *Status+6P   4  .System.Windows.Controls.DataGridTemplateColumn  5      $ Actions��6)   $ * 6:      CellTemplate 5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6)   $��Center=�6B   .+�5   "   �� -   5        $
��Edit��5   )   $��5q�6d   
	 � Tag	 6Q   �� *Id+6d   5      5      5      5      �� 5    
   $��APPOINMENT MANAGEMENT��6   $��Center=�60   $��52��6M   $��0,29,0,0q�6Y   $	��Top=�6k   $	��800��6�   $��26(�6�   $
��Bold"�6�   ���	#FF17C0C6$��Center=�6�   �� 5!   
   $	��ID:��6   $
��Left=�6   $��28��69   $��	15,86,0,0q�6E   $	��Top=�6X   $��36��6p   �� 5"   
   -   5        
 ��Name$
 txtId��5"      $
��Left=�6#   $��14��6>   $��	51,91,0,0q�6J   $
��Wrap=�6]   $	��Top=�6q   $��83��6�   �� 5#   
   $
��Date��6   $
��Left=�6   $��26��6:   $��
14,116,0,0q�6F   $	��Top=�6Z   $��36��6r   (  "System.Windows.Controls.DatePicker  5$   
   -   5          Name$ txtDate��5$      $
��Left=�6&   $��26��6A   $��
55,116,0,0q�6M   $	��Top=�6a   $	��105��6y   �� 5%   
   -   5         ��Name$ txtTime��5%      $
��Left=�6#   $��21��6>   $��
59,155,0,0q�6J    �� TextWrapping$
 Wrap=�6^   $	��Top=�6r   $��70��6�   �� 5&   
   $
��Time��6   $
��Left=�6   $��26��6:   $��
15,150,0,0q�6F   $	��Top=�6Z   $��37��6r   �� 5'   
   $��
CustomerId��6   $
��Left=�6%   $��26��6@   $��197,116,0,0q�6L   $	��Top=�6a   $��74��6y   �� 5(   
   -   5        $ txtCustomer��5(      $
��Left=�6'   $��22��6B   $��278,122,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $��64��6�   �� 5)   
   $��	DentistId��6   $
��Left=�6$   $��26��6?   $��197,150,0,0q�6K   $	��Top=�6`   $��74��6x   �� 5*   
   -   5        $ 
txtDentist��5*      $
��Left=�6&   $��21��6A   $��276,155,0,0q�6M   $
 Wrap=�6b   $	��Top=�6v   $��63��6�   �� 5+   
   $��	ServiceID��6   $
��Left=�6$   $��30��6?   $��
-4,182,0,0q�6K   $	��Top=�6_   $��58��6w   �� 5,   
   -   5        $ 
txtService��5,      $
��Left=�6&   $��19��6A   $��
59,187,0,0q�6M   $
 Wrap=�6a   $	��Top=�6u   $��75��6�   �� 5-   
   -	   5         ��Name$ btnAdd��5-      $	��ADD��6!   $
��Left=�6/   $��34��6J   $��478,132,0,0q�6V   $	��Top=�6k   $��91��6�   6�   �� 5.   
   -
   5        $ 	btnCancel��5.      $��CANCEL��6$   $
��Left=�65   $��37��6P   $��478,181,0,0q�6\   $	��Top=�6q   $��91��6�   6�   �� 5/   
   $��Status��6   $��Center=�6!   $��25��6>   $��	0,132,0,0q�6J   $	��Top=�6]   $��52��6u    J� RenderTransformOrigin$ 0.611,0.313&�6�   �� 50   
   -   5         ��Name$ cbStatus��50      $��Center=�6%   $��21��6B   $��	0,171,0,0q�6N   $	��Top=�6a   $��64��6y   �� 51   
   -   5        $
 txtError��51      $
��Left=�6&   $��16��6A   $��
129,91,0,0q�6M   $
��Wrap=�6a   $	��Top=�6u   $	��362��6�   ���	#FFDC13136�   �� 52   
   $��ClinicId��6   $
��Left=�6#   $��25��6>   $��190,184,0,0q�6J   $	��Top=�6_   $��58��6w   �� 53   
   -   5        $ txtClinicId��53      $
��Left=�6'   $��21��6B   $��278,188,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $��61��6�   �� 54   
   -   5        $
 back��54      $
��Back��6   $
��Left=�6.   $��	52,35,0,0q�6I   $	��Top=�6\   $��32��6t   $��84��6�   ���	#FF1D4A4F$��Tahoma)�6�   $
��Bold"�6�   $��14(�6�   ���	#FFEEE3E36�   56      57      