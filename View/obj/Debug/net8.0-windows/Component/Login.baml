   M S B A M L   `   `   `  ����  View    View.Component.Login   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ Login��5   	   $	��300��6   $	��400��6$   .��5	      � -   5         �Name$ field��5	       � RowDefinitions 5
   
   �� 5      $
��Auto �6   $��60��6*   �� 5      $
��Auto �6   $��40��6*   �� 5      $
��Auto �6   $��40��6*   �� 5      $
��Auto �6   $��60��6*   .+�5   
   �� $��0��6   ���#007ACC �� Padding$ 10q�63   $��0,0,0,20q�6@   ._�5      �� $��Login��6   $��24(�6%   $
��Bold"�63   
�������$��Center=�6X   5      � 5   
   -   5        $
 mail��5      $��1��6   $��28,10,10,10q�6*    � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $��* �6#   .+�5      �� $��Email��6   $��Center=�6%   ���#007ACC$��0,0,10,0q�6U   �� 5      -   5         ��Name$ email��5      $��1��6%   $��Center=�65   $��	59,0,30,0q�6P   5      � 5!   
   -   5        $	 pwd��5!      $��2��6   $��28,10,10,10q�6)    5"      �� 5#      $
��Auto �6#   �� 5$      $��* �6#   .+�5&      �� $��Password��6   $��Center=�6(   ���#007ACC$��0,0,10,0q�6X   G� 5'      -   5         G�Name$ password��5'      $��1��6,   $��Center=�6<   $��	38,0,30,0q�6W   5(      �� 5*   
   -   5        $��3��5*      $��Login��6   $	��Top=�6.   $��Center=�6F   $
��10,5q�6c   ���#007ACC
�������$��80��6�   $��0,26,0,0q�6�   �� 5+   
   -   5        $��3��5+      $��Sign up as customer��6   $��	0,67,0,27q�6<   $��Center=�6O   $
��10,5q�6l   ���	#FF338784
�������$	��156��6�   6�   5,      5-      