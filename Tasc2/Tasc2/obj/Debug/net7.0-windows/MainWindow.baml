   M S B A M L   `   `   `  ����@  <Tasc2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Tasc2Tasc2  5   	       Tasc2.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Tasc2     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6   $��Цвет кисти:��6-   �� 5   
   -   5         ��Name$ colorComboBox��5   0   $��0��6   $��1��6     �� SelectedIndex$ 0��5      .@�5      �� $��Черный��6   
���   �
�������6?   �� 5      $��
Белый��6   
�������
���   �6>   �� 5      $��Красный��6   
���  ��
�������6>   �� 5      $��Зеленый��6   
��� � �
�������6@   �� 5      $��
Синий��6   
����  �
�������6=   5      �� 5!   
   $��1��6   $��0��6   $��Размер кисти:��6-   �� 5"   
   -   5         ��Name$ 
sizeSlider��5"   .   $��1��6   $��1��6    � Minimum$ 1Q�5#       � Maximum$ 10Q�6    � Value$ 5Q�6*   	 �� TickFrequency$	 1Q�64   
 �� IsSnapToTickEnabled$

 True��5$      6,   �� 5&   
   $��2��6   $��0��6   $��Режим работы:��6-   �� 5'   
   $��2��6   $��1��6"    �� Orientation$ 
Horizontal=�62   .+�5(      	� -   5         	�Name$ drawModeRadioButton��5(      $��Рисование��67   $
��10 0q�6K    d� 	IsChecked$
 TrueY�5)      6+   	� 5*      -   5        $ editModeRadioButton��5*      $"��Редактирование��67   $
��10 0q�6P   5+      	� 5,      -   5        $ deleteModeRadioButton��5,      $��Удаление��69   $
��10 0q�6L   5-      5.      �� 5/   
   -   5         ��Name$ drawingCanvas��5/      $��3��6(   $��0��65   $��2��6E   
�������51   5   52      55      