   M S B A M L   `   `   `  ����   ViewFormulaire    ViewFormulaire.ViewList   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008       N� Title$  ViewList��.��(�  (� Stretch$ Uniform=�.��� $	��370��$	��500��.+��� -   $��btnContinue��$��	Continuer��$��32��$
��Left=�$��177,325,0,0q�$	��Top=�$	��160��&   System.Windows.Controls.DataGrid  -   $��gridList��   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ *    AutoGenerateColumns .     	RowHeight$ 20Q�   ColumnHeaderHeight$ 30Q�$��5q�
�������$	��300��$	��460��$
��Left=�$��	20,10,0,0q�$	��Top=�   CanUserReorderColumns .     CanUserResizeRows .  |�.     
IsReadOnly . 	   AlternatingRowBackground
	 �����$��Stretch=�$
   HorizontalScrollBarVisibility$
 Disabled=�   HeadersVisibility$ Column=�   Columns 0  *System.Windows.Controls.DataGridTextColumn  -   	cLastName��,  &System.Windows.Controls.DataGridColumn   Header$	 Nom��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *
LastName+  -   
cFirstName��$ Prénom�� �� *	FirstName+  -   
cEmail��$ Email�� �� *Email+   	CellStyle ��  �� 
TargetType*  $System.Windows.Controls.DataGridCell"   �� Triggers P�  P� Property �@ 
IsSelected P� Value . . ���  �� Property � �� �� Value
 ��i����  � ��
 �   ��� -   $��btnPrint��$��Print��$��20��$
��Left=�$��381,336,0,0q�$	��Top=�$��91��