   M S B A M L   `   `   `  ����D  @FolderApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:FolderApp	FolderApp  5   	   #    FolderApp.FileNameInputWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:FolderApp     5   	     � Title$  
File Name ��5   	   $	��200��6   $	��300��6)    � 
ResizeMode$ NoResize=�65   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��120* �6   �� 5      $	��35* �6   �� 5      $	��15* �6    � ColumnDefinitions 5   
   �� 5      $	��15* �6   �� 5      $
��110* �6   �� 5      $
��150* �6   �� 5      $	��15* �6   .+�5   
   �� -   5         ��Name$ labelFileName��5      $��Enter file name: ��6'   $��1��6C   $
��Left=�6S   $��5,55,0,0q�6n   $	��Top=�6�   $��26��6�   $��95��6�   �� 5   
   -   5         ��Name$ textBoxFileName��5      $��2��6+   $
��Left=�6;   $��23��6V   $��	10,55,0,0q�6b    �� TextWrapping$
 Wrap=�6u   $�� ��6�   $	��Top=�6�   $��93��6�   �� 5   
   -   5         ��Name$ buttonCreate��5      $��Create��6'   $��1��68   $
��Left=�6H   $��10,5,0,0q�6c   $��1��6u   $	��Top=�6�   $��75��6�   6�   �� 5   
   -   5        $ labelExtension��5      $
��.dat��6(   $��2��67   $
��Left=�6G   $��
113,55,0,0q�6b   $	��Top=�6v   5      5      