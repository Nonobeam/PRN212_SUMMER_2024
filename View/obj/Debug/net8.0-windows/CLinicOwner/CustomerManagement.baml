   M S B A M L   `   `   `  ����?  ;View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:View.CLinicOwnerView.CLinicOwner  5   	   )    #View.CLinicOwner.CustomerManagement   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:View.CLinicOwner     5   	     � Title$  CustomerManagement��5   	   $	��450��6$   $	��900��61   .��5	      � .+�5
   
   �� $��CUSTOMER MANAGEMENT��6   $��Center=�6.   $��0,26,0,0q�6K   $	��Top=�6]   $��50��6u   $	��810��6�   ���	#FFF2F5F6$��30(�6�   $��Center=�6�   ���	#FF1EB1DA$
��Bold"�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
tbCustomer��5         AutoGenerateColumns$ False��6'   $��Center=�6C   $	��207��6`   $��	0,217,0,0q�6m   $	��Top=�6�   $	��880��6�   $
��Auto=�6�   $
��Auto=�5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6H   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+6H     5      $
 Name��6%   $	 150 6L    63   �� *Name+6L     5      $ Email��6%   $	 150 6N    64   �� *Email+6N     5      $ Phone��6%   $	 150 6N    64   �� *Phone+6N     5      $ Password��6%   $	 150 6T    67   �� *
Password+6T     5      $ Status��6%   $	 100 6P    65   �� *Status+6P   4  .System.Windows.Controls.DataGridTemplateColumn  5      $ Actions��6)   $ * 6:      CellTemplate 5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6)   $��Center=�6B   .+�5   "   �� -   5        $
��Edit��5   )   $��5q�6d   
	 � Tag	 6Q   �� *Id+6d   5      5      5      5      �� 5   
   -   5        $	��ADD��5      $
��Left=�6   $��28��6:   $��764,170,0,0q�6F   $	��Top=�6[   $��50��6s   ���	#FF59B3DF6�   �� 5    
   $
��Left=�6   $��
10,137,0,0q�6+   $	��Top=�6?   $��59��6W   �� 5!   
   -   5        
 ��Name$
 txtName��5!      $
��Left=�6#   $��26��6>   $��
10,169,0,0q�6J    �� TextWrapping$
 Wrap=�6^   $	��Top=�6r   $��84��6�   �� 5"   
   $��Name:��6   $
��Left=�6    $��26��6;   $��
10,138,0,0q�6G   $	��Top=�6[   $��59��6s   �� 5#   
   $��Email��6   $
��Left=�6    $��26��6;   $��112,137,0,0q�6G   $	��Top=�6\   $��49��6t   �� 5$   
   -   5        $
 txtEmail��5$      $
��Left=�6$   $��26��6?   $��112,169,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��159��6�   �� 5%   
   $��Phone:��6   $
��Left=�6!   $��26��6<   $��292,138,0,0q�6H   $	��Top=�6]   $��50��6u   �� 5&   
   -   5        $
 txtPhone��5&      $
��Left=�6$   $��28��6?   $��292,167,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��133��6�   �� 5'   
   $��Password��6   $
��Left=�6#   $��27��6>   $��452,138,0,0q�6J   $	��Top=�6_   $��63��6w   �� 5(   
   -   5        $
 txtPassword��5(      $
��Left=�6'   $��25��6B   $��452,170,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��159��6�   �� 5)   
   -   5         ��Name$ cbStatus��5)      $
��Left=�6%   $��27��6@   $��647,169,0,0q�6L   $	��Top=�6a   $��90��6y   6�   �� 5*   
   -	   5         ��Name$ ad��5*      $��Status��6   $
��Left=�6-   $��28��6H   $��649,137,0,0q�6T   $	��Top=�6i   $��61��6�   �� 5+   
   -
   5         ��Name$ txtError��5+      $
��Left=�6&   $��27��6A   $��117,105,0,0q�6M   $
��Wrap=�6b   $	��Top=�6v   $	��415��6�   ���	#FFED1212$��14(�6�   �� 5,   
   $��ID��6   $
��Left=�6   $��25��68   $��
10,112,0,0q�6D   $	��Top=�6X   $��30��6p   �� 5-   
   -   5        $ txtId��5-      $
��Left=�6#   $��26��6>   $��
47,118,0,0q�6J   $
��Wrap=�6^   $	��Top=�6r   $��60��6�   �� 5.   
   -   5        $��CLEAR��5.      $
��Left=�6!   $��30��6<   $��832,169,0,0q�6H   $	��Top=�6]   $��45��6u    J� RenderTransformOrigin$ 
0.48,0.648&�6�   ���	#FF34B2DD6�   �� 5/   
   -   5         ��Name$
 back��5/      $
��Back��6   $
��Left=�6.   $��	52,35,0,0q�6I   $	��Top=�6\   $��32��6t   $��84��6�   ���	#FF1D4A4F$��Tahoma)�6�   $
��Bold"�6�   $��14(�6�   ���	#FFEEE3E36�   51      52      