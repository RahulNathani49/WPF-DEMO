   M S B A M L   `   `   `  ����F  BPassportWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:PassportWPF.ViewsPassportWPF.Views  5      %    PassportWPF.Views.PassportsView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:PassportWPF.Views     5        � 	Resources  5
       �� 
TargetType �� Property �� Value��%m  '��       '�� q     '��     �� 5   
   " ��6   .�5      ��  � ��$ 10, 5q�6(   �� 5       � ��$
 Left=�64   5      �� 5   
   " ��6   .�5      ��  � ��$ 10��6&   �� 5       � ��$ 10��6'   �� 5       � ��
 ���� 6+   5      �� 5   
   " ��6   .�5      ��  � ��$ Center=�69   5      5      .��5      �� 
�������$��1q�6%   $��20q�69   ._�5   
   �� $��20q�6   .+�5      �� -   5         ��Name$ label��5      $��Students��6#   �� 5      &   System.Windows.Controls.DataGrid  5"      -   5          Name$ PassportData��5"         AutoGenerateColumns$ False��5#         SelectionMode$ Single=�6   $	��127��65   ��5"   .   ��  �� Path$ 	Passports�	   Columns	 5$      0  *System.Windows.Controls.DataGridTextColumn  5%      ,  &System.Windows.Controls.DataGridColumn
   Header$
 ID��6)      
IsReadOnly$
 True��5&   )   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5'   )   �� $ Id�  5)      $
 
First Name��6)    6=   �� $ 	FirstName�  5*      $
 	Last Name��6)    6<   �� $ LastName�  5+      $
 Date of Birth��6)    6@   �� $ DateOfBirth�  5,      $	
 Age��6)    66   �� $	 Age�4  .System.Windows.Controls.DataGridCheckBoxColumn  5-      $
 
Travelling��6-    6A   �� $ 	Traveling� �� Mode$ OneWay=�5/      �� 51      ]� 53      .+�55      �� $��
First Name��6   �� 56      -   5        $��	firstname��56      ��6+   �� $ 	FirstName�58      �� 5:      ]� 5<      .+�5>      �� $��	Last Name��6   �� 5?      ��6   �� $ LastName�5A      �� 5B      ]� 5C      .+�5E      �� $��Date of Birth��6   (  "System.Windows.Controls.DatePicker  5F         SelectedDate 6   �� $ DateOfBirth�5H      �� 5I      ]� 5J      .+�5L      �� $��Country ��6   �� 5M      ��6   �� $ Country�5O      �� 5P      �� 5T      �� 5V       �� Orientation$ 
Horizontal=�6   .+�5W      �� -   5        $	��Add��5W      ��5X      �� $ 
AddCommand�5Y      �� 5Z      5[      5]      5^      5a      