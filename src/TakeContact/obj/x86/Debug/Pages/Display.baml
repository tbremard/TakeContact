   M S B A M L   `   `   `  ����  TakeContact    ViewFormulaire.ViewList   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        N� Title$  ViewList��5      .��5	      (�  (� Stretch$ Uniform=�6   .��5   
   � $	��370��6   $	��500��6   .+�5      &   System.Windows.Controls.DataGrid  -   5        $��gridList��5         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5         AutoGenerateColumns .     	RowHeight$ 20Q�5         ColumnHeaderHeight$ 30Q�5      $��5q�5      $	��300��5      $	��460��5      $
��Left=�5      $��	20,10,0,0q�5      $	��Top=�5         CanUserReorderColumns .     CanUserResizeRows .  |�.     
IsReadOnly . 	   AlternatingRowBackground
	 �����$��Stretch=�5      $
   HorizontalScrollBarVisibility$
 Disabled=�5         HeadersVisibility$ Column=�5      ��5       �� 5!       �� 
StartPoint$	 0,0&�6.    �� EndPoint$	 0,1&�6?   ��5#   "   � � 5$   &    � Color$ 	LightPink��63    � Offset$	 0.0Q�6F   � 5%   &   $ HotPink��63   $	 0.5Q�6D   � 5&   &   $ Purple��63   $	 1.0Q�6C   5'   #   5)         Columns 5+      0  *System.Windows.Controls.DataGridTextColumn  5,      -   5        	cLastName��,  &System.Windows.Controls.DataGridColumn   Header$	 Nom��5,   Y   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   �� *
LastName+6Y     5-      -   5        
cFirstName��$ Prénom��5-   [    6=   �� *	FirstName+6[     5.      -   5        
cEmail��$ Email��5.   S    69   �� *Email+6S      	CellStyle 51      �� 52       �� 
TargetType*  $System.Windows.Controls.DataGridCell"  6    �� Triggers 53      P� 54       P� Property �@ 
IsSelected P� Value . . �56   "   ��  �� Property � �� �� Value
 ��i��6?   �� 57   "    � ��
 �   �58      59      5;      5=      �� 5?      -   5        $��btnContinue��5?   �      btnStyle#��[  6   $��	Continuer��68   $��40��6L   $
��Left=�6X   $��177,320,0,0q�6s   $	��Top=�6�   $	��160��6�   6�   �� 5@      -   5        $��btnPrint��5@   �   #��[  6   $��Export Excel��68   $��40��6O   $
��Left=�6[   $��386,320,0,0q�6v   $	��Top=�6�   $��91��6�   6�   5A      5B      5C      