   M S B A M L   `   `   `  ����?  ;WPFs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WPFsWPFs  5   	       WPFs.ItemsMenu   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:WPFs     5   	     � Title$  Products��5   	   $	��450��6   $	��800��6'   .��5	      � .+�5
   
   � -   5         �Name$ MainGrid��5
      $��-1,0,1,0q�6!    � ColumnDefinitions 5      �� 5      $��2* �6#   �� 5      $��1* �6#    � RowDefinitions 5      �� 5      $��40 �6    �� 5      .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ ItemsDataGrid��5      $��1��6.   $��0��6;      AutoGenerateColumns .  $��	170,0,0,0q�5   I   ��5   K   �� *Items+ �� SelectedItem 5      �� *SelectedItem+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6)   	   Width5  /System.Windows.Controls.DataGridLengthConverter$
	 Auto 67   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6D   ��  �� Path$
 Name�  5      $ Description��6)   $	 * 6>   
 6H   �� $ Description�  5      $ Category��6)   $
	 Auto 6;   
 6H   �� $ Category�  5      $ Price��6)   $
	 Auto 68   
 6E   �� $ Price�  5      $ In Stock��6)   $
	 Auto 6;   
 6H   �� $ InStock�5      �� 5       $��Product info��6   $��2��6+   $��1��6<   $
��Left=�6L   $��	88,20,0,0q�6g   $	��Top=�6z   $��18(�6�   �� 5!      $
��Name��6   $��1��6#   $
��Left=�63   $��	13,30,0,0q�6N   $	��Top=�6a   $��1��6y   $��10(�6�   �� 5"      $��Description��6   $��1��6*   $
��Left=�6:   $��	13,50,0,0q�6U   $	��Top=�6h   $��1��6�   $��10(�6�   �� 5#      $��Price��6   $��1��6$   $
��Left=�64   $��	13,90,0,0q�6O   $	��Top=�6b   $��1��6z   $��10(�6�   �� 5$      $��In stock��6   $��1��6'   $
��Left=�67   $��
13,110,0,0q�6R   $	��Top=�6f   $��1��6~   $��10(�6�   �� 5%      $��Category��6   $��1��6'   $
��Left=�67   $��
13,140,0,0q�6R   $	��Top=�6f   $��1��6~   $��10(�6�   �� 5'      $��1��6   $��88.333,32,0,0q�6N   $
��Left=�6e   $	��Top=�6�   $	��100��6�   $��1��6�    J� RenderTransformOrigin$ -4.354,0.493&�6�    � DataContext 6)   �� *SelectedItem+.+�5(      �� -   5         ��Name$ name_textbox��5(       �� TextWrapping$
 Wrap=�6k   $	��140��6   $��20��6�   ��60   �� *Name+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5)      -   5        $ desc_textbox��5)      $
 Wrap=�6r   $	��140��6�   $��40��6�   ��60   �� *Description+$ PropertyChanged=�6�   �� 5*      -   5        $ price_textbox��5*      $
 Wrap=�6m   $	��140��6�   $��20��6�   ��61   �� *Price+$ PropertyChanged=�6�   �� 5+      -   5        $ inStock_textbox��5+      $
 Wrap=�6q   $	��140��6�   $��20��6�   ��63   �� *	InStock+$ PropertyChanged=�6�   5,      �� 5.      -   5         ��Name$ category_combobox��5.       �� DisplayMemberPath$
 Name��51      $��1��52      $
��Left=�53      $��
88,139,0,0q�62   $	��Top=�54      $	��140��6/   $��1��55       5/      �� $ SelectedCategory���50      �� $ 
Categories�55      �� 57      -   5         ��Name$ Cancel��57      $��Cancel��6%   $��1��66   $��1��6F   $
��Left=�6S   $��Center=�6n   $	��100��6�   $��20��6�    �� IsCancel . $��130,327,0,33.667q�6�   �� 58      -	   5        $ Delete��58      $��Delete��6%   $��1��66   $
��Left=�6F   $��13,200,0,160.667q�6a   $��Center=�6{   $	��100��6�   $��20��6�   $��1��6�   �� 59      -
   5        $
 Save��59      $
��Save��6#   $��1��62   $
��Left=�6B   $��130,200,0,160.667q�6]   $��Center=�6x   $	��100��6�   $��20��6�   $��1��6�   �� 5<      $��Search��6   $��0��6%   $��0��65   $
��Left=�6B   $��10,6,0,0q�6]   $ -0.029,0.448&�6o   $��45��6�   �� 5=      -   5        $ search_textbox��5=      $��0��6.   $
��Left=�6>   $
 Wrap=�5?      $��Center=�5@      $	��468��61   $��
60,11,0,11q�5A      ��5>      �� *
SearchText+$ PropertyChanged=�5A   *   �� 5C      -   5        $ AddItem��5C      $��Add new product��6&   $
��Left=�6@   $��20��6[   $��	28,62,0,0q�6g   $��1��6z   $	��Top=�6�   $	��108��6�   6�   5E      5F      5G      