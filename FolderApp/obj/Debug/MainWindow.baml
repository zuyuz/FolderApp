   M S B A M L   `   `   `  ����D  @FolderApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:FolderApp	FolderApp  5   	       FolderApp.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:FolderApp     5   	     � Title$  
Folder App��5   	   $	��350��6   $	��525��6)    � 
ResizeMode$ NoResize=�65   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��26* �6   �� 5      $
��465* �6   �� 5      $	��26* �6    � RowDefinitions 5   
   �� 5      $	��16* �6   �� 5      $
��244* �6   �� 5      $	��43* �6   �� 5      $	��16* �6   .+�5   
   �� -   5         ��Name$ 
buttonPack��5      $��	Serialize��6%   $
��Left=�69   $��	10,10,0,0q�6T   $	��Top=�6g   $��75��6   $��1��6�   $��2��6�   �� 5   
   -   5        $ buttonShowStructure��5      $
��Show��6.   $
��Left=�6=   $��
189,10,0,0q�6X   $	��Top=�6l   $��75��6�   $��1��6�   $��2��6�   R� 5   
   -   5         R�Name$ treeView��5      $��1��6%   $
��Left=�65   $	��224��6P   $��	10,0,0,10q�6]   $��1��6p   $��Bottom=�6}   $	��445��6�   6�   �� 5   
   -   5        $ buttonUnpack��5      $��Unpack��6'   $��1��68   $
��Left=�6H   $��
380,10,0,0q�6c   $��2��6w   $	��Top=�6�   $��75��6�   6�   5      5      